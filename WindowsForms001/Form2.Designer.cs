namespace WindowsForms001
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.GroupboxColores = new System.Windows.Forms.GroupBox();
            this.EtiquetaRadios = new System.Windows.Forms.Label();
            this.EtiqRadios = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.Seleccionado = new System.Windows.Forms.Button();
            this.EtiqAprob = new System.Windows.Forms.Label();
            this.BtnAprobado = new System.Windows.Forms.Button();
            this.EsInformatico = new System.Windows.Forms.CheckBox();
            this.BotonInfo = new System.Windows.Forms.Button();
            this.GroupboxColores.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Verde";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Rojo";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(15, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(45, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Azul";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // GroupboxColores
            // 
            this.GroupboxColores.Controls.Add(this.radioButton1);
            this.GroupboxColores.Controls.Add(this.radioButton3);
            this.GroupboxColores.Controls.Add(this.radioButton2);
            this.GroupboxColores.Location = new System.Drawing.Point(43, 27);
            this.GroupboxColores.Name = "GroupboxColores";
            this.GroupboxColores.Size = new System.Drawing.Size(200, 100);
            this.GroupboxColores.TabIndex = 3;
            this.GroupboxColores.TabStop = false;
            this.GroupboxColores.Text = "Colores";
            this.GroupboxColores.Enter += new System.EventHandler(this.GroupboxColores_Enter);
            // 
            // EtiquetaRadios
            // 
            this.EtiquetaRadios.AutoSize = true;
            this.EtiquetaRadios.Location = new System.Drawing.Point(40, 139);
            this.EtiquetaRadios.Name = "EtiquetaRadios";
            this.EtiquetaRadios.Size = new System.Drawing.Size(0, 13);
            this.EtiquetaRadios.TabIndex = 4;
            // 
            // EtiqRadios
            // 
            this.EtiqRadios.AutoSize = true;
            this.EtiqRadios.Location = new System.Drawing.Point(40, 139);
            this.EtiqRadios.Name = "EtiqRadios";
            this.EtiqRadios.Size = new System.Drawing.Size(35, 13);
            this.EtiqRadios.TabIndex = 5;
            this.EtiqRadios.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Location = new System.Drawing.Point(43, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 43);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(72, 17);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.Text = "Suspenso";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 20);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(71, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Aprobado";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // Seleccionado
            // 
            this.Seleccionado.Location = new System.Drawing.Point(295, 63);
            this.Seleccionado.Name = "Seleccionado";
            this.Seleccionado.Size = new System.Drawing.Size(85, 23);
            this.Seleccionado.TabIndex = 7;
            this.Seleccionado.Text = "Seleccionado";
            this.Seleccionado.UseVisualStyleBackColor = true;
            this.Seleccionado.Click += new System.EventHandler(this.Seleccionado_Click);
            // 
            // EtiqAprob
            // 
            this.EtiqAprob.AutoSize = true;
            this.EtiqAprob.Location = new System.Drawing.Point(43, 299);
            this.EtiqAprob.Name = "EtiqAprob";
            this.EtiqAprob.Size = new System.Drawing.Size(35, 13);
            this.EtiqAprob.TabIndex = 8;
            this.EtiqAprob.Text = "label1";
            this.EtiqAprob.Click += new System.EventHandler(this.EtiqAprob_Click);
            // 
            // BtnAprobado
            // 
            this.BtnAprobado.Location = new System.Drawing.Point(295, 219);
            this.BtnAprobado.Name = "BtnAprobado";
            this.BtnAprobado.Size = new System.Drawing.Size(85, 23);
            this.BtnAprobado.TabIndex = 9;
            this.BtnAprobado.Text = "Seleccionado";
            this.BtnAprobado.UseVisualStyleBackColor = true;
            this.BtnAprobado.Click += new System.EventHandler(this.BtnAprobado_Click);
            // 
            // EsInformatico
            // 
            this.EsInformatico.AutoSize = true;
            this.EsInformatico.Location = new System.Drawing.Point(476, 109);
            this.EsInformatico.Name = "EsInformatico";
            this.EsInformatico.Size = new System.Drawing.Size(92, 17);
            this.EsInformatico.TabIndex = 10;
            this.EsInformatico.Text = "Es informático";
            this.EsInformatico.UseVisualStyleBackColor = true;
            // 
            // BotonInfo
            // 
            this.BotonInfo.Location = new System.Drawing.Point(496, 176);
            this.BotonInfo.Name = "BotonInfo";
            this.BotonInfo.Size = new System.Drawing.Size(75, 23);
            this.BotonInfo.TabIndex = 11;
            this.BotonInfo.Text = "Boton Info";
            this.BotonInfo.UseVisualStyleBackColor = true;
            this.BotonInfo.Click += new System.EventHandler(this.BotonInfo_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotonInfo);
            this.Controls.Add(this.EsInformatico);
            this.Controls.Add(this.BtnAprobado);
            this.Controls.Add(this.EtiqAprob);
            this.Controls.Add(this.Seleccionado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EtiqRadios);
            this.Controls.Add(this.EtiquetaRadios);
            this.Controls.Add(this.GroupboxColores);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.GroupboxColores.ResumeLayout(false);
            this.GroupboxColores.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox GroupboxColores;
        private System.Windows.Forms.Label EtiquetaRadios;
        private System.Windows.Forms.Label EtiqRadios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button Seleccionado;
        private System.Windows.Forms.Label EtiqAprob;
        private System.Windows.Forms.Button BtnAprobado;
        private System.Windows.Forms.CheckBox EsInformatico;
        private System.Windows.Forms.Button BotonInfo;
    }
}