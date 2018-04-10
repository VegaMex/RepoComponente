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

        public RichTextBox Caja { get; set; }

        private void btn_nuevo_Click(object sender, EventArgs e) {
            Caja.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btn_Abrir_Click(object sender, EventArgs e) {
            DiálogoAbrir.DefaultExt = "*.txt";

            if (DiálogoAbrir.ShowDialog() == DialogResult.OK) {
                Caja.LoadFile(DiálogoAbrir.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e) {
            DiálogoGuardar.DefaultExt = "*.txt";
            DiálogoGuardar.Filter = "Documento de texto|*.txt";

            if (DiálogoGuardar.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               DiálogoGuardar.FileName.Length > 0) {
                Caja.SaveFile(DiálogoGuardar.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void btn_Deshacer_Click(object sender, EventArgs e) {
            Caja.Undo();
        }

        private void btn_Rehacer_Click(object sender, EventArgs e) {
            Caja.Redo();
        }

        private void btn_Seleccionar_Click(object sender, EventArgs e) {
            Caja.SelectAll();
            Caja.Focus();
        }

        private void btn_Cortar_Click(object sender, EventArgs e) {
            Caja.Cut();
        }

        private void btn_Copiar_Click(object sender, EventArgs e) {
            Caja.Copy();
        }

        private void btn_Pegar_Click(object sender, EventArgs e) {
            Caja.Paste();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (DiálogoFuente.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                Caja.Font = DiálogoFuente.Font;
            }
        }
    }
}
