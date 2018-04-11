using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing;

namespace Biblioteca_de_Clases
{
    public class TomarColor
    {
        /// <summary>
        /// Esta variable toma la cadena de color hexadeximal
        /// si el método comprobarColor retorna verdadero.
        /// </summary>
        public string colorfinal;

        /// <summary>
        /// Verifica la existencia de un archivo llamado color.txt en la raíz del disco C.
        /// </summary>
        /// <returns></returns>
        public bool existencia() {
            if (File.Exists("c:\\color.txt")) {
                return true;
            } else {
                return false;
            }
        }

        /// <summary>
        /// Comprueba que la primera línea del archivo color.txt corresponda
        /// con el formato de color hexadecimal mediante una expresión regular.
        /// Si no cumple con el formato o bien, se invoca sin un retorno verdadero 
        /// del método existencia(), este método devolverá false.
        /// </summary>
        /// <returns></returns>
        public bool comprobarColor() {
            try {
                StreamReader lector = new StreamReader("c:\\color.txt");
                string color;
                color = lector.ReadLine();

                if (Regex.IsMatch(color, "(#)([0-9]|[A-F]){6}")) {
                    colorfinal = color;
                    lector.Close();
                    return true;
                } else {
                    lector.Close();
                    return false;
                }
            } catch (Exception) {
                return false;
                throw;
            }
        }
    }
}
