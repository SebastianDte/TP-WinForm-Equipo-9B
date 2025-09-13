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
    public partial class frmCategorias : MaterialForm
    {
        public frmCategorias()
        {
            InitializeComponent();
            ConfigurarMaterialSkin();
            cargar();

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

        private void cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                dgvCategoria.DataSource = negocio.listar();
                dgvCategoria.Columns["Id"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
