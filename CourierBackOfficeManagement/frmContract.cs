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
using CourierBackOfficeManagement.CorporateClientLocation;
using CourierManagement;

namespace CourierBackOfficeManagement
{
    public partial class frmContract : Form
    {
        public frmContract()
        {
            InitializeComponent();
            LoadLocationName();
        }
        public frmContract(int corporateClientLocationId, int corporateClientID)
        {
            InitializeComponent();
            LoadLocationName();
            monthCalendar1.Visible = false;
            monthCalendar2.Visible = false;
            CorporateClientLocation.CorporateClientLocationWebService objWebService = new CorporateClientLocation.CorporateClientLocationWebService();
            CorporateClientLocationInfo objInfo = new CorporateClientLocationInfo();
            objInfo.CorporateClientLocationID = corporateClientLocationId;
            objInfo.CorporateClientID = corporateClientID;
            objInfo = objWebService.CorporateClientLocationGetByID(objInfo.CorporateClientLocationID, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
            lblCorporateClientLocationId.Text = objInfo.CorporateClientLocationID.ToString();
            lblCorporateClientID.Text = objInfo.CorporateClientID.ToString();
            cmbFrom.SelectedValue = objInfo.FromLocationID;
            cmbTo.SelectedValue = objInfo.ToLocationID;
            int serviceTypeId = objInfo.ServiceTypeID;
            {
                if (serviceTypeId == 1)
                {
                    rbOnAir.Checked = true;
                }
                else
                {
                    rbByLand.Checked = true;
                }
            }
            int weightUnitId = objInfo.WeightUnitID;
            {
                if (weightUnitId == 1)
                {
                    rbPerKg.Checked = true;
                }
                else
                {
                    rbPerGm.Checked = true;
                }
            }
            txtCharge.Text = objInfo.Charge.ToString();
            rchtxtContractDescription.Text = objInfo.ContractDiscription;
            txtContractDate.Text = objInfo.ContractDate.ToShortDateString();
            txtContractExpireDate.Text = objInfo.ContractExpireDate.ToShortDateString();
            

        }
        public frmContract(int corporateClientId)
        {
            InitializeComponent();
            LoadLocationName();
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar2.MaxSelectionCount = 1;
            monthCalendar1.Visible = false;
            monthCalendar2.Visible = false;
            CorporateClientLocationInfo objInfo = new CorporateClientLocationInfo();
            lblCorporateClientID.Text = Convert.ToString(corporateClientId);
            lblCorporateClientLocationId.Text = "0";

        }

        private void frmContract_Load(object sender, EventArgs e)
        {
            

        }


        private void LoadLocationName()
        {
            Location.LocationWebService objWebService = new CourierBackOfficeManagement.Location.LocationWebService();
            cmbFrom.DataSource = objWebService.LocationNameGetAll(TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
            cmbTo.DataSource = objWebService.LocationNameGetAll(TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
            cmbFrom.ValueMember = "LocationID";
            cmbFrom.DisplayMember = "LocationName";
            cmbTo.ValueMember = "LocationID";
            cmbTo.DisplayMember = "LocationName";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    CorporateClientLocation.CorporateClientLocationWebService objWebService = new CorporateClientLocation.CorporateClientLocationWebService();
                    CorporateClientLocationInfo objInfo = new CorporateClientLocationInfo();
                    objInfo.FromLocationID = Convert.ToInt32(cmbFrom.SelectedValue);
                    objInfo.ToLocationID = Convert.ToInt32(cmbTo.SelectedValue);
                    int serviceTypeId = 0;
                    bool isChecked = rbOnAir.Checked;
                    if (isChecked)
                        serviceTypeId = 1;

                    else
                    {
                        serviceTypeId = 2;
                    }


                    objInfo.ServiceTypeID = serviceTypeId;
                    int weightUnitId = 0;
                    bool isCheckedWeight = rbPerKg.Checked;
                    if (isCheckedWeight)
                        weightUnitId = 1;
                    else
                    {
                        weightUnitId = 2;
                    }
                    objInfo.WeightUnitID = weightUnitId;
                    objInfo.Charge = Convert.ToDecimal(txtCharge.Text);
                    objInfo.ContractDiscription = rchtxtContractDescription.Text;
                    objInfo.ContractDate = Convert.ToDateTime(txtContractDate.Text);
                    objInfo.ContractExpireDate = Convert.ToDateTime(txtContractExpireDate.Text);

                    int corporateClientId = Convert.ToInt32(lblCorporateClientID.Text);
                    int clientLocationId = Convert.ToInt32(lblCorporateClientLocationId.Text);
                    if (clientLocationId == 0 && corporateClientId != 0)
                    {
                        objInfo.AddedBy = GetLoginUser.UserName;
                        objInfo.CorporateClientID = Convert.ToInt32(lblCorporateClientID.Text);
                        objWebService.CorporateClientLocationAdd(objInfo, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
                        MessageBox.Show("Data saved successfully...");

                    }
                    else if (clientLocationId != 0 && corporateClientId != 0)
                    {
                        objInfo.EditedBy = GetLoginUser.UserName;
                        objInfo.CorporateClientLocationID = clientLocationId;
                        objInfo.CorporateClientID = corporateClientId;
                        objWebService.CorporateClientLocationUpdate(objInfo, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
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

        private void ClearField()
        {
            cmbFrom.SelectedItem = string.Empty;
            cmbTo.SelectedItem = string.Empty;
            txtCharge.Text = string.Empty;
            rchtxtContractDescription.Text = string.Empty;
            txtContractDate.Text = string.Empty;
            txtContractExpireDate.Text = string.Empty;
        }
        private bool ValidateForm()
        {
            if (cmbFrom.Text == string.Empty)
            {
                cmbFrom.Focus();
                errorProvider1.SetError(cmbFrom, "Required!");
                return false;
            }
            else if (cmbTo.Text == string.Empty)
            {
                cmbTo.Focus();
                errorProvider1.SetError(cmbTo, "Required!");
                return false;
            }
            else if (txtCharge.Text == string.Empty)
            {
                txtCharge.Focus();
                errorProvider1.SetError(txtCharge, "Required!");
                return false;
            }
            else if (rchtxtContractDescription.Text == string.Empty)
            {
                rchtxtContractDescription.Focus();
                errorProvider1.SetError(rchtxtContractDescription, "Required!");
                return false;
            }
            else if (txtContractDate.Text == string.Empty)
            {
                txtContractDate.Focus();
                errorProvider1.SetError(txtContractDate, "Required!");
                return false;
            }
            else if (txtContractExpireDate.Text == string.Empty)
            {
                txtContractExpireDate.Focus();
                errorProvider1.SetError(txtContractExpireDate, "Required!");
                return false;
            }
            else
            {
                return true;
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void txtContractDate_Enter(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;

        }

        private void txtContractDate_Leave(object sender, EventArgs e)
        {
            
                monthCalendar1.Visible = false;

        }

        private void txtContractExpireDate_Enter(object sender, EventArgs e)
        {
            monthCalendar2.Visible = true;


        }

        private void txtContractExpireDate_Leave(object sender, EventArgs e)
        {
            
                monthCalendar2.Visible = false;

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            var monthCalendar = sender as MonthCalendar;
            txtContractDate.Text = monthCalendar.SelectionRange.Start.ToShortDateString();

        }

        private void monthCalendar1_Leave(object sender, EventArgs e)
        {
            var monthCalendar = sender as MonthCalendar;
            monthCalendar.Visible = false;

        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            var monthCalendar = sender as MonthCalendar;
            txtContractExpireDate.Text = monthCalendar.SelectionRange.Start.ToShortDateString();
        }

        private void monthCalendar2_Leave(object sender, EventArgs e)
        {
            var monthCalendar = sender as MonthCalendar;
            monthCalendar.Visible = false;


        }

        private void txtCharge_Validating(object sender, CancelEventArgs e)
        {
            ValidateCharge();
        }
        private bool ValidateCharge()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtCharge.Text == string.Empty)
            {
                errorProvider1.SetError(txtCharge, "Please Enter Charge");
                bStatus = false;
            }
            else if (!Regex.IsMatch(txtCharge.Text, @"[0-9]*\.?[0-9]*"))
            {

                errorProvider1.SetError(txtCharge, "Please enter valid integer or decimal number");
                bStatus = false;

            }
            else
                errorProvider1.SetError(txtCharge, string.Empty);
            return bStatus;
        }

        private void rchtxtContractDescription_Validating(object sender, CancelEventArgs e)
        {
            ValidateContractDescription();

        }
        private bool ValidateContractDescription()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (rchtxtContractDescription.Text == string.Empty)
            {
                errorProvider1.SetError(rchtxtContractDescription, "Please enter contract description");
                bStatus = false;
            }
            else if (!Regex.IsMatch(rchtxtContractDescription.Text, @"^(?:\S|[^\S\r\n]|\r?\n){0,1500}$"))
            {

                errorProvider1.SetError(rchtxtContractDescription, "Maximum length exceeded");
                bStatus = false;

            }
            else
                errorProvider1.SetError(rchtxtContractDescription, string.Empty);
            return bStatus;
        }
        private bool ValidateContractDate()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtContractDate.Text == string.Empty)
            {
                errorProvider1.SetError(txtContractDate, "Please enter contract date");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtContractDate, string.Empty);
            return bStatus;

        }
        private bool ValidateFromLocation()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (cmbFrom.Text == string.Empty)
            {
                errorProvider1.SetError(cmbFrom, "Please select location");
                bStatus = false;
            }
            else
                errorProvider1.SetError(cmbFrom, string.Empty);
            return bStatus;

        }
        private bool ValidateToLocation()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (cmbTo.Text == string.Empty)
            {
                errorProvider1.SetError(cmbTo, "Please select location");
                bStatus = false;
            }
            else
                errorProvider1.SetError(cmbTo, string.Empty);
            return bStatus;

        }
        private bool ValidateContractExpireDate()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtContractExpireDate.Text == string.Empty)
            {
                errorProvider1.SetError(txtContractExpireDate, "Please enter contract expire date");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtContractExpireDate, string.Empty);
            return bStatus;

        }

        private void txtContractDate_Validating(object sender, CancelEventArgs e)
        {
            ValidateContractDate();

        }

        private void txtContractExpireDate_Validating(object sender, CancelEventArgs e)
        {
            ValidateContractExpireDate();
        }

        private void cmbFrom_Validating(object sender, CancelEventArgs e)
        {
            ValidateFromLocation();

        }

        private void cmbTo_Validating(object sender, CancelEventArgs e)
        {
            ValidateToLocation();
        }
    }
}
