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
    public partial class frmPopUpState : Form
    {
        public frmPopUpState(int countryID)
        {
            InitializeComponent();
            lblCountryID.Text = countryID.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    State.StateWebService objWebService = new State.StateWebService();
                    StateInfo objInfo = new StateInfo();
                    objInfo.CountryID = Convert.ToInt32(lblCountryID.Text);
                    objInfo.StateName = txtStateName.Text;
                    objInfo.AddedBy = GetLoginUser.UserName;
                    objWebService.StateNameAdd(objInfo, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
                    MessageBox.Show("State Name Added Successfully");
                    txtStateName.Text = string.Empty;    

                }
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                throw ex;
            }
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
        private bool ValidateForm()
        {
            if (txtStateName.Text == string.Empty)
            {
                txtStateName.Focus();
                errorProvider1.SetError(txtStateName, "Required!");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
