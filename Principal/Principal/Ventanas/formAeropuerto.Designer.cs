namespace Principal.Ventanas
{
    partial class formAeropuerto
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
            this.dgvDatosAeropuerto = new System.Windows.Forms.DataGridView();
            this.IdAeropuerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantPuertasEmbarque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantMangasVuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDatosAeropuerto = new System.Windows.Forms.Label();
            this.btnEditarAeropuerto = new System.Windows.Forms.Button();
            this.btnAceptarEdicion = new System.Windows.Forms.Button();
            this.groupAeropuerto = new System.Windows.Forms.GroupBox();
            this.btnBuscarAeropuerto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusquedaNombre = new System.Windows.Forms.TextBox();
            this.btnAgregarAeropuerto = new System.Windows.Forms.Button();
            this.btnEliminarAeropuerto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAeropuerto)).BeginInit();
            this.groupAeropuerto.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatosAeropuerto
            // 
            this.dgvDatosAeropuerto.AllowUserToAddRows = false;
            this.dgvDatosAeropuerto.AllowUserToDeleteRows = false;
            this.dgvDatosAeropuerto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosAeropuerto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAeropuerto,
            this.Nombre,
            this.Domicilio,
            this.Telefono,
            this.Descripcion,
            this.CantPuertasEmbarque,
            this.CantMangasVuelo});
            this.dgvDatosAeropuerto.Location = new System.Drawing.Point(16, 83);
            this.dgvDatosAeropuerto.Name = "dgvDatosAeropuerto";
            this.dgvDatosAeropuerto.ReadOnly = true;
            this.dgvDatosAeropuerto.Size = new System.Drawing.Size(573, 113);
            this.dgvDatosAeropuerto.TabIndex = 2;
            this.dgvDatosAeropuerto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosAeropuerto_CellContentClick);
            // 
            // IdAeropuerto
            // 
            this.IdAeropuerto.DataPropertyName = "IdAeropuerto";
            this.IdAeropuerto.HeaderText = "Id";
            this.IdAeropuerto.Name = "IdAeropuerto";
            this.IdAeropuerto.ReadOnly = true;
            this.IdAeropuerto.Width = 30;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Domicilio
            // 
            this.Domicilio.DataPropertyName = "Domicilio";
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // CantPuertasEmbarque
            // 
            this.CantPuertasEmbarque.DataPropertyName = "CantPuertasEmbarque";
            this.CantPuertasEmbarque.HeaderText = "Cantidad Puertas Embarque";
            this.CantPuertasEmbarque.Name = "CantPuertasEmbarque";
            this.CantPuertasEmbarque.ReadOnly = true;
            // 
            // CantMangasVuelo
            // 
            this.CantMangasVuelo.DataPropertyName = "CantMangasVuelo";
            this.CantMangasVuelo.HeaderText = "Cantidad Mangas Vuelo";
            this.CantMangasVuelo.Name = "CantMangasVuelo";
            this.CantMangasVuelo.ReadOnly = true;
            // 
            // lblDatosAeropuerto
            // 
            this.lblDatosAeropuerto.AutoSize = true;
            this.lblDatosAeropuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosAeropuerto.Location = new System.Drawing.Point(12, 50);
            this.lblDatosAeropuerto.Name = "lblDatosAeropuerto";
            this.lblDatosAeropuerto.Size = new System.Drawing.Size(165, 20);
            this.lblDatosAeropuerto.TabIndex = 3;
            this.lblDatosAeropuerto.Text = "Datos del Aeropuerto:";
            // 
            // btnEditarAeropuerto
            // 
            this.btnEditarAeropuerto.Enabled = false;
            this.btnEditarAeropuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAeropuerto.Location = new System.Drawing.Point(416, 225);
            this.btnEditarAeropuerto.Name = "btnEditarAeropuerto";
            this.btnEditarAeropuerto.Size = new System.Drawing.Size(75, 28);
            this.btnEditarAeropuerto.TabIndex = 4;
            this.btnEditarAeropuerto.Text = "Editar";
            this.btnEditarAeropuerto.UseVisualStyleBackColor = true;
            this.btnEditarAeropuerto.Click += new System.EventHandler(this.btnEditarAeropuerto_Click);
            // 
            // btnAceptarEdicion
            // 
            this.btnAceptarEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarEdicion.Location = new System.Drawing.Point(514, 225);
            this.btnAceptarEdicion.Name = "btnAceptarEdicion";
            this.btnAceptarEdicion.Size = new System.Drawing.Size(75, 28);
            this.btnAceptarEdicion.TabIndex = 5;
            this.btnAceptarEdicion.Text = "Aceptar";
            this.btnAceptarEdicion.UseVisualStyleBackColor = true;
            this.btnAceptarEdicion.Click += new System.EventHandler(this.btnAceptarEdicion_Click);
            // 
            // groupAeropuerto
            // 
            this.groupAeropuerto.Controls.Add(this.btnBuscarAeropuerto);
            this.groupAeropuerto.Controls.Add(this.label1);
            this.groupAeropuerto.Controls.Add(this.txtBusquedaNombre);
            this.groupAeropuerto.Controls.Add(this.btnAgregarAeropuerto);
            this.groupAeropuerto.Controls.Add(this.btnAceptarEdicion);
            this.groupAeropuerto.Controls.Add(this.btnEliminarAeropuerto);
            this.groupAeropuerto.Controls.Add(this.btnEditarAeropuerto);
            this.groupAeropuerto.Controls.Add(this.lblDatosAeropuerto);
            this.groupAeropuerto.Controls.Add(this.dgvDatosAeropuerto);
            this.groupAeropuerto.Location = new System.Drawing.Point(36, 20);
            this.groupAeropuerto.Name = "groupAeropuerto";
            this.groupAeropuerto.Size = new System.Drawing.Size(602, 259);
            this.groupAeropuerto.TabIndex = 7;
            this.groupAeropuerto.TabStop = false;
            // 
            // btnBuscarAeropuerto
            // 
            this.btnBuscarAeropuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAeropuerto.Location = new System.Drawing.Point(268, 225);
            this.btnBuscarAeropuerto.Name = "btnBuscarAeropuerto";
            this.btnBuscarAeropuerto.Size = new System.Drawing.Size(75, 28);
            this.btnBuscarAeropuerto.TabIndex = 10;
            this.btnBuscarAeropuerto.Text = "Buscar";
            this.btnBuscarAeropuerto.UseVisualStyleBackColor = true;
            this.btnBuscarAeropuerto.Click += new System.EventHandler(this.btnBuscarAeropuerto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buscar por Nombre:";
            // 
            // txtBusquedaNombre
            // 
            this.txtBusquedaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaNombre.Location = new System.Drawing.Point(163, 227);
            this.txtBusquedaNombre.MaxLength = 37284;
            this.txtBusquedaNombre.Name = "txtBusquedaNombre";
            this.txtBusquedaNombre.Size = new System.Drawing.Size(99, 26);
            this.txtBusquedaNombre.TabIndex = 8;
            // 
            // btnAgregarAeropuerto
            // 
            this.btnAgregarAeropuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAeropuerto.Location = new System.Drawing.Point(514, 9);
            this.btnAgregarAeropuerto.Name = "btnAgregarAeropuerto";
            this.btnAgregarAeropuerto.Size = new System.Drawing.Size(75, 28);
            this.btnAgregarAeropuerto.TabIndex = 7;
            this.btnAgregarAeropuerto.Text = "Agregar";
            this.btnAgregarAeropuerto.UseVisualStyleBackColor = true;
            this.btnAgregarAeropuerto.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminarAeropuerto
            // 
            this.btnEliminarAeropuerto.Enabled = false;
            this.btnEliminarAeropuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAeropuerto.Location = new System.Drawing.Point(416, 9);
            this.btnEliminarAeropuerto.Name = "btnEliminarAeropuerto";
            this.btnEliminarAeropuerto.Size = new System.Drawing.Size(75, 28);
            this.btnEliminarAeropuerto.TabIndex = 6;
            this.btnEliminarAeropuerto.Text = "Eliminar";
            this.btnEliminarAeropuerto.UseVisualStyleBackColor = true;
            this.btnEliminarAeropuerto.Click += new System.EventHandler(this.button2_Click);
            // 
            // formAeropuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 302);
            this.Controls.Add(this.groupAeropuerto);
            this.Name = "formAeropuerto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aeropuerto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAeropuerto)).EndInit();
            this.groupAeropuerto.ResumeLayout(false);
            this.groupAeropuerto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDatosAeropuerto;
        private System.Windows.Forms.Label lblDatosAeropuerto;
        private System.Windows.Forms.Button btnEditarAeropuerto;
        private System.Windows.Forms.Button btnAceptarEdicion;
        private System.Windows.Forms.GroupBox groupAeropuerto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusquedaNombre;
        private System.Windows.Forms.Button btnAgregarAeropuerto;
        private System.Windows.Forms.Button btnEliminarAeropuerto;
        private System.Windows.Forms.Button btnBuscarAeropuerto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAeropuerto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantPuertasEmbarque;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantMangasVuelo;
    }
}