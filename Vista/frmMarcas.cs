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
    }
}
