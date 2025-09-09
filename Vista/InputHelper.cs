using MaterialSkin.Controls;
using System;
using System.Text.RegularExpressions;

namespace Vista
{
    public static class InputHelper
    {
        // Valida si el campo está vacío
        public static bool EstaVacio(MaterialTextBox2 txtBox, string mensajeError = "Campo obligatorio")
        {
            if (string.IsNullOrWhiteSpace(txtBox.Text))
            {
                txtBox.SetErrorState(true);
                txtBox.Hint = mensajeError;
                return true;
            }
            txtBox.SetErrorState(false);
            return false;
        }

        // Valida longitud mínima
        public static bool LongitudMinima(MaterialTextBox2 txtBox, int minLength, string mensajeError = null)
        {
            if (txtBox.Text.Length < minLength)
            {
                txtBox.SetErrorState(true);
                txtBox.Hint = mensajeError ?? $"Debe tener al menos {minLength} caracteres";
                return true;
            }
            txtBox.SetErrorState(false);
            return false;
        }

        // Valida longitud máxima
        public static bool LongitudMaxima(MaterialTextBox2 txtBox, int maxLength, string mensajeError = null)
        {
            if (txtBox.Text.Length > maxLength)
            {
                txtBox.SetErrorState(true);
                txtBox.Hint = mensajeError ?? $"No puede superar los {maxLength} caracteres";
                return true;
            }
            txtBox.SetErrorState(false);
            return false;
        }

        // Valida si contiene solo números
        public static bool SoloNumeros(MaterialTextBox2 txtBox, string mensajeError = "Ingrese solo números")
        {
            if (!Regex.IsMatch(txtBox.Text, @"^\d+$"))
            {
                txtBox.SetErrorState(true);
                txtBox.Hint = mensajeError;
                return false;
            }
            txtBox.SetErrorState(false);
            return true;
        }

        // Combina varias validaciones y devuelve true si pasó todo
        public static bool Validar(MaterialTextBox2 txtBox, int minLength = 0, int maxLength = int.MaxValue, bool soloNumeros = false)
        {
            if (EstaVacio(txtBox)) return false;
            if (minLength > 0 && LongitudMinima(txtBox, minLength)) return false;
            if (maxLength < int.MaxValue && LongitudMaxima(txtBox, maxLength)) return false;
            if (soloNumeros && !SoloNumeros(txtBox)) return false;

            txtBox.SetErrorState(false);
            return true;
        }

        //Quita los errores de los Texbox
        public static void QuitarErrorAlEscribir(MaterialTextBox2 txtBox)
        {
            txtBox.TextChanged += (s, e) => txtBox.SetErrorState(false);
        }
        public static void LimpiarFiltros(MaterialComboBox cboCampo, MaterialComboBox cboCriterio, MaterialTextBox2 txtFiltro,EventHandler eventoCambio = null)
        {
            if (eventoCambio != null)
                cboCampo.SelectedIndexChanged -= eventoCambio;

            cboCampo.SelectedIndex = -1;
            cboCriterio.Items.Clear();
            cboCriterio.SelectedIndex = -1;
            txtFiltro.Text = string.Empty;

            if (eventoCambio != null)
                cboCampo.SelectedIndexChanged += eventoCambio;

            cboCampo.Refresh();
            cboCriterio.Refresh();
        }
    }
}
