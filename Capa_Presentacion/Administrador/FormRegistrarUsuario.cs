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
    public partial class FormRegistrarUsuario : Form
    {
        public FormRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void uSUARIOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uSUARIOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tallerProgramacionIIDataSet);

        }

        private void FormRegistrarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tallerProgramacionIIDataSet.USUARIOS' Puede moverla o quitarla según sea necesario.
            this.uSUARIOSTableAdapter.Fill(this.tallerProgramacionIIDataSet.USUARIOS);
            // TODO: esta línea de código carga datos en la tabla 'tallerProgramacionIIDataSet.USUARIOS' Puede moverla o quitarla según sea necesario.
            this.uSUARIOSTableAdapter.Fill(this.tallerProgramacionIIDataSet.USUARIOS);

        }

        private void uSUARIOSBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.uSUARIOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tallerProgramacionIIDataSet);

        }
    }
}
