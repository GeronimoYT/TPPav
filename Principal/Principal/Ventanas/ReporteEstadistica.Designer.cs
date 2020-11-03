namespace Principal.Ventanas
{
    partial class ReporteEstadistica
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
            this.rvGraficoAviones = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvGraficoAviones
            // 
            this.rvGraficoAviones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvGraficoAviones.LocalReport.ReportEmbeddedResource = "Principal.Informes y Reportes.EstadisticaAvion.rdlc";
            this.rvGraficoAviones.Location = new System.Drawing.Point(0, 0);
            this.rvGraficoAviones.Name = "rvGraficoAviones";
            this.rvGraficoAviones.ServerReport.BearerToken = null;
            this.rvGraficoAviones.Size = new System.Drawing.Size(617, 391);
            this.rvGraficoAviones.TabIndex = 0;
            this.rvGraficoAviones.Load += new System.EventHandler(this.rvGraficoAviones_Load);
            // 
            // ReporteEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 391);
            this.Controls.Add(this.rvGraficoAviones);
            this.Name = "ReporteEstadistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Estadistica";
            this.Load += new System.EventHandler(this.ReporteEstadistica_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvGraficoAviones;
    }
}