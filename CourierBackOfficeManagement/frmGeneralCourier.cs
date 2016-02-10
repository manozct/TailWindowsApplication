using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourierBackOfficeManagement.GeneralCourier;

namespace CourierBackOfficeManagement
{
    public partial class frmGeneralCourier : Form
    {
        public frmGeneralCourier()
        {
            InitializeComponent();
            placeholder();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtCourierNumber_TextChanged(object sender, EventArgs e)
        {

        }
        public void placeholder()
        {
            txtCourierNumber.Text = "Courier Number";
            txtCourierNumber.ForeColor = Color.Gray;
            txtReceiverFirstName.Text = "First Name";
            txtReceiverFirstName.ForeColor = Color.Gray;
            txtReceiverMiddleName.Text = "Middle Name (Optional)";
            txtReceiverMiddleName.ForeColor = Color.Gray;
            txtReceiverLastName.Text = "Last Name";
            txtReceiverLastName.ForeColor = Color.Gray;
            txtReceiverMobile.Text = "Mobile";
            txtReceiverMobile.ForeColor = Color.Gray;
            txtReceiverPhone.Text = "Phone";
            txtReceiverPhone.ForeColor = Color.Gray;
            txtReceiverAddress.Text = "Address";
            txtReceiverAddress.ForeColor = Color.Gray;
            txtNumberOfPackage.Text = "Number Of Package";
            txtNumberOfPackage.ForeColor = Color.Gray;
            txtWeight.Text = "Weight";
            txtWeight.ForeColor = Color.Gray;
            txtSenderFirstName.Text = "First Name";
            txtSenderFirstName.ForeColor = Color.Gray;
            txtSenderMiddleName.Text = "Middle Name (Optional)";
            txtSenderMiddleName.ForeColor = Color.Gray;
            txtSenderLastName.Text = "Last Name";
            txtSenderLastName.ForeColor = Color.Gray;
            txtSenderMobile.Text = "Mobile";
            txtSenderMobile.ForeColor = Color.Gray;
            txtSenderPhone.Text = "Phone";
            txtSenderPhone.ForeColor = Color.Gray;
            txtSenderAddress.Text = "Address";
            txtSenderAddress.ForeColor = Color.Gray;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            cmbWeightUnit.SelectedItem = "Kg";
            cmbServiceType.SelectedItem = "On Air";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtCourierNumber_Enter(object sender, EventArgs e)
        {

            txtCourierNumber.Text = "";
            txtCourierNumber.ForeColor = Color.Black;
        }

        private void txtCourierNumber_Leave(object sender, EventArgs e)
        {
            if (txtCourierNumber.Text == "")
            {
                txtCourierNumber.Text = "Courier Number";
                txtCourierNumber.ForeColor = Color.Gray;
            }
        }

        private void txtReciverFirstName_Leave(object sender, EventArgs e)
        {
            if (txtReceiverFirstName.Text == "")
            {
                txtReceiverFirstName.Text = "First Name";
                txtReceiverFirstName.ForeColor = Color.Gray;
            }

        }

        private void txtReciverFirstName_Enter(object sender, EventArgs e)
        {
            txtReceiverFirstName.Text = "";
            txtReceiverFirstName.ForeColor = Color.Black;

        }

        private void txtReceiverMiddleName_Enter(object sender, EventArgs e)
        {
            txtReceiverMiddleName.Text = "";
            txtReceiverMiddleName.ForeColor = Color.Black;

        }

        private void txtReceiverMiddleName_Leave(object sender, EventArgs e)
        {
            if (txtReceiverMiddleName.Text == "")
            {
                txtReceiverMiddleName.Text = "Middle Name (Optional)";
                txtReceiverMiddleName.ForeColor = Color.Gray;
            }

        }

        private void txtReceiverLastName_Enter(object sender, EventArgs e)
        {
            txtReceiverLastName.Text = "";
            txtReceiverLastName.ForeColor = Color.Black;

        }

        private void txtReceiverLastName_Leave(object sender, EventArgs e)
        {
            if (txtReceiverLastName.Text == "")
            {
                txtReceiverLastName.Text = "Last Name";
                txtReceiverLastName.ForeColor = Color.Gray;
            }

        }

        private void txtReceiverMobile_Enter(object sender, EventArgs e)
        {
            txtReceiverMobile.Text = "";
            txtReceiverMobile.ForeColor = Color.Black;
        }

        private void txtReceiverMobile_Leave(object sender, EventArgs e)
        {
            if (txtReceiverMobile.Text == "")
            {
                txtReceiverMobile.Text = "Mobile";
                txtReceiverMobile.ForeColor = Color.Gray;
            }

        }

        private void txtReceiverPhone_Enter(object sender, EventArgs e)
        {
            txtReceiverPhone.Text = "";
            txtReceiverPhone.ForeColor = Color.Black;

        }

        private void txtReceiverPhone_Leave(object sender, EventArgs e)
        {
            if (txtReceiverPhone.Text == "")
            {
                txtReceiverPhone.Text = "Phone";
                txtReceiverPhone.ForeColor = Color.Gray;
            }

        }

        private void txtReceiverAddress_Enter(object sender, EventArgs e)
        {
            txtReceiverAddress.Text = "";
            txtReceiverAddress.ForeColor = Color.Black;

        }

        private void txtReceiverAddress_Leave(object sender, EventArgs e)
        {
            if (txtReceiverAddress.Text == "")
            {
                txtReceiverAddress.Text = "Address";
                txtReceiverAddress.ForeColor = Color.Gray;
            }
        }

        private void txtNumberOfPackage_Enter(object sender, EventArgs e)
        {
            txtNumberOfPackage.Text = "";
            txtNumberOfPackage.ForeColor = Color.Black;

        }

        private void txtNumberOfPackage_Leave(object sender, EventArgs e)
        {
            if (txtNumberOfPackage.Text == "")
            {
                txtNumberOfPackage.Text = "Number Of Package";
                txtNumberOfPackage.ForeColor = Color.Gray;
            }

        }

        private void txtWeight_Leave(object sender, EventArgs e)
        {
            if (txtWeight.Text == "")
            {
                txtWeight.Text = "Weight";
                txtWeight.ForeColor = Color.Gray;
            }

        }

        private void txtWeight_Enter(object sender, EventArgs e)
        {
            txtWeight.Text = "";
            txtWeight.ForeColor = Color.Black;

        }

        private void txtSenderFirstName_Enter(object sender, EventArgs e)
        {
            txtSenderFirstName.Text = "";
            txtSenderFirstName.ForeColor = Color.Black;
        }

        private void txtSenderFirstName_Leave(object sender, EventArgs e)
        {
            if (txtSenderFirstName.Text == "")
            {
                txtSenderFirstName.Text = "First Name";
                txtSenderFirstName.ForeColor = Color.Gray;
            }

        }

        private void txtSenderMiddleName_Enter(object sender, EventArgs e)
        {
            txtSenderMiddleName.Text = "";
            txtSenderMiddleName.ForeColor = Color.Black;

        }

        private void txtSenderMiddleName_Leave(object sender, EventArgs e)
        {
            if (txtSenderMiddleName.Text == "")
            {
                txtSenderMiddleName.Text = "Middle Name (Optional)";
                txtSenderMiddleName.ForeColor = Color.Gray;
            }

        }

        private void txtSenderLastName_Enter(object sender, EventArgs e)
        {
            txtSenderLastName.Text = "";
            txtSenderLastName.ForeColor = Color.Black;
        }

        private void txtSenderLastName_Leave(object sender, EventArgs e)
        {
            if (txtSenderLastName.Text == "")
            {
                txtSenderLastName.Text = "Last Name";
                txtSenderLastName.ForeColor = Color.Gray;
            }


        }

        private void txtSenderMobile_Enter(object sender, EventArgs e)
        {
            txtSenderMobile.Text = "";
            txtSenderMobile.ForeColor = Color.Black;
        }

        private void txtSenderMobile_Leave(object sender, EventArgs e)
        {
            if (txtSenderMobile.Text == "")
            {
                txtSenderMobile.Text = "Mobile";
                txtSenderMobile.ForeColor = Color.Gray;
            }


        }

        private void txtSenderPhone_Enter(object sender, EventArgs e)
        {
            txtSenderPhone.Text = "";
            txtSenderPhone.ForeColor = Color.Black;
        }

        private void txtSenderPhone_Leave(object sender, EventArgs e)
        {
            if (txtSenderPhone.Text == "")
            {
                txtSenderPhone.Text = "Phone";
                txtSenderPhone.ForeColor = Color.Gray;
            }

        }

        private void txtSenderAddress_Enter(object sender, EventArgs e)
        {
            txtSenderAddress.Text = "";
            txtSenderAddress.ForeColor = Color.Black;

        }

        private void txtSenderAddress_Leave(object sender, EventArgs e)
        {
            if (txtSenderAddress.Text == "")
            {
                txtSenderAddress.Text = "Address";
                txtSenderAddress.ForeColor = Color.Gray;
            }
        }

        private void txtReciverFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                GeneralCourier.GeneralCourierWebService objWebService = new GeneralCourier.GeneralCourierWebService();
                GeneralCourierInfo objInfo = new GeneralCourierInfo();
                objInfo.CourierNumber = txtCourierNumber.Text;
                objInfo.ReceiverFirstName = txtReceiverFirstName.Text;
                objInfo.ReceiverMiddleName = txtReceiverMiddleName.Text;
                objInfo.ReceiverLastName = txtReceiverLastName.Text;
                objInfo.ReceiverAddress = txtReceiverAddress.Text;
                objInfo.ReceiverMobile =Convert.ToUInt16(txtReceiverMobile.Text);
                objInfo.ReceiverPhone = Convert.ToInt32(txtReceiverPhone.Text);
                objInfo.NumberOfPackage = Convert.ToInt32(txtNumberOfPackage.Text);
                objInfo.WeightOfPackage = Convert.ToDecimal(txtWeight.Text);
                objInfo.ServiceTypeID = Convert.ToInt32(cmbServiceType.SelectedValue);
                objInfo.WeightUnitID = Convert.ToInt32(cmbWeightUnit.SelectedValue);
                objInfo.SenderFirstName = txtSenderFirstName.Text;
                objInfo.SenderMiddleName = txtSenderMiddleName.Text;
                objInfo.SenderLastName = txtSenderLastName.Text;
                objInfo.SenderAddress = txtSenderAddress.Text;
                objInfo.SenderMobile = Convert.ToInt32(txtSenderMobile.Text);
                objInfo.SenderPhone = Convert.ToInt32(txtSenderPhone.Text);
                objInfo.AddedBy = "";
                objWebService.GeneralCourierAdd(objInfo, SystemSettings.AppToken);
                MessageBox.Show("Data Saved Successfully...");
                ClearField();

            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
        public void ClearField()
        {
            txtCourierNumber.Text = "";
            txtReceiverFirstName.Text = "";
            txtReceiverMiddleName.Text = "";
            txtReceiverLastName.Text = "";
            txtReceiverAddress.Text = "";
            txtReceiverMobile.Text = "";
            txtReceiverPhone.Text = "";
            txtNumberOfPackage.Text = "";
            txtWeight.Text = "";
            cmbWeightUnit.SelectedItem = "Kg";
            cmbServiceType.SelectedItem = "On Air";
            txtSenderFirstName.Text = "";
            txtSenderMiddleName.Text = "";
            txtSenderLastName.Text = "";
            txtSenderAddress.Text = "";
            txtSenderMobile.Text = "";
            txtSenderPhone.Text = "";
        }
       
    }
}
