using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourierBackOfficeManagement.GeneralCourier;
using CourierBackOfficeManagement.BLL;
using System.Collections;
using CourierManagement;

namespace CourierBackOfficeManagement
{
    public partial class frmGridGeneralCourier : Form
    {
        public frmGridGeneralCourier()
        {
            InitializeComponent();
            dataGridViewGeneralCourier.Columns["clmEdit"].Width = 40;
            dataGridViewGeneralCourier.Columns["clmDelete"].Width = 60;
            ComboBoxItem objCombo = new ComboBoxItem();
            cmbShowRows.DataSource = objCombo.ItemOfCmbShowRows();
          


        }

        private void frmGridGeneralCourier_Load(object sender, EventArgs e)
        {
            dataGridViewGeneralCourier.AutoGenerateColumns = false;
            LoadGeneralCourier();
            dataGridViewGeneralCourier.ClearSelection();
          

        }



        public void LoadGeneralCourier()
        {
            GeneralCourier.GeneralCourierWebService objWebService = new GeneralCourier.GeneralCourierWebService();
            dataGridViewGeneralCourier.DataSource = objWebService.GeneralCourierGetAll(TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
        }

        private void btnAddNewCourier_Click(object sender, EventArgs e)
        {
            frmGeneralCourier objGeneralCourier = new frmGeneralCourier();
            CourierBackOfficeManagement.BLL.RNGenerator objRNGenerator = new CourierBackOfficeManagement.BLL.RNGenerator();
            objGeneralCourier.txtCourierNumber.Text = objRNGenerator.GetUniqueKey();
            objGeneralCourier.ShowDialog();
            dataGridViewGeneralCourier.DataSource = null;
            LoadGeneralCourier();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            GeneralCourier.GeneralCourierWebService objWebService = new GeneralCourier.GeneralCourierWebService();
            DataTable dt = objWebService.SearchCourier(searchText, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
            if (dt.Rows.Count>=1)
            {
                dataGridViewGeneralCourier.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Records Found !!!");
                txtSearch.Text = string.Empty;
            }
            

        }
        private void dataGridViewGeneralCourier_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GridViewSerial objSerial = new GridViewSerial();
           objSerial.LoadSerial(dataGridViewGeneralCourier);
        }
      
        private void dataGridViewGeneralCourier_CellContentClick(object sender, DataGridViewCellEventArgs e)


        {

            if (e.ColumnIndex == dataGridViewGeneralCourier.Columns["clmDelete"].Index)
            {

                try
                {
                    GeneralCourier.GeneralCourierWebService obj = new GeneralCourier.GeneralCourierWebService();
                    GeneralCourierInfo objInfo = new GeneralCourierInfo();
                    objInfo.GeneralCourierID = Convert.ToInt32(dataGridViewGeneralCourier.Rows[e.RowIndex].Cells["clmGeneralCourierID"].Value.ToString());
                    if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        obj.GeneralCourierDeleteByID(objInfo.GeneralCourierID, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
                        MessageBox.Show("Data Deleted Successfully");
                        LoadGeneralCourier();
                    }
                   
                }
                catch (Exception ex)
                {
                    throw ex;
                }


            }
            if (e.ColumnIndex == dataGridViewGeneralCourier.Columns["clmEdit"].Index)
            {
                int x = Convert.ToInt32(dataGridViewGeneralCourier.CurrentRow.Cells["clmGeneralCourierID"].Value.ToString());
                frmGeneralCourier objGeneralCourier = new frmGeneralCourier(x);
                objGeneralCourier.ShowDialog();
                dataGridViewGeneralCourier.DataSource = null;
                LoadGeneralCourier();

            }

        }

        private void cmbShowRows_SelectedValueChanged(object sender, EventArgs e)
        {
            GeneralCourier.GeneralCourierWebService objWebService = new GeneralCourier.GeneralCourierWebService();
            int current = 0;
            int pagesize = Int32.Parse(cmbShowRows.SelectedValue.ToString());
            DataSet ds = objWebService.GetPageData(current, pagesize, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens()));
            if (ds.Tables.Count >=1)
            {
                DataTable dt = ds.Tables[1];
                dataGridViewGeneralCourier.DataSource = dt;
            }


        }

        private void btnReferesh_Click(object sender, EventArgs e)
        {
             txtSearch.Text = string.Empty;
             dataGridViewGeneralCourier.DataSource = null;
             LoadGeneralCourier();
            ComboBoxItem objCombo = new ComboBoxItem();
            cmbShowRows.DataSource = objCombo.ItemOfCmbShowRows();






        }
    }
}
