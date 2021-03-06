﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using Principal.Clases;



namespace Principal.Ventanas.Aviones
{
    public partial class Baja_Avion : Form
    {
        private FormAviones _formAviones;
        private Avion avion;
        private AvionesRepositorio _avionesRep;
        public Baja_Avion(FormAviones formAviones, Avion avionBaja)
        {
            _formAviones = formAviones;
            _avionesRep = new AvionesRepositorio();
            avion = avionBaja;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("Está seguro que desea realizar esta operacion?", "Confirmar Operacion", buttons);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                if (radioActivo.Checked) { avion.estado = true; }
                else { avion.estado = false; }
                _avionesRep.BajaAvion(avion);
            }
            CerrarFormuario();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Baja_Avion_Load(object sender, EventArgs e)
        {
            txtNumero.Text = avion.numero.ToString();
            txtCategoria.Text = _formAviones.NumeroACategoria(avion.idTipo);
            txtDescripcion.Text = avion.descripcion;
            if (avion.estado) { radioActivo.Checked = true; }
            else { radioInactivo.Checked = true; }
        }

        private void CerrarFormuario()
        {
            _formAviones.RefrescarFormulario();
            _formAviones.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CerrarFormuario();
        }
    }
}
