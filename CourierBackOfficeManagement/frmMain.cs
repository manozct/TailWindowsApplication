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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void corporateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGridGeneralCourier objGridViewGeneralCourier = new frmGridGeneralCourier();
            objGridViewGeneralCourier.Show();
        }

        private void expenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExpense objfrmExpense = new frmExpense();
            objfrmExpense.Show();
        }

        private void fIleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void countryToolStripMenuCountry_Click(object sender, EventArgs e)
        {
            frmGridCountry objCountry = new frmGridCountry();
            objCountry.Show();
        }

        private void stateToolStripMenuState_Click(object sender, EventArgs e)
        {
            frmState objfrmState = new frmState();
            objfrmState.Show();
        }

        private void locationToolStripMenuLocation_Click(object sender, EventArgs e)
        {
            frmLocation objfrmLocation = new frmLocation();
            objfrmLocation.Show();
        }

        private void addCorporateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGridCorporateClient objGridCorporateClient = new frmGridCorporateClient();
            objGridCorporateClient.Show();
        }

        private void addContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContract objfrmContract = new frmContract();
            objfrmContract.Show();
        }

        private void addCourierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrder objfrmOrder = new frmOrder();
            objfrmOrder.Show();
        }

        private void priceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeneralPrice objfrmGeneralPrice = new frmGeneralPrice();
            objfrmGeneralPrice.Show();
        }
    }
}
