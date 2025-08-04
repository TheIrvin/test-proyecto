namespace test
{
    partial class AgregarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProveedor));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlProveedor = new System.Windows.Forms.Panel();
            this.SalirProveedor = new System.Windows.Forms.Label();
            this.txtBox_RucProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardarProveedor = new System.Windows.Forms.Button();
            this.btnCancelarProveedor = new System.Windows.Forms.Button();
            this.cmbBox_ActivoProveedor = new System.Windows.Forms.ComboBox();
            this.txtBox_NombreProveedor = new System.Windows.Forms.TextBox();
            this.txtBox_telefonoProveedor = new System.Windows.Forms.TextBox();
            this.txtBox_CorreoProveedor = new System.Windows.Forms.TextBox();
            this.txtBox_direccionProveedor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Proveedor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlProveedor
            // 
            this.pnlProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlProveedor.Controls.Add(this.SalirProveedor);
            this.pnlProveedor.Controls.Add(this.label1);
            this.pnlProveedor.Controls.Add(this.pictureBox1);
            this.pnlProveedor.Location = new System.Drawing.Point(0, 1);
            this.pnlProveedor.Name = "pnlProveedor";
            this.pnlProveedor.Size = new System.Drawing.Size(591, 47);
            this.pnlProveedor.TabIndex = 2;
            this.pnlProveedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlProveedor_MouseDown);
            // 
            // SalirProveedor
            // 
            this.SalirProveedor.AutoSize = true;
            this.SalirProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirProveedor.Location = new System.Drawing.Point(536, 8);
            this.SalirProveedor.Name = "SalirProveedor";
            this.SalirProveedor.Size = new System.Drawing.Size(31, 29);
            this.SalirProveedor.TabIndex = 2;
            this.SalirProveedor.Text = "X";
            this.SalirProveedor.Click += new System.EventHandler(this.SalirProveedor_Click);
            // 
            // txtBox_RucProveedor
            // 
            this.txtBox_RucProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_RucProveedor.Location = new System.Drawing.Point(179, 96);
            this.txtBox_RucProveedor.Multiline = true;
            this.txtBox_RucProveedor.Name = "txtBox_RucProveedor";
            this.txtBox_RucProveedor.Size = new System.Drawing.Size(298, 30);
            this.txtBox_RucProveedor.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "RUC:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Teléfono:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Correo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Dirección:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Activo:";
            // 
            // btnGuardarProveedor
            // 
            this.btnGuardarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProveedor.Location = new System.Drawing.Point(41, 468);
            this.btnGuardarProveedor.Name = "btnGuardarProveedor";
            this.btnGuardarProveedor.Size = new System.Drawing.Size(173, 48);
            this.btnGuardarProveedor.TabIndex = 10;
            this.btnGuardarProveedor.Text = "Guardar Cambios";
            this.btnGuardarProveedor.UseVisualStyleBackColor = true;
            this.btnGuardarProveedor.Click += new System.EventHandler(this.btnGuardarProveedor_Click);
            // 
            // btnCancelarProveedor
            // 
            this.btnCancelarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProveedor.Location = new System.Drawing.Point(404, 468);
            this.btnCancelarProveedor.Name = "btnCancelarProveedor";
            this.btnCancelarProveedor.Size = new System.Drawing.Size(173, 48);
            this.btnCancelarProveedor.TabIndex = 11;
            this.btnCancelarProveedor.Text = "Cancelar";
            this.btnCancelarProveedor.UseVisualStyleBackColor = true;
            // 
            // cmbBox_ActivoProveedor
            // 
            this.cmbBox_ActivoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_ActivoProveedor.FormattingEnabled = true;
            this.cmbBox_ActivoProveedor.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbBox_ActivoProveedor.Location = new System.Drawing.Point(179, 414);
            this.cmbBox_ActivoProveedor.Name = "cmbBox_ActivoProveedor";
            this.cmbBox_ActivoProveedor.Size = new System.Drawing.Size(298, 28);
            this.cmbBox_ActivoProveedor.TabIndex = 55;
            // 
            // txtBox_NombreProveedor
            // 
            this.txtBox_NombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_NombreProveedor.Location = new System.Drawing.Point(179, 158);
            this.txtBox_NombreProveedor.Multiline = true;
            this.txtBox_NombreProveedor.Name = "txtBox_NombreProveedor";
            this.txtBox_NombreProveedor.Size = new System.Drawing.Size(298, 30);
            this.txtBox_NombreProveedor.TabIndex = 51;
            // 
            // txtBox_telefonoProveedor
            // 
            this.txtBox_telefonoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_telefonoProveedor.Location = new System.Drawing.Point(179, 213);
            this.txtBox_telefonoProveedor.Multiline = true;
            this.txtBox_telefonoProveedor.Name = "txtBox_telefonoProveedor";
            this.txtBox_telefonoProveedor.Size = new System.Drawing.Size(298, 30);
            this.txtBox_telefonoProveedor.TabIndex = 52;
            // 
            // txtBox_CorreoProveedor
            // 
            this.txtBox_CorreoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_CorreoProveedor.Location = new System.Drawing.Point(179, 278);
            this.txtBox_CorreoProveedor.Multiline = true;
            this.txtBox_CorreoProveedor.Name = "txtBox_CorreoProveedor";
            this.txtBox_CorreoProveedor.Size = new System.Drawing.Size(298, 30);
            this.txtBox_CorreoProveedor.TabIndex = 53;
            // 
            // txtBox_direccionProveedor
            // 
            this.txtBox_direccionProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_direccionProveedor.Location = new System.Drawing.Point(179, 345);
            this.txtBox_direccionProveedor.Multiline = true;
            this.txtBox_direccionProveedor.Name = "txtBox_direccionProveedor";
            this.txtBox_direccionProveedor.Size = new System.Drawing.Size(298, 30);
            this.txtBox_direccionProveedor.TabIndex = 54;
            // 
            // AgregarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 528);
            this.Controls.Add(this.txtBox_direccionProveedor);
            this.Controls.Add(this.txtBox_CorreoProveedor);
            this.Controls.Add(this.txtBox_telefonoProveedor);
            this.Controls.Add(this.txtBox_NombreProveedor);
            this.Controls.Add(this.cmbBox_ActivoProveedor);
            this.Controls.Add(this.btnCancelarProveedor);
            this.Controls.Add(this.btnGuardarProveedor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_RucProveedor);
            this.Controls.Add(this.pnlProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarProveedor";
            this.ShowIcon = false;
            this.Text = "AgregarProveedor";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AgregarProveedor_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlProveedor.ResumeLayout(false);
            this.pnlProveedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlProveedor;
        private System.Windows.Forms.Label SalirProveedor;
        private System.Windows.Forms.TextBox txtBox_RucProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGuardarProveedor;
        private System.Windows.Forms.Button btnCancelarProveedor;
        private System.Windows.Forms.ComboBox cmbBox_ActivoProveedor;
        private System.Windows.Forms.TextBox txtBox_NombreProveedor;
        private System.Windows.Forms.TextBox txtBox_telefonoProveedor;
        private System.Windows.Forms.TextBox txtBox_CorreoProveedor;
        private System.Windows.Forms.TextBox txtBox_direccionProveedor;
    }
}