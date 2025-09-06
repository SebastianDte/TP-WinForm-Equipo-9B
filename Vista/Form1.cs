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
            CargarComboxFiltro();


        }

        private void CargarArticulos()
        {
            try
            {
                listaArticulos = articulosNegocio.lista(); 
                dgvArticulos.DataSource = listaArticulos;
                OcultarColumnasDgv();

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
        
        private void CargarComboxFiltro()
        {
            cboCampo.Items.Add("Categoria");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Precio");
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
                
                indiceImagenActual = 0;
               
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
            bool activado = ckBoxFiltroAvanzado.Checked;

            cboCampo.Enabled = activado;
            cboCriterio.Enabled = activado;
            btnBuscar.Enabled = activado;

            txtBuscar.Visible = !activado;
            txtBoxFiltroAvanzado.Visible = activado;
            picBoxLimpiar.Visible = activado;

            if (!activado)
            {              
                dgvArticulos.DataSource = null;
                CargarArticulos();
            }


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
            cardVerMas.Visible = true;

            lblCodigoArticulo.Text = seleccionado.codigo;         
            txtBoxDescripcion.Text = seleccionado.descripcion; 
        }

        

        private void OcultarColumnasDgv()
        {
            dgvArticulos.Columns["id"].Visible = false;
            dgvArticulos.Columns["descripcion"].Visible = false;
            dgvArticulos.Columns["codigo"].Visible = false;

            //Esto es para mandar los botones al final de la DGV
            dgvArticulos.Columns["btnEditar"].DisplayIndex = dgvArticulos.Columns.Count - 1;
            dgvArticulos.Columns["btnVerMas"].DisplayIndex = dgvArticulos.Columns.Count - 1;
        }

        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {

            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtBoxFiltroAvanzado.SetErrorState(false);
            txtBoxFiltroAvanzado.Hint = "Filtro avanzado";
            try
            {
                if (validarFiltro(cboCampo, cboCriterio, txtBoxFiltroAvanzado))
                    return;
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtBoxFiltroAvanzado.Text;
                dgvArticulos.DataSource = articulosNegocio.filtrar(campo, criterio, filtro);                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void LimpiarFiltros()
        {
            cboCampo.SelectedIndexChanged -= cbxCampo_SelectedIndexChanged;


            cboCampo.SelectedIndex = -1;
            cboCriterio.Items.Clear();
            cboCriterio.SelectedIndex = -1;
            txtBoxFiltroAvanzado.Text = string.Empty;

            cboCampo.SelectedIndexChanged += cbxCampo_SelectedIndexChanged;

            cboCampo.Refresh();
            cboCriterio.Refresh();
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!char.IsNumber(caracter))
                    return false;
            }
            return true;
        }

        public bool validarFiltro(MaterialComboBox cboCampo, MaterialComboBox cboCriterio, MaterialTextBox2 txtFiltroAvanzado)
        {
            bool error = false;
           
            if (cboCampo.SelectedItem == null)
            {
                lblErrorCampo.Visible = true;
                lblErrorCampo.Text = "Seleccionar campo";
                error = true;
            }
            else
            {
                lblErrorCampo.Visible = false;
            }

            if (cboCriterio.SelectedItem == null)
            {
                lblErrorCriterio.Visible = true;
                lblErrorCriterio.Text = "Seleccionar criterio";
                error = true;
            }
            else
            {
                lblErrorCriterio.Visible = false;
            }

            
            if (!error && cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    txtFiltroAvanzado.SetErrorState(true);
                    txtFiltroAvanzado.Hint = "El campo Precio es obligatorio";
                    error = true;
                }
                else if (!soloNumeros(txtFiltroAvanzado.Text))
                {
                    txtFiltroAvanzado.SetErrorState(true);
                    txtFiltroAvanzado.Hint = "Ingrese solo números. Sin puntos ni comas.";
                    error = true;
                }
            }

            return error;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();
            dgvArticulos.DataSource = null;
            CargarArticulos();
        }

        private void picBoxLimpiar_MouseEnter(object sender, EventArgs e)
        {
            picBoxLimpiar.BackColor = Color.LightGray;
        }

        private void picBoxLimpiar_MouseLeave(object sender, EventArgs e)
        {
            picBoxLimpiar.BackColor = Color.Transparent;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            string filtro = txtBuscar.Text.Trim();
            List<Articulo> listaFiltrada;
            if (!string.IsNullOrEmpty(filtro))
            {
                listaFiltrada = listaArticulos.FindAll(a => a.nombre.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0);
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            OcultarColumnasDgv();
        }

        
    }
}
