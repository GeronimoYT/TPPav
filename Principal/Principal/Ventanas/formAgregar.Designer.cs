namespace Principal.Ventanas
{
    partial class formAgregar
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
            this.lblDatosNuevoAeropuerto = new System.Windows.Forms.Label();
            this.lblDomicilioNuevoAeropuerto = new System.Windows.Forms.Label();
            this.txtNuevoDomicilio = new System.Windows.Forms.TextBox();
            this.txtNuevoTelefono = new System.Windows.Forms.TextBox();
            this.lblNuevoTelefono = new System.Windows.Forms.Label();
            this.txtNuevaDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcionNuevoVuelo = new System.Windows.Forms.Label();
            this.txtCMVuelo = new System.Windows.Forms.TextBox();
            this.lblCMNuevoVuelo = new System.Windows.Forms.Label();
            this.txtCPEmbarque = new System.Windows.Forms.TextBox();
            this.lblCPNuevoEmbarque = new System.Windows.Forms.Label();
            this.dgvDatosAeropuerto = new System.Windows.Forms.DataGridView();
            this.IdAeropuerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantPuertasEmbarque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantMangasVuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAeropuerto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatosNuevoAeropuerto
            // 
            this.lblDatosNuevoAeropuerto.AutoSize = true;
            this.lblDatosNuevoAeropuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosNuevoAeropuerto.Location = new System.Drawing.Point(12, 9);
            this.lblDatosNuevoAeropuerto.Name = "lblDatosNuevoAeropuerto";
            this.lblDatosNuevoAeropuerto.Size = new System.Drawing.Size(212, 20);
            this.lblDatosNuevoAeropuerto.TabIndex = 0;
            this.lblDatosNuevoAeropuerto.Text = "Datos Nuevo Aeropuerto:";
            // 
            // lblDomicilioNuevoAeropuerto
            // 
            this.lblDomicilioNuevoAeropuerto.AutoSize = true;
            this.lblDomicilioNuevoAeropuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilioNuevoAeropuerto.Location = new System.Drawing.Point(43, 52);
            this.lblDomicilioNuevoAeropuerto.Name = "lblDomicilioNuevoAeropuerto";
            this.lblDomicilioNuevoAeropuerto.Size = new System.Drawing.Size(68, 17);
            this.lblDomicilioNuevoAeropuerto.TabIndex = 1;
            this.lblDomicilioNuevoAeropuerto.Text = "Domicilio:";
            // 
            // txtNuevoDomicilio
            // 
            this.txtNuevoDomicilio.Location = new System.Drawing.Point(154, 51);
            this.txtNuevoDomicilio.Name = "txtNuevoDomicilio";
            this.txtNuevoDomicilio.Size = new System.Drawing.Size(155, 20);
            this.txtNuevoDomicilio.TabIndex = 2;
            // 
            // txtNuevoTelefono
            // 
            this.txtNuevoTelefono.Location = new System.Drawing.Point(154, 101);
            this.txtNuevoTelefono.MaxLength = 10;
            this.txtNuevoTelefono.Name = "txtNuevoTelefono";
            this.txtNuevoTelefono.Size = new System.Drawing.Size(155, 20);
            this.txtNuevoTelefono.TabIndex = 4;
            // 
            // lblNuevoTelefono
            // 
            this.lblNuevoTelefono.AutoSize = true;
            this.lblNuevoTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoTelefono.Location = new System.Drawing.Point(43, 102);
            this.lblNuevoTelefono.Name = "lblNuevoTelefono";
            this.lblNuevoTelefono.Size = new System.Drawing.Size(68, 17);
            this.lblNuevoTelefono.TabIndex = 3;
            this.lblNuevoTelefono.Text = "Telefono:";
            // 
            // txtNuevaDescripcion
            // 
            this.txtNuevaDescripcion.Location = new System.Drawing.Point(154, 150);
            this.txtNuevaDescripcion.Multiline = true;
            this.txtNuevaDescripcion.Name = "txtNuevaDescripcion";
            this.txtNuevaDescripcion.Size = new System.Drawing.Size(155, 44);
            this.txtNuevaDescripcion.TabIndex = 6;
            // 
            // lblDescripcionNuevoVuelo
            // 
            this.lblDescripcionNuevoVuelo.AutoSize = true;
            this.lblDescripcionNuevoVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionNuevoVuelo.Location = new System.Drawing.Point(43, 150);
            this.lblDescripcionNuevoVuelo.Name = "lblDescripcionNuevoVuelo";
            this.lblDescripcionNuevoVuelo.Size = new System.Drawing.Size(86, 17);
            this.lblDescripcionNuevoVuelo.TabIndex = 5;
            this.lblDescripcionNuevoVuelo.Text = "Descripcion:";
            // 
            // txtCMVuelo
            // 
            this.txtCMVuelo.Location = new System.Drawing.Point(239, 265);
            this.txtCMVuelo.MaxLength = 2;
            this.txtCMVuelo.Name = "txtCMVuelo";
            this.txtCMVuelo.Size = new System.Drawing.Size(70, 20);
            this.txtCMVuelo.TabIndex = 10;
            // 
            // lblCMNuevoVuelo
            // 
            this.lblCMNuevoVuelo.AutoSize = true;
            this.lblCMNuevoVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMNuevoVuelo.Location = new System.Drawing.Point(43, 266);
            this.lblCMNuevoVuelo.Name = "lblCMNuevoVuelo";
            this.lblCMNuevoVuelo.Size = new System.Drawing.Size(162, 17);
            this.lblCMNuevoVuelo.TabIndex = 9;
            this.lblCMNuevoVuelo.Text = "Cantidad Mangas Vuelo:";
            // 
            // txtCPEmbarque
            // 
            this.txtCPEmbarque.Location = new System.Drawing.Point(239, 221);
            this.txtCPEmbarque.MaxLength = 2;
            this.txtCPEmbarque.Name = "txtCPEmbarque";
            this.txtCPEmbarque.Size = new System.Drawing.Size(70, 20);
            this.txtCPEmbarque.TabIndex = 8;
            // 
            // lblCPNuevoEmbarque
            // 
            this.lblCPNuevoEmbarque.AutoSize = true;
            this.lblCPNuevoEmbarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPNuevoEmbarque.Location = new System.Drawing.Point(43, 222);
            this.lblCPNuevoEmbarque.Name = "lblCPNuevoEmbarque";
            this.lblCPNuevoEmbarque.Size = new System.Drawing.Size(190, 17);
            this.lblCPNuevoEmbarque.TabIndex = 7;
            this.lblCPNuevoEmbarque.Text = "Cantidad Puertas Embarque:";
            // 
            // dgvDatosAeropuerto
            // 
            this.dgvDatosAeropuerto.AllowUserToAddRows = false;
            this.dgvDatosAeropuerto.AllowUserToDeleteRows = false;
            this.dgvDatosAeropuerto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosAeropuerto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAeropuerto,
            this.Domicilio,
            this.Telefono,
            this.Descripcion,
            this.CantPuertasEmbarque,
            this.CantMangasVuelo});
            this.dgvDatosAeropuerto.Location = new System.Drawing.Point(353, 51);
            this.dgvDatosAeropuerto.Name = "dgvDatosAeropuerto";
            this.dgvDatosAeropuerto.ReadOnly = true;
            this.dgvDatosAeropuerto.Size = new System.Drawing.Size(340, 234);
            this.dgvDatosAeropuerto.TabIndex = 11;
            // 
            // IdAeropuerto
            // 
            this.IdAeropuerto.DataPropertyName = "IdAeropuerto";
            this.IdAeropuerto.HeaderText = "Id";
            this.IdAeropuerto.Name = "IdAeropuerto";
            this.IdAeropuerto.ReadOnly = true;
            this.IdAeropuerto.Width = 30;
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
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(239, 313);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 33);
            this.btnCargar.TabIndex = 12;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(46, 313);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 33);
            this.btnAtras.TabIndex = 13;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // formAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 357);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dgvDatosAeropuerto);
            this.Controls.Add(this.txtCMVuelo);
            this.Controls.Add(this.lblCMNuevoVuelo);
            this.Controls.Add(this.txtCPEmbarque);
            this.Controls.Add(this.lblCPNuevoEmbarque);
            this.Controls.Add(this.txtNuevaDescripcion);
            this.Controls.Add(this.lblDescripcionNuevoVuelo);
            this.Controls.Add(this.txtNuevoTelefono);
            this.Controls.Add(this.lblNuevoTelefono);
            this.Controls.Add(this.txtNuevoDomicilio);
            this.Controls.Add(this.lblDomicilioNuevoAeropuerto);
            this.Controls.Add(this.lblDatosNuevoAeropuerto);
            this.Name = "formAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Aeropuerto";
            this.Load += new System.EventHandler(this.formAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAeropuerto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatosNuevoAeropuerto;
        private System.Windows.Forms.Label lblDomicilioNuevoAeropuerto;
        private System.Windows.Forms.TextBox txtNuevoDomicilio;
        private System.Windows.Forms.TextBox txtNuevoTelefono;
        private System.Windows.Forms.Label lblNuevoTelefono;
        private System.Windows.Forms.TextBox txtNuevaDescripcion;
        private System.Windows.Forms.Label lblDescripcionNuevoVuelo;
        private System.Windows.Forms.TextBox txtCMVuelo;
        private System.Windows.Forms.Label lblCMNuevoVuelo;
        private System.Windows.Forms.TextBox txtCPEmbarque;
        private System.Windows.Forms.Label lblCPNuevoEmbarque;
        private System.Windows.Forms.DataGridView dgvDatosAeropuerto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAeropuerto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantPuertasEmbarque;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantMangasVuelo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnAtras;
    }
}