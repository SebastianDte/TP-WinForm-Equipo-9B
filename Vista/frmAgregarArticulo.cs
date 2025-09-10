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
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Vista
{
    public partial class frmAgregarArticulo : MaterialForm
    {
        public frmAgregarArticulo()
        {
            InitializeComponent();
            ConfigurarMaterialSkin();
            FrmAlta_Load();
        }

        private List<Imagen> imagenesEnMemoria = new List<Imagen>();
        private ImagenHelper imagenHelper = new ImagenHelper();

        public event Action Cancelado;
        private Articulo articulo = null;
        public event Action ArticuloAgregado;

        private void FrmAlta_Load()
        {
            CategoriaNegocio cbxCategoria = new CategoriaNegocio();
            MarcaNegocio cbxMarca = new MarcaNegocio();
            try
            {
                cboCategoria.DataSource = cbxCategoria.listar();
                cboCategoria.ValueMember = "id";
                cboCategoria.DisplayMember = "descripcion";
                cboMarca.DataSource = cbxMarca.listar();
                cboMarca.ValueMember = "id";
                cboMarca.DisplayMember = "descripcion";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelado?.Invoke();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ImagenNegocio imgNegocio = new ImagenNegocio();
            bool error = false;

            if (articulo == null)
                articulo = new Articulo();

            // --- Validaciones  ---
            if (!InputHelper.Validar(txtNombre, minLength: 5, maxLength: 100))
                error = true;

            if (!InputHelper.Validar(txtCodigo, minLength: 3, maxLength: 20))
                error = true;

            if (!InputHelper.Validar(txtPrecio, minLength: 3, maxLength: 10, soloNumeros: true))
                error = true;

            // validación para el multiline
            if (txtDescripcion.Text.Length > 200)
            {
                MessageBox.Show("La descripción no puede superar los 200 caracteres.");
                error = true;
            }


            if (error) return;

            // --- Asigna los datos ---
            articulo.nombre = txtNombre.Text.Trim();
            articulo.descripcion = txtDescripcion.Text.Trim();
            articulo.codigo = txtCodigo.Text.Trim();
            articulo.precio = decimal.Parse(txtPrecio.Text);
            articulo.marca = (Marca)cboMarca.SelectedItem;
            articulo.categoria = (Categoria)cboCategoria.SelectedItem;

            articulo.Imagenes = new List<Imagen>(imagenesEnMemoria);

            try
            {
                if (articulo.id == 0) // NUEVO
                {
                    int idArticulo = negocio.agregar(articulo);

                    foreach (var img in articulo.Imagenes)
                    {
                        img.idArticulo = idArticulo;
                        new ImagenNegocio().AgregarImagen(img);
                    }
                }
                else // MODIFICAR
                {
                    negocio.Modificar(articulo);
                    negocio.SincronizarImagenes(articulo, imagenesEnMemoria);
                }

                ArticuloAgregado?.Invoke();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        
        }


        public void CargarArticulo(Articulo articuloExistente)
        {
            articulo = articuloExistente;

            txtNombre.Text = articulo.nombre;
            txtCodigo.Text = articulo.codigo;
            txtPrecio.Text = articulo.precio.ToString();
            txtDescripcion.Text = articulo.descripcion;
            cboMarca.SelectedItem = articulo.marca;
            cboCategoria.SelectedItem = articulo.categoria;

            // Copiamos las imágenes a memoria
            imagenesEnMemoria = new List<Imagen>(articulo.Imagenes);

            // Refrescar UI para la primera imagen
            if (imagenesEnMemoria.Count > 0)
            {
                imagenHelper.IrAIndice(imagenesEnMemoria, 0);
                imagenHelper.RefrescarUI(pxbImagen, imagenesEnMemoria, btnAtras, btnSiguiente, lblIndice);
            }
        }









        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            string url = txtUrlImagen.Text.Trim();

            if (!InputHelper.ValidarUrlImagen(txtUrlImagen))
                return;

            var img = new Imagen { imageUrl = url };
            imagenesEnMemoria.Add(img);
           
            imagenHelper.IrAIndice(imagenesEnMemoria, imagenesEnMemoria.Count - 1);
            imagenHelper.RefrescarUI(pxbImagen, imagenesEnMemoria, btnAtras, btnSiguiente, lblIndice);
            
            txtUrlImagen.Clear();
            txtUrlImagen.Focus();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            imagenHelper.Siguiente(imagenesEnMemoria);
            imagenHelper.RefrescarUI(pxbImagen, imagenesEnMemoria, btnAtras, btnSiguiente, lblIndice);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            imagenHelper.Anterior(imagenesEnMemoria);
            imagenHelper.RefrescarUI(pxbImagen, imagenesEnMemoria, btnAtras, btnSiguiente, lblIndice);
        }

        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            if (imagenesEnMemoria.Count == 0) return;

            imagenesEnMemoria.RemoveAt(imagenHelper.IndiceActual);

            if (imagenHelper.IndiceActual >= imagenesEnMemoria.Count)
                imagenHelper.ReiniciarIndice();

            imagenHelper.RefrescarUI(pxbImagen, imagenesEnMemoria, btnAtras, btnSiguiente, lblIndice);
        }

        private void ConfigurarMaterialSkin()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue700,
                TextShade.WHITE
            );
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            InputHelper.QuitarErrorAlEscribir(txtNombre);
            txtNombre.Hint = "Nombre del artículo";
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            InputHelper.QuitarErrorAlEscribir(txtPrecio);
            txtPrecio.Hint = "Precio del Artículo";
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            InputHelper.QuitarErrorAlEscribir(txtCodigo);
            txtCodigo.Hint = "Código del Artículo";
        }

        private void txtUrlImagen_TextChanged(object sender, EventArgs e)
        {
            InputHelper.QuitarErrorAlEscribir(txtUrlImagen);
            txtUrlImagen.Hint = "URL de la imagen";
        }
    }
}
