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
        private ImagenHelper imagenHelper = new ImagenHelper();

        public Form1(string usuario)
        {
            InitializeComponent();
            ConfigurarMaterialSkin();
            CargarArticulos();
            CargarComboxFiltro();
            InicializarTabs();

            lblUsuario.Text = "Bienvenido " + usuario;
        }


        //--------------------------DGV------------------------------------------------------//
        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                if (seleccionado.Imagenes == null || seleccionado.Imagenes.Count == 0)
                    seleccionado.Imagenes = imagenesNegocio.listarImagenes(seleccionado.id);

                ActualizarImagenArticulo(seleccionado);

            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null) return;

            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            imagenHelper.Siguiente(seleccionado.Imagenes);
            ActualizarImagenArticulo(seleccionado, reiniciarIndice: false);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null) return;

            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            imagenHelper.Anterior(seleccionado.Imagenes);
            ActualizarImagenArticulo(seleccionado, reiniciarIndice: false);
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
            if (e.RowIndex < 0) return;

            if (dgvArticulos.Columns[e.ColumnIndex].Name == "btnVerMas")
            {
                Articulo seleccionado = (Articulo)dgvArticulos.Rows[e.RowIndex].DataBoundItem;

                MostrarDetalles(seleccionado);
            }
            else if (dgvArticulos.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                Articulo seleccionado = (Articulo)dgvArticulos.Rows[e.RowIndex].DataBoundItem;
                Eliminar(seleccionado);
            }
        }


        //-----------------Metodos Referidos a Filtros------------------------------------------------
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InputHelper.LimpiarFiltros(cboCampo, cboCriterio, txtBoxFiltroAvanzado, cbxCampo_SelectedIndexChanged);
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

        //------------------Manejo del Tab - Menú--------------------------------------------------------------------
        private void InicializarTabs()
        {

            CargarFormularioEnTab(tabPage2, new frmCategorias());

        }
        private void CargarFormularioEnTab(TabPage tab, Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            tab.Controls.Clear();
            tab.Controls.Add(form);

            form.Show();
        }


        //----------------------CRUD-----------------------------------------------------------------------------------------
        private void Eliminar(Articulo seleccionado)
        {

            try
            {
                if (dgvArticulos.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Seguro que quieres eliminarlo?", "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                        articulosNegocio.eliminar(seleccionado.id);

                        CargarArticulos();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al eliminar el artículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pxbAgregar_Click(object sender, EventArgs e)
        {
            pnlArticulos.Visible = false;
            pnlAgregarArticulo.Controls.Clear();

            pnlAgregarArticulo.Parent = tabPage1;
            pnlAgregarArticulo.Dock = DockStyle.Fill;


            var agregar = new frmAgregarArticulo();
            agregar.TopLevel = false;
            agregar.FormBorderStyle = FormBorderStyle.None;
            agregar.Dock = DockStyle.Fill;

            // Asignamos el evento Cancelado
            agregar.Cancelado += () =>
            {
                pnlAgregarArticulo.Controls.Clear();
                pnlAgregarArticulo.Visible = false;
                pnlArticulos.Visible = true;
            };

            agregar.ArticuloAgregado += () =>
            {
                pnlAgregarArticulo.Controls.Clear();
                pnlAgregarArticulo.Visible = false;
                pnlArticulos.Visible = true;

                // Refrescamos la lista de artículos
                CargarArticulos();
            };


            // Lo agregamos al panel
            pnlAgregarArticulo.Controls.Add(agregar);

            // Mostramos el panel y el form
            pnlAgregarArticulo.Visible = true;
            agregar.Show();
            pnlAgregarArticulo.BringToFront();
        }


        //Metodo auxiliares-------------------------------------------------------------------------------------------------

        private void ActualizarImagenArticulo(Articulo seleccionado, bool reiniciarIndice = true)
        {
            if (reiniciarIndice)
                imagenHelper.ReiniciarIndice();

            imagenHelper.RefrescarUI(pctBoxListImg, seleccionado.Imagenes, btnAtras, btnSiguiente, lblImagenes);
        }
        public bool validarFiltro(MaterialComboBox cboCampo, MaterialComboBox cboCriterio, MaterialTextBox2 txtFiltroAvanzado)
        {
            bool error = false;

            // Validamos combos
            if (cboCampo.SelectedItem == null)
            {
                lblErrorCampo.Visible = true;
                lblErrorCampo.Text = "Seleccionar campo";
                error = true;
            }
            else
                lblErrorCampo.Visible = false;

            if (cboCriterio.SelectedItem == null)
            {
                lblErrorCriterio.Visible = true;
                lblErrorCriterio.Text = "Seleccionar criterio";
                error = true;
            }
            else
                lblErrorCriterio.Visible = false;


            if (!error && cboCampo.SelectedItem.ToString() == "Precio")
            {

                if (!InputHelper.Validar(txtFiltroAvanzado, minLength: 1, soloNumeros: true))
                {
                    txtFiltroAvanzado.SetErrorState(true);
                    txtFiltroAvanzado.Hint = "Ingrese solo números. Sin puntos ni comas.";
                    error = true;
                }
            }

            return error;
        }
        private void OcultarColumnasDgv()
        {
            dgvArticulos.Columns["id"].Visible = false;
            dgvArticulos.Columns["descripcion"].Visible = false;
            dgvArticulos.Columns["codigo"].Visible = false;

            //Esto es para mandar los botones al final de la DGV
            dgvArticulos.Columns["btnEditar"].DisplayIndex = dgvArticulos.Columns.Count - 1;
            dgvArticulos.Columns["btnEliminar"].DisplayIndex = dgvArticulos.Columns.Count - 1;
            dgvArticulos.Columns["btnVerMas"].DisplayIndex = dgvArticulos.Columns.Count - 1;
        }
        private void CargarComboxFiltro()
        {
            cboCampo.Items.Add("Categoria");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Precio");
        }
        private void MostrarDetalles(Articulo seleccionado)
        {
            cardVerMas.Visible = true;

            lblCodigoArticulo.Text = seleccionado.codigo;
            txtBoxDescripcion.Text = seleccionado.descripcion;
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
                    // Traemos las imágenes del primer artículo
                    listaArticulos[0].Imagenes = imagenesNegocio.listarImagenes(listaArticulos[0].id);

                    ActualizarImagenArticulo(listaArticulos[0]);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
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
                Accent.LightBlue200,
                TextShade.WHITE
            );
        }
    }
}