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


        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDato datos = new AccesoDato();
            try
            {
                string consulta = "select a.Id as articuloId, Codigo, Nombre, a.Descripcion as articuloDescripcion, " +
                  "Precio, m.Descripcion as marcaDescripcion, c.Descripcion as categoriaDescripcion, " +
                  "a.IdMarca, a.IdCategoria, i.Id as imagenId, i.ImagenUrl " +
                  "from ARTICULOS a " +
                  "inner join MARCAS m on a.IdMarca = m.Id " +
                  "inner join CATEGORIAS c on a.IdCategoria = c.Id " +
                  "left join IMAGENES i on i.IdArticulo = a.Id " +
                  "where ";

                switch (campo)
                {
                    case "Precio":
                        switch (criterio)
                        {
                            case "Mayor a":
                                consulta += "a.Precio > " + filtro;
                                break;
                            case "Menor a":
                                consulta += "a.Precio < " + filtro;
                                break;
                            default:
                                consulta += "a.Precio = " + filtro;
                                break;
                        }
                        break;

                    case "Marca":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "m.Descripcion like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "m.Descripcion like '%" + filtro + "'";
                                break;
                            case "Contiene":
                                consulta += "m.Descripcion like '%" + filtro + "%'";
                                break;
                        }
                        break;

                    case "Categoria":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "c.Descripcion like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "c.Descripcion like '%" + filtro + "'";
                                break;
                            case "Contiene":
                                consulta += "c.Descripcion like '%" + filtro + "%'";
                                break;
                        }
                        break;
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    int idArticulo = (int)datos.Lector["articuloId"];

                    
                    Articulo auxiliar = lista.FirstOrDefault(a => a.id == idArticulo);

                    if (auxiliar == null)
                    {
                        
                        auxiliar = new Articulo();
                        auxiliar.id = idArticulo;
                        auxiliar.codigo = (string)datos.Lector["Codigo"];
                        auxiliar.nombre = (string)datos.Lector["Nombre"];
                        auxiliar.descripcion = (string)datos.Lector["articuloDescripcion"];
                        auxiliar.precio = (decimal)datos.Lector["Precio"];
                        auxiliar.marca = new Marca
                        {
                            id = (int)datos.Lector["IdMarca"],
                            descripcion = (string)datos.Lector["marcaDescripcion"]
                        };
                        auxiliar.categoria = new Categoria
                        {
                            id = (int)datos.Lector["IdCategoria"],
                            descripcion = (string)datos.Lector["categoriaDescripcion"]
                        };

                        lista.Add(auxiliar);
                    }

                    
                    if (!(datos.Lector["imagenId"] is DBNull))
                    {
                        Imagen img = new Imagen
                        {
                            id = (int)datos.Lector["imagenId"],
                            idArticulo = idArticulo,
                            imageUrl = (string)datos.Lector["ImagenUrl"]
                        };
                        auxiliar.Imagenes.Add(img);
                    }
                }

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
      


  
