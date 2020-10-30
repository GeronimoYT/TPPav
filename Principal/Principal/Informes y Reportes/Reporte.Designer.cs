namespace Principal.Informes_y_Reportes
{
    partial class formReporte
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
            this.rvAeropuerto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvAeropuerto
            // 
            this.rvAeropuerto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvAeropuerto.Location = new System.Drawing.Point(0, 0);
            this.rvAeropuerto.Name = "rvAeropuerto";
            this.rvAeropuerto.ServerReport.BearerToken = null;
            this.rvAeropuerto.Size = new System.Drawing.Size(469, 394);
            this.rvAeropuerto.TabIndex = 0;
            // 
            // formReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 394);
            this.Controls.Add(this.rvAeropuerto);
            this.Name = "formReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.formReporte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvAeropuerto;
    }
}