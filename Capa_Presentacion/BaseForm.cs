using System;
using System.Drawing;
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

        private void BaseForm_Load(object sender, EventArgs e)
        {
        }
    }
}