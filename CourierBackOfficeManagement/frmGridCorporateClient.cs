using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourierBackOfficeManagement.CorporateClient;
using CourierManagement;

namespace CourierBackOfficeManagement
{
    public partial class frmGridCorporateClient : Form
    {
        public frmGridCorporateClient()
        {
            InitializeComponent();
            dataGridViewCorporateClient.Columns["clmContract"].Width = 80;
            dataGridViewCorporateClient.Columns["clmEdit"].Width = 40;
            dataGridViewCorporateClient.Columns["clmDelete"].Width = 90;
            ComboBoxItem objCombo = new ComboBoxItem();
            cmbShowRows.DataSource = objCombo.ItemOfCmbShowRows();
        }         

        private void frmGridCorporateClient_Load(object sender, EventArgs e)
        {
            dataGridViewCorporateClient.AutoGenerateColumns = false;
            LoadCorporateClient();
            dataGridViewCorporateClient.ClearSelection();
        }
        public void LoadCorporateClient()
        {
            CorporateClient.CorporateClientWebService objWebService = new CorporateClient.CorporateClientWebService();
            dataGridViewCorporateClient.DataSource = objWebService.CorporateClientGetAll(TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
        }

        private void dataGridViewCorporateClient_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GridViewSerial objSerial = new GridViewSerial();
           objSerial.LoadSerial(dataGridViewCorporateClient);
        }

        private void btnAddNewCorporate_Click(object sender, EventArgs e)
        {
            frmCorporateClient objFrm = new frmCorporateClient();
            objFrm.ShowDialog();
            dataGridViewCorporateClient.DataSource = null;
            LoadCorporateClient();
            
        }

        private void dataGridViewCorporateClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewCorporateClient.Columns["clmEdit"].Index)
            {
                int x = Convert.ToInt32(dataGridViewCorporateClient.CurrentRow.Cells["clmCorporateClientID"].Value.ToString());
                frmCorporateClient objFrm = new frmCorporateClient(x);
                objFrm.ShowDialog();
                dataGridViewCorporateClient.DataSource = null;
                LoadCorporateClient();
            }
            if (e.ColumnIndex == dataGridViewCorporateClient.Columns["clmDelete"].Index)
            {

                try
                {

                    CorporateClient.CorporateClientWebService objWebService = new CorporateClient.CorporateClientWebService();
                    CorporateClientInfo objInfo = new CorporateClientInfo();
                    objInfo.CorporateClientID = Convert.ToInt32(dataGridViewCorporateClient.Rows[e.RowIndex].Cells["clmCorporateClientID"].Value.ToString());
                    if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        string deletedBy = GetLoginUser.UserName;
                        objWebService.CorporateClientDeleteByID(objInfo.CorporateClientID,deletedBy, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
                        MessageBox.Show("Data Deleted Successfully");
                        LoadCorporateClient();

                    }
                    
                }
                catch (Exception ex)
                {
                    throw ex;
                }


            }
            if (e.ColumnIndex == dataGridViewCorporateClient.Columns["clmContract"].Index)
            {
                int x = Convert.ToInt32(dataGridViewCorporateClient.CurrentRow.Cells["clmCorporateClientID"].Value.ToString());
                frmContractGrid objGridContract = new frmContractGrid(x);
                objGridContract.Show();
                this.Close();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            CorporateClient.CorporateClientWebService objWebService = new CorporateClient.CorporateClientWebService();
            DataTable dt= objWebService.SearchCorporateClient(searchText, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
            if(dt.Rows.Count>0)
            {
                dataGridViewCorporateClient.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Records Found !!!");
                txtSearch.Text = string.Empty;
            }

        }

        private void cmbShowRows_SelectedValueChanged(object sender, EventArgs e)
        {
            CorporateClient.CorporateClientWebService objWebService = new CorporateClient.CorporateClientWebService();
            int current = 0;
            int pagesize = Int32.Parse(cmbShowRows.SelectedValue.ToString());
            DataSet ds = objWebService.GetPageData(current, pagesize, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
            if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[1];
                dataGridViewCorporateClient.DataSource = dt;
            }


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            dataGridViewCorporateClient.DataSource = null;
            LoadCorporateClient();
            ComboBoxItem objCombo = new ComboBoxItem();
            cmbShowRows.DataSource = objCombo.ItemOfCmbShowRows();
        }
    }
}
