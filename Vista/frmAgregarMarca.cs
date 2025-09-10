using Negocio;
using Dominio;
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
    public partial class frmAgregarMarca : Form
    {
        private Marca marca = null;

        public frmAgregarMarca()
        {
            InitializeComponent();
            Text = "Nueva Marca";
        }

        public frmAgregarMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificar Marca";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarNuevaMarca_Click(object sender, EventArgs e)
        {

            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                if ( marca == null)
                {
                    marca = new Marca();
                }
                    
                marca.descripcion = txtbDescripcion.Text;
                
                if ( marca.id != 0)
                {
                    negocio.modificar(marca);
                    MessageBox.Show("Marca modifiacada exitosamente");
                }
                else
                {
                    negocio.agregar(marca);
                    MessageBox.Show("Marca agregada exitosamente");
                }

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void frmAgregarMarca_Load(object sender, EventArgs e)
        {
            try
            {
                if ( marca != null)
                {
                    txtbDescripcion.Text = marca.descripcion; 
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
