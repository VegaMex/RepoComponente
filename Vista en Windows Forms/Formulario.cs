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

        /// <summary>
        /// Establece el valor del objeto RichTextBox del componente
        /// al valor del RichTextBox del formulario al momento de
        /// cargar el componente en el formulario.
        /// </summary>
        private void editorTexto1_Load(object sender, EventArgs e) {
            editorTexto1.Caja = txt_CajaTexto;
        }

        /// <summary>
        /// Envía mensajes de existencia o no existencia
        /// de un archivo de texto color.txt en C: al momento
        /// de cargar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Formulario_Load(object sender, EventArgs e) {

            //Objeto de la clase TomarColor
            TomarColor fondo = new TomarColor();
            
            if (fondo.existencia()) {
                if (fondo.comprobarColor()) {

                    //Se convierte la cadena de color haxadecimal de la
                    //variable pública colorfinal de la clase TomarColor
                    //en un objeto de tipo Color.
                    Color fondocolor = System.Drawing.ColorTranslator.FromHtml(fondo.colorfinal);

                    //Se asigna objeto de tipo Color al color de fondo del formulario.
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
