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
using Principal.Utils;

namespace Principal.Ventanas.Aviones
{
    public partial class Modificacion_Avion : Form
    {
        private Form _formAviones;
        private Avion avion;
        private AvionesRepositorio _avionesRep;
        private FormUtils _formUtils;
        private TiposAvionRepositorio _repTipo;

        public Modificacion_Avion(FormAviones formAviones, Avion avionModificar)
        {
            _formAviones = formAviones;
            _formUtils = new FormUtils();
            _avionesRep = new AvionesRepositorio();
            _repTipo = new TiposAvionRepositorio();
            avion = avionModificar;
            InitializeComponent();
        }

        private void Modificacion_Avion_Load(object sender, EventArgs e)
        {
            txtNumero.Text = avion.numero.ToString();
            txtNuevoNumero.Text = avion.numero.ToString();
            txtCategoria.Text = avion.idTipo.ToString();
            rTxtDescripcion.Text = avion.descripcion;
        
            List<TipoAvion> tipos = _repTipo.ObtenerTipos();
            var conectorDeDatos = new BindingSource();
            conectorDeDatos.DataSource = tipos;
            //_formUtils.CargarCombo(ref comboCategorias, conectorDeDatos, "descripcion", "id");
        }

        private void CerrarFormuario()
        {
            _formAviones.Show();
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            CerrarFormuario();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            TipoAvion tipoSeleccionado = (TipoAvion)comboCategorias.SelectedItem;
            avion.idTipo = tipoSeleccionado.id;
            avion.descripcion = rTxtNuevaDescripcion.Text;

            _avionesRep.ModificacionAvion(avion);
            CerrarFormuario();
        }
    }
}