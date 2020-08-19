namespace WindowsForms001
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.button1 = new System.Windows.Forms.Button();
            this.EtiquetaNombre = new System.Windows.Forms.Label();
            this.CajaNombre = new System.Windows.Forms.TextBox();
            this.EtiquetaApellidos = new System.Windows.Forms.Label();
            this.CajaApellidos = new System.Windows.Forms.TextBox();
            this.BotonPersona = new System.Windows.Forms.Button();
            this.EtiquetaNota1 = new System.Windows.Forms.Label();
            this.EtiquetaNota3 = new System.Windows.Forms.Label();
            this.EtiquetaNota2 = new System.Windows.Forms.Label();
            this.CajaNota1 = new System.Windows.Forms.TextBox();
            this.CajaNota2 = new System.Windows.Forms.TextBox();
            this.CajaNota3 = new System.Windows.Forms.TextBox();
            this.BotonNotas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Púlsame";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EtiquetaNombre
            // 
            this.EtiquetaNombre.AutoSize = true;
            this.EtiquetaNombre.Location = new System.Drawing.Point(44, 88);
            this.EtiquetaNombre.Name = "EtiquetaNombre";
            this.EtiquetaNombre.Size = new System.Drawing.Size(44, 13);
            this.EtiquetaNombre.TabIndex = 1;
            this.EtiquetaNombre.Text = "Nombre";
            this.EtiquetaNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // CajaNombre
            // 
            this.CajaNombre.Location = new System.Drawing.Point(118, 85);
            this.CajaNombre.Name = "CajaNombre";
            this.CajaNombre.Size = new System.Drawing.Size(100, 20);
            this.CajaNombre.TabIndex = 2;
            // 
            // EtiquetaApellidos
            // 
            this.EtiquetaApellidos.AutoSize = true;
            this.EtiquetaApellidos.Location = new System.Drawing.Point(44, 123);
            this.EtiquetaApellidos.Name = "EtiquetaApellidos";
            this.EtiquetaApellidos.Size = new System.Drawing.Size(49, 13);
            this.EtiquetaApellidos.TabIndex = 3;
            this.EtiquetaApellidos.Text = "Apellidos";
            // 
            // CajaApellidos
            // 
            this.CajaApellidos.Location = new System.Drawing.Point(118, 120);
            this.CajaApellidos.Name = "CajaApellidos";
            this.CajaApellidos.Size = new System.Drawing.Size(100, 20);
            this.CajaApellidos.TabIndex = 4;
            // 
            // BotonPersona
            // 
            this.BotonPersona.Location = new System.Drawing.Point(47, 162);
            this.BotonPersona.Name = "BotonPersona";
            this.BotonPersona.Size = new System.Drawing.Size(171, 48);
            this.BotonPersona.TabIndex = 5;
            this.BotonPersona.Text = "Datos de la Persona";
            this.BotonPersona.UseVisualStyleBackColor = true;
            this.BotonPersona.Click += new System.EventHandler(this.BotonPersona_Click);
            // 
            // EtiquetaNota1
            // 
            this.EtiquetaNota1.AutoSize = true;
            this.EtiquetaNota1.Location = new System.Drawing.Point(300, 21);
            this.EtiquetaNota1.Name = "EtiquetaNota1";
            this.EtiquetaNota1.Size = new System.Drawing.Size(36, 13);
            this.EtiquetaNota1.TabIndex = 6;
            this.EtiquetaNota1.Text = "Nota1";
            // 
            // EtiquetaNota3
            // 
            this.EtiquetaNota3.AutoSize = true;
            this.EtiquetaNota3.Location = new System.Drawing.Point(300, 92);
            this.EtiquetaNota3.Name = "EtiquetaNota3";
            this.EtiquetaNota3.Size = new System.Drawing.Size(36, 13);
            this.EtiquetaNota3.TabIndex = 7;
            this.EtiquetaNota3.Text = "Nota3";
            // 
            // EtiquetaNota2
            // 
            this.EtiquetaNota2.AutoSize = true;
            this.EtiquetaNota2.Location = new System.Drawing.Point(300, 56);
            this.EtiquetaNota2.Name = "EtiquetaNota2";
            this.EtiquetaNota2.Size = new System.Drawing.Size(36, 13);
            this.EtiquetaNota2.TabIndex = 8;
            this.EtiquetaNota2.Text = "Nota2";
            // 
            // CajaNota1
            // 
            this.CajaNota1.Location = new System.Drawing.Point(367, 18);
            this.CajaNota1.Name = "CajaNota1";
            this.CajaNota1.Size = new System.Drawing.Size(100, 20);
            this.CajaNota1.TabIndex = 9;
            // 
            // CajaNota2
            // 
            this.CajaNota2.Location = new System.Drawing.Point(367, 53);
            this.CajaNota2.Name = "CajaNota2";
            this.CajaNota2.Size = new System.Drawing.Size(100, 20);
            this.CajaNota2.TabIndex = 10;
            // 
            // CajaNota3
            // 
            this.CajaNota3.Location = new System.Drawing.Point(367, 85);
            this.CajaNota3.Name = "CajaNota3";
            this.CajaNota3.Size = new System.Drawing.Size(100, 20);
            this.CajaNota3.TabIndex = 11;
            // 
            // BotonNotas
            // 
            this.BotonNotas.Location = new System.Drawing.Point(313, 123);
            this.BotonNotas.Name = "BotonNotas";
            this.BotonNotas.Size = new System.Drawing.Size(144, 33);
            this.BotonNotas.TabIndex = 12;
            this.BotonNotas.Text = "Suma Notas";
            this.BotonNotas.UseVisualStyleBackColor = true;
            this.BotonNotas.Click += new System.EventHandler(this.BotonNotas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 361);
            this.Controls.Add(this.BotonNotas);
            this.Controls.Add(this.CajaNota3);
            this.Controls.Add(this.CajaNota2);
            this.Controls.Add(this.CajaNota1);
            this.Controls.Add(this.EtiquetaNota2);
            this.Controls.Add(this.EtiquetaNota3);
            this.Controls.Add(this.EtiquetaNota1);
            this.Controls.Add(this.BotonPersona);
            this.Controls.Add(this.CajaApellidos);
            this.Controls.Add(this.EtiquetaApellidos);
            this.Controls.Add(this.CajaNombre);
            this.Controls.Add(this.EtiquetaNombre);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label EtiquetaNombre;
        private System.Windows.Forms.TextBox CajaNombre;
        private System.Windows.Forms.Button BotonPersona;
        private System.Windows.Forms.TextBox CajaApellidos;
        private System.Windows.Forms.Label EtiquetaApellidos;
        private System.Windows.Forms.Button BotonNotas;
        private System.Windows.Forms.TextBox CajaNota3;
        private System.Windows.Forms.TextBox CajaNota2;
        private System.Windows.Forms.TextBox CajaNota1;
        private System.Windows.Forms.Label EtiquetaNota2;
        private System.Windows.Forms.Label EtiquetaNota3;
        private System.Windows.Forms.Label EtiquetaNota1;
    }
}

