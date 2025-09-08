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
            ventanaAgregar.Show();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            ListaMarca = negocio.listar();
            dgvMarcas.DataSource = ListaMarca;
            
        }
    }
}
