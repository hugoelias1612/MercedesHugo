using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica;

namespace ArimaERP.EmpleadoClientes
{
    
    public partial class FormEditarCliente : Form
    {
        private ClassClienteLogica clienteLog = new ClassClienteLogica();
        private CLIENTE clienteActual;

       

        public FormEditarCliente(CLIENTE cliente)
        {
            InitializeComponent();
            clienteActual = cliente;
        }

        private void FormEditarCliente_Load(object sender, EventArgs e)
        {
            List<TAMAÑO_NEGOCIO> listaTamanos = clienteLog.ObtenerTamanos();
            List<ZONA> zonas = clienteLog.ObtenerZonas();
            //Cargar datos del cliente seleccionado en datagrid
            if (clienteActual != null)
            {
                txtBoxNombre.Text = clienteActual.nombre;
                txtBoxApellido.Text = clienteActual.apellido;
                txtBoxDni.Text = clienteActual.dni.ToString();
                txtBoxCuil.Text = clienteActual.cuil_cuit.ToString();
                txtBoxMovil.Text = clienteActual.telefono.ToString();
                txtMail.Text = clienteActual.email.ToString();
                txtBoxLocalidad.Text = clienteActual.ciudad;
                txtBoxProvincia.Text = clienteActual.provincia;
                txtBoxCalle.Text = clienteActual.calle;
                txtCodigoPostal.Text = clienteActual.cod_postal.ToString();
                txtNumero.Text = clienteActual.numero.ToString();
                checkBoxActivo.Checked = clienteActual.estado;
                checkBoxConfiable.Checked = clienteActual.confiable;
                txtRazonSocial.Text = clienteActual.razon_social;
                comboBoxSeleccionarTamano.DataSource = listaTamanos;
                comboBoxSeleccionarTamano.DisplayMember = "descripcion";
                comboBoxSeleccionarTamano.ValueMember = "id_tamano";
                comboBoxSeleccionarTamano.SelectedValue = clienteActual.id_tamano;
                comboBoxSeleccionarZona.DataSource = zonas;
                comboBoxSeleccionarZona.DisplayMember = "nombre";
                comboBoxSeleccionarZona.ValueMember = "id_zona";
                comboBoxSeleccionarZona.SelectedValue = clienteActual.id_zona;
                comboBoxCondicionFrenteIVA.SelectedItem = clienteActual.condicion_frenteIVA;

                txtBoxNombre.ReadOnly = true;
                txtBoxApellido.ReadOnly = true;
                txtBoxDni.ReadOnly = true;
                txtBoxCuil.ReadOnly = true;

            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cierra el formulario sin guardar cambios
            this.Close();
        }
    }
    }

