using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjectFinal
{
    public partial class Form_Login : Form
    {
        private DataAccess Da { get; set; }
        public Form_Login()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM UserInfo WHERE UserId = '" + this.txtUserIdLogin.Text + "' AND UserPassword = '" + this.txtPasswordLogin.Text + "'";

                DataSet ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    this.Hide();
                    MessageBox.Show("Valid");

                    string userRole = ds.Tables[0].Rows[0]["UserRole"].ToString();

                    if (userRole == "ADMIN")
                    {
                        new Form_Admin(ds.Tables[0].Rows[0]["UserName"].ToString(), this).Show();
                    }
                    else if (userRole == "USER")
                    {
                        new Form_User(ds.Tables[0].Rows[0]["UserName"].ToString(), this).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }



            /*bool found = false;
            int count = 0;
            while (count < ds.Tables[0].Rows.Count)
            {
                if(this.txtLoginUserId.Text == ds.Tables[0].Rows[count][0].ToString() && this.txtLoginPassword.Text == ds.Tables[0].Rows[0][2].ToString())
                {
                    found = true;
                    MessageBox.Show("Congrats! Valid User");
                   
                }
                count++;


            }
            if (!found)
                MessageBox.Show("Invalid User");*/



        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnForgetPasswordLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sent an email to majumdarprtiom@gmail.com");
        }
    }
    }

