using Microsoft.Reporting.WinForms;
using Principal._PAV_3K2_10_AEROLINEADataSetTableAdapters;
using Principal.Clases;
using Principal.Informes_y_Reportes.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Principal.Informes_y_Reportes.DataSet1;
using AeropuertoTableAdapter = Principal.Informes_y_Reportes.DataSet1TableAdapters.AeropuertoTableAdapter;

namespace Principal.Informes_y_Reportes
{
    public partial class formReporte : Form
    {
        public formReporte()
        {
            InitializeComponent();
        }

        private void formReporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Aeropuerto' Puede moverla o quitarla según sea necesario.
            this.AeropuertoTableAdapter.Fill(this.DataSet1.Aeropuerto);
            CargarReporte();
        }

        private void CargarReporte()
        {
            this.rvAeropuerto.RefreshReport();
            var adapter = new AeropuertoTableAdapter();
            var datos = new AeropuertoDataTable();

            adapter.Fill(datos);
            var ds = new ReportDataSource("DatosAeropuertos", (DataTable)datos);
            rvAeropuerto.LocalReport.DataSources.Clear();
            rvAeropuerto.LocalReport.DataSources.Add(ds);
            this.rvAeropuerto.LocalReport.Refresh();
        }
    }
}
