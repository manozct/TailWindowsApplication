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
    public partial class frmState : Form
    {
        public frmState()
        {
            InitializeComponent();
            placeholder();
        }

        private void frmState_Load(object sender, EventArgs e)
        {

        }
        public void placeholder()
        {
            txtStateName.Text = "State Name";
            txtStateName.ForeColor = Color.Gray;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtStateName_Enter(object sender, EventArgs e)
        {
            txtStateName.Text = "";
            txtStateName.ForeColor = Color.Black;

        }

        private void txtStateName_Leave(object sender, EventArgs e)
        {
            if(txtStateName.Text=="")
            {
                txtStateName.Text = "State Name";
                txtStateName.ForeColor = Color.Gray;
            }

        }
    }
}
