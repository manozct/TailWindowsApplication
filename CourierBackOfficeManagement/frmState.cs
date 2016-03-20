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
using CourierBackOfficeManagement.State;
using CourierManagement;

namespace CourierBackOfficeManagement
{
    public partial class frmState : Form
    {
        public frmState()
        {
            InitializeComponent();

            LoadCountry();
            lblStateID.Text = "0";
            lblCountryID.Text = "0";
            this.ActiveControl = lblCountryID;

        }
        public frmState(int stateID, int countryID)
        {
            InitializeComponent();
            LoadCountry();
            State.StateWebService objWebService = new State.StateWebService();
            StateInfo objInfo = new StateInfo();
            objInfo.StateID = stateID;
            objInfo.CountryID = countryID;
            objInfo = objWebService.StateNameGetByID(objInfo.StateID, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
            cmbCountryName.SelectedValue = objInfo.CountryID;
            txtStateName.Text = objInfo.StateName;
            lblCountryID.Text = objInfo.CountryID.ToString();
            lblStateID.Text = objInfo.StateID.ToString();
        }
        
        public void LoadCountry()
        {
            Country.CountryWebService objWebService = new Country.CountryWebService();
            cmbCountryName.DataSource = objWebService.CountryNameGetAll(TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
            cmbCountryName.ValueMember = "CountryID";
            cmbCountryName.DisplayMember = "CountryName";
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
                    State.StateWebService objWebService = new State.StateWebService();
                    StateInfo objInfo = new StateInfo();
                    objInfo.StateName = txtStateName.Text;
                    lblCountryID.Text = cmbCountryName.SelectedValue.ToString();
                    int stateID = Convert.ToInt32(lblStateID.Text);
                    int countryID = Convert.ToInt32(lblCountryID.Text);
                    if (stateID == 0 && countryID != 0)
                    {
                        objInfo.CountryID = Convert.ToInt32(cmbCountryName.SelectedValue);
                        objInfo.AddedBy = GetLoginUser.UserName;
                        objWebService.StateNameAdd(objInfo, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
                        MessageBox.Show("Data Saved Successfully");

                    }
                    else if (stateID != 0 && countryID != 0)
                    {
                        objInfo.StateID = stateID;
                        objInfo.CountryID = countryID;
                        objInfo.EditedBy = GetLoginUser.UserName;
                        objWebService.StateNameUpdate(objInfo, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
                        MessageBox.Show("Data Updated Successfully");

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
        private void ClearField()
        {
            txtStateName.Text = string.Empty;

        }

        private void cmbCountryName_Validating(object sender, CancelEventArgs e)
        {
            ValidateCountryName();
        }

        private void txtStateName_Validating(object sender, CancelEventArgs e)
        {
            ValidateStateName();
        }
        private bool ValidateStateName()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtStateName.Text == string.Empty)
            {
                errorProvider1.SetError(txtStateName, "Please enter state name");
                bStatus = false;
            }
            else if (!Regex.IsMatch(txtStateName.Text, @"^[a-zA-Z\\s]+"))
            {

                errorProvider1.SetError(txtStateName, "Please enter valid state name");
                bStatus = false;

            }
            else
                errorProvider1.SetError(txtStateName, string.Empty);
            return bStatus;
        }
        private bool ValidateCountryName()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (cmbCountryName.Text == string.Empty)
            {
                errorProvider1.SetError(cmbCountryName, "Please select country name");
                bStatus = false;
            }
            else
                errorProvider1.SetError(cmbCountryName, string.Empty);
            return bStatus;
        }
        private bool ValidateForm()
        {
            if (txtStateName.Text == string.Empty)
            {
                txtStateName.Focus();
                errorProvider1.SetError(txtStateName, "Required!");
                return false;
            }
            else if (cmbCountryName.Text == string.Empty)
            {
                cmbCountryName.Focus();
                errorProvider1.SetError(cmbCountryName, "Required!");
                return false;
            }

            else
            {
                return true;
            }

        }

        private void frmState_Load(object sender, EventArgs e)
        {

        }
    }
}
