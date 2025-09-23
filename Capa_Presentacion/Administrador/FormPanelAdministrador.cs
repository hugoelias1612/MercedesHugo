﻿using ArimaERP.EmpleadoClientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArimaERP.Administrador
{
    public partial class FormPanelAdministrador : Form
    {
        public FormPanelAdministrador()
        {
            InitializeComponent();
        }

        private void FormPanelAdministrador_Load(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy - hh:mm tt", new System.Globalization.CultureInfo("es-ES"));
            lblFECHA.Text = fecha;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //volver al login
            this.Close();
          

        }

        private void gbxAdmin_Enter(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //abrir formulario clientes
            MDIClientes mDIClientes = new MDIClientes();
            mDIClientes.StartPosition = FormStartPosition.CenterScreen;
            FormClosedEventHandler value1 = (s, args) => this.Show();
            FormClosedEventHandler value = value1;
            mDIClientes.FormClosed += value;
            mDIClientes.Show();
            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            //abrir formulario productos
            EmpleadoProducto.MDIProductos mDIProductos = new EmpleadoProducto.MDIProductos();
            mDIProductos.StartPosition = FormStartPosition.CenterScreen;
            FormClosedEventHandler value1 = (s, args) => this.Show();
            FormClosedEventHandler value = value1;
            mDIProductos.FormClosed += value;
            mDIProductos.Show();
            this.Hide();
        }

        private void btnPreventista_Click(object sender, EventArgs e)
        {
            //abrir formulario preventista
            Preventista.MDIPreventista mDIPreventista = new Preventista.MDIPreventista();
            mDIPreventista.StartPosition = FormStartPosition.CenterScreen;
            FormClosedEventHandler value1 = (s, args) => this.Show();
            FormClosedEventHandler value = value1;
            mDIPreventista.FormClosed += value;
            mDIPreventista.Show();
            this.Hide();

        }

        private void Accion2_Click(object sender, EventArgs e)
        {
            //abrir formulario agregar rol
            FormAgregarRol formAgregarRol = new FormAgregarRol();
            formAgregarRol.StartPosition = FormStartPosition.CenterScreen;
            FormClosedEventHandler value1 = (s, args) => this.Show();
            FormClosedEventHandler value = value1;
            formAgregarRol.FormClosed += value;
            formAgregarRol.Show();
            this.Hide();
        }

        private void Accion1_Click(object sender, EventArgs e)
        {
            //abrir formulario registrar usuario
            FormRegistrarUsuario formRegistrarUsuario = new FormRegistrarUsuario();
            formRegistrarUsuario.StartPosition = FormStartPosition.CenterScreen;
            FormClosedEventHandler value1 = (s, args) => this.Show();
            FormClosedEventHandler value = value1;
            formRegistrarUsuario.FormClosed += value;
            formRegistrarUsuario.Show();
            this.Hide();

        }

        private void Accion3_Click(object sender, EventArgs e)
        {
            //abrir formulario FormReportes
            FormReportes formReportes = new FormReportes();
            formReportes.StartPosition = FormStartPosition.CenterScreen;
            FormClosedEventHandler value1 = (s, args) => this.Show();
            FormClosedEventHandler value = value1;
            formReportes.FormClosed += value;
            formReportes.Show();
            this.Hide();
        }
    }
}