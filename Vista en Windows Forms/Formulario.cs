using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca_de_Clases;

namespace Vista_en_Windows_Forms {
    public partial class Formulario : Form {
        public Formulario() {
            InitializeComponent();
        }

        private void editorTexto1_Load(object sender, EventArgs e) {
            editorTexto1.Caja = txt_CajaTexto;
        }

        private void Formulario_Load(object sender, EventArgs e) {
            TomarColor fondo = new TomarColor();

            if (fondo.existencia()) {
                if (fondo.comprobarColor()) {
                    Color fondocolor = System.Drawing.ColorTranslator.FromHtml(fondo.colorfinal);
                    this.BackColor = fondocolor;
                } else {
                    MessageBox.Show("La primera línea del archivo C:\\color.txt\n" +
                   "no corresponde con un código de color hexadecimal.\n\n" +
                   "Se usará el color por defecto gris.\n\n" +
                   "Si desea un color personalizado de fondo, corrija la\n" +
                   "primera línea del archivo C:\\color.txt para que\n" +
                   "coincida con un código hexadecimal válido\n" +
                   "y vuelva a ejecutar el programa.");
                }
            } else {
                MessageBox.Show("No existe un archivo .txt personalizado en C: llamado color.txt.\n\n" +
                    "Se usará el color por defecto gris.\n\n" +
                    "Si desea un color personalizado de fondo,\n" +
                    "cree una archivo color.txt en C: cuya primera línea\n" +
                    "coincida con un código hexadecimal válido.");
            }

        }
    }
}
