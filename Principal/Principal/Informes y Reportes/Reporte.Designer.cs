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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.AeropuertoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Principal.Informes_y_Reportes.DataSet1();
            this.rvAeropuerto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AeropuertoTableAdapter = new Principal.Informes_y_Reportes.DataSet1TableAdapters.AeropuertoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AeropuertoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // AeropuertoBindingSource
            // 
            this.AeropuertoBindingSource.DataMember = "Aeropuerto";
            this.AeropuertoBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvAeropuerto
            // 
            this.rvAeropuerto.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DatosAeropuertos";
            reportDataSource1.Value = this.AeropuertoBindingSource;
            this.rvAeropuerto.LocalReport.DataSources.Add(reportDataSource1);
            this.rvAeropuerto.LocalReport.ReportEmbeddedResource = "Principal.Informes y Reportes.InformeAeropuerto.rdlc";
            this.rvAeropuerto.Location = new System.Drawing.Point(0, 0);
            this.rvAeropuerto.Name = "rvAeropuerto";
            this.rvAeropuerto.ServerReport.BearerToken = null;
            this.rvAeropuerto.Size = new System.Drawing.Size(469, 394);
            this.rvAeropuerto.TabIndex = 0;
            this.rvAeropuerto.Load += new System.EventHandler(this.rvAeropuerto_Load);
            // 
            // AeropuertoTableAdapter
            // 
            this.AeropuertoTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.AeropuertoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvAeropuerto;
        private System.Windows.Forms.BindingSource AeropuertoBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.AeropuertoTableAdapter AeropuertoTableAdapter;
    }
}