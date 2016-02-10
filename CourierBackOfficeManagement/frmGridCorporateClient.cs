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



namespace CourierBackOfficeManagement
{
    public partial class frmGridCorporateClient : Form
    {
        public int CorClientID { get; private set; }
        public string DeletedBy { get; private set; }
        
        public frmGridCorporateClient()
        {
            
            InitializeComponent();
            placeholder();


        }


        private void dataGridViewCorporateClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {





            //foreach (DataGridViewRow row in dataGridViewCorporateClient.SelectedRows)
            //{
            //    string value1 = row.Cells[0].Value.ToString();
            //    string value2 = row.Cells[1].Value.ToString();
            //}





            if (e.RowIndex >= 0)
            {
                if (Convert.ToString(dataGridViewCorporateClient.Columns[e.ColumnIndex].Name) == "Contract")
                {
                    frmContract objContract = new frmContract();

                    objContract.Show();


                }

            }




            if (e.ColumnIndex == dataGridViewCorporateClient.Columns["DeleteButton"].Index)
            {



                CorporateClient.CorporateClientWebService obj = new CorporateClient.CorporateClientWebService();
                CorporateClientInfo objInfo = new CorporateClientInfo();
                objInfo.CorporateClientID = Convert.ToInt32(dataGridViewCorporateClient.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    obj.CorporateClientDeleteByID(objInfo.CorporateClientID, DeletedBy, SystemSettings.AppToken);

                }
                LoadCorporateClient();
                MessageBox.Show("Data Deleted Successfully");

            }



            if (e.ColumnIndex == dataGridViewCorporateClient.Columns["EditButton"].Index)
            {



                //CorporateClient.CorporateClientWebService obj = new CorporateClient.CorporateClientWebService();
                //CorporateClientInfo objInfo = new CorporateClientInfo();
                //objInfo.CorporateClientID = Convert.ToInt32(dataGridViewCorporateClient.Rows[e.RowIndex].Cells[0].Value.ToString());
                //obj.CorporateClientGetByID(objInfo.CorporateClientID, SystemSettings.AppToken);
               


                frmCorporateClient objCorporateClient = new frmCorporateClient();
                objCorporateClient.lblCorporateClientId.Text = this.dataGridViewCorporateClient.CurrentRow.Cells[0].Value.ToString();
                objCorporateClient.txtCorporateName.Text = this.dataGridViewCorporateClient.CurrentRow.Cells[1].Value.ToString();
                objCorporateClient.txtCorporateName.ForeColor = Color.Black;
                objCorporateClient.txtLCDContractPerson.Text = this.dataGridViewCorporateClient.CurrentRow.Cells[2].Value.ToString();
                objCorporateClient.txtLCDContractPerson.ForeColor = Color.Black;
                objCorporateClient.txtContactPersonMobile.Text = this.dataGridViewCorporateClient.CurrentRow.Cells[3].Value.ToString();
                objCorporateClient.txtContactPersonMobile.ForeColor = Color.Black;
                objCorporateClient.rchtxtAddress.Text = this.dataGridViewCorporateClient.CurrentRow.Cells[4].Value.ToString();
                objCorporateClient.rchtxtAddress.ForeColor = Color.Black;
                objCorporateClient.txtPhoneNumber.Text = this.dataGridViewCorporateClient.CurrentRow.Cells[5].Value.ToString();
                objCorporateClient.txtPhoneNumber.ForeColor = Color.Black;
                objCorporateClient.txtCorporateEmail.Text = this.dataGridViewCorporateClient.CurrentRow.Cells[6].Value.ToString();
                objCorporateClient.txtCorporateEmail.ForeColor = Color.Black;
                objCorporateClient.txtHeadOfficeAddress.Text = this.dataGridViewCorporateClient.CurrentRow.Cells[7].Value.ToString();
                objCorporateClient.txtHeadOfficeAddress.ForeColor = Color.Black;
                objCorporateClient.txtLCDepartment.Text = this.dataGridViewCorporateClient.CurrentRow.Cells[8].Value.ToString();
                objCorporateClient.txtLCDepartment.ForeColor = Color.Black;
                objCorporateClient.txtContactPersonPhone.Text = this.dataGridViewCorporateClient.CurrentRow.Cells[9].Value.ToString();
                objCorporateClient.txtContactPersonPhone.ForeColor = Color.Black;
                objCorporateClient.txtContactPersonEmail.Text = this.dataGridViewCorporateClient.CurrentRow.Cells[10].Value.ToString();
                objCorporateClient.txtContactPersonEmail.ForeColor = Color.Black;
                objCorporateClient.rchtxtSLA.Text = this.dataGridViewCorporateClient.CurrentRow.Cells[11].Value.ToString();
                objCorporateClient.rchtxtSLA.ForeColor = Color.Black;
                objCorporateClient.ShowDialog();







            }

        }

        public void frmGridCorporateClient_Load(object sender, EventArgs e)
        {
            LoadCorporateClient();

        }

        private void LoadCorporateClient()
        {
            CorporateClient.CorporateClientWebService obj = new CorporateClient.CorporateClientWebService();

            corporateClientInfoBindingSource.DataSource = obj.CorporateClientGetAll(SystemSettings.AppToken);

        }

        private void btnAddNewCorporate_Click(object sender, EventArgs e)
        {
            frmCorporateClient objCorporateClient = new frmCorporateClient();
            
            objCorporateClient.Show();
            



        }
        public void placeholder()
        {
            txtSearch.Text = "Search Name";
            txtSearch.ForeColor = Color.Gray;
        }

        private void lblShowRows_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.ForeColor = Color.Black;

        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search Name";
                txtSearch.ForeColor = Color.Gray;
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CorporateClient.CorporateClientWebService objWebService = new CorporateClient.CorporateClientWebService();
            string searchText = txtSearch.Text;
            corporateClientInfoBindingSource.DataSource = objWebService.SearchCorporateClient(searchText, SystemSettings.AppToken);
            
        }
    }
}
