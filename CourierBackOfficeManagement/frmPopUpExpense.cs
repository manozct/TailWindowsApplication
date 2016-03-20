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
using CourierBackOfficeManagement.ExpenseHead;
using CourierManagement;

namespace CourierBackOfficeManagement
{
    public partial class frmPopUpExpense : Form
    {
        public frmPopUpExpense()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    ExpenseHead.ExpenseHeadWebService objWebService = new ExpenseHead.ExpenseHeadWebService();
                    ExpenseHeadInfo objInfo = new ExpenseHeadInfo();
                    objInfo.ExpenseHead = txtExpenseTitle.Text;
                    objInfo.AddedBy = GetLoginUser.UserName;
                    objWebService.ExpenseHeadAdd(objInfo, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
                    txtExpenseTitle.Text = string.Empty;
                    MessageBox.Show("Expense Title Added Successfully");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
           
        }
        private bool ValidateExpenseTitle()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtExpenseTitle.Text == string.Empty)
            {
                errorProvider1.SetError(txtExpenseTitle, "Please Enter Expense Title");
                bStatus = false;
            }
            else if (!Regex.IsMatch(txtExpenseTitle.Text, @"^[a-zA-Z\\s]+"))
            {

                errorProvider1.SetError(txtExpenseTitle, "Please Enter Valid Value");
                bStatus = false;

            }
            else
                errorProvider1.SetError(txtExpenseTitle, string.Empty);
            return bStatus;
        }

        private void txtExpenseTitle_Validating(object sender, CancelEventArgs e)
        {
            ValidateExpenseTitle();
        }
        private bool ValidateForm()
        {
            if (txtExpenseTitle.Text == string.Empty)
            {
                txtExpenseTitle.Focus();
                errorProvider1.SetError(txtExpenseTitle, "Required!");
                return false;
            }          

            else
            {
                return true;
            }

        }
    }
}
