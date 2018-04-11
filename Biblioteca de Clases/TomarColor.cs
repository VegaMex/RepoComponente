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
        public string colorfinal;

        public bool existencia() {
            if (File.Exists("c:\\color.txt")) {
                return true;
            } else {
                return false;
            }
        }

        public bool comprobarColor() {
            StreamReader lector = new StreamReader("c:\\color.txt");
            string color;
            color = lector.ReadLine();

            if (Regex.IsMatch(color, "(#)([0-9]|[A-F]){6}")) {
                colorfinal = color;
                return true;
            } else {
                return false;
            }
        }
    }
}
