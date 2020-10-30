﻿using Principal.Clases;
using System;
using System.Windows.Forms;
using Principal.Ventanas.TiposAvion;
using Principal.Transacciones;

namespace Principal.Ventanas
{
    public partial class formPrincipal : Form
    {
        public formPrincipal(Usuario user)
        {
            InitializeComponent();
            lblNombreUsuario.Text = "Bienvenido " + user.NombreDeUsuario;
            lblNombreUsuario.Visible = true;
        }


        private void aeropuertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAeropuerto ventanaAeropuerto = new formAeropuerto();
            ventanaAeropuerto.Show();
        }

        private void vueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vuelo ventanaVuelo = new Vuelo();
            ventanaVuelo.Show();
        }

        private void pasajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formularioPasajes = new formPasajes(this);
            formularioPasajes.Show();
            //this.Hide();
        }

        private void formPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void pasajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formularioPasajeros = new formPasajeros(this);
            formularioPasajeros.Show();
            //this.Hide();
        }

        private void avionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAviones ventanaAeropuerto = new FormAviones();
            ventanaAeropuerto.Show();
        }

        private void tipoAvionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTipos ventanaTipoAvion = new FormTipos(this);
            ventanaTipoAvion.Show();
        }

        private void btnEquipaje_Click(object sender, EventArgs e)
        {
            formEquipajes ventanaEquipajes = new formEquipajes(this);
            ventanaEquipajes.Show();
        }
    }
}
