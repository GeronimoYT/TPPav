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
            this.cmbAeropuerto = new System.Windows.Forms.ComboBox();
            this.lblAeropuerto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbAeropuerto
            // 
            this.cmbAeropuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAeropuerto.FormattingEnabled = true;
            this.cmbAeropuerto.Location = new System.Drawing.Point(194, 68);
            this.cmbAeropuerto.Name = "cmbAeropuerto";
            this.cmbAeropuerto.Size = new System.Drawing.Size(180, 24);
            this.cmbAeropuerto.TabIndex = 0;
            this.cmbAeropuerto.SelectedIndexChanged += new System.EventHandler(this.cmbAeropuerto_SelectedIndexChanged);
            // 
            // lblAeropuerto
            // 
            this.lblAeropuerto.AutoSize = true;
            this.lblAeropuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAeropuerto.Location = new System.Drawing.Point(60, 71);
            this.lblAeropuerto.Name = "lblAeropuerto";
            this.lblAeropuerto.Size = new System.Drawing.Size(101, 20);
            this.lblAeropuerto.TabIndex = 1;
            this.lblAeropuerto.Text = "Aeropuertos:";
            // 
            // formAeropuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 303);
            this.Controls.Add(this.lblAeropuerto);
            this.Controls.Add(this.cmbAeropuerto);
            this.Name = "formAeropuerto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aeropuerto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAeropuerto;
        private System.Windows.Forms.Label lblAeropuerto;
    }
}