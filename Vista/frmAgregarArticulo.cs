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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            try
            {
                // Si no hay artículo creado aún, lo instanciamos
                if (articulo == null)
                    articulo = new Articulo();

                // Llenamos los datos del artículo desde los controles
                articulo.nombre = txtNombre.Text.Trim();
                articulo.descripcion = txtDescripcion.Text.Trim();
                articulo.codigo = txtCodigo.Text.Trim();
                articulo.precio = decimal.Parse(txtPrecio.Text);
                articulo.marca = (Marca)cboMarca.SelectedItem;
                articulo.categoria = (Categoria)cboCategoria.SelectedItem;

                // Si hay una URL en el TextBox de la imagen, la agregamos a la lista
                if (!string.IsNullOrWhiteSpace(txtUrlImagen.Text))
                {
                    Imagen img = new Imagen();
                    img.imageUrl = txtUrlImagen.Text.Trim();
                    articulo.Imagenes.Add(img);
                }

                // Insertamos el artículo y obtenemos su ID generado
                int idArticulo = negocio.agregar(articulo);

                // Asociamos la(s) imagen(es) al artículo en la DB
                foreach (var img in articulo.Imagenes)
                {
                    img.idArticulo = idArticulo; // asignamos el ID generado
                    imgNegocio.AgregarImagen(img);
                }

                MessageBox.Show("Agregado exitosamente");

                ArticuloAgregado?.Invoke();

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
