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
    public partial class frmGridCountry : Form
    {
        public frmGridCountry()
        {
            InitializeComponent();
        }

        private void btnAddNewCountry_Click(object sender, EventArgs e)
        {
            frmCountry objCountry = new frmCountry();
            objCountry.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadCountry()
        {
            Country.CountryWebService obj = new Country.CountryWebService();

            countryInfoBindingSource.DataSource = obj.CountryNameGetAll(SystemSettings.AppToken);

        }

        private void frmGridCountry_Load(object sender, EventArgs e)
        {
            LoadCountry();
        }
    }
}
