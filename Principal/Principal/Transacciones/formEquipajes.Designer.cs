namespace Principal.Transacciones
{
    partial class formEquipajes
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
            this.lboxEquipaje = new System.Windows.Forms.ListBox();
            this.comboBusqueda = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtTipoDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lboxEquipaje
            // 
            this.lboxEquipaje.FormattingEnabled = true;
            this.lboxEquipaje.ItemHeight = 16;
            this.lboxEquipaje.Location = new System.Drawing.Point(12, 97);
            this.lboxEquipaje.Name = "lboxEquipaje";
            this.lboxEquipaje.Size = new System.Drawing.Size(181, 308);
            this.lboxEquipaje.TabIndex = 0;
            this.lboxEquipaje.SelectedIndexChanged += new System.EventHandler(this.lboxEquipaje_SelectedIndexChanged);
            // 
            // comboBusqueda
            // 
            this.comboBusqueda.FormattingEnabled = true;
            this.comboBusqueda.Items.AddRange(new object[] {
            "DNI",
            "Pasaporte"});
            this.comboBusqueda.Location = new System.Drawing.Point(12, 52);
            this.comboBusqueda.Name = "comboBusqueda";
            this.comboBusqueda.Size = new System.Drawing.Size(69, 24);
            this.comboBusqueda.TabIndex = 1;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(87, 54);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(142, 22);
            this.txtBusqueda.TabIndex = 21;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(381, 94);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(175, 22);
            this.txtNumero.TabIndex = 3;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(381, 137);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(175, 22);
            this.txtCategoria.TabIndex = 4;
            // 
            // txtTipoDocumento
            // 
            this.txtTipoDocumento.Location = new System.Drawing.Point(381, 181);
            this.txtTipoDocumento.Name = "txtTipoDocumento";
            this.txtTipoDocumento.ReadOnly = true;
            this.txtTipoDocumento.Size = new System.Drawing.Size(70, 22);
            this.txtTipoDocumento.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Equipajes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(376, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Numero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Documento";
            // 
            // btnModificacion
            // 
            this.btnModificacion.Location = new System.Drawing.Point(199, 329);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(30, 30);
            this.btnModificacion.TabIndex = 13;
            this.btnModificacion.Text = "M";
            this.btnModificacion.UseVisualStyleBackColor = true;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(235, 54);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(23, 22);
            this.btnBusqueda.TabIndex = 14;
            this.btnBusqueda.Text = "B";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(199, 375);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(30, 30);
            this.btnBaja.TabIndex = 15;
            this.btnBaja.Text = "-";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(199, 276);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(30, 30);
            this.btnAlta.TabIndex = 16;
            this.btnAlta.Text = "+";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(381, 228);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(175, 61);
            this.txtDescripcion.TabIndex = 18;
            this.txtDescripcion.Text = "";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(466, 375);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(90, 27);
            this.btnAtras.TabIndex = 19;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(466, 181);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.ReadOnly = true;
            this.txtNroDocumento.Size = new System.Drawing.Size(90, 22);
            this.txtNroDocumento.TabIndex = 20;
            // 
            // formEquipajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 416);
            this.Controls.Add(this.txtNroDocumento);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.btnModificacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTipoDocumento);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.comboBusqueda);
            this.Controls.Add(this.lboxEquipaje);
            this.Name = "formEquipajes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formEquipajes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxEquipaje;
        private System.Windows.Forms.ComboBox comboBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtTipoDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TextBox txtNroDocumento;
    }
}