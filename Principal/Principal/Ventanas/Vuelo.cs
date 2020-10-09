﻿using Principal.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.Ventanas
{
    public partial class Vuelo : Form
    {
        public Vuelo()
        {
            InitializeComponent();
            CargaGrilla();
        }

        
        private void CargaGrilla()
        {
            try
            {
                string consulta = $"SELECT * FROM Vuelo";
                var grilla = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                dgvVuelos.DataSource = grilla;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("La consulta ejecutada es incorrecta, por favor revise nuevamente ");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("Está seguro que desea realizar esta operación?", "Eliminar Vuelo", buttons);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    if (dgvVuelos.CurrentRow == null)
                        return;
                    //ELSE ?
                    dgvVuelos.Rows.Remove(dgvVuelos.CurrentRow);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido realizar la operación");
                }
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            formAltaVuelo _formAltaVuelo = new formAltaVuelo();
            _formAltaVuelo.Show();
            this.Close();
        }

        private void Vuelo_Load(object sender, EventArgs e)
        {

        }
    }
}
