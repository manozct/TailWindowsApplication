using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourierBackOfficeManagement.Country;
using CourierManagement;

namespace CourierBackOfficeManagement
{
    public partial class frmGridCountry : Form
    {
        public frmGridCountry()
        {
            InitializeComponent();
            dataGridViewCountry.Columns["clmEdit"].Width = 20;
            dataGridViewCountry.Columns["clmDelete"].Width = 60;
            ComboBoxItem objCombo = new ComboBoxItem();
            cmbShowRows.DataSource = objCombo.ItemOfCmbShowRows();

        }
       
        public void LoadCountry()
        {
            Country.CountryWebService objWebService = new Country.CountryWebService();
            dataGridViewCountry.DataSource = objWebService.CountryNameGetAll(TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
        }
        private void frmGridCountry_Load(object sender, EventArgs e)
        {
            LoadCountry();
            dataGridViewCountry.ClearSelection();
        }

        private void dataGridViewCountry_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GridViewSerial objSerial = new GridViewSerial();
            objSerial.LoadSerial(dataGridViewCountry);
        }      

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            Country.CountryWebService objWebService = new Country.CountryWebService();
            DataTable dt = objWebService.SearchCountry(searchText, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
            if (dt.Rows.Count > 0)
            {
                dataGridViewCountry.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Records Found !!!");
                txtSearch.Text = string.Empty;
            }


        }

        private void btnAddNewCountry_Click(object sender, EventArgs e)
        {
            frmCountry objFrm = new frmCountry();
            objFrm.ShowDialog();
            dataGridViewCountry.DataSource = null;
            LoadCountry();
           
        }

        private void dataGridViewCountry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewCountry.Columns["clmEdit"].Index)
            {
                int x = Convert.ToInt32(dataGridViewCountry.CurrentRow.Cells["clmCountryID"].Value.ToString());
                frmCountry objFrm = new frmCountry(x);
                objFrm.ShowDialog();
                dataGridViewCountry.DataSource = null;
                LoadCountry();
            }
            if (e.ColumnIndex == dataGridViewCountry.Columns["clmDelete"].Index)
            {

                try
                {

                    Country.CountryWebService objWebService = new Country.CountryWebService();
                    CountryInfo objInfo = new CountryInfo();
                    objInfo.CountryID = Convert.ToInt32(dataGridViewCountry.Rows[e.RowIndex].Cells["clmCountryID"].Value.ToString());
                    if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        string deletedBy = GetLoginUser.UserName;
                        objWebService.CountryNameDeleteByID(objInfo.CountryID, deletedBy, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
                        MessageBox.Show("Data Deleted Successfully");
                        LoadCountry();

                    }
                    
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void cmbShowRows_SelectedValueChanged(object sender, EventArgs e)
        {
            Country.CountryWebService objWebService = new Country.CountryWebService();
            int current = 0;
            int pagesize = Int32.Parse(cmbShowRows.SelectedValue.ToString());
            DataSet ds = objWebService.GetPageData(current, pagesize, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
            if (ds.Tables.Count >=1)
            {
                DataTable dt = ds.Tables[1];
                dataGridViewCountry.DataSource = dt;
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            dataGridViewCountry.DataSource = null;
            LoadCountry();
            ComboBoxItem objCombo = new ComboBoxItem();
            cmbShowRows.DataSource = objCombo.ItemOfCmbShowRows();
        }
    }
}
