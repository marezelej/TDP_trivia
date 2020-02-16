using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TriviaGUI.Modal
{
    internal class ErrorModal
    {
        /// <summary>
        /// Muestra un modal de error con título y mensaje.
        /// El usuario solo puede seleccionar OK.
        /// </summary>
        /// <param name="pErrorMsg">El mensaje a mostrar</param>
        /// <param name="pErrorTitle">El título a mostrar</param>
        internal static void Show(string pErrorMsg, string pErrorTitle)
        {
            MessageBox.Show(
                    pErrorMsg,
                    pErrorTitle,
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                );
        }

        /// <summary>
        /// Muestra un modal de error con título "Error" y mensaje.
        /// El usuario solo puede seleccionar OK.
        /// </summary>
        /// <param name="pErrorMsg">El mensaje a mostrar</param>
        internal static void Show(string pErrorMsg)
        {
            Show(pErrorMsg, "Error");
        }
    }
}
