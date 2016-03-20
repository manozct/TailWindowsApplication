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
using CourierManagement;


namespace CourierBackOfficeManagement
{
    public partial class frmLogin : Form
    {
        public int PortalID { get; private set; }

        public frmLogin()
        {
            InitializeComponent();
           
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
      

        private bool ValidateLogin()
        {
            bool validateLogin = false;
            try
            {
                int PortalID = SystemPortalID.PortalID;
                Login.LoginWebService obj = new Login.LoginWebService();
                
                if (obj.LoginUser(PortalID, txtUsername.Text, txtPassword.Text, TokenCleintEncrypt.Encrypt(ClientTokenBuilder.BuildTokens())))
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
                GetLoginUser.PortalID = SystemPortalID.PortalID;
                GetLoginUser.UserName = txtUsername.Text;
                this.DialogResult = DialogResult.OK;
                
            }


        }

       
     
      

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }





}


