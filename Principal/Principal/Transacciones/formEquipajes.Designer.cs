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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEquipajes));
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
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chboxBusqueda = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuqueda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboxEquipaje
            // 
            this.lboxEquipaje.FormattingEnabled = true;
            this.lboxEquipaje.ItemHeight = 16;
            this.lboxEquipaje.Location = new System.Drawing.Point(12, 109);
            this.lboxEquipaje.Name = "lboxEquipaje";
            this.lboxEquipaje.Size = new System.Drawing.Size(181, 324);
            this.lboxEquipaje.TabIndex = 0;
            this.lboxEquipaje.SelectedIndexChanged += new System.EventHandler(this.lboxEquipaje_SelectedIndexChanged);
            // 
            // comboBusqueda
            // 
            this.comboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBusqueda.FormattingEnabled = true;
            this.comboBusqueda.Items.AddRange(new object[] {
            "DNI",
            "Pasaporte"});
            this.comboBusqueda.Location = new System.Drawing.Point(12, 52);
            this.comboBusqueda.Name = "comboBusqueda";
            this.comboBusqueda.Size = new System.Drawing.Size(96, 24);
            this.comboBusqueda.TabIndex = 1;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(114, 54);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(127, 22);
            this.txtBusqueda.TabIndex = 21;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(450, 219);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(175, 22);
            this.txtNumero.TabIndex = 3;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(450, 262);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(175, 22);
            this.txtCategoria.TabIndex = 4;
            // 
            // txtTipoDocumento
            // 
            this.txtTipoDocumento.Location = new System.Drawing.Point(450, 139);
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
            this.label2.Location = new System.Drawing.Point(317, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Datos Pasajero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Numero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Peso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Documento";
            // 
            // btnBaja
            // 
            this.btnBaja.Image = ((System.Drawing.Image)(resources.GetObject("btnBaja.Image")));
            this.btnBaja.Location = new System.Drawing.Point(199, 393);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(42, 40);
            this.btnBaja.TabIndex = 15;
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.FlatAppearance.BorderSize = 0;
            this.btnAlta.Image = ((System.Drawing.Image)(resources.GetObject("btnAlta.Image")));
            this.btnAlta.Location = new System.Drawing.Point(201, 347);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(40, 40);
            this.btnAlta.TabIndex = 16;
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(450, 307);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(175, 61);
            this.txtDescripcion.TabIndex = 18;
            this.txtDescripcion.Text = "";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(516, 402);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(109, 30);
            this.btnAtras.TabIndex = 19;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(535, 139);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.ReadOnly = true;
            this.txtNroDocumento.Size = new System.Drawing.Size(90, 22);
            this.txtNroDocumento.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Datos Equipaje";
            // 
            // chboxBusqueda
            // 
            this.chboxBusqueda.AutoSize = true;
            this.chboxBusqueda.Location = new System.Drawing.Point(12, 82);
            this.chboxBusqueda.Name = "chboxBusqueda";
            this.chboxBusqueda.Size = new System.Drawing.Size(204, 21);
            this.chboxBusqueda.TabIndex = 23;
            this.chboxBusqueda.Text = "Incluir pasajeros eliminados";
            this.chboxBusqueda.UseVisualStyleBackColor = true;
            this.chboxBusqueda.CheckedChanged += new System.EventHandler(this.chboxBusqueda_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(315, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(262, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Datos equipaje seleccionado";
            // 
            // btnBuqueda
            // 
            this.btnBuqueda.Image = ((System.Drawing.Image)(resources.GetObject("btnBuqueda.Image")));
            this.btnBuqueda.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBuqueda.Location = new System.Drawing.Point(247, 46);
            this.btnBuqueda.Name = "btnBuqueda";
            this.btnBuqueda.Size = new System.Drawing.Size(45, 43);
            this.btnBuqueda.TabIndex = 25;
            this.btnBuqueda.UseVisualStyleBackColor = true;
            this.btnBuqueda.Click += new System.EventHandler(this.btnBuqueda_Click);
            // 
            // formEquipajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 444);
            this.Controls.Add(this.btnBuqueda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chboxBusqueda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNroDocumento);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnBaja);
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
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chboxBusqueda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuqueda;
    }
}