using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Negocio
{
    public class ArticuloNegocio
    {
        AccesoDato datos = new AccesoDato();
        public List<Articulo> lista()
        {
            List<Articulo> lista = new List<Articulo>();



            try
            {

                datos.setearConsulta("select a.Id as articuloId, Codigo, Nombre, a.Descripcion as articuloDescripcion, Precio, m.Descripcion as marcaDescripcion, c.Descripcion as categoriaDescripcion,a.IdMarca,a.IdCategoria From ARTICULOS a, MARCAS m, CATEGORIAS c where a.IdMarca = m.id and a.IdCategoria = c.id");
                datos.ejecutarLectura();


                while (datos.Lector.Read())
                {
                    Articulo auxiliar = new Articulo();
                    auxiliar.id = (int)datos.Lector["articuloId"];
                    auxiliar.codigo = (string)datos.Lector["Codigo"];
                    auxiliar.nombre = (string)datos.Lector["Nombre"];
                    auxiliar.descripcion = (string)datos.Lector["articuloDescripcion"];
                    auxiliar.precio = (decimal)datos.Lector["Precio"];
                    auxiliar.marca = new Marca();
                    auxiliar.marca.descripcion = (string)datos.Lector["marcaDescripcion"];
                    auxiliar.marca.id = (int)datos.Lector["IdMarca"];
                    auxiliar.categoria = new Categoria();
                    auxiliar.categoria.descripcion = (string)datos.Lector["categoriaDescripcion"];
                    auxiliar.categoria.id = (int)datos.Lector["IdCategoria"];
                    lista.Add(auxiliar);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

      


    }

}

