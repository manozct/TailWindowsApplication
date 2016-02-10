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
    public partial class frmLocation : Form
    {
        public frmLocation()
        {
            InitializeComponent();
            placeholder();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void placeholder()
        {
            cmbCountryName.Text = "--Select Country--";
            cmbCountryName.ForeColor = Color.Gray;
            cmbStateName.Text = "--Select State--";
            cmbStateName.ForeColor = Color.Gray;
            txtLocationName.Text = "Location Name";
            txtLocationName.ForeColor = Color.Gray;
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            frmPopUpState objfrmPopUpState = new frmPopUpState();
            objfrmPopUpState.ShowDialog(this);
        }
    }
}
