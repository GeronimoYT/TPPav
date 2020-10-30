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
            CargarReporte();
        }

        private void CargarReporte()
        {
            this.rvAeropuerto.RefreshReport();
            var aeropuerto = new AeropuertoTableAdapter();
            var datos = new AeropuertoDataTable();

            aeropuerto.Fill(datos);
            var ds = new ReportDataSource("Listado de Aeropuertos: ", (DataTable)datos);
            rvAeropuerto.LocalReport.DataSources.Clear();
            rvAeropuerto.LocalReport.DataSources.Add(ds);
            rvAeropuerto.LocalReport.Refresh();
        }
    }
}
