using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourierBackOfficeManagement.Login;


namespace CourierBackOfficeManagement
{
    public partial class frmLogin : Form
    {
        public int PortalID { get; private set; }

        public frmLogin()
        {
            InitializeComponent();
            placeholder();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void placeholder()
        {
            txtUsername.Text = "Username";
            txtUsername.ForeColor = Color.Gray;
            txtPassword.Text = "Password";
            txtPassword.ForeColor = Color.Gray;
        }

        private bool ValidateLogin()
        {
            bool validateLogin = false;
            try
            {

                int PortalID = SystemPortalID.PortalID;
                Login.LoginWebService obj = new Login.LoginWebService();
                
                if (obj.LoginUser(PortalID, txtUsername.Text, txtPassword.Text, SystemSettings.AppToken))

                {
                    validateLogin = true;
                }
                else
                {
                    MessageBox.Show("Invalid UserName or Password");
                }

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);

            }
            return validateLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            if (ValidateLogin() == true)
            {
                this.DialogResult = DialogResult.OK;
            }


        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtUsername.ForeColor = Color.Black;

        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Gray;
            }

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.ForeColor = Color.Black;

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }





}


