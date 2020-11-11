namespace Principal.Ventanas.TiposAvion
{
    partial class FormTipos
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
            this.lboxTipos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtClase1 = new System.Windows.Forms.TextBox();
            this.txtClaseTurista = new System.Windows.Forms.TextBox();
            this.txtEquipaje = new System.Windows.Forms.TextBox();
            this.txtSalidas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAlcance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboxTipos
            // 
            this.lboxTipos.FormattingEnabled = true;
            this.lboxTipos.Location = new System.Drawing.Point(17, 40);
            this.lboxTipos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lboxTipos.Name = "lboxTipos";
            this.lboxTipos.Size = new System.Drawing.Size(184, 290);
            this.lboxTipos.TabIndex = 1;
            this.lboxTipos.SelectedIndexChanged += new System.EventHandler(this.lboxTipos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(50, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipos de Aviones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Asientos 1ra Clase";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Asientos Clase Turista";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(309, 95);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(198, 20);
            this.txtDescripcion.TabIndex = 6;
            // 
            // txtClase1
            // 
            this.txtClase1.Location = new System.Drawing.Point(368, 190);
            this.txtClase1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClase1.Name = "txtClase1";
            this.txtClase1.ReadOnly = true;
            this.txtClase1.Size = new System.Drawing.Size(138, 20);
            this.txtClase1.TabIndex = 7;
            // 
            // txtClaseTurista
            // 
            this.txtClaseTurista.Location = new System.Drawing.Point(368, 223);
            this.txtClaseTurista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClaseTurista.Name = "txtClaseTurista";
            this.txtClaseTurista.ReadOnly = true;
            this.txtClaseTurista.Size = new System.Drawing.Size(138, 20);
            this.txtClaseTurista.TabIndex = 8;
            // 
            // txtEquipaje
            // 
            this.txtEquipaje.Location = new System.Drawing.Point(368, 258);
            this.txtEquipaje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEquipaje.Name = "txtEquipaje";
            this.txtEquipaje.ReadOnly = true;
            this.txtEquipaje.Size = new System.Drawing.Size(109, 20);
            this.txtEquipaje.TabIndex = 9;
            // 
            // txtSalidas
            // 
            this.txtSalidas.Location = new System.Drawing.Point(368, 291);
            this.txtSalidas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSalidas.Name = "txtSalidas";
            this.txtSalidas.ReadOnly = true;
            this.txtSalidas.Size = new System.Drawing.Size(138, 20);
            this.txtSalidas.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Capacidad Equipaje";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 293);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Salidas de Emergencia";
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(309, 128);
            this.txtLongitud.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.ReadOnly = true;
            this.txtLongitud.Size = new System.Drawing.Size(168, 20);
            this.txtLongitud.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Longitud";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 161);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Alcance";
            // 
            // txtAlcance
            // 
            this.txtAlcance.Location = new System.Drawing.Point(309, 158);
            this.txtAlcance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAlcance.Name = "txtAlcance";
            this.txtAlcance.ReadOnly = true;
            this.txtAlcance.Size = new System.Drawing.Size(168, 20);
            this.txtAlcance.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(350, 19);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Detalle";
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(17, 337);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(62, 19);
            this.btnAlta.TabIndex = 18;
            this.btnAlta.Text = "Nuevo";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnModificacion
            // 
            this.btnModificacion.Location = new System.Drawing.Point(78, 337);
            this.btnModificacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(62, 19);
            this.btnModificacion.TabIndex = 19;
            this.btnModificacion.Text = "Modificar";
            this.btnModificacion.UseVisualStyleBackColor = true;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(139, 337);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(62, 19);
            this.btnBaja.TabIndex = 20;
            this.btnBaja.Text = "Eliminar";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(481, 130);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Mts";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(481, 161);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Km";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(481, 262);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Kg";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(423, 332);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(82, 26);
            this.btnCerrar.TabIndex = 25;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormTipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 366);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModificacion);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAlcance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSalidas);
            this.Controls.Add(this.txtEquipaje);
            this.Controls.Add(this.txtClaseTurista);
            this.Controls.Add(this.txtClase1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboxTipos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos";
            this.VisibleChanged += new System.EventHandler(this.FormTipos_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxTipos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtClase1;
        private System.Windows.Forms.TextBox txtClaseTurista;
        private System.Windows.Forms.TextBox txtEquipaje;
        private System.Windows.Forms.TextBox txtSalidas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAlcance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCerrar;
    }
}