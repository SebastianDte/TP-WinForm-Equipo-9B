using Dominio;
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
    public partial class frmMarcas : Form
    {
        

        private List<Marca> ListaMarca;
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarMarca ventanaAgregar = new frmAgregarMarca();
            ventanaAgregar.ShowDialog();
            cargar();
            
        }

        private void cargar()
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                ListaMarca = negocio.listar();
                dgvMarcas.DataSource = ListaMarca;
                dgvMarcas.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void frmMarcas_Load(object sender, EventArgs e)
        {   
            cargar(); 
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Marca seleccionada;
            seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

            frmAgregarMarca modificar = new frmAgregarMarca(seleccionada);
            modificar.ShowDialog();
            cargar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionada;

            try
            {

                DialogResult respuesta = MessageBox.Show("¿Estas seguro de eliminar definitivamente esta marca?","Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if( respuesta == DialogResult.Yes)
                {
                    seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionada.id);
                    cargar();

                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            } 
        }
    }
}
