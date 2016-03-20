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
using CourierBackOfficeManagement.Expense;
using CourierManagement;

namespace CourierBackOfficeManagement
{
    public partial class frmExpense : Form
    {
        public frmExpense()
        {
            InitializeComponent();
            lblExpenseID.Text = "0";
            lblExpenseHeadID.Text = "0";
            LoadExpenseHead();

        }
        public frmExpense(int expenseID)
        {
            InitializeComponent();
            LoadExpenseHead();
            Expense.ExpenseWebService objWebService = new Expense.ExpenseWebService();
            ExpenseInfo objInfo = new ExpenseInfo();
            objInfo.ExpenseID = expenseID;
            objInfo = objWebService.ExpenseGetByID(objInfo.ExpenseID, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
            cmbExpenseType.SelectedValue = objInfo.ExpenseHeadID;
            txtCost.Text = objInfo.Expense.ToString();
            rchtxtNote.Text = objInfo.Note;
            lblExpenseID.Text = objInfo.ExpenseID.ToString();
            lblExpenseHeadID.Text = objInfo.ExpenseHeadID.ToString();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            frmPopUpExpense objFrm = new frmPopUpExpense();
            objFrm.ShowDialog();
            cmbExpenseType.DataSource = null;
            LoadExpenseHead();
        }

        private void frmExpense_Load(object sender, EventArgs e)
        {

        }
        private void ClearField()
        {
            txtCost.Text = string.Empty;
            rchtxtNote.Text = string.Empty;
        }
        public void LoadExpenseHead()
        {
            ExpenseHead.ExpenseHeadWebService objWebService = new ExpenseHead.ExpenseHeadWebService();
            cmbExpenseType.DataSource = objWebService.ExpenseHeadGetAll(TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
            cmbExpenseType.ValueMember = "ExpenseHeadID";
            cmbExpenseType.DisplayMember = "ExpenseHead";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    Expense.ExpenseWebService objWebService = new Expense.ExpenseWebService();
                    ExpenseInfo objInfo = new ExpenseInfo();
                    objInfo.ExpenseHeadID = Convert.ToInt32(cmbExpenseType.SelectedValue);
                    objInfo.Expense = Convert.ToDecimal(txtCost.Text);
                    objInfo.Note = rchtxtNote.Text;
                    int expenseID = Convert.ToInt32(lblExpenseID.Text);
                    int expenseHeadID = objInfo.ExpenseHeadID;
                    if (expenseHeadID != 0 && expenseID == 0)
                    {
                        objInfo.AddedBy = GetLoginUser.UserName;
                        objWebService.ExpenseAdd(objInfo, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
                        MessageBox.Show("Data saved successfully");

                    }
                    else if (expenseHeadID != 0 && expenseID != 0)
                    {
                        objInfo.ExpenseHeadID = expenseHeadID;
                        objInfo.ExpenseID = expenseID;
                        objInfo.EditedBy = GetLoginUser.UserName;
                        objInfo.EditedDate = DateTime.Now;
                        objWebService.ExpenseUpdate(objInfo, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
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
            if (cmbExpenseType.Text == string.Empty)
            {
                cmbExpenseType.Focus();
                errorProvider1.SetError(cmbExpenseType, "Required!");
                return false;
            }
            else if (txtCost.Text == string.Empty)
            {
                txtCost.Focus();
                errorProvider1.SetError(txtCost, "Required!");
                return false;
            }
            else if (rchtxtNote.Text == string.Empty)
            {
                rchtxtNote.Focus();
                errorProvider1.SetError(rchtxtNote, "Required!");
                return false;
            }

            else
            {
                return true;
            }

        }

        private void cmbExpenseType_Validating(object sender, CancelEventArgs e)
        {
            ValidateExpenseType();
        }

        private void txtCost_Validating(object sender, CancelEventArgs e)
        {
            ValidateCost();
        }

        private void rchtxtNote_Validating(object sender, CancelEventArgs e)
        {
            ValidateNote();

        }
        private bool ValidateExpenseType()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (cmbExpenseType.Text == string.Empty)
            {
                errorProvider1.SetError(cmbExpenseType, "Please Select Expense Type");
                bStatus = false;
            }
            else
                errorProvider1.SetError(cmbExpenseType, string.Empty);
            return bStatus;
        }
        private bool ValidateCost()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (txtCost.Text == string.Empty)
            {
                errorProvider1.SetError(txtCost, "Please Enter Cost");
                bStatus = false;
            }
            else if (!Regex.IsMatch(txtCost.Text, @"[0-9]*\.?[0-9]"))
            {

                errorProvider1.SetError(txtCost, "Please enter valid integer or decimal number");
                bStatus = false;

            }
            else
                errorProvider1.SetError(txtCost, string.Empty);
            return bStatus;
        }
        private bool ValidateNote()
        {
            errorProvider1.Clear();
            bool bStatus = true;
            if (rchtxtNote.Text == string.Empty)
            {
                errorProvider1.SetError(rchtxtNote, "Please Enter Note");
                bStatus = false;
            }
            else
                errorProvider1.SetError(rchtxtNote, string.Empty);
            return bStatus;
        }
    }
}
