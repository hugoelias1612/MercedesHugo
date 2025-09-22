using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ArimaERP
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            this.Font = new Font("Segoe UI", 9F);
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
        }
    }
}