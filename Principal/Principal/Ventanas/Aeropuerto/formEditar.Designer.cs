﻿namespace Principal.Ventanas
{
    partial class formEditar
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
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dgvDatosAeropuerto = new System.Windows.Forms.DataGridView();
            this.IdAeropuerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantPuertasEmbarque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantMangasVuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCMNuevoVuelo = new System.Windows.Forms.Label();
            this.lblCPNuevoEmbarque = new System.Windows.Forms.Label();
            this.txtNuevaDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcionNuevoVuelo = new System.Windows.Forms.Label();
            this.lblNuevoTelefono = new System.Windows.Forms.Label();
            this.txtNuevoDomicilio = new System.Windows.Forms.TextBox();
            this.lblDomicilioNuevoAeropuerto = new System.Windows.Forms.Label();
            this.lblDatosNuevoAeropuerto = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNuevoTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtCMVuelo = new System.Windows.Forms.MaskedTextBox();
            this.txtCPEmbarque = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAeropuerto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(41, 438);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 33);
            this.btnAtras.TabIndex = 27;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(234, 438);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 33);
            this.btnCargar.TabIndex = 26;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
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
            this.dgvDatosAeropuerto.Location = new System.Drawing.Point(353, 48);
            this.dgvDatosAeropuerto.Name = "dgvDatosAeropuerto";
            this.dgvDatosAeropuerto.ReadOnly = true;
            this.dgvDatosAeropuerto.Size = new System.Drawing.Size(340, 350);
            this.dgvDatosAeropuerto.TabIndex = 25;
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
            // lblCMNuevoVuelo
            // 
            this.lblCMNuevoVuelo.AutoSize = true;
            this.lblCMNuevoVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMNuevoVuelo.Location = new System.Drawing.Point(43, 381);
            this.lblCMNuevoVuelo.Name = "lblCMNuevoVuelo";
            this.lblCMNuevoVuelo.Size = new System.Drawing.Size(162, 17);
            this.lblCMNuevoVuelo.TabIndex = 23;
            this.lblCMNuevoVuelo.Text = "Cantidad Mangas Vuelo:";
            // 
            // lblCPNuevoEmbarque
            // 
            this.lblCPNuevoEmbarque.AutoSize = true;
            this.lblCPNuevoEmbarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPNuevoEmbarque.Location = new System.Drawing.Point(43, 337);
            this.lblCPNuevoEmbarque.Name = "lblCPNuevoEmbarque";
            this.lblCPNuevoEmbarque.Size = new System.Drawing.Size(190, 17);
            this.lblCPNuevoEmbarque.TabIndex = 21;
            this.lblCPNuevoEmbarque.Text = "Cantidad Puertas Embarque:";
            // 
            // txtNuevaDescripcion
            // 
            this.txtNuevaDescripcion.Location = new System.Drawing.Point(154, 265);
            this.txtNuevaDescripcion.MaxLength = 30;
            this.txtNuevaDescripcion.Multiline = true;
            this.txtNuevaDescripcion.Name = "txtNuevaDescripcion";
            this.txtNuevaDescripcion.Size = new System.Drawing.Size(155, 44);
            this.txtNuevaDescripcion.TabIndex = 20;
            // 
            // lblDescripcionNuevoVuelo
            // 
            this.lblDescripcionNuevoVuelo.AutoSize = true;
            this.lblDescripcionNuevoVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionNuevoVuelo.Location = new System.Drawing.Point(43, 265);
            this.lblDescripcionNuevoVuelo.Name = "lblDescripcionNuevoVuelo";
            this.lblDescripcionNuevoVuelo.Size = new System.Drawing.Size(86, 17);
            this.lblDescripcionNuevoVuelo.TabIndex = 19;
            this.lblDescripcionNuevoVuelo.Text = "Descripcion:";
            // 
            // lblNuevoTelefono
            // 
            this.lblNuevoTelefono.AutoSize = true;
            this.lblNuevoTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoTelefono.Location = new System.Drawing.Point(43, 217);
            this.lblNuevoTelefono.Name = "lblNuevoTelefono";
            this.lblNuevoTelefono.Size = new System.Drawing.Size(68, 17);
            this.lblNuevoTelefono.TabIndex = 17;
            this.lblNuevoTelefono.Text = "Telefono:";
            // 
            // txtNuevoDomicilio
            // 
            this.txtNuevoDomicilio.Location = new System.Drawing.Point(154, 166);
            this.txtNuevoDomicilio.MaxLength = 20;
            this.txtNuevoDomicilio.Name = "txtNuevoDomicilio";
            this.txtNuevoDomicilio.Size = new System.Drawing.Size(155, 20);
            this.txtNuevoDomicilio.TabIndex = 16;
            this.txtNuevoDomicilio.TextChanged += new System.EventHandler(this.txtNuevoDomicilio_TextChanged);
            // 
            // lblDomicilioNuevoAeropuerto
            // 
            this.lblDomicilioNuevoAeropuerto.AutoSize = true;
            this.lblDomicilioNuevoAeropuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilioNuevoAeropuerto.Location = new System.Drawing.Point(43, 167);
            this.lblDomicilioNuevoAeropuerto.Name = "lblDomicilioNuevoAeropuerto";
            this.lblDomicilioNuevoAeropuerto.Size = new System.Drawing.Size(68, 17);
            this.lblDomicilioNuevoAeropuerto.TabIndex = 15;
            this.lblDomicilioNuevoAeropuerto.Text = "Domicilio:";
            // 
            // lblDatosNuevoAeropuerto
            // 
            this.lblDatosNuevoAeropuerto.AutoSize = true;
            this.lblDatosNuevoAeropuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosNuevoAeropuerto.Location = new System.Drawing.Point(12, 9);
            this.lblDatosNuevoAeropuerto.Name = "lblDatosNuevoAeropuerto";
            this.lblDatosNuevoAeropuerto.Size = new System.Drawing.Size(157, 20);
            this.lblDatosNuevoAeropuerto.TabIndex = 14;
            this.lblDatosNuevoAeropuerto.Text = "Datos Aeropuerto:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(154, 48);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(79, 20);
            this.txtID.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID:";
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(154, 106);
            this.txtNuevoNombre.MaxLength = 20;
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(155, 20);
            this.txtNuevoNombre.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nombre:";
            // 
            // txtNuevoTelefono
            // 
            this.txtNuevoTelefono.Location = new System.Drawing.Point(154, 214);
            this.txtNuevoTelefono.Mask = "000-000-0000";
            this.txtNuevoTelefono.Name = "txtNuevoTelefono";
            this.txtNuevoTelefono.Size = new System.Drawing.Size(79, 20);
            this.txtNuevoTelefono.TabIndex = 35;
            // 
            // txtCMVuelo
            // 
            this.txtCMVuelo.Location = new System.Drawing.Point(258, 378);
            this.txtCMVuelo.Mask = "99";
            this.txtCMVuelo.Name = "txtCMVuelo";
            this.txtCMVuelo.Size = new System.Drawing.Size(27, 20);
            this.txtCMVuelo.TabIndex = 38;
            // 
            // txtCPEmbarque
            // 
            this.txtCPEmbarque.Location = new System.Drawing.Point(258, 334);
            this.txtCPEmbarque.Mask = "99";
            this.txtCPEmbarque.Name = "txtCPEmbarque";
            this.txtCPEmbarque.Size = new System.Drawing.Size(27, 20);
            this.txtCPEmbarque.TabIndex = 37;
            this.txtCPEmbarque.ValidatingType = typeof(int);
            // 
            // formEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 498);
            this.Controls.Add(this.txtCMVuelo);
            this.Controls.Add(this.txtCPEmbarque);
            this.Controls.Add(this.txtNuevoTelefono);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dgvDatosAeropuerto);
            this.Controls.Add(this.lblCMNuevoVuelo);
            this.Controls.Add(this.lblCPNuevoEmbarque);
            this.Controls.Add(this.txtNuevaDescripcion);
            this.Controls.Add(this.lblDescripcionNuevoVuelo);
            this.Controls.Add(this.lblNuevoTelefono);
            this.Controls.Add(this.txtNuevoDomicilio);
            this.Controls.Add(this.lblDomicilioNuevoAeropuerto);
            this.Controls.Add(this.lblDatosNuevoAeropuerto);
            this.Name = "formEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Aeropuerto";
            this.Load += new System.EventHandler(this.formEditar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAeropuerto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView dgvDatosAeropuerto;
        private System.Windows.Forms.Label lblCMNuevoVuelo;
        private System.Windows.Forms.Label lblCPNuevoEmbarque;
        private System.Windows.Forms.TextBox txtNuevaDescripcion;
        private System.Windows.Forms.Label lblDescripcionNuevoVuelo;
        private System.Windows.Forms.Label lblNuevoTelefono;
        private System.Windows.Forms.TextBox txtNuevoDomicilio;
        private System.Windows.Forms.Label lblDomicilioNuevoAeropuerto;
        private System.Windows.Forms.Label lblDatosNuevoAeropuerto;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAeropuerto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantPuertasEmbarque;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantMangasVuelo;
        private System.Windows.Forms.MaskedTextBox txtNuevoTelefono;
        private System.Windows.Forms.MaskedTextBox txtCMVuelo;
        private System.Windows.Forms.MaskedTextBox txtCPEmbarque;
    }
}