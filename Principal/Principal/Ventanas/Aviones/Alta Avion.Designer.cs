namespace Principal.Ventanas.Aviones
{
    partial class Alta_Avion
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.comboCategorias = new System.Windows.Forms.ComboBox();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.rTxtBoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(348, 133);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 49);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(348, 201);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 24);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // comboCategorias
            // 
            this.comboCategorias.FormattingEnabled = true;
            this.comboCategorias.Location = new System.Drawing.Point(85, 86);
            this.comboCategorias.Name = "comboCategorias";
            this.comboCategorias.Size = new System.Drawing.Size(222, 24);
            this.comboCategorias.TabIndex = 2;
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(85, 39);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(222, 22);
            this.txtBoxId.TabIndex = 3;
            this.txtBoxId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rTxtBoxDescripcion
            // 
            this.rTxtBoxDescripcion.Location = new System.Drawing.Point(12, 133);
            this.rTxtBoxDescripcion.Name = "rTxtBoxDescripcion";
            this.rTxtBoxDescripcion.Size = new System.Drawing.Size(295, 92);
            this.rTxtBoxDescripcion.TabIndex = 4;
            this.rTxtBoxDescripcion.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Categoria";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Alta_Avion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 237);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rTxtBoxDescripcion);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.comboCategorias);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "Alta_Avion";
            this.Text = "Alta_Avion";
            this.Load += new System.EventHandler(this.Alta_Avion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox comboCategorias;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.RichTextBox rTxtBoxDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}