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
    public partial class frmContract : Form
    {
        public frmContract()
        {
            InitializeComponent();
            placeholder();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmContract_Load(object sender, EventArgs e)
        {

        }
        public void placeholder()
        {
            txtCharge.Text = "Charge(NRs)";
            txtCharge.ForeColor = Color.Gray;
            rchtxtContractDescription.Text = "Contract Description (not more than 1500 words)";
            rchtxtContractDescription.ForeColor = Color.Gray;
            txtContractDate.Text = "Contract Date(dd/mm/yyyy)";
            txtContractDate.ForeColor = Color.Gray;
            txtContractExpireDate.Text = "Expire Date(dd/mm/yyyy)";
            txtContractExpireDate.ForeColor = Color.Gray;
        }

        private void txtCharge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCharge_Enter(object sender, EventArgs e)
        {
            txtCharge.Text = "";
            txtCharge.ForeColor = Color.Black;

        }

        private void txtCharge_Leave(object sender, EventArgs e)
        {
            if(txtCharge.Text=="")
            {
                txtCharge.Text = "Charge(NRs)";
                txtCharge.ForeColor = Color.Gray;
            }
        }

        private void rchtxtContractDescription_Enter(object sender, EventArgs e)
        {
            rchtxtContractDescription.Text = "";
            rchtxtContractDescription.ForeColor = Color.Black;

        }

        private void rchtxtContractDescription_Leave(object sender, EventArgs e)
        {
            if(rchtxtContractDescription.Text=="")
            {
                rchtxtContractDescription.Text = "Contract Description (not more than 1500 words)";
                rchtxtContractDescription.ForeColor = Color.Gray;
            }

        }

        private void txtContractDate_Enter(object sender, EventArgs e)
        {
            txtContractDate.Text = "";
            txtContractDate.ForeColor = Color.Black;


        }

        private void txtContractDate_Leave(object sender, EventArgs e)
        {
            if (txtContractDate.Text == "")
            {
                txtContractDate.Text = "Contract Date(dd/mm/yyyy)";
                txtContractDate.ForeColor = Color.Gray;
            }
        }

        private void txtContractExpireDate_Enter(object sender, EventArgs e)
        {
            txtContractExpireDate.Text = "";
            txtContractExpireDate.ForeColor = Color.Black;

        }

        private void txtContractExpireDate_Leave(object sender, EventArgs e)
        {
            if (txtContractExpireDate.Text == "")
            {
                txtContractExpireDate.Text = "Expire Date(dd/mm/yyyy)";
                txtContractExpireDate.ForeColor = Color.Gray;
            }

        }

        private void txtContractDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContractExpireDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
