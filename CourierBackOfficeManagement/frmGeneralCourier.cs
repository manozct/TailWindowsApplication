using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourierBackOfficeManagement.BLL;
using CourierBackOfficeManagement.GeneralCourier;
using CourierManagement;

namespace CourierBackOfficeManagement
{
    public partial class frmGeneralCourier : Form
    {
        public frmGeneralCourier()
        {
            InitializeComponent();
            ItemOfCmbServiceType();
            ItemOfCmbWeightUnit();
            this.ActiveControl = lblGeneralCourierId;
            lblGeneralCourierId.Text = "0";
        }
        public frmGeneralCourier(int GeneralCourierID)
        {
            InitializeComponent();
            ItemOfCmbServiceType();
            ItemOfCmbWeightUnit();
            GeneralCourierWebService objWebService = new GeneralCourier.GeneralCourierWebService();
            GeneralCourierInfo objInfo = new GeneralCourierInfo();
            objInfo.GeneralCourierID = GeneralCourierID;
            objInfo = objWebService.GeneralCourierGetByID(objInfo.GeneralCourierID, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
            lblGeneralCourierId.Text = objInfo.GeneralCourierID.ToString();
            txtCourierNumber.Text = objInfo.CourierNumber;
            txtReceiverFirstName.Text = objInfo.ReceiverFirstName;
            txtReceiverMiddleName.Text = objInfo.ReceiverMiddleName;
            txtReceiverLastName.Text = objInfo.ReceiverLastName;
            txtReceiverMobile.Text = objInfo.ReceiverMobile;
            txtReceiverPhone.Text = objInfo.ReceiverPhone;
            txtReceiverAddress.Text = objInfo.ReceiverAddress;
            txtNumberOfPackage.Text = objInfo.NumberOfPackage.ToString();
            txtWeight.Text = objInfo.WeightOfPackage.ToString();
            cmbWeightUnit.SelectedValue = objInfo.WeightUnitID.ToString();
            cmbServiceType.SelectedValue = objInfo.ServiceTypeID.ToString();
            txtCourierCharge.Text = objInfo.CourierCharge.ToString();
            txtSenderFirstName.Text = objInfo.SenderFirstName;
            txtSenderMiddleName.Text = objInfo.SenderMiddleName;
            txtSenderLastName.Text = objInfo.SenderLastName;
            txtSenderMobile.Text = objInfo.SenderMobile;
            txtSenderPhone.Text = objInfo.SenderPhone;
            txtSenderPhone.Text = objInfo.SenderPhone;
            txtSenderAddress.Text = objInfo.SenderAddress;
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
           

        }
        private void frmClient_Load(object sender, EventArgs e)
        {
           
        }

        public void ItemOfCmbServiceType()
        {
            var serviceType = new Dictionary<string, string>();
            serviceType["1"] = "On Air";
            serviceType["2"] = "By Land";
            cmbServiceType.DataSource = new BindingSource(serviceType, null);
            cmbServiceType.DisplayMember = "Value";
            cmbServiceType.ValueMember = "Key";
        }
        public void ItemOfCmbWeightUnit()
        {
            var weightUnit = new Dictionary<string, string>();
            weightUnit["2"] = "Kg";
            weightUnit["1"] = "Gm";
            cmbWeightUnit.DataSource = new BindingSource(weightUnit, null);
            cmbWeightUnit.DisplayMember = "Value";
            cmbWeightUnit.ValueMember = "Key";
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    GeneralCourier.GeneralCourierWebService objWebService = new GeneralCourier.GeneralCourierWebService();
                    GeneralCourierInfo objInfo = new GeneralCourierInfo();
                    objInfo.CourierNumber = txtCourierNumber.Text.Trim();
                    objInfo.ReceiverFirstName = txtReceiverFirstName.Text.Trim();
                    objInfo.ReceiverMiddleName = txtReceiverMiddleName.Text.Trim();
                    objInfo.ReceiverLastName = txtReceiverLastName.Text.Trim();
                    objInfo.ReceiverAddress = txtReceiverAddress.Text.Trim();
                    objInfo.ReceiverMobile = txtReceiverMobile.Text.Trim();
                    objInfo.ReceiverPhone = txtReceiverPhone.Text.Trim();
                    objInfo.NumberOfPackage = Convert.ToInt32(txtNumberOfPackage.Text.Trim());
                    objInfo.WeightOfPackage = Convert.ToDecimal(txtWeight.Text.Trim());
                    objInfo.ServiceTypeID = Convert.ToInt32(cmbServiceType.SelectedValue);
                    objInfo.WeightUnitID = Convert.ToInt32(cmbWeightUnit.SelectedValue);
                    objInfo.SenderFirstName = txtSenderFirstName.Text.Trim();
                    objInfo.SenderMiddleName = txtSenderMiddleName.Text.Trim();
                    objInfo.SenderLastName = txtSenderLastName.Text.Trim();
                    objInfo.SenderAddress = txtSenderAddress.Text.Trim();
                    objInfo.SenderMobile = txtSenderMobile.Text.Trim();
                    objInfo.SenderPhone = txtSenderPhone.Text.Trim();
                    objInfo.CourierCharge = Convert.ToDecimal(txtCourierCharge.Text.Trim());
                    int Id = Convert.ToInt32(lblGeneralCourierId.Text);

                    if (Id == 0)
                    {
                        objInfo.AddedBy = GetLoginUser.UserName;
                        objInfo.AddedOn = DateTime.Now;
                        objInfo.UpdatedBy = GetLoginUser.UserName;
                        objWebService.GeneralCourierAdd(objInfo, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
                        MessageBox.Show("Data Saved Successfully...");

                    }
                    else
                    {
                        objInfo.UpdatedBy = GetLoginUser.UserName;
                        objInfo.AddedBy = GetLoginUser.UserName;
                        objInfo.GeneralCourierID = Id;
                        objWebService.GeneralCourierUpdate(objInfo, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
                        MessageBox.Show("Data Updated Successfully...");
                    }
                    ClearField();
                    this.DialogResult = DialogResult.OK;

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void ClearField()
        {
            txtCourierNumber.Text = string.Empty;
            txtReceiverFirstName.Text = string.Empty;
            txtReceiverMiddleName.Text = string.Empty;
            txtReceiverLastName.Text = string.Empty;
            txtReceiverAddress.Text = string.Empty;
            txtReceiverMobile.Text = string.Empty;
            txtReceiverPhone.Text = string.Empty;
            txtNumberOfPackage.Text = string.Empty;
            txtWeight.Text = string.Empty;
            cmbWeightUnit.SelectedItem = string.Empty;
            cmbServiceType.SelectedItem = string.Empty;
            txtSenderFirstName.Text = string.Empty;
            txtSenderMiddleName.Text = string.Empty;
            txtSenderLastName.Text = string.Empty;
            txtSenderAddress.Text = string.Empty;
            txtSenderMobile.Text = string.Empty;
            txtSenderPhone.Text = string.Empty;
        }

        private void txtReceiverFirstName_Validating(object sender, CancelEventArgs e)
        {

            ValidateReceiverFirstName();

        }
        private bool ValidateReceiverFirstName()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtReceiverFirstName.Text == string.Empty)
            {
                errorProvider1.SetError(txtReceiverFirstName, "Please Enter First Name");
                bStatus = false;
            }
            else if (!Regex.IsMatch(txtReceiverFirstName.Text, @"^[a-zA-Z]+$"))
            {

                errorProvider1.SetError(txtReceiverFirstName, "Please Enter valid name");
                bStatus = false;

            }
            else
                errorProvider1.SetError(txtReceiverFirstName, string.Empty);
            return bStatus;
        }
        private bool ValidateReceiverMiddleName()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtReceiverMiddleName.Text != string.Empty)
            {
                if (!Regex.IsMatch(txtReceiverMiddleName.Text, @"^[a-zA-Z]+$"))
                {

                    errorProvider1.SetError(txtReceiverMiddleName, "Please Enter valid name");
                    bStatus = false;

                }
            }
            else
                errorProvider1.SetError(txtReceiverMiddleName, string.Empty);
            return bStatus;
        }
        private bool ValidateReceiverLastName()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtReceiverLastName.Text == string.Empty)
            {
                errorProvider1.SetError(txtReceiverLastName, "Please Enter Last Name");
                bStatus = false;
            }
            else if (!Regex.IsMatch(txtReceiverLastName.Text, @"^[a-zA-Z]+$"))
            {

                errorProvider1.SetError(txtReceiverLastName, "Please Enter valid name");
                bStatus = false;

            }
            else
                errorProvider1.SetError(txtReceiverLastName, string.Empty);
            return bStatus;
        }
        private bool ValidateReceiverMobileNumber()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtReceiverMobile.Text == string.Empty)
            {
                errorProvider1.SetError(txtReceiverMobile, "Please Enter Mobile Number");
                bStatus = false;
            }
            else if (!Regex.IsMatch(txtReceiverMobile.Text, @"^\+?\d[\d -]{7,12}\d$"))
            {

                errorProvider1.SetError(txtReceiverMobile, "Please Enter valid number");
                bStatus = false;

            }
            else
                errorProvider1.SetError(txtReceiverMobile, string.Empty);
            return bStatus;
        }
        private bool ValidateReceiverPhoneNumber()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtReceiverPhone.Text != string.Empty)
            {

                if (!Regex.IsMatch(txtReceiverPhone.Text, @"^\+?\d[\d -]{7,12}\d$"))
                {

                    errorProvider1.SetError(txtReceiverPhone, "Please Enter valid number");
                    bStatus = false;

                }
            }
            else
                errorProvider1.SetError(txtReceiverPhone, string.Empty);
            return bStatus;
        }
        private bool ValidateReceiverAddress()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtReceiverAddress.Text == string.Empty)
            {
                errorProvider1.SetError(txtReceiverAddress, "Please Enter Address");
                bStatus = false;
            }
            else if (Regex.IsMatch(txtReceiverAddress.Text, @"^\+?\d[\d -][0-9][0-9 ]*$"))
            {
                errorProvider1.SetError(txtReceiverAddress, "Please enter valid address");
                bStatus = false;

            }
            else if (!Regex.IsMatch(txtReceiverAddress.Text, @"[a-zA-Z0-9!$* \t\r\n\-]"))
            {

                errorProvider1.SetError(txtReceiverAddress, "Please enter valid address");
                bStatus = false;

            }
            else
                errorProvider1.SetError(txtReceiverAddress, string.Empty);
            return bStatus;
        }
        private bool ValidateNumberOfPackage()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtNumberOfPackage.Text == string.Empty)
            {
                errorProvider1.SetError(txtNumberOfPackage, "Please Enter Number of Package");
                bStatus = false;
            }
            else if (!Regex.IsMatch(txtNumberOfPackage.Text, @"^\d$"))
            {

                errorProvider1.SetError(txtNumberOfPackage, "Please enter valid data");
                bStatus = false;

            }
            else
                errorProvider1.SetError(txtNumberOfPackage, string.Empty);
            return bStatus;
        }
        private bool ValidateWeightOfPackage()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtWeight.Text == string.Empty)
            {
                errorProvider1.SetError(txtWeight, "Please Enter Weight of Package");
                bStatus = false;
            }
            else if (!Regex.IsMatch(txtWeight.Text, @"[0-9]*\.?[0-9]*"))
            {

                errorProvider1.SetError(txtWeight, "Please enter valid data");
                bStatus = false;

            }
            else
                errorProvider1.SetError(txtWeight, string.Empty);
            return bStatus;
        }
        private bool ValidateCourierCharge()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtCourierCharge.Text == string.Empty)
            {
                errorProvider1.SetError(txtCourierCharge, "Please Enter Courier Charge");
                bStatus = false;
            }
            else if (!Regex.IsMatch(txtCourierCharge.Text, @"[0-9]*\.?[0-9]"))
            {

                errorProvider1.SetError(txtCourierCharge, "Please enter valid integer or decimal number");
                bStatus = false;

            }
            else
                errorProvider1.SetError(txtCourierCharge, string.Empty);
            return bStatus;
        }
        private bool ValidateSenderFirstName()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtSenderFirstName.Text == string.Empty)
            {
                errorProvider1.SetError(txtSenderFirstName, "Please Enter First Name");
                bStatus = false;
            }
            else if (!Regex.IsMatch(txtSenderFirstName.Text, @"^[a-zA-Z]+$"))
            {

                errorProvider1.SetError(txtSenderFirstName, "Please Enter valid name");
                bStatus = false;

            }
            else
                errorProvider1.SetError(txtSenderFirstName, string.Empty);
            return bStatus;
        }
        private bool ValidateSenderMiddleName()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtSenderMiddleName.Text != string.Empty)
            {
                if (!Regex.IsMatch(txtSenderMiddleName.Text, @"^[a-zA-Z]+$"))
                {

                    errorProvider1.SetError(txtSenderMiddleName, "Please Enter valid name");
                    bStatus = false;

                }
            }
            else
                errorProvider1.SetError(txtSenderMiddleName, string.Empty);
            return bStatus;
        }
        private bool ValidateSenderLastName()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtSenderLastName.Text == string.Empty)
            {
                errorProvider1.SetError(txtSenderLastName, "Please Enter Last Name");
                bStatus = false;
            }
            else if (!Regex.IsMatch(txtSenderLastName.Text, @"^[a-zA-Z]+$"))
            {

                errorProvider1.SetError(txtSenderLastName, "Please Enter valid name");
                bStatus = false;

            }
            else
                errorProvider1.SetError(txtSenderLastName, string.Empty);
            return bStatus;
        }
        private bool ValidateSenderMobileNumber()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtSenderMobile.Text == string.Empty)
            {
                errorProvider1.SetError(txtSenderMobile, "Please Enter Mobile Number");
                bStatus = false;
            }
            else if (!Regex.IsMatch(txtSenderMobile.Text, @"^\+?\d[\d -]{7,12}\d$"))
            {

                errorProvider1.SetError(txtSenderMobile, "Please Enter valid number");
                bStatus = false;

            }
            else
                errorProvider1.SetError(txtSenderMobile, string.Empty);
            return bStatus;
        }
        private bool ValidateWeightUnit()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (cmbWeightUnit.Text == string.Empty)
            {
                errorProvider1.SetError(cmbWeightUnit, "Please Select weight unit");
                bStatus = false;
            }
            else
                errorProvider1.SetError(cmbWeightUnit, string.Empty);
            return bStatus;
        }
        private bool ValidateServiceType()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (cmbServiceType.Text == string.Empty)
            {
                errorProvider1.SetError(cmbServiceType, "Please Select service type");
                bStatus = false;
            }
            else
                errorProvider1.SetError(cmbServiceType, string.Empty);
            return bStatus;
        }
        private bool ValidateSenderPhoneNumber()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtSenderPhone.Text != string.Empty)
            {
                if (!Regex.IsMatch(txtSenderPhone.Text, @"^\+?\d[\d -]{7,12}\d$"))
                {

                    errorProvider1.SetError(txtSenderPhone, "Please Enter valid number");
                    bStatus = false;

                }
            }
            else
                errorProvider1.SetError(txtSenderPhone, string.Empty);
            return bStatus;
        }
        private bool ValidateSenderAddress()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtSenderAddress.Text == string.Empty)
            {
                errorProvider1.SetError(txtSenderAddress, "Please Enter Address");
                bStatus = false;
            }
            else if (Regex.IsMatch(txtSenderAddress.Text, @"^\+?\d[\d -][0-9][0-9 ]*$"))
            {
                errorProvider1.SetError(txtSenderAddress, "Please enter valid address");
                bStatus = false;

            }
            else if (!Regex.IsMatch(txtSenderAddress.Text, @"[a-zA-Z0-9!$* \t\r\n\-]"))
            {

                errorProvider1.SetError(txtSenderAddress, "Please enter valid address");
                bStatus = false;

            }
            else
                errorProvider1.SetError(txtSenderAddress, string.Empty);
            return bStatus;
        }
        private bool ValidateForm()
        {
            if (txtReceiverFirstName.Text == string.Empty)
            {
                txtReceiverFirstName.Focus();
                errorProvider1.SetError(txtReceiverFirstName, "Required!");
                return false;
            }
            else if (txtReceiverLastName.Text == string.Empty)
            {
                txtReceiverLastName.Focus();
                errorProvider1.SetError(txtReceiverLastName, "Required!");
                return false;
            }
            else if (txtReceiverMobile.Text == string.Empty)
            {
                txtReceiverMobile.Focus();
                errorProvider1.SetError(txtReceiverMobile, "Required!");
                return false;
            }
            else if (txtReceiverAddress.Text == string.Empty)
            {
                txtReceiverAddress.Focus();
                errorProvider1.SetError(txtReceiverAddress, "Required!");
                return false;
            }
            else if (txtNumberOfPackage.Text == string.Empty)
            {
                txtNumberOfPackage.Focus();
                errorProvider1.SetError(txtNumberOfPackage, "Required!");
                return false;
            }
            else if (txtWeight.Text == string.Empty)
            {
                txtWeight.Focus();
                errorProvider1.SetError(txtWeight, "Required!");
                return false;
            }
            else if (cmbWeightUnit.Text == string.Empty)
            {
                cmbWeightUnit.Focus();
                errorProvider1.SetError(cmbWeightUnit, "Required!");
                return false;
            }
            else if (cmbServiceType.Text == string.Empty)
            {
                cmbServiceType.Focus();
                errorProvider1.SetError(cmbServiceType, "Required!");
                return false;
            }
            else if (txtCourierCharge.Text == string.Empty)
            {
                txtCourierCharge.Focus();
                errorProvider1.SetError(txtCourierCharge, "Required!");
                return false;
            }
            else if (txtSenderFirstName.Text == string.Empty)
            {
                txtSenderFirstName.Focus();
                errorProvider1.SetError(txtSenderFirstName, "Required!");
                return false;
            }
            else if (txtSenderLastName.Text == string.Empty)
            {
                txtSenderLastName.Focus();
                errorProvider1.SetError(txtSenderLastName, "Required!");
                return false;
            }
            else if (txtSenderMobile.Text == string.Empty)
            {
                txtSenderMobile.Focus();
                errorProvider1.SetError(txtSenderMobile, "Required!");
                return false;
            }
            else if (txtSenderAddress.Text == string.Empty)
            {
                txtSenderAddress.Focus();
                errorProvider1.SetError(txtSenderAddress, "Required!");
                return false;
            }
            else
            {
                return true;
            }

        }


        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void txtReceiverMiddleName_Validating(object sender, CancelEventArgs e)
        {
            ValidateReceiverMiddleName();
        }

        private void txtReceiverLastName_Validating(object sender, CancelEventArgs e)
        {
            ValidateReceiverLastName();
        }

        private void txtReceiverMobile_Validating(object sender, CancelEventArgs e)
        {
            ValidateReceiverMobileNumber();
        }

        private void txtReceiverPhone_Validating(object sender, CancelEventArgs e)
        {
            ValidateReceiverPhoneNumber();
        }

        private void txtReceiverAddress_Validating(object sender, CancelEventArgs e)
        {
            ValidateReceiverAddress();
        }

        private void txtNumberOfPackage_Validating(object sender, CancelEventArgs e)
        {
            ValidateNumberOfPackage();
        }

        private void txtWeight_Validating(object sender, CancelEventArgs e)
        {
            ValidateWeightOfPackage();
        }

        private void txtSenderFirstName_Validating(object sender, CancelEventArgs e)
        {
            ValidateSenderFirstName();

        }

        private void txtSenderMiddleName_Validating(object sender, CancelEventArgs e)
        {
            ValidateSenderMiddleName();

        }

        private void txtSenderLastName_Validating(object sender, CancelEventArgs e)
        {
            ValidateSenderLastName();
        }

        private void txtSenderMobile_Validating(object sender, CancelEventArgs e)
        {
            ValidateSenderMobileNumber();
        }

        private void txtSenderPhone_Validating(object sender, CancelEventArgs e)
        {
            ValidateSenderPhoneNumber();
        }

        private void txtSenderAddress_Validating(object sender, CancelEventArgs e)
        {
            ValidateSenderAddress();

        }

        private void txtCourierCharge_Validating(object sender, CancelEventArgs e)
        {
            ValidateCourierCharge();
        }

        private void cmbWeightUnit_Validating(object sender, CancelEventArgs e)
        {
            ValidateWeightUnit();

        }

        private void cmbServiceType_Validating(object sender, CancelEventArgs e)
        {
            ValidateServiceType();
        }
    }
}
