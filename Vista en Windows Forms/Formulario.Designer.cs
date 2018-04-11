namespace Vista_en_Windows_Forms {
    partial class Formulario {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.editorTexto1 = new Biblioteca_de_Controles.EditorTexto();
            this.txt_CajaTexto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // editorTexto1
            // 
            this.editorTexto1.Caja = null;
            this.editorTexto1.Location = new System.Drawing.Point(12, 157);
            this.editorTexto1.Name = "editorTexto1";
            this.editorTexto1.Size = new System.Drawing.Size(536, 92);
            this.editorTexto1.TabIndex = 0;
            this.editorTexto1.Load += new System.EventHandler(this.editorTexto1_Load);
            // 
            // txt_CajaTexto
            // 
            this.txt_CajaTexto.Location = new System.Drawing.Point(12, 13);
            this.txt_CajaTexto.Name = "txt_CajaTexto";
            this.txt_CajaTexto.Size = new System.Drawing.Size(536, 138);
            this.txt_CajaTexto.TabIndex = 1;
            this.txt_CajaTexto.Text = "";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 257);
            this.Controls.Add(this.txt_CajaTexto);
            this.Controls.Add(this.editorTexto1);
            this.MaximizeBox = false;
            this.Name = "Formulario";
            this.Text = "Vista";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Biblioteca_de_Controles.EditorTexto editorTexto1;
        private System.Windows.Forms.RichTextBox txt_CajaTexto;
    }
}

