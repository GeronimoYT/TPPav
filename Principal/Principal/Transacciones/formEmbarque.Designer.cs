namespace Principal.Transacciones
{
    partial class formEmbarque
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
            this.lblEmbarque = new System.Windows.Forms.Label();
            this.lblNroVuelo = new System.Windows.Forms.Label();
            this.cmbNroVuelo = new System.Windows.Forms.ComboBox();
            this.lblFechaEmbarque = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPuertaEmbarque = new System.Windows.Forms.Label();
            this.cmbAeropuerto = new System.Windows.Forms.ComboBox();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.cmbNroDoc = new System.Windows.Forms.ComboBox();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptarEdicion = new System.Windows.Forms.Button();
            this.btnEditarAeropuerto = new System.Windows.Forms.Button();
            this.cmbPuertaEmbarque = new System.Windows.Forms.ComboBox();
            this.txtFechaEmbarque = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblEmbarque
            // 
            this.lblEmbarque.AutoSize = true;
            this.lblEmbarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmbarque.Location = new System.Drawing.Point(12, 9);
            this.lblEmbarque.Name = "lblEmbarque";
            this.lblEmbarque.Size = new System.Drawing.Size(91, 20);
            this.lblEmbarque.TabIndex = 0;
            this.lblEmbarque.Text = "Embarque";
            // 
            // lblNroVuelo
            // 
            this.lblNroVuelo.AutoSize = true;
            this.lblNroVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroVuelo.Location = new System.Drawing.Point(27, 47);
            this.lblNroVuelo.Name = "lblNroVuelo";
            this.lblNroVuelo.Size = new System.Drawing.Size(127, 17);
            this.lblNroVuelo.TabIndex = 1;
            this.lblNroVuelo.Text = "*Número de Vuelo:";
            // 
            // cmbNroVuelo
            // 
            this.cmbNroVuelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNroVuelo.FormattingEnabled = true;
            this.cmbNroVuelo.Location = new System.Drawing.Point(205, 46);
            this.cmbNroVuelo.Name = "cmbNroVuelo";
            this.cmbNroVuelo.Size = new System.Drawing.Size(70, 21);
            this.cmbNroVuelo.TabIndex = 64;
            this.cmbNroVuelo.SelectedIndexChanged += new System.EventHandler(this.cmbNroVuelo_SelectedIndexChanged);
            // 
            // lblFechaEmbarque
            // 
            this.lblFechaEmbarque.AutoSize = true;
            this.lblFechaEmbarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEmbarque.Location = new System.Drawing.Point(301, 47);
            this.lblFechaEmbarque.Name = "lblFechaEmbarque";
            this.lblFechaEmbarque.Size = new System.Drawing.Size(186, 17);
            this.lblFechaEmbarque.TabIndex = 67;
            this.lblFechaEmbarque.Text = "Fecha y Hora de Embarque:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "Aeropuerto de Embarque:";
            // 
            // lblPuertaEmbarque
            // 
            this.lblPuertaEmbarque.AutoSize = true;
            this.lblPuertaEmbarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuertaEmbarque.Location = new System.Drawing.Point(347, 144);
            this.lblPuertaEmbarque.Name = "lblPuertaEmbarque";
            this.lblPuertaEmbarque.Size = new System.Drawing.Size(143, 17);
            this.lblPuertaEmbarque.TabIndex = 71;
            this.lblPuertaEmbarque.Text = "Puerta de Embarque:";
            // 
            // cmbAeropuerto
            // 
            this.cmbAeropuerto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAeropuerto.FormattingEnabled = true;
            this.cmbAeropuerto.Location = new System.Drawing.Point(205, 144);
            this.cmbAeropuerto.Name = "cmbAeropuerto";
            this.cmbAeropuerto.Size = new System.Drawing.Size(70, 21);
            this.cmbAeropuerto.TabIndex = 73;
            this.cmbAeropuerto.SelectedIndexChanged += new System.EventHandler(this.cmbAeropuerto_SelectedIndexChanged);
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(166, 212);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(109, 21);
            this.cmbTipoDoc.TabIndex = 75;
            this.cmbTipoDoc.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDoc_SelectedIndexChanged);
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(27, 213);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(116, 17);
            this.lblTipoDoc.TabIndex = 74;
            this.lblTipoDoc.Text = "Tipo Documento:";
            // 
            // cmbNroDoc
            // 
            this.cmbNroDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNroDoc.FormattingEnabled = true;
            this.cmbNroDoc.Location = new System.Drawing.Point(191, 273);
            this.cmbNroDoc.Name = "cmbNroDoc";
            this.cmbNroDoc.Size = new System.Drawing.Size(84, 21);
            this.cmbNroDoc.TabIndex = 77;
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDoc.Location = new System.Drawing.Point(27, 274);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(158, 17);
            this.lblNroDoc.TabIndex = 76;
            this.lblNroDoc.Text = "Número de Documento:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(493, 272);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(112, 21);
            this.cmbEstado.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 78;
            this.label1.Text = "Estado:";
            // 
            // btnAceptarEdicion
            // 
            this.btnAceptarEdicion.Enabled = false;
            this.btnAceptarEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarEdicion.Location = new System.Drawing.Point(530, 345);
            this.btnAceptarEdicion.Name = "btnAceptarEdicion";
            this.btnAceptarEdicion.Size = new System.Drawing.Size(75, 28);
            this.btnAceptarEdicion.TabIndex = 83;
            this.btnAceptarEdicion.Text = "Aceptar";
            this.btnAceptarEdicion.UseVisualStyleBackColor = true;
            this.btnAceptarEdicion.Click += new System.EventHandler(this.btnAceptarEdicion_Click);
            // 
            // btnEditarAeropuerto
            // 
            this.btnEditarAeropuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAeropuerto.Location = new System.Drawing.Point(432, 345);
            this.btnEditarAeropuerto.Name = "btnEditarAeropuerto";
            this.btnEditarAeropuerto.Size = new System.Drawing.Size(75, 28);
            this.btnEditarAeropuerto.TabIndex = 82;
            this.btnEditarAeropuerto.Text = "Cancelar";
            this.btnEditarAeropuerto.UseVisualStyleBackColor = true;
            this.btnEditarAeropuerto.Click += new System.EventHandler(this.btnEditarAeropuerto_Click);
            // 
            // cmbPuertaEmbarque
            // 
            this.cmbPuertaEmbarque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuertaEmbarque.FormattingEnabled = true;
            this.cmbPuertaEmbarque.Location = new System.Drawing.Point(535, 143);
            this.cmbPuertaEmbarque.Name = "cmbPuertaEmbarque";
            this.cmbPuertaEmbarque.Size = new System.Drawing.Size(70, 21);
            this.cmbPuertaEmbarque.TabIndex = 84;
            // 
            // txtFechaEmbarque
            // 
            this.txtFechaEmbarque.Location = new System.Drawing.Point(493, 46);
            this.txtFechaEmbarque.Mask = "00/00/0000 00:00";
            this.txtFechaEmbarque.Name = "txtFechaEmbarque";
            this.txtFechaEmbarque.Size = new System.Drawing.Size(112, 20);
            this.txtFechaEmbarque.TabIndex = 85;
            this.txtFechaEmbarque.ValidatingType = typeof(System.DateTime);
            // 
            // formEmbarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 385);
            this.Controls.Add(this.txtFechaEmbarque);
            this.Controls.Add(this.cmbPuertaEmbarque);
            this.Controls.Add(this.btnAceptarEdicion);
            this.Controls.Add(this.btnEditarAeropuerto);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNroDoc);
            this.Controls.Add(this.lblNroDoc);
            this.Controls.Add(this.cmbTipoDoc);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.cmbAeropuerto);
            this.Controls.Add(this.lblPuertaEmbarque);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFechaEmbarque);
            this.Controls.Add(this.cmbNroVuelo);
            this.Controls.Add(this.lblNroVuelo);
            this.Controls.Add(this.lblEmbarque);
            this.Name = "formEmbarque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Embarque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmbarque;
        private System.Windows.Forms.Label lblNroVuelo;
        private System.Windows.Forms.ComboBox cmbNroVuelo;
        private System.Windows.Forms.Label lblFechaEmbarque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPuertaEmbarque;
        private System.Windows.Forms.ComboBox cmbAeropuerto;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.ComboBox cmbNroDoc;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptarEdicion;
        private System.Windows.Forms.Button btnEditarAeropuerto;
        private System.Windows.Forms.ComboBox cmbPuertaEmbarque;
        private System.Windows.Forms.MaskedTextBox txtFechaEmbarque;
    }
}