using Dominio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace Vista
{
    public class ImagenHelper
    {
        public int IndiceActual { get; private set; } = 0;
        private readonly string fallbackUrl = "https://www.shutterstock.com/image-vector/no-photo-image-viewer-thumbnail-260nw-2495883211.jpg";

        public Image CargarImagen(string url)
        {
            if (string.IsNullOrEmpty(url))
                url = fallbackUrl;

            try
            {
                using (var client = new WebClient())
                {
                    client.Headers.Add("user-agent", "Mozilla/5.0");
                    byte[] data = client.DownloadData(url);
                    using (var ms = new System.IO.MemoryStream(data))
                    {
                        return Image.FromStream(ms);
                    }
                }
            }
            catch
            {
                using (var client = new WebClient())
                {
                    client.Headers.Add("user-agent", "Mozilla/5.0");
                    byte[] data = client.DownloadData(fallbackUrl);
                    using (var ms = new System.IO.MemoryStream(data))
                    {
                        return Image.FromStream(ms);
                    }
                }
            }
        }

        public void Mostrar(PictureBox pctBox, List<Imagen> imagenes)
        {
            if (imagenes == null || imagenes.Count == 0)
            {
                pctBox.Image = CargarImagen(null);
                return;
            }

            pctBox.Image = CargarImagen(imagenes[IndiceActual].imageUrl);
        }

        public void Siguiente(List<Imagen> imagenes)
        {
            if (imagenes == null || imagenes.Count == 0) return;
            if (IndiceActual < imagenes.Count - 1) IndiceActual++;
        }

        public void Anterior(List<Imagen> imagenes)
        {
            if (imagenes == null || imagenes.Count == 0) return;
            if (IndiceActual > 0) IndiceActual--;
        }

        public void ReiniciarIndice() => IndiceActual = 0;

        public void ActualizarBotones(List<Imagen> imagenes, Button btnAtras, Button btnSiguiente)
        {
            if (imagenes == null || imagenes.Count <= 1)
            {
                btnAtras.Enabled = false;
                btnSiguiente.Enabled = false;
                return;
            }

            btnAtras.Enabled = IndiceActual > 0;
            btnSiguiente.Enabled = IndiceActual < imagenes.Count - 1;
        }

        
        public void RefrescarUI(PictureBox pctBox, List<Imagen> imagenes, Button btnAtras, Button btnSiguiente, Label lblIndice)
        {
            Mostrar(pctBox, imagenes);
            ActualizarBotones(imagenes, btnAtras, btnSiguiente);

            if (lblIndice != null)
            {
                lblIndice.Text = (imagenes != null && imagenes.Count > 0)
                    ? $"Imagen {IndiceActual + 1} / {imagenes.Count}"
                    : "Sin imágenes";
            }
        }

        public void RefrescarUI(PictureBox pctBox, List<Imagen> imagenes, PictureBox picAtras, PictureBox picSiguiente, Label lblIndice)
        {
            Mostrar(pctBox, imagenes);

            // Lógica para habilitar/deshabilitar los "botones" creados con PictureBox
            if (imagenes == null || imagenes.Count <= 1)
            {
                picAtras.Enabled = false;
                picSiguiente.Enabled = false;
            }
            else
            {
                picAtras.Enabled = IndiceActual > 0;
                picSiguiente.Enabled = IndiceActual < imagenes.Count - 1;
            }

            if (lblIndice != null)
            {
                lblIndice.Text = (imagenes != null && imagenes.Count > 0)
                    ? $"Imagen {IndiceActual + 1} / {imagenes.Count}"
                    : "Sin imágenes";
            }
        }

        public void IrAIndice(List<Imagen> imagenes, int indice)
        {
            if (imagenes != null && indice >= 0 && indice < imagenes.Count)
                IndiceActual = indice;
        }

    }
}
