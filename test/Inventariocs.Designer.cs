namespace test
{
    partial class Inventariocs
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
            this.btnNuevoProveedor = new System.Windows.Forms.Button();
            this.btnEditarProveedor = new System.Windows.Forms.Button();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_FiltroPor = new System.Windows.Forms.ComboBox();
            this.txtBox_Filtro = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoProveedor
            // 
            this.btnNuevoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProveedor.Location = new System.Drawing.Point(27, 25);
            this.btnNuevoProveedor.Name = "btnNuevoProveedor";
            this.btnNuevoProveedor.Size = new System.Drawing.Size(159, 38);
            this.btnNuevoProveedor.TabIndex = 0;
            this.btnNuevoProveedor.Text = "Nuevo";
            this.btnNuevoProveedor.UseVisualStyleBackColor = true;
            this.btnNuevoProveedor.Click += new System.EventHandler(this.btnNuevoProveedor_Click);
            // 
            // btnEditarProveedor
            // 
            this.btnEditarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProveedor.Location = new System.Drawing.Point(234, 25);
            this.btnEditarProveedor.Name = "btnEditarProveedor";
            this.btnEditarProveedor.Size = new System.Drawing.Size(159, 38);
            this.btnEditarProveedor.TabIndex = 1;
            this.btnEditarProveedor.Text = "Editar";
            this.btnEditarProveedor.UseVisualStyleBackColor = true;
            this.btnEditarProveedor.Click += new System.EventHandler(this.btnEditarProveedor_Click_1);
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProveedor.Location = new System.Drawing.Point(446, 25);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(159, 38);
            this.btnEliminarProveedor.TabIndex = 2;
            this.btnEliminarProveedor.Text = "Eliminar";
            this.btnEliminarProveedor.UseVisualStyleBackColor = true;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.txtBox_Filtro);
            this.panel1.Controls.Add(this.cmb_FiltroPor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvProveedor);
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 602);
            this.panel1.TabIndex = 3;
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.AllowUserToAddRows = false;
            this.dgvProveedor.AllowUserToDeleteRows = false;
            this.dgvProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedor.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Location = new System.Drawing.Point(0, 82);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.ReadOnly = true;
            this.dgvProveedor.RowHeadersWidth = 51;
            this.dgvProveedor.RowTemplate.Height = 24;
            this.dgvProveedor.Size = new System.Drawing.Size(961, 520);
            this.dgvProveedor.TabIndex = 0;
            this.dgvProveedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedor_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buscar Por:";
            // 
            // cmb_FiltroPor
            // 
            this.cmb_FiltroPor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_FiltroPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FiltroPor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_FiltroPor.FormattingEnabled = true;
            this.cmb_FiltroPor.Items.AddRange(new object[] {
            "RUC",
            "Nombre",
            "Telefono",
            "Correo",
            "Direccion",
            "Activo"});
            this.cmb_FiltroPor.Location = new System.Drawing.Point(568, 26);
            this.cmb_FiltroPor.Name = "cmb_FiltroPor";
            this.cmb_FiltroPor.Size = new System.Drawing.Size(131, 24);
            this.cmb_FiltroPor.TabIndex = 3;
            this.cmb_FiltroPor.SelectedIndexChanged += new System.EventHandler(this.cmb_FiltroPor_SelectedIndexChanged);
            // 
            // txtBox_Filtro
            // 
            this.txtBox_Filtro.Location = new System.Drawing.Point(730, 26);
            this.txtBox_Filtro.Multiline = true;
            this.txtBox_Filtro.Name = "txtBox_Filtro";
            this.txtBox_Filtro.Size = new System.Drawing.Size(155, 24);
            this.txtBox_Filtro.TabIndex = 4;
            this.txtBox_Filtro.TextChanged += new System.EventHandler(this.txtBox_Filtro_TextChanged);
            // 
            // Inventariocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(962, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliminarProveedor);
            this.Controls.Add(this.btnEditarProveedor);
            this.Controls.Add(this.btnNuevoProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventariocs";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Inventariocs";
            this.Load += new System.EventHandler(this.Inventariocs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoProveedor;
        private System.Windows.Forms.Button btnEditarProveedor;
        private System.Windows.Forms.Button btnEliminarProveedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.TextBox txtBox_Filtro;
        private System.Windows.Forms.ComboBox cmb_FiltroPor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}