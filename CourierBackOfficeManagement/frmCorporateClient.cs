using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourierBackOfficeManagement.CorporateClient;


namespace CourierBackOfficeManagement
{
    public partial class frmCorporateClient : Form
    {


        public frmCorporateClient()
        {
            InitializeComponent();

            lblCorporateClientId.Text = "0";
            Placeholder();
            this.ActiveControl = lblCorporateClientId;




        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmGridCorporateClient objGrid = new frmGridCorporateClient();
            objGrid.Show();





        }



        private void txtCorporateName_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtCorporateName_Leave(object sender, EventArgs e)
        {
            if (txtCorporateName.Text == "")
            {
                txtCorporateName.Text = "Corporate Name";
                txtCorporateName.ForeColor = Color.Gray;
            }
        }

        private void txtCorporateName_Enter(object sender, EventArgs e)
        {
            txtCorporateName.Text = "";
            txtCorporateName.ForeColor = Color.Black;

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_Enter(object sender, EventArgs e)
        {
            txtPhoneNumber.Text = "";
            txtPhoneNumber.ForeColor = Color.Black;

        }

        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text == "")
            {
                txtPhoneNumber.Text = "Phone Number";
                txtPhoneNumber.ForeColor = Color.Gray;
            }

        }
        public void Placeholder()
        {
            txtCorporateName.Text = "Corporate Name";
            txtCorporateName.ForeColor = Color.Gray;
            txtPhoneNumber.Text = "Phone Number";
            txtPhoneNumber.ForeColor = Color.Gray;
            txtHeadOfficeAddress.Text = "Head Office Address";
            txtHeadOfficeAddress.ForeColor = Color.Gray;
            txtLCDContractPerson.Text = "LCD Contract Person";
            txtLCDContractPerson.ForeColor = Color.Gray;
            txtContactPersonPhone.Text = "Contact Person Phone";
            txtContactPersonPhone.ForeColor = Color.Gray;
            rchtxtAddress.Text = "Address";
            rchtxtAddress.ForeColor = Color.Gray;
            txtCorporateEmail.Text = "Corporate Email";
            txtCorporateEmail.ForeColor = Color.Gray;
            txtLCDepartment.Text = "LC Department";
            txtLCDepartment.ForeColor = Color.Gray;
            txtContactPersonMobile.Text = "Contact Person Mobile";
            txtContactPersonMobile.ForeColor = Color.Gray;
            txtContactPersonEmail.Text = "Contact Person Email";
            txtContactPersonEmail.ForeColor = Color.Gray;
            rchtxtSLA.Text = "SLA (not more than 1500 words)...";
            rchtxtSLA.ForeColor = Color.Gray;

        }



