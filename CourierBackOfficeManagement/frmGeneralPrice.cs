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
using CourierBackOfficeManagement.GeneralCourierPrice;
using CourierManagement;

namespace CourierBackOfficeManagement
{
    public partial class frmGeneralPrice : Form
    {
        public frmGeneralPrice()
        {
            InitializeComponent();
            LoadLocationName();
            lblGeneralCourierPriceID.Text = "0";

        }
        public frmGeneralPrice(int generalCourierPriceID)
        {
            InitializeComponent();
            LoadLocationName();
            GeneralCourierPrice.GeneralCourierPriceWebService objWebService = new GeneralCourierPrice.GeneralCourierPriceWebService();
            GeneralCourierPriceInfo objInfo = new GeneralCourierPriceInfo();
            objInfo.GeneralCourierPriceID = generalCourierPriceID;
            objInfo = objWebService.GetGeneralCourierPriceByID(objInfo.GeneralCourierPriceID, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
            cmbFrom.SelectedValue = objInfo.FromID;
            cmbTo.SelectedValue = objInfo.ToID;
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
            int packageTypeId = objInfo.PackageTypeID;
            {
                if (packageTypeId == 1)
                {
                    rbGood.Checked = true;
                }
                else
                {
                    rbDocument.Checked = true;
                }
            }
            txtPrice.Text = objInfo.PricePerKG.ToString();
            lblGeneralCourierPriceID.Text = objInfo.GeneralCourierPriceID.ToString();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void LoadLocationName()
        {
            GeneralCourierPrice.GeneralCourierPriceWebService objWebService = new GeneralCourierPrice.GeneralCourierPriceWebService();
            cmbFrom.DataSource = objWebService.GetAllLocation(TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
            cmbTo.DataSource = objWebService.GetAllLocation(TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
            cmbFrom.ValueMember = "LocationID";
            cmbFrom.DisplayMember = "LocationName";
            cmbTo.ValueMember = "LocationID";
            cmbTo.DisplayMember = "LocationName";

        }
        private void frmGeneralPrice_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    GeneralCourierPrice.GeneralCourierPriceWebService objWebService = new GeneralCourierPrice.GeneralCourierPriceWebService();
                    GeneralCourierPriceInfo objInfo = new GeneralCourierPriceInfo();
                    objInfo.FromID = Convert.ToInt32(cmbFrom.SelectedValue);
                    objInfo.ToID = Convert.ToInt32(cmbTo.SelectedValue);
                    int serviceTypeId = 0;
                    bool isChecked = rbOnAir.Checked;
                    if (isChecked)
                        serviceTypeId = 1;

                    else
                    {
                        serviceTypeId = 2;
                    }


                    objInfo.ServiceTypeID = serviceTypeId;
                    int packageTypeId = 0;
                    bool isCheckedPackageId = rbGood.Checked;
                    if (isCheckedPackageId)
                        packageTypeId = 1;
                    else
                    {
                        packageTypeId = 2;
                    }
                    objInfo.PackageTypeID = packageTypeId;
                    objInfo.PricePerKG = Convert.ToDecimal(txtPrice.Text);


                    int generalCourierPriceID = Convert.ToInt32(lblGeneralCourierPriceID.Text);
                    if (generalCourierPriceID == 0)
                    {
                        objInfo.AddedBy = GetLoginUser.UserName;
                        objWebService.AddGeneralCourierPrice(objInfo, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
                        MessageBox.Show("Data saved successfully");

                    }
                    else if (generalCourierPriceID != 0)
                    {
                        objInfo.GeneralCourierPriceID = generalCourierPriceID;
                        objInfo.EditedBy = GetLoginUser.UserName;
                        objWebService.UpdateGeneralCourierPrice(objInfo, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
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
            txtPrice.Text = string.Empty;
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
            else if (txtPrice.Text == string.Empty)
            {
                txtPrice.Focus();
                errorProvider1.SetError(txtPrice, "Required!");
                return false;
            }

            else
            {
                return true;
            }

        }

        private void cmbFrom_Validating(object sender, CancelEventArgs e)
        {
            ValidateFromLocation();
        }

        private void cmbTo_Validating(object sender, CancelEventArgs e)
        {
            ValidateToLocation();
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            ValidatePrice();
        }
        private bool ValidateFromLocation()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (cmbFrom.Text == string.Empty)
            {
                errorProvider1.SetError(cmbFrom, "Please Select Location Name");
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
                errorProvider1.SetError(cmbTo, "Please Select Location Name");
                bStatus = false;
            }
            else
                errorProvider1.SetError(cmbTo, string.Empty);
            return bStatus;
        }
        private bool ValidatePrice()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtPrice.Text == string.Empty)
            {
                errorProvider1.SetError(txtPrice, "Please Enter Price");
                bStatus = false;
            }
            else if (!Regex.IsMatch(txtPrice.Text, @"[0-9]*\.?[0-9]"))
            {

                errorProvider1.SetError(txtPrice, "Please enter valid integer or decimal number");
                bStatus = false;

            }
            else
                errorProvider1.SetError(txtPrice, string.Empty);
            return bStatus;
        }
    }
}
