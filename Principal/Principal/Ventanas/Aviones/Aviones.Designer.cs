namespace Principal.Ventanas
{
    public partial class FormAviones
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
            this.gridAviones = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.comboCategorias = new System.Windows.Forms.ComboBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridAviones)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAviones
            // 
            this.gridAviones.AllowUserToAddRows = false;
            this.gridAviones.AllowUserToDeleteRows = false;
            this.gridAviones.AllowUserToResizeColumns = false;
            this.gridAviones.AllowUserToResizeRows = false;
            this.gridAviones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridAviones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gridAviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAviones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Categoria,
            this.Descripcion});
<<<<<<< HEAD
            this.gridAviones.GridColor = System.Drawing.SystemColors.Control;
            this.gridAviones.Location = new System.Drawing.Point(11, 44);
=======
            this.gridAviones.Location = new System.Drawing.Point(23, 24);
>>>>>>> Eliel2
            this.gridAviones.Margin = new System.Windows.Forms.Padding(2);
            this.gridAviones.Name = "gridAviones";
            this.gridAviones.ReadOnly = true;
            this.gridAviones.RowHeadersWidth = 51;
            this.gridAviones.RowTemplate.Height = 24;
            this.gridAviones.Size = new System.Drawing.Size(433, 259);
            this.gridAviones.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Numero";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 125;
            // 
            // btnAlta
            // 
<<<<<<< HEAD
            this.btnAlta.Location = new System.Drawing.Point(504, 103);
=======
            this.btnAlta.Location = new System.Drawing.Point(672, 127);
>>>>>>> Eliel2
            this.btnAlta.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 19);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "Nuevo Avion";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnModificar
            // 
<<<<<<< HEAD
            this.btnModificar.Location = new System.Drawing.Point(504, 134);
=======
            this.btnModificar.Location = new System.Drawing.Point(672, 165);
>>>>>>> Eliel2
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 19);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBaja
            // 
<<<<<<< HEAD
            this.btnBaja.Location = new System.Drawing.Point(504, 164);
=======
            this.btnBaja.Location = new System.Drawing.Point(672, 202);
>>>>>>> Eliel2
            this.btnBaja.Margin = new System.Windows.Forms.Padding(2);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 19);
            this.btnBaja.TabIndex = 3;
            this.btnBaja.Text = "Eliminar";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnBuscar
            // 
<<<<<<< HEAD
            this.btnBuscar.Location = new System.Drawing.Point(172, 308);
=======
            this.btnBuscar.Location = new System.Drawing.Point(184, 314);
>>>>>>> Eliel2
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 19);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboCategorias
            // 
            this.comboCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategorias.FormattingEnabled = true;
            this.comboCategorias.IntegralHeight = false;
<<<<<<< HEAD
            this.comboCategorias.Location = new System.Drawing.Point(11, 337);
=======
            this.comboCategorias.Location = new System.Drawing.Point(23, 349);
>>>>>>> Eliel2
            this.comboCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.comboCategorias.Name = "comboCategorias";
            this.comboCategorias.Size = new System.Drawing.Size(218, 21);
            this.comboCategorias.TabIndex = 5;
            this.comboCategorias.SelectedIndexChanged += new System.EventHandler(this.comboCategorias_SelectedIndexChanged);
            // 
<<<<<<< HEAD
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(504, 284);
=======
            // picAvion
            // 
            this.picAvion.Location = new System.Drawing.Point(672, 24);
            this.picAvion.Margin = new System.Windows.Forms.Padding(2);
            this.picAvion.Name = "picAvion";
            this.picAvion.Size = new System.Drawing.Size(75, 76);
            this.picAvion.TabIndex = 6;
            this.picAvion.TabStop = false;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(579, 350);
>>>>>>> Eliel2
            this.btnAtras.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 19);
            this.btnAtras.TabIndex = 8;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtBuscar
            // 
<<<<<<< HEAD
            this.txtBuscar.Location = new System.Drawing.Point(11, 307);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.MaxLength = 9;
=======
            this.txtBuscar.Location = new System.Drawing.Point(23, 314);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Mask = "99999";
>>>>>>> Eliel2
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(157, 20);
            this.txtBuscar.TabIndex = 9;
<<<<<<< HEAD
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeypressKeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(20, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Aviones";
=======
            this.txtBuscar.ValidatingType = typeof(int);
            
>>>>>>> Eliel2
            // 
            // FormAviones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.comboCategorias);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.gridAviones);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAviones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aviones";
            this.Load += new System.EventHandler(this.Aviones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAviones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAviones;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox comboCategorias;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Label label1;
    }
}