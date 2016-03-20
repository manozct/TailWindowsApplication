using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourierBackOfficeManagement.CorporateClient;
using CourierManagement;


namespace CourierBackOfficeManagement
{
    public partial class frmCorporateClient : Form
    {
        public frmCorporateClient()
        {
            InitializeComponent();
            lblCorporateClientId.Text = "0";
            this.ActiveControl = lblCorporateClientId;
            
        }
        
        public frmCorporateClient(int corporateClientID)
        {
            InitializeComponent(); 
                       
            CorporateClient.CorporateClientWebService objWebService = new CorporateClient.CorporateClientWebService();
            CorporateClientInfo objInfo = new CorporateClientInfo();
            objInfo.CorporateClientID = corporateClientID;
            objInfo = objWebService.CorporateClientGetByID(objInfo.CorporateClientID, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
            lblCorporateClientId.Text = objInfo.CorporateClientID.ToString();
            txtCorporateName.Text = objInfo.ClientName;
            rchtxtAddress.Text = objInfo.Address;
            txtPhoneNumber.Text = objInfo.PhoneNumber.ToString();
            txtCorporateEmail.Text = objInfo.EmailAddress;
            txtHeadOfficeAddress.Text = objInfo.HOAddress;
            txtLCDepartment.Text = objInfo.LCDepartment;
            txtLCDContractPerson.Text = objInfo.LCDContactPerson;
            txtContactPersonMobile.Text = objInfo.LCDContactPersonMobile;
            txtContactPersonPhone.Text = objInfo.LCDContactPersonPhone;
            txtContactPersonEmail.Text = objInfo.LCDContactPersonEmail;
            rchtxtSLA.Text = objInfo.SLA;
           

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    CorporateClient.CorporateClientWebService obj = new CorporateClient.CorporateClientWebService();
                    CorporateClientInfo objCorporateClientInfo = new CorporateClientInfo();
                    objCorporateClientInfo.ClientName = txtCorporateName.Text;
                    objCorporateClientInfo.Address = rchtxtAddress.Text;
                    objCorporateClientInfo.PhoneNumber = txtPhoneNumber.Text;
                    objCorporateClientInfo.EmailAddress = txtCorporateEmail.Text;
                    objCorporateClientInfo.HOAddress = txtHeadOfficeAddress.Text;
                    objCorporateClientInfo.LCDepartment = txtLCDepartment.Text;
                    objCorporateClientInfo.LCDContactPerson = txtLCDContractPerson.Text;
                    objCorporateClientInfo.LCDContactPersonPhone = txtContactPersonPhone.Text;
                    objCorporateClientInfo.LCDContactPersonMobile = txtContactPersonMobile.Text;
                    objCorporateClientInfo.LCDContactPersonEmail = txtContactPersonEmail.Text;
                    objCorporateClientInfo.SLA = rchtxtSLA.Text;
                    int Id = Convert.ToInt32(lblCorporateClientId.Text);
                    if (Id == 0)
                    {
                        objCorporateClientInfo.AddedBy = GetLoginUser.UserName;
                        obj.CorporateClientAdd(objCorporateClientInfo, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
                        MessageBox.Show("Data Saved Successfully...");

                    }
                    else
                    {
                        objCorporateClientInfo.EditedBy = GetLoginUser.UserName;
                        objCorporateClientInfo.CorporateClientID = Id;
                        obj.CorporateClientUpdate(objCorporateClientInfo, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
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
            txtCorporateName.Text = string.Empty;
            rchtxtAddress.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtCorporateEmail.Text = string.Empty;
            txtHeadOfficeAddress.Text = string.Empty;
            txtLCDepartment.Text = string.Empty;
            txtLCDContractPerson.Text = string.Empty;
            txtContactPersonPhone.Text = string.Empty;
            txtContactPersonMobile.Text = string.Empty;
            txtContactPersonEmail.Text = string.Empty;
            rchtxtSLA.Text = "";
        }
        private bool ValidateForm()
        {
            if (txtCorporateName.Text == string.Empty)
            {
                txtCorporateName.Focus();
                errorProvider1.SetError(txtCorporateName, "Required!");
                return false;
            }
            else if (rchtxtAddress.Text == string.Empty)
            {
                rchtxtAddress.Focus();
                errorProvider1.SetError(rchtxtAddress, "Required!");
                return false;
            }
            else if (txtPhoneNumber.Text == string.Empty)
            {
                txtPhoneNumber.Focus();
                errorProvider1.SetError(txtPhoneNumber, "Required!");
                return false;
            }
            else if (txtCorporateEmail.Text == string.Empty)
            {
                txtCorporateEmail.Focus();
                errorProvider1.SetError(txtCorporateEmail, "Required!");
                return false;
            }
            else if (txtHeadOfficeAddress.Text == string.Empty)
            {
                txtHeadOfficeAddress.Focus();
                errorProvider1.SetError(txtHeadOfficeAddress, "Required!");
                return false;
            }
            else if (txtLCDepartment.Text == string.Empty)
            {
                txtLCDepartment.Focus();
                errorProvider1.SetError(txtLCDepartment, "Required!");
                return false;
            }
            else if (txtLCDContractPerson.Text == string.Empty)
            {
                txtLCDContractPerson.Focus();
                errorProvider1.SetError(txtLCDContractPerson, "Required!");
                return false;
            }
            else if (txtContactPersonMobile.Text == string.Empty)
            {
                txtContactPersonMobile.Focus();
                errorProvider1.SetError(txtContactPersonMobile, "Required!");
                return false;
            }
            else if (txtContactPersonEmail.Text == string.Empty)
            {
                txtContactPersonEmail.Focus();
                errorProvider1.SetError(txtContactPersonEmail, "Required!");
                return false;
            }
            else if (rchtxtSLA.Text == string.Empty)
            {
                rchtxtSLA.Focus();
                errorProvider1.SetError(rchtxtSLA, "Required!");
                return false;
            }
            else
            {
                return true;
            }

        }

        private void frmCorporateClient_Load(object sender, EventArgs e)
        {

        }
        private bool ValidateCorporateName()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtCorporateName.Text ==string.Empty)
            {
                errorProvider1.SetError(txtCorporateName, "Please enter corporate name");
                bStatus = false;
            }
            else if (Regex.IsMatch(txtCorporateName.Text, @"^\+?\d[\d -][0-9][0-9 ]*$"))
            {
                errorProvider1.SetError(txtCorporateName, "Please enter valid corporate name");
                bStatus = false;

            }
            else if (!Regex.IsMatch(txtCorporateName.Text, @"[a-zA-Z0-9!$* \t\r\n\-]"))
            {

                errorProvider1.SetError(txtCorporateName, "Please enter valid corporate name");
                bStatus = false;

            }
            else
                errorProvider1.SetError(txtCorporateName,string.Empty);
            return bStatus;
        }
        private bool ValidateAddress()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (rchtxtAddress.Text ==string.Empty)
            {
                errorProvider1.SetError(rchtxtAddress, "Please enter address");
                bStatus = false;
            }
            else if (Regex.IsMatch(rchtxtAddress.Text, @"^\+?\d[\d -][0-9][0-9 ]*$"))
            {
                errorProvider1.SetError(rchtxtAddress, "Please enter valid address");
                bStatus = false;

            }
            else if (!Regex.IsMatch(rchtxtAddress.Text, @"[a-zA-Z0-9!$* \t\r\n\-]"))
            {

                errorProvider1.SetError(rchtxtAddress, "Please enter valid address");
                bStatus = false;

            }
            else
                errorProvider1.SetError(rchtxtAddress,string.Empty);
            return bStatus;
        }
        private bool ValidateCoporatePhoneNumber()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtPhoneNumber.Text ==string.Empty)
            {
                errorProvider1.SetError(txtPhoneNumber, "Please enter phone number");
                bStatus = false;
            }
            else if (!Regex.IsMatch(txtPhoneNumber.Text, @"^\+?\d[\d -]{7,12}\d$"))
            {

                errorProvider1.SetError(txtPhoneNumber, "Please enter valid phone number");
                bStatus = false;

            }
            else
                errorProvider1.SetError(txtPhoneNumber,string.Empty);
            return bStatus;
        }
        private bool ValidateCoporateEmail()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtCorporateEmail.Text ==string.Empty)
            {
                errorProvider1.SetError(txtCorporateEmail, "Please enter email address");
                bStatus = false;
            }
            else if (!Regex.IsMatch(txtCorporateEmail.Text, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
            {

                errorProvider1.SetError(txtCorporateEmail, "Please enter valid email");
                bStatus = false;

            }
            else
                errorProvider1.SetError(txtCorporateEmail,string.Empty);
            return bStatus;
        }
        private bool ValidateHeadOfficeAddress()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtHeadOfficeAddress.Text ==string.Empty)
            {
                errorProvider1.SetError(txtHeadOfficeAddress, "Please enter head office address");
                bStatus = false;
            }
            else if (Regex.IsMatch(txtHeadOfficeAddress.Text, @"^\+?\d[\d -][0-9][0-9 ]*$"))
            {
                errorProvider1.SetError(txtHeadOfficeAddress, "Please enter valid address");
                bStatus = false;

            }
            else if (!Regex.IsMatch(txtHeadOfficeAddress.Text, @"[a-zA-Z0-9!$* \t\r\n\-]"))
            {

                errorProvider1.SetError(txtHeadOfficeAddress, "Please enter valid address");
                bStatus = false;

            }
            else
                errorProvider1.SetError(txtHeadOfficeAddress,string.Empty);
            return bStatus;
        }
        private bool ValidateLCDepartment()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtLCDepartment.Text ==string.Empty)
            {
                errorProvider1.SetError(txtLCDepartment, "Please enter LC Department");
                bStatus = false;
            }
            else if (Regex.IsMatch(txtLCDepartment.Text, @"^\+?\d[\d -][0-9][0-9 ]*$"))
            {
                errorProvider1.SetError(txtLCDepartment, "Please enter valid department");
                bStatus = false;

            }
            else if (!Regex.IsMatch(txtLCDepartment.Text, @"[a-zA-Z0-9!$* \t\r\n\-]"))
            {

                errorProvider1.SetError(txtLCDepartment, "Please enter valid data");
                bStatus = false;

            }
            else
                errorProvider1.SetError(txtLCDepartment,string.Empty);
            return bStatus;
        }
        private bool ValidateLCDContractPerson()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtLCDContractPerson.Text ==string.Empty)
            {
                errorProvider1.SetError(txtLCDContractPerson, "Please enter contract person name");
                bStatus = false;
            }
            else if (!Regex.IsMatch(txtLCDContractPerson.Text, @"^[a-zA-Z\\s]+"))
            {

                errorProvider1.SetError(txtLCDContractPerson, "Please enter valid name");
                bStatus = false;

            }
            else
                errorProvider1.SetError(txtLCDContractPerson,string.Empty);
            return bStatus;
        }
        private bool ValidateContactPersonMobile()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtContactPersonMobile.Text ==string.Empty)
            {
                errorProvider1.SetError(txtContactPersonMobile, "Please enter mobile number");
                bStatus = false;
            }
            else if (!Regex.IsMatch(txtContactPersonMobile.Text, @"^\+?\d[\d -]{7,12}\d$"))
            {

                errorProvider1.SetError(txtContactPersonMobile, "Please enter valid phone number");
                bStatus = false;

            }
            else
                errorProvider1.SetError(txtContactPersonMobile,string.Empty);
            return bStatus;
        }
        private bool ValidateContactPersonPhone()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtContactPersonPhone.Text !=string.Empty)
            {
                if (!Regex.IsMatch(txtContactPersonPhone.Text, @"^\+?\d[\d -]{7,12}\d$"))
                {

                    errorProvider1.SetError(txtContactPersonPhone, "Please enter valid phone number");
                    bStatus = false;

                }
            }
            else
                errorProvider1.SetError(txtContactPersonPhone,string.Empty);
            return bStatus;
        }
        private bool ValidateContactPersonEmail()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtContactPersonEmail.Text ==string.Empty)
            {
                errorProvider1.SetError(txtContactPersonEmail, "Please enter email address");
                bStatus = false;
            }
            else if (!Regex.IsMatch(txtContactPersonEmail.Text, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
            {

                errorProvider1.SetError(txtContactPersonEmail, "Please enter valid email");
                bStatus = false;

            }
            else
                errorProvider1.SetError(txtContactPersonEmail,string.Empty);
            return bStatus;
        }
        private bool ValidateSLA()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (rchtxtSLA.Text ==string.Empty)
            {
                errorProvider1.SetError(rchtxtSLA, "Please enter SLA");
                bStatus = false;
            }
            else if (!Regex.IsMatch(rchtxtSLA.Text, @"^(?:\S|[^\S\r\n]|\r?\n){0,1500}$"))
            {

                errorProvider1.SetError(rchtxtSLA, "SLA has exceeded maximum length");
                bStatus = false;

            }
            else
                errorProvider1.SetError(rchtxtSLA,string.Empty);
            return bStatus;
        }

        private void txtCorporateName_Validating(object sender, CancelEventArgs e)
        {
            ValidateCorporateName();
        }

        private void rchtxtAddress_Validating(object sender, CancelEventArgs e)
        {
            ValidateAddress();

        }

        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            ValidateCoporatePhoneNumber();

        }

        private void txtCorporateEmail_Validating(object sender, CancelEventArgs e)
        {
            ValidateCoporateEmail();

        }

        private void txtHeadOfficeAddress_Validating(object sender, CancelEventArgs e)
        {
            ValidateHeadOfficeAddress();

        }

        private void txtLCDepartment_Validating(object sender, CancelEventArgs e)
        {
            ValidateLCDepartment();

        }

        private void txtLCDContractPerson_Validating(object sender, CancelEventArgs e)
        {
            ValidateLCDContractPerson();

        }

        private void txtContactPersonMobile_Validating(object sender, CancelEventArgs e)
        {
            ValidateContactPersonMobile();
        }

        private void txtContactPersonPhone_Validating(object sender, CancelEventArgs e)
        {
            ValidateContactPersonPhone();
        }

        private void txtContactPersonEmail_Validating(object sender, CancelEventArgs e)
        {
            ValidateContactPersonEmail();
        }

        private void rchtxtSLA_Validating(object sender, CancelEventArgs e)
        {
            ValidateSLA();
        }

       
    }
}
