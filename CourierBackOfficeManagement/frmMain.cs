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
            _UserName = GetLoginUser.UserName;
           
        }
        private string _UserName;
       

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
            frmGridExpense objFrmGrid = new frmGridExpense();
            objFrmGrid.Show();
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
            frmGridState objFrm = new frmGridState();
            objFrm.Show();
        }

        private void locationToolStripMenuLocation_Click(object sender, EventArgs e)
        {
            frmGridLocation objFrmGrid = new frmGridLocation();
            objFrmGrid.Show();
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
            frmGridCorporateCourierEntry objFrm = new frmGridCorporateCourierEntry();
            objFrm.Show();
        }

        private void priceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGridGeneralCourierPrice objFrm = new frmGridGeneralCourierPrice();
            objFrm.Show();
        }

        private void demoToolStripMenuItem_Click(object sender, EventArgs e)
        {
     
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport objFrm = new frmReport();
            objFrm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
    }
}
