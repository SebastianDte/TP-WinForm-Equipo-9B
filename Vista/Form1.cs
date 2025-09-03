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
    public partial class Form1 : MaterialForm
    {
        private List<Articulo> listaArticulos; // lista global en el form
        private ArticuloNegocio articulosNegocio = new ArticuloNegocio();
        private ImagenNegocio imagenesNegocio = new ImagenNegocio();
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            CargarArticulos();

        }

        private void CargarArticulos()
        {
            try
            {
                listaArticulos = articulosNegocio.lista(); 
                dataGridView1.DataSource = listaArticulos;
                

                if (listaArticulos.Count > 0)
                {
                    // Cargar imágenes del primer artículo
                    listaArticulos[0].Imagenes = imagenesNegocio.listarImagenes(listaArticulos[0].id);
                    if (listaArticulos[0].Imagenes.Count > 0)
                        pictureBox1.Load(listaArticulos[0].Imagenes[0].imageUrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }
    }
}
