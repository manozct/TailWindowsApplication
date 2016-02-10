using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourierBackOfficeManagement
{
    public partial class frmGeneralPrice : Form
    {
        public frmGeneralPrice()
        {
            InitializeComponent();
            placeholder();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGeneralPrice_Load(object sender, EventArgs e)
        {

        }
        public void placeholder()
        {
            txtPrice.Text = "Enter Price in NRs";
            txtPrice.ForeColor = Color.Gray;
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            txtPrice.Text = "";
            txtPrice.ForeColor = Color.Black;

        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if(txtPrice.Text=="")
            {
                txtPrice.Text = "Enter Price in NRs";
                txtPrice.ForeColor = Color.Gray;
            }

        }
    }
}
