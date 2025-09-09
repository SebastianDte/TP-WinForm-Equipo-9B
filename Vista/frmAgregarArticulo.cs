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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Vista
{
    public partial class frmAgregarArticulo : MaterialForm
    {
        public frmAgregarArticulo()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
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

            // --- Validaciones usando InputHelper ---
            if (!InputHelper.Validar(txtNombre, minLength: 5, maxLength: 100))
                error = true;

            if (!InputHelper.Validar(txtCodigo, minLength: 1, maxLength: 20))
                error = true;

            if (!InputHelper.Validar(txtPrecio, minLength: 1, maxLength: 10, soloNumeros: true))
                error = true;

            // Para la descripción, validación inline porque es multiline
            if (txtDescripcion.Text.Length > 200)
            {
                MessageBox.Show("La descripción no puede superar los 200 caracteres.");
                error = true;
            }

            // Validación de URLs de imágenes
            foreach (var img in imagenesEnMemoria)
            {
                if (img.imageUrl.Length > 1000)
                {
                    MessageBox.Show($"La URL de la imagen '{img.imageUrl}' supera los 1000 caracteres.");
                    error = true;
                    break;
                }
            }

            if (error) return;

            // --- Asignamos los datos ---
            articulo.nombre = txtNombre.Text.Trim();
            articulo.descripcion = txtDescripcion.Text.Trim();
            articulo.codigo = txtCodigo.Text.Trim();
            articulo.precio = decimal.Parse(txtPrecio.Text);
            articulo.marca = (Marca)cboMarca.SelectedItem;
            articulo.categoria = (Categoria)cboCategoria.SelectedItem;

            articulo.Imagenes = new List<Imagen>(imagenesEnMemoria);

            try
            {
                int idArticulo = negocio.agregar(articulo);

                foreach (var img in articulo.Imagenes)
                {
                    img.idArticulo = idArticulo;
                    imgNegocio.AgregarImagen(img);
                }

                ArticuloAgregado?.Invoke();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            string url = txtUrlImagen.Text.Trim();

            // Validaciones
            if (!InputHelper.Validar(txtUrlImagen, minLength: 1, maxLength: 1000))
                return;

            // Creamos la imagen y la agregamos a la lista en memoria
            var img = new Imagen { imageUrl = url };
            imagenesEnMemoria.Add(img);

            // Vamos al último índice y refrescamos UI
            imagenHelper.IrAIndice(imagenesEnMemoria, imagenesEnMemoria.Count - 1);
            imagenHelper.RefrescarUI(pxbImagen, imagenesEnMemoria, btnAtras, btnSiguiente, lblIndice);

            // Limpiamos el TextBox y ponemos foco para seguir agregando si quiere
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
    }
}
