namespace Taller1
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
            System.Windows.Forms.PictureBox picFup;
            this.lblFundacion = new System.Windows.Forms.Label();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.lblcontrol = new System.Windows.Forms.Label();
            this.txtcontrol = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.cbosemestre = new System.Windows.Forms.ComboBox();
            this.btnsaludo = new System.Windows.Forms.Button();
            picFup = new System.Windows.Forms.PictureBox();
            this.grbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(picFup)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFundacion
            // 
            this.lblFundacion.AutoSize = true;
            this.lblFundacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFundacion.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFundacion.Location = new System.Drawing.Point(90, 21);
            this.lblFundacion.Name = "lblFundacion";
            this.lblFundacion.Size = new System.Drawing.Size(568, 34);
            this.lblFundacion.TabIndex = 0;
            this.lblFundacion.Text = "FUNDACION UNIVERSITARIA DE POPAYAN";
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.cbosemestre);
            this.grbDatos.Controls.Add(this.lblSemestre);
            this.grbDatos.Controls.Add(this.lblNombre);
            this.grbDatos.Controls.Add(this.textBox2);
            this.grbDatos.Controls.Add(this.txtcontrol);
            this.grbDatos.Controls.Add(this.lblcontrol);
            this.grbDatos.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatos.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbDatos.Location = new System.Drawing.Point(90, 229);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(384, 235);
            this.grbDatos.TabIndex = 1;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos ";
            this.grbDatos.Enter += new System.EventHandler(this.grbDatos_Enter);
            // 
            // lblcontrol
            // 
            this.lblcontrol.AutoSize = true;
            this.lblcontrol.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontrol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcontrol.Location = new System.Drawing.Point(20, 56);
            this.lblcontrol.Name = "lblcontrol";
            this.lblcontrol.Size = new System.Drawing.Size(80, 20);
            this.lblcontrol.TabIndex = 0;
            this.lblcontrol.Text = "No. Control";
            // 
            // txtcontrol
            // 
            this.txtcontrol.Location = new System.Drawing.Point(132, 56);
            this.txtcontrol.Name = "txtcontrol";
            this.txtcontrol.Size = new System.Drawing.Size(100, 32);
            this.txtcontrol.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(246, 32);
            this.textBox2.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(20, 108);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemestre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSemestre.Location = new System.Drawing.Point(20, 157);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(106, 20);
            this.lblSemestre.TabIndex = 4;
            this.lblSemestre.Text = "Especializacion";
            // 
            // cbosemestre
            // 
            this.cbosemestre.FormattingEnabled = true;
            this.cbosemestre.Items.AddRange(new object[] {
            "Administracion",
            "Psicologia",
            "Licentiatura",
            "Arquitectura"});
            this.cbosemestre.Location = new System.Drawing.Point(132, 157);
            this.cbosemestre.Name = "cbosemestre";
            this.cbosemestre.Size = new System.Drawing.Size(121, 33);
            this.cbosemestre.TabIndex = 5;
            // 
            // btnsaludo
            // 
            this.btnsaludo.Font = new System.Drawing.Font("Microsoft YaHei Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaludo.Location = new System.Drawing.Point(538, 376);
            this.btnsaludo.Name = "btnsaludo";
            this.btnsaludo.Size = new System.Drawing.Size(144, 49);
            this.btnsaludo.TabIndex = 2;
            this.btnsaludo.Text = "Saludo";
            this.btnsaludo.UseVisualStyleBackColor = true;
            this.btnsaludo.Click += new System.EventHandler(this.btnsaludo_Click);
            // 
            // picFup
            // 
            picFup.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            picFup.BackColor = System.Drawing.SystemColors.Control;
            picFup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            picFup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picFup.Image = global::Taller1.Properties.Resources.descarga;
            picFup.Location = new System.Drawing.Point(54, 81);
            picFup.Name = "picFup";
            picFup.Size = new System.Drawing.Size(414, 123);
            picFup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picFup.TabIndex = 3;
            picFup.TabStop = false;
            picFup.Click += new System.EventHandler(this.picFup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(picFup);
            this.Controls.Add(this.btnsaludo);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.lblFundacion);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "ALUMNOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(picFup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFundacion;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtcontrol;
        private System.Windows.Forms.Label lblcontrol;
        private System.Windows.Forms.ComboBox cbosemestre;
        private System.Windows.Forms.Button btnsaludo;
    }
}

