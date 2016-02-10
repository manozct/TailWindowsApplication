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
    public partial class frmGridGeneralCourier : Form
    {
        public frmGridGeneralCourier()
        {
            InitializeComponent();
            placeholder();
            
        }
        public void placeholder()
        {
            txtSearch.Text = "Enter Courier Number";
            txtSearch.ForeColor = Color.Gray;
        }
        private void frmGridGeneralCourier_Load(object sender, EventArgs e)
        {
            LoadGeneralCourier();

        }
        public void LoadGeneralCourier()
        {
            GeneralCourier.GeneralCourierWebService objWebService = new GeneralCourier.GeneralCourierWebService();
            generalCourierInfoBindingSource.DataSource = objWebService.GeneralCourierGetAll(SystemSettings.AppToken);
        }

        private void btnAddNewCourier_Click(object sender, EventArgs e)
        {
            frmGeneralCourier objGeneralCourier = new frmGeneralCourier();
            objGeneralCourier.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            GeneralCourier.GeneralCourierWebService objWebService = new GeneralCourier.GeneralCourierWebService();
            generalCourierInfoBindingSource.DataSource = objWebService.SearchCourier(searchText, SystemSettings.AppToken);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if(txtSearch.Text=="")
            {
                txtSearch.Text = "Enter Courier Number";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.ForeColor = Color.Black;
        }

        private void dataGridViewGeneralCourier_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            LoadSerial(dataGridViewGeneralCourier);
        }
        private void LoadSerial(DataGridView grid)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                grid.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                row.Height = 30;
                
                
            }
        }
    }
}
