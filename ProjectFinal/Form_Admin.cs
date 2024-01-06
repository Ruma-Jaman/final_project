using Microsoft.SqlServer.Server;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjectFinal
{
    public partial class Form_Admin : Form
    {
        private DataAccess Da { get; set; }
        private Form_Login A1 { get; set; }
        public Form_Admin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.A1 = new Form_Login();
        }
        private void PopulateGridView(string sql)
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvAdmin.AutoGenerateColumns = false;
            this.dgvAdmin.DataSource = ds.Tables[0];

        }

        public Form_Admin(string username, Form_Login a1) : this()
        {
            this.lblWelcomeAdmin.Text += username;
            this.A1 = a1;
        }

        private void btnUserDetails_Click(object sender, EventArgs e)
        {
            string sql = "Select * from UserInfo";
            this.PopulateGridView(sql);
        }

        private void btnSearchAdmin_Click(object sender, EventArgs e)
        {
            string sql = "Select* From UserInfo Where UserId = '" + this.txtUserIdAdmin.Text + "';";
            this.PopulateGridView(sql);

        }

        private void btnSaveAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                    return;

                var sql = "insert into UserInfo Values('" + this.txtUserIdAdmin.Text + "','" + this.txtUserNameAdmin.Text + "','" + this.txtPasswordAdmin.Text + "','" + this.txtRoleAdmin.Text + "');";
                int count = this.Da.ExecuteDMLQuery(sql);
                if (count == 1)
                    MessageBox.Show("Data Saved.");
                else
                    MessageBox.Show("Data Not Saved");

                this.ClearAll();

            }
            catch (Exception exc)
            {
                MessageBox.Show("EROOR OCCURED! " + exc.Message);
            }


        }
        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtUserIdAdmin.Text) || String.IsNullOrEmpty(this.txtUserNameAdmin.Text) ||
                    String.IsNullOrEmpty(this.txtPasswordAdmin.Text) || String.IsNullOrEmpty(this.txtRoleAdmin.Text))
                return false;
            else
                return true;
        }


        private void ClearAll()
        {
            this.txtUserIdAdmin.Clear();
            this.txtUserNameAdmin.Clear();
            this.txtPasswordAdmin.Clear();
            this.txtRoleAdmin.Clear();

        }

        private void btnClearAdmin_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void btnAdminDelete_Click(object sender, EventArgs e)
        {


            try
            {
                if (!IsValidToDelete())
                    return;

                string userId = this.txtUserIdAdmin.Text;

                string sql = "DELETE FROM UserInfo WHERE UserId = '" + userId + "';";

                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Data Deleted.");
                else
                    MessageBox.Show("Data Not Deleted");

                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR OCCURRED! " + exc.Message);
            }

        }
        private bool IsValidToDelete()
        {
            if (String.IsNullOrEmpty(this.txtUserIdAdmin.Text))
            {
                MessageBox.Show("Please fill in the UserId field.");
                return false;
            }
            else

                return true;
        }

        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidToUpdate())
                    return;

                string userId = this.txtUserIdAdmin.Text;
                string newUserNameAdmin = this.txtUserNameAdmin.Text;
                string newPasswordAdmin = this.txtPasswordAdmin.Text;
                string newUserRoleAdmin = this.txtRoleAdmin.Text;

                string sql = "UPDATE UserInfo SET UserName = '" + newUserNameAdmin + "', UserPassword = '" + newPasswordAdmin + "', UserRole = '" + newUserRoleAdmin + "' WHERE UserId = '" + userId + "';";

                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Data Updated.");
                else
                    MessageBox.Show("Data Not Updated");

                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR OCCURRED! " + exc.Message);
            }



        }
        private bool IsValidToUpdate()
        {
            if (String.IsNullOrEmpty(this.txtUserIdAdmin.Text) ||
                String.IsNullOrEmpty(this.txtUserNameAdmin.Text) ||
                String.IsNullOrEmpty(this.txtPasswordAdmin.Text) ||
                String.IsNullOrEmpty(this.txtRoleAdmin.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return false;
            }
            else
                return true;
        }

       
        private void btnBookInformationAdmin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form_Information Info = new Form_Information();
            Info.Visible = true;
        }

        private void btnLogOutAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                MessageBox.Show("LogOut Complete");
                this.A1.Show();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }

        }
    }
}

   
    
