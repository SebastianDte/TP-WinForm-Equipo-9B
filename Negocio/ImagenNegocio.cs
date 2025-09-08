using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ImagenNegocio
    {
        AccesoDato datos = new AccesoDato();

        public List<Imagen> listarImagenes(int idArticulo)
        {
            List<Imagen> imagenes = new List<Imagen>();
            try
            {
                datos.setearConsulta("SELECT Id, IdArticulo, imagenUrl FROM IMAGENES WHERE IdArticulo = " + idArticulo);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Imagen img = new Imagen();
                    img.id = (int)datos.Lector["Id"];
                    img.idArticulo = (int)datos.Lector["IdArticulo"];
                    img.imageUrl = (string)datos.Lector["imagenUrl"];
                    imagenes.Add(img);
                }
                return imagenes;
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


        public void AgregarImagen(Imagen img)
        {
            try
            {
                datos.setearConsulta("INSERT INTO IMAGENES(IdArticulo, imagenUrl) VALUES(@IdArticulo, @ImagenUrl)");
                datos.setearParametro("@IdArticulo", img.idArticulo);
                datos.setearParametro("@ImagenUrl", img.imageUrl);
                datos.ejecutarAccion();
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

        public void eliminarImagenes(int idArticulo)
        {
            try
            {
                datos.setearConsulta("DELETE FROM IMAGENES WHERE IdArticulo = @idArticulo");
                datos.setearParametro("@idArticulo", idArticulo);
                datos.ejecutarAccion();
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



        public void AgregarImagenes(List<Imagen> imagenes)
        {
            foreach (var img in imagenes)
            {
                AgregarImagen(img);
            }
        }



    }
}
