namespace Biblioteca_de_Controles
{
    partial class EditorTexto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Deshacer = new System.Windows.Forms.Button();
            this.btn_Abrir = new System.Windows.Forms.Button();
            this.btn_Rehacer = new System.Windows.Forms.Button();
            this.btn_Cortar = new System.Windows.Forms.Button();
            this.btn_Copiar = new System.Windows.Forms.Button();
            this.btn_Pegar = new System.Windows.Forms.Button();
            this.btn_Seleccionar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DiálogoAbrir = new System.Windows.Forms.OpenFileDialog();
            this.DiálogoGuardar = new System.Windows.Forms.SaveFileDialog();
            this.DiálogoFuente = new System.Windows.Forms.FontDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Abrir);
            this.groupBox1.Controls.Add(this.btn_Guardar);
            this.groupBox1.Controls.Add(this.btn_Salir);
            this.groupBox1.Controls.Add(this.btn_nuevo);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Archivo";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(7, 20);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_nuevo.TabIndex = 0;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(7, 50);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(89, 50);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 3;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Seleccionar);
            this.groupBox2.Controls.Add(this.btn_Pegar);
            this.groupBox2.Controls.Add(this.btn_Copiar);
            this.groupBox2.Controls.Add(this.btn_Cortar);
            this.groupBox2.Controls.Add(this.btn_Rehacer);
            this.groupBox2.Controls.Add(this.btn_Deshacer);
            this.groupBox2.Location = new System.Drawing.Point(183, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edición";
            // 
            // btn_Deshacer
            // 
            this.btn_Deshacer.Location = new System.Drawing.Point(6, 19);
            this.btn_Deshacer.Name = "btn_Deshacer";
            this.btn_Deshacer.Size = new System.Drawing.Size(75, 23);
            this.btn_Deshacer.TabIndex = 2;
            this.btn_Deshacer.Text = "Deshacer";
            this.btn_Deshacer.UseVisualStyleBackColor = true;
            this.btn_Deshacer.Click += new System.EventHandler(this.btn_Deshacer_Click);
            // 
            // btn_Abrir
            // 
            this.btn_Abrir.Location = new System.Drawing.Point(89, 19);
            this.btn_Abrir.Name = "btn_Abrir";
            this.btn_Abrir.Size = new System.Drawing.Size(75, 23);
            this.btn_Abrir.TabIndex = 4;
            this.btn_Abrir.Text = "Abrir";
            this.btn_Abrir.UseVisualStyleBackColor = true;
            this.btn_Abrir.Click += new System.EventHandler(this.btn_Abrir_Click);
            // 
            // btn_Rehacer
            // 
            this.btn_Rehacer.Location = new System.Drawing.Point(87, 19);
            this.btn_Rehacer.Name = "btn_Rehacer";
            this.btn_Rehacer.Size = new System.Drawing.Size(75, 23);
            this.btn_Rehacer.TabIndex = 3;
            this.btn_Rehacer.Text = "Rehacer";
            this.btn_Rehacer.UseVisualStyleBackColor = true;
            this.btn_Rehacer.Click += new System.EventHandler(this.btn_Rehacer_Click);
            // 
            // btn_Cortar
            // 
            this.btn_Cortar.Location = new System.Drawing.Point(6, 50);
            this.btn_Cortar.Name = "btn_Cortar";
            this.btn_Cortar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cortar.TabIndex = 4;
            this.btn_Cortar.Text = "Cortar";
            this.btn_Cortar.UseVisualStyleBackColor = true;
            this.btn_Cortar.Click += new System.EventHandler(this.btn_Cortar_Click);
            // 
            // btn_Copiar
            // 
            this.btn_Copiar.Location = new System.Drawing.Point(87, 50);
            this.btn_Copiar.Name = "btn_Copiar";
            this.btn_Copiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Copiar.TabIndex = 5;
            this.btn_Copiar.Text = "Copiar";
            this.btn_Copiar.UseVisualStyleBackColor = true;
            this.btn_Copiar.Click += new System.EventHandler(this.btn_Copiar_Click);
            // 
            // btn_Pegar
            // 
            this.btn_Pegar.Location = new System.Drawing.Point(168, 50);
            this.btn_Pegar.Name = "btn_Pegar";
            this.btn_Pegar.Size = new System.Drawing.Size(75, 23);
            this.btn_Pegar.TabIndex = 6;
            this.btn_Pegar.Text = "Pegar";
            this.btn_Pegar.UseVisualStyleBackColor = true;
            this.btn_Pegar.Click += new System.EventHandler(this.btn_Pegar_Click);
            // 
            // btn_Seleccionar
            // 
            this.btn_Seleccionar.Location = new System.Drawing.Point(168, 19);
            this.btn_Seleccionar.Name = "btn_Seleccionar";
            this.btn_Seleccionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Seleccionar.TabIndex = 7;
            this.btn_Seleccionar.Text = "Seleccionar";
            this.btn_Seleccionar.UseVisualStyleBackColor = true;
            this.btn_Seleccionar.Click += new System.EventHandler(this.btn_Seleccionar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(442, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(89, 82);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Formato";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fuente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DiálogoAbrir
            // 
            this.DiálogoAbrir.FileName = "Nuevo documento de texto";
            // 
            // EditorTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditorTexto";
            this.Size = new System.Drawing.Size(536, 92);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Deshacer;
        private System.Windows.Forms.Button btn_Abrir;
        private System.Windows.Forms.Button btn_Seleccionar;
        private System.Windows.Forms.Button btn_Pegar;
        private System.Windows.Forms.Button btn_Copiar;
        private System.Windows.Forms.Button btn_Cortar;
        private System.Windows.Forms.Button btn_Rehacer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog DiálogoAbrir;
        private System.Windows.Forms.SaveFileDialog DiálogoGuardar;
        private System.Windows.Forms.FontDialog DiálogoFuente;
    }
}
