namespace Principal.Ventanas
{
    partial class EmbarquePorNroVuelo
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
            this.rvEmNroVuelo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvEmNroVuelo
            // 
            this.rvEmNroVuelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvEmNroVuelo.LocalReport.ReportEmbeddedResource = "Principal.Informes y Reportes.EmbarquePorFecha.rdlc";
            this.rvEmNroVuelo.Location = new System.Drawing.Point(0, 0);
            this.rvEmNroVuelo.Name = "rvEmNroVuelo";
            this.rvEmNroVuelo.ServerReport.BearerToken = null;
            this.rvEmNroVuelo.Size = new System.Drawing.Size(474, 388);
            this.rvEmNroVuelo.TabIndex = 0;
            this.rvEmNroVuelo.Load += new System.EventHandler(this.rvEmNroVuelo_Load);
            // 
            // EmbarquePorNroVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 388);
            this.Controls.Add(this.rvEmNroVuelo);
            this.Name = "EmbarquePorNroVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Embarque por Nro Vuelo";
            this.Load += new System.EventHandler(this.EmbarquePorFecha_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvEmNroVuelo;
    }
}