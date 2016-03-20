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
using CourierBackOfficeManagement.Country;
using CourierManagement;

namespace CourierBackOfficeManagement
{
    public partial class frmCountry : Form
    {
        public frmCountry()
        {
            InitializeComponent();
            lblCountryID.Text = "0";

        }
        public frmCountry(int countryID)
        {
            InitializeComponent();
            Country.CountryWebService objWebService = new Country.CountryWebService();
            CountryInfo objInfo = new CountryInfo();
            objInfo.CountryID = countryID;
            objInfo = objWebService.CountryNameGetByID(objInfo.CountryID, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
            lblCountryID.Text = objInfo.CountryID.ToString();
            txtCountryName.Text = objInfo.CountryName;

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
                    Country.CountryWebService obj = new Country.CountryWebService();
                    CountryInfo objInfo = new CountryInfo();
                    objInfo.CountryName = txtCountryName.Text;
                    int Id = Convert.ToInt32(lblCountryID.Text);
                    if (Id == 0)
                    {
                        objInfo.AddedBy = GetLoginUser.UserName;
                        obj.CountryNameAdd(objInfo, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
                        MessageBox.Show("Data Saved Successfully...");
                    }
                    else
                    {
                        objInfo.EditedBy = GetLoginUser.UserName;
                        objInfo.CountryID = Id;
                        obj.CountryNameUpdate(objInfo, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
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
        private void ClearField()
        {
            txtCountryName.Text = string.Empty;
        }

        private void txtCountryName_Validating(object sender, CancelEventArgs e)
        {
            ValidateCountryName();

        }
        private bool ValidateCountryName()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtCountryName.Text == string.Empty)
            {
                errorProvider1.SetError(txtCountryName, "Please Enter Country Name");
                bStatus = false;
            }
            else if (!Regex.IsMatch(txtCountryName.Text, @"^[a-zA-Z ]+$"))
            {

                errorProvider1.SetError(txtCountryName, "Please Enter valid name");
                bStatus = false;

            }
            else
                errorProvider1.SetError(txtCountryName, string.Empty);
            return bStatus;
        }
        private bool ValidateForm()
        {
            if (txtCountryName.Text == string.Empty)
            {
                txtCountryName.Focus();
                errorProvider1.SetError(txtCountryName, "Required!");
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
