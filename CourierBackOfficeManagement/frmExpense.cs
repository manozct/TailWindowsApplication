using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourierBackOfficeManagement
{
    public partial class frmExpense : Form
    {
        public frmExpense()
        {
            InitializeComponent();
            placeholder();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void placeholder()
        {
            cmbExpenseType.Text = "--Select Expense Type--";
            cmbExpenseType.ForeColor = Color.Gray;
            txtCost.Text = "Cost NPR";
            txtCost.ForeColor = Color.Gray;
            rchtxtNote.Text = "Note";
            rchtxtNote.ForeColor = Color.Gray;
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            frmPopUpExpense objfrmPopUpExpense = new frmPopUpExpense();
            objfrmPopUpExpense.ShowDialog(this);
        }
    }
}
