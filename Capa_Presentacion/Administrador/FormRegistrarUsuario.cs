﻿using System;
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
    public partial class FormRegistrarUsuario : Form
    {
        public FormRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            //activar btnModificar y btnBaja
            btnModificar.Enabled = true;
            btnBaja.Enabled = true;
            btnCancelar.Enabled = true;
            //desactivar btnNuevo
            btnCrear.Enabled = false;
        }
    }
}
