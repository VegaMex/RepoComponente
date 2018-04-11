using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_de_Controles
{
    public partial class EditorTexto: UserControl
    {
        public EditorTexto()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Propiedad para establecer el valor de la caja de texto del formulario.
        /// </summary>
        public RichTextBox Caja { get; set; }

        private void btn_nuevo_Click(object sender, EventArgs e) {
            archivo(true);
        }

        private void btn_Salir_Click(object sender, EventArgs e) {
            archivo(false);
        }

        private void btn_Abrir_Click(object sender, EventArgs e) {
            abrir("Abrir un archivo");
        }

        private void btn_Guardar_Click(object sender, EventArgs e) {
            guardar("Nuevo documento de texto", "Guardar el archivo");
        }

        private void btn_Deshacer_Click(object sender, EventArgs e) {
            undodredo(false);
        }

        private void btn_Rehacer_Click(object sender, EventArgs e) {
            undodredo(true);
        }

        private void btn_Seleccionar_Click(object sender, EventArgs e) {
            seleccion(true);
        }

        private void btn_Cortar_Click(object sender, EventArgs e) {
            seleccion(false);
        }

        private void btn_Copiar_Click(object sender, EventArgs e) {
            editar(true);
        }

        private void btn_Pegar_Click(object sender, EventArgs e) {
            editar(false);
        }

        private void button1_Click(object sender, EventArgs e) {
            fuente();
        }

        /// <summary>
        /// Limpia la RichTextBox o cierra la aplicación.
        /// </summary>
        /// <param name="orden">Si el parámetro es true, limpia la RichTextBox. Si el parámetro es false, cierra la aplicación.</param>
        public void archivo(bool orden)
        {
            if (orden)
            {
                Caja.Clear();
            }
            else
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Rehace o deshace los cambios de la RichTextBox.
        /// </summary>
        /// <param name="orden">Si el parámetro es true, rehace. Si el parámetro es false, deshace.</param>
        public void undodredo(bool orden)
        {
            if (orden)
            {
                Caja.Redo();
            }
            else
            {
                Caja.Undo();
            }
        }

        /// <summary>
        /// Selecciona todo el texto o corta el texto seleccionado del RichTextBox.
        /// </summary>
        /// <param name="orden">Si el parámetro es true, selecciona el texto del RichTextBox. Si el parámetro es false, corta el texto del RichTextBox.</param>
        public void seleccion(bool orden)
        {
            if (orden)
            {
                Caja.SelectAll();
                Caja.Focus();
            }
            else
            {
                Caja.Cut();
            }

        }

        /// <summary>
        /// Copia o pega el texto del RichTextBox.
        /// </summary>
        /// <param name="orden">Si el parámetro es true, copia el texto del RichTextBox. Si el parámetro es false, pega el texto del RichTextBox.</param>
        public void editar(bool orden)
        {
            if (orden)
            {
                Caja.Copy();
            }
            else
            {
                Caja.Paste();
            }
        }

        /// <summary>
        /// Guarda el contenido de la RichTextBox en un documento de texto.
        /// </summary>
        /// <param name="nombre">Establece el nombre por defecto del archivo a guardar.</param>
        /// <param name="título">Establece el título de la ventana de guardado.</param>
        public void guardar(string nombre, string título) {

            DiálogoGuardar.DefaultExt = "*.txt";
            DiálogoGuardar.Filter = "Documento de texto|*.txt";
            DiálogoGuardar.FileName = nombre;
            DiálogoGuardar.Title = título;

            if (DiálogoGuardar.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               DiálogoGuardar.FileName.Length > 0) {
                Caja.SaveFile(DiálogoGuardar.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        /// <summary>
        /// Abre un documento de texto y lo carga en la RichTextBox.
        /// </summary>
        /// <param name="título">Establece el título de la ventana de apertura.</param>
        public void abrir(string título) {

            DiálogoAbrir.DefaultExt = "*.txt";
            DiálogoAbrir.Title = título;

            if (DiálogoAbrir.ShowDialog() == DialogResult.OK) {
                Caja.LoadFile(DiálogoAbrir.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        /// <summary>
        /// Abre un diálogo selector de fuente y lo aplica al RichTextBox.
        /// </summary>
        public void fuente() {
            if (DiálogoFuente.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                Caja.Font = DiálogoFuente.Font;
            }
        }
    }
}
