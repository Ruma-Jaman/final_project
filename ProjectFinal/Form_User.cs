using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFinal
{

    public partial class Form_User : Form
    {
        private DataAccess Da { get; set; }
        
        private Form_Login A1 { get; set; }
        
        public Form_User()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.A1 = new Form_Login();
        }
        private void PopulateGridView(string sql)
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvUser.AutoGenerateColumns = false;
            this.dgvUser.DataSource = ds.Tables[0];

        }
        public Form_User(string username, Form_Login a1) : this()
        {
            this.lblWelcomeUser.Text += username;
            this.A1 = a1;
        }

        private void btnBookDetailsUser_Click(object sender, EventArgs e)
        {
            string sql = "Select * from BookStoreInfo";
            this.PopulateGridView(sql);
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            string sql = "Select* From BookStoreInfo Where BookCategory = '" + this.cmbBookCategoryUser.Text + "';";
            this.PopulateGridView(sql);

        }

        private void txtBookIdUser_TextChanged(object sender, EventArgs e)
        {
            var sql = "SELECT * FROM BookStoreInfo WHERE BookId LIKE '%" + this.txtBookIdUser.Text + "%';";

            this.PopulateGridView(sql);
        }

        private void txtBookNameUser_TextChanged(object sender, EventArgs e)
        {
            var sql = "SELECT * FROM BookStoreInfo WHERE BookName LIKE '%" + this.txtBookNameUser.Text + "%';";

            this.PopulateGridView(sql);
        }

        private void txtBookPriceUser_TextChanged(object sender, EventArgs e)
        {
            var sql = "SELECT * FROM BookStoreInfo WHERE BookPrice LIKE '%" + this.txtBookPriceUser.Text + "%';";

            this.PopulateGridView(sql);

        }

        private void btnLogOutUser_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                MessageBox.Show("LogOut Complete");
                this.A1.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred:" + ex.Message);
            }
        }
    }
}