        private void txtHeadOfficeAddress_Leave(object sender, EventArgs e)
        {
            if (txtHeadOfficeAddress.Text == "")
            {
                txtHeadOfficeAddress.Text = "Head Office Address";
                txtHeadOfficeAddress.ForeColor = Color.Gray;
            }

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHeadOfficeAddress_Enter(object sender, EventArgs e)
        {
            txtHeadOfficeAddress.Text = "";
            txtHeadOfficeAddress.ForeColor = Color.Black;

        }

        private void txtLCDContractPerson_Enter(object sender, EventArgs e)
        {
            txtLCDContractPerson.Text = "";
            txtLCDContractPerson.ForeColor = Color.Black;

        }

        private void txtLCDContractPerson_Leave(object sender, EventArgs e)
        {
            if (txtLCDContractPerson.Text == "")
            {
                txtLCDContractPerson.Text = "LCD Contract Person";
                txtLCDContractPerson.ForeColor = Color.Gray;
            }

        }

        private void txtContactPersonPhone_Enter(object sender, EventArgs e)
        {
            txtContactPersonPhone.Text = "";
            txtContactPersonPhone.ForeColor = Color.Black;


        }

        private void txtContactPersonPhone_Leave(object sender, EventArgs e)
        {
            if (txtContactPersonPhone.Text == "")
            {
                txtContactPersonPhone.Text = "Contact Person Phone";
                txtContactPersonPhone.ForeColor = Color.Gray;
            }


        }

        private void rchtxtAddress_Enter(object sender, EventArgs e)
        {
            rchtxtAddress.Text = "";
            rchtxtAddress.ForeColor = Color.Black;
        }

        private void rchtxtAddress_Leave(object sender, EventArgs e)
        {
            if (rchtxtAddress.Text == "")
            {
                rchtxtAddress.Text = "Address";
                rchtxtAddress.ForeColor = Color.Gray;
            }

        }

        private void txtCorporateEmail_Enter(object sender, EventArgs e)
        {
            txtCorporateEmail.Text = "";
            txtCorporateEmail.ForeColor = Color.Black;
        }

        private void txtCorporateEmail_Leave(object sender, EventArgs e)
        {
            if (txtCorporateEmail.Text == "")
            {
                txtCorporateEmail.Text = "Corporate Email";
                txtCorporateEmail.ForeColor = Color.Gray;
            }

        }

        private void txtLCDepartment_Enter(object sender, EventArgs e)
        {
            txtLCDepartment.Text = "";
            txtLCDepartment.ForeColor = Color.Black;

        }

        private void txtLCDepartment_Leave(object sender, EventArgs e)
        {
            if (txtLCDepartment.Text == "")
            {
                txtLCDepartment.Text = "LC Department";
                txtLCDepartment.ForeColor = Color.Gray;
            }


        }

        private void txtContactPersonMobile_Enter(object sender, EventArgs e)
        {
            txtContactPersonMobile.Text = "";
            txtContactPersonMobile.ForeColor = Color.Black;

        }

        private void txtContactPersonMobile_Leave(object sender, EventArgs e)
        {
            if (txtContactPersonMobile.Text == "")
            {
                txtContactPersonMobile.Text = "Contact Person Mobile";
                txtContactPersonMobile.ForeColor = Color.Gray;
            }

        }

        private void txtContactPersonEmail_Enter(object sender, EventArgs e)
        {
            txtContactPersonEmail.Text = "";
            txtContactPersonEmail.ForeColor = Color.Black;

        }

        private void txtContactPersonEmail_Leave(object sender, EventArgs e)
        {
            if (txtContactPersonEmail.Text == "")
            {
                txtContactPersonEmail.Text = "Contact Person Email";
                txtContactPersonEmail.ForeColor = Color.Gray;
            }

        }

        private void rchtxtSLA_Enter(object sender, EventArgs e)
        {
            rchtxtSLA.Text = "";
            rchtxtSLA.ForeColor = Color.Black;

        }

        private void rchtxtSLA_Leave(object sender, EventArgs e)
        {
            if (rchtxtSLA.Text == "")
            {
                rchtxtSLA.Text = "SLA (not more than 1500 words)...";
                rchtxtSLA.ForeColor = Color.Gray;
            }
        }

        private void frmCorporateClient_Load(object sender, EventArgs e)
        {




        }


        private void txtCorporateEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLCDepartment_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContactPersonMobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContactPersonEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
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


                    objCorporateClientInfo.AddedBy = "";
                    obj.CorporateClientAdd(objCorporateClientInfo, SystemSettings.AppToken);
                    MessageBox.Show("Data Saved Successfully...");
                    ClearField();
                    this.Close();
                }
                else
                {
                    objCorporateClientInfo.EditedBy = Convert.ToString(WindowsIdentity.GetCurrent());
                    objCorporateClientInfo.CorporateClientID = Id;
                    obj.CorporateClientUpdate(objCorporateClientInfo, SystemSettings.AppToken);
                    MessageBox.Show("Data Updated Successfully...");
                    ClearField();
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }




        }
        public void ClearField()
        {
            txtCorporateName.Text = "";
            rchtxtAddress.Text = "";
            txtPhoneNumber.Text = "";
            txtCorporateEmail.Text = "";
            txtHeadOfficeAddress.Text = "";
            txtLCDepartment.Text = "";
            txtLCDContractPerson.Text = "";
            txtContactPersonPhone.Text = "";
            txtContactPersonMobile.Text = "";
            txtContactPersonEmail.Text = "";
            rchtxtSLA.Text = "";
        }

        private void txtCorporateEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
