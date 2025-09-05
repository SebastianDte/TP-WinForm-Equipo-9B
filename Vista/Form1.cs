using Dominio;
using MaterialSkin;
using MaterialSkin.Controls;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class Form1 : MaterialForm
    {
        private List<Articulo> listaArticulos; 
        private ArticuloNegocio articulosNegocio = new ArticuloNegocio();
        private ImagenNegocio imagenesNegocio = new ImagenNegocio();

        private bool usoFallback;
        private int indiceImagenActual = 0;
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            
            CargarArticulos();

        }

        private void CargarArticulos()
        {
            try
            {
                listaArticulos = articulosNegocio.lista(); 
                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.Columns["id"].Visible = false;
                dgvArticulos.Columns["descripcion"].Visible = false;
                dgvArticulos.Columns["codigo"].Visible = false;

                //Esto es para mandar los botones al final de la DGV
                dgvArticulos.Columns["btnEditar"].DisplayIndex = dgvArticulos.Columns.Count - 1;
                dgvArticulos.Columns["btnVerMas"].DisplayIndex = dgvArticulos.Columns.Count - 1;

                if (listaArticulos.Count > 0)
                {
                    listaArticulos[0].Imagenes = imagenesNegocio.listarImagenes(listaArticulos[0].id);

                    string urlPrimerImagen = listaArticulos[0].Imagenes.Count > 0
                        ? listaArticulos[0].Imagenes[0].imageUrl
                        : null; 

                    pctBoxListImg.Image = CargarImagenDesdeUrl(urlPrimerImagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }
 
        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                // Resetear índice al cambiar de artículo
                indiceImagenActual = 0;

                // Traer imágenes si no están cargadas
                if (seleccionado.Imagenes == null || seleccionado.Imagenes.Count == 0)
                    seleccionado.Imagenes = imagenesNegocio.listarImagenes(seleccionado.id);

                // Cargar la primera imagen
                string urlImagen = seleccionado.Imagenes.Count > 0 ? seleccionado.Imagenes[0].imageUrl : null;
                pctBoxListImg.Image = CargarImagenDesdeUrl(urlImagen);

                // Actualizar botones según índice y cantidad de imágenes
                ActualizarBotones(seleccionado);


                // Actualizar label de índice
                lblImagenes.Text = seleccionado.Imagenes.Count > 0
                    ? $"Imagen {indiceImagenActual + 1} / {seleccionado.Imagenes.Count}"
                    : "Sin imágenes";
            }


        }

        private void ActualizarBotones(Articulo seleccionado)
        {
            if (seleccionado.Imagenes.Count <= 1)
            {
                btnSiguiente.Enabled = false;
                btnAtras.Enabled = false;
            }
            else
            {
                btnAtras.Enabled = indiceImagenActual > 0;
                btnSiguiente.Enabled = indiceImagenActual < seleccionado.Imagenes.Count - 1;
            }
        }

        private Image CargarImagenDesdeUrl(string url)
        {
            // URL de la imagen por defecto si no hay o falla
            string fallbackUrl = "https://www.shutterstock.com/image-vector/no-photo-image-viewer-thumbnail-260nw-2495883211.jpg";
            usoFallback = false;
            // Si la URL es null o vacía, usa el fallback
            if (string.IsNullOrEmpty(url))
                url = fallbackUrl;

            
            try
            {
                using (var client = new System.Net.WebClient())
                {
                    client.Headers.Add("user-agent", "Mozilla/5.0"); // simula ser un navegador.
                    byte[] data = client.DownloadData(url);   //Acá descarga la imagen.
                    using (var ms = new System.IO.MemoryStream(data))
                    {
                        return Image.FromStream(ms);
                    }
                }
            }
            catch
            {
                usoFallback = true;
                using (var client = new System.Net.WebClient())
                {
                    client.Headers.Add("user-agent", "Mozilla/5.0");
                    byte[] data = client.DownloadData(fallbackUrl);
                    using (var ms = new System.IO.MemoryStream(data))
                    {
                        return Image.FromStream(ms);
                    }
                }
            }
        }
        
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                if (indiceImagenActual < seleccionado.Imagenes.Count - 1)
                {
                    indiceImagenActual++;
                    pctBoxListImg.Image = CargarImagenDesdeUrl(seleccionado.Imagenes[indiceImagenActual].imageUrl);
                    ActualizarBotones(seleccionado);

                    lblImagenes.Text = $"Imagen {indiceImagenActual + 1} / {seleccionado.Imagenes.Count}";

                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                if (indiceImagenActual > 0)
                {
                    indiceImagenActual--;
                    pctBoxListImg.Image = CargarImagenDesdeUrl(seleccionado.Imagenes[indiceImagenActual].imageUrl);
                    ActualizarBotones(seleccionado);

                    // Actualizar label
                    lblImagenes.Text = $"Imagen {indiceImagenActual + 1} / {seleccionado.Imagenes.Count}";
                }
            }
        }

        private void ckBoxFiltroAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            cbxCampo.Enabled = ckBoxFiltroAvanzado.Checked;
            cbxCriterio.Enabled = ckBoxFiltroAvanzado.Checked;
            btnBuscar.Enabled = ckBoxFiltroAvanzado.Checked;
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            if (cardVerMas.Visible)
            {
                cardVerMas.Visible = false;
            }
        }

        private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignorar clicks en el header

            // Verifico si la columna clickeada es "VerMás"
            if (dgvArticulos.Columns[e.ColumnIndex].Name == "btnVerMas")
            {
                Articulo seleccionado = (Articulo)dgvArticulos.Rows[e.RowIndex].DataBoundItem;
                // Abrir la card y mostrar los detalles
                MostrarDetalles(seleccionado);
            }
        }

        private void MostrarDetalles(Articulo seleccionado)
        {
            // Hacer visible la card
            cardVerMas.Visible = true;

            // Cargar datos en los controles dentro de la card
            lblCodigoArticulo.Text = seleccionado.codigo;          // Label para el código
            txtBoxDescripcion.Text = seleccionado.descripcion; // TextBox multilinea para la descripción
        }
    }
}
