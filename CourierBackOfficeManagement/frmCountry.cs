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
    public partial class frmCountry : Form
    {
        public frmCountry()
        {
            InitializeComponent();
            placeholder();
        }

        private void frmCountry_Load(object sender, EventArgs e)
        {

        }
        public void placeholder()
        {
            txtCountryName.Text = "Country Name";
            txtCountryName.ForeColor = Color.Gray;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCountryName_Enter(object sender, EventArgs e)
        {
            txtCountryName.Text = "";
            txtCountryName.ForeColor = Color.Black;

        }

        private void txtCountryName_Leave(object sender, EventArgs e)
        {
            if(txtCountryName.Text=="")
            {
                txtCountryName.Text = "Country Name";
                txtCountryName.ForeColor = Color.Gray;
            }
        }
    }
}
