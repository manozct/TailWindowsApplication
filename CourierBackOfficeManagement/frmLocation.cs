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
using CourierBackOfficeManagement.Location;
using CourierManagement;

namespace CourierBackOfficeManagement
{
    public partial class frmLocation : Form
    {
        public frmLocation()
        {
            InitializeComponent();
            this.ActiveControl = lblCountryID;
            lblCountryID.Text = "0";
            lblStateID.Text = "0";
            lblLocationID.Text = "0";           
            LoadCountry();

        }
        public frmLocation(int locationID)
        {
            InitializeComponent();
            LoadCountry();
            Location.LocationWebService objWebService = new Location.LocationWebService();
            LocationInfo objInfo = new LocationInfo();
            objInfo.LocationID = locationID;
            objInfo = objWebService.LocationNameGetByID(objInfo.LocationID, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
            cmbCountryName.SelectedValue = objInfo.CountryID;
            cmbStateName.SelectedValue = objInfo.StateID;
            txtLocationName.Text = objInfo.LocationName;
            lblCountryID.Text = objInfo.LocationID.ToString();
            lblStateID.Text = objInfo.StateID.ToString();
            lblLocationID.Text = objInfo.LocationID.ToString();           


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }
        private void LoadCountry()
        {
            Country.CountryWebService objWebService = new Country.CountryWebService();
            cmbCountryName.DataSource = objWebService.CountryNameGetAll(TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
            cmbCountryName.ValueMember = "CountryID";
            cmbCountryName.DisplayMember = "CountryName";

        }
        private void LoadStateNameByCountryId()
        {
            State.StateWebService objWebService = new State.StateWebService();
            int countryID;
            bool parseOK = Int32.TryParse(cmbCountryName.SelectedValue.ToString(), out countryID);
            cmbStateName.DataSource = objWebService.StateNameGetByCountryID(countryID, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
            cmbStateName.ValueMember = "StateID";
            cmbStateName.DisplayMember = "StateName";
        }
        
        private void cmbCountryName_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbStateName.DataSource = null;
            LoadStateNameByCountryId();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    Location.LocationWebService objWebService = new Location.LocationWebService();
                    LocationInfo objInfo = new LocationInfo();
                    objInfo.CountryID = Convert.ToInt32(cmbCountryName.SelectedValue);
                    objInfo.StateID = Convert.ToInt32(cmbStateName.SelectedValue);
                    objInfo.LocationName = txtLocationName.Text;
                    int countryId = objInfo.CountryID;
                    int stateId = objInfo.StateID;
                    int locationId = Convert.ToInt32(lblLocationID.Text);
                    if (countryId != 0 && stateId != 0 && locationId == 0)
                    {
                        objInfo.AddedBy = GetLoginUser.UserName;
                        objWebService.LocationNameAdd(objInfo, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
                        MessageBox.Show("Data saved successfully");
                    }
                    else if (countryId != 0 && stateId != 0 && locationId != 0)
                    {
                        objInfo.CountryID = countryId;
                        objInfo.StateID = stateId;
                        objInfo.LocationID = locationId;
                        objInfo.EditedBy = GetLoginUser.UserName;
                        objWebService.LocationNameUpdate(objInfo, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
                        MessageBox.Show("Data updated successfully");
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
        private bool ValidateForm()
        {
            if (txtLocationName.Text == string.Empty)
            {
                txtLocationName.Focus();
                errorProvider1.SetError(txtLocationName, "Required!");
                return false;
            }
            else if (cmbCountryName.Text == string.Empty)
            {
                cmbCountryName.Focus();
                errorProvider1.SetError(cmbCountryName, "Required!");
                return false;
            }
            else if (cmbStateName.Text == string.Empty)
            {
                cmbStateName.Focus();
                errorProvider1.SetError(cmbStateName, "Required!");
                return false;
            }

            else
            {
                return true;
            }

        }
        private void ClearField()
        {
            txtLocationName.Text = string.Empty;
        }
        private void cmbCountryName_Validating(object sender, CancelEventArgs e)
        {
            ValidateCountryName();

        }

        private void cmbStateName_Validating(object sender, CancelEventArgs e)
        {
            ValidateStateName();

        }

        private void txtLocationName_Validating(object sender, CancelEventArgs e)
        {
            ValidateLocationName();
        }
        private bool ValidateCountryName()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (cmbCountryName.Text == string.Empty)
            {
                errorProvider1.SetError(cmbCountryName, "Please Select Country Name");
                bStatus = false;
            }
            else
                errorProvider1.SetError(cmbCountryName, string.Empty);
            return bStatus;
        }
        private bool ValidateStateName()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (cmbStateName.Text == string.Empty)
            {
                errorProvider1.SetError(cmbStateName, "Please Select State Name");
                bStatus = false;
            }
            else
                errorProvider1.SetError(cmbStateName, string.Empty);
            return bStatus;
        }
        private bool ValidateLocationName()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtLocationName.Text == string.Empty)
            {
                errorProvider1.SetError(txtLocationName, "Please Enter Location Name");
                bStatus = false;
            }
            else if (Regex.IsMatch(txtLocationName.Text, @"^\+?\d[\d -][0-9][0-9 ]*$"))
            {
                errorProvider1.SetError(txtLocationName, "Please Enter Valid Location");
                bStatus = false;

            }
            else if (!Regex.IsMatch(txtLocationName.Text, @"[a-zA-Z0-9!$* \t\r\n\-]"))
            {

                errorProvider1.SetError(txtLocationName, "Please Enter Valid Location");
                bStatus = false;

            }
            else
                errorProvider1.SetError(txtLocationName, string.Empty);
            return bStatus;
        }

        private void btnAddState_Click(object sender, EventArgs e)
        {
            int countryId = Convert.ToInt32(cmbCountryName.SelectedValue);
            frmPopUpState objFrm = new frmPopUpState(countryId);
            objFrm.ShowDialog();
            cmbStateName.DataSource = null;
            LoadStateNameByCountryId();

        }

        private void frmLocation_Load(object sender, EventArgs e)
        {

        }
    }
}
