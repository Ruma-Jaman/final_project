using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjectFinal
{
    public partial class Form_Information : Form
    {
        private DataAccess Da { get; set; }

        private Form_Login A1 { get; set; }
        public Form_Information()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.A1 = new Form_Login();
        }
        private void PopulateGridView(string sql)
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvInformation.AutoGenerateColumns = false;
            this.dgvInformation.DataSource = ds.Tables[0];

        }

        private void Form_Information_Load(object sender, EventArgs e)
        {
          
        }
       

        private void btnBookDetailsInformation_Click(object sender, EventArgs e)
        {
            string sql = "Select * from BookStoreInfo";
            this.PopulateGridView(sql);
        }

        private void btnSearchInformation_Click(object sender, EventArgs e)
        {
            string sql = "Select* From BookStoreInfo Where BookId = '" + this.txtBookIdAdmin.Text + "';";
            this.PopulateGridView(sql);
        }

        private void btnSaveInformation_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidToSave())
                    return;

                var sql = "INSERT INTO BookStoreInfo VALUES ('"
                           + this.txtBookIdAdmin.Text + "','"
                           + this.txtBookNameAdmin.Text + "','"
                           + this.cmbBookCategoryAdmin.Text + "','"
                           + this.txtBookPriceAdmin.Text + "','"
                           + this.dtpBookPublishAdmin.Value.ToString("yyyy-MM-dd") + "');";

                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Data Saved.");
                else
                    MessageBox.Show("Data Not Saved");

                ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR OCCURRED! " + exc.Message);
            }

        }
        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtBookIdAdmin.Text) || String.IsNullOrEmpty(this.txtBookNameAdmin.Text) ||
                    String.IsNullOrEmpty(this.cmbBookCategoryAdmin.Text) || String.IsNullOrEmpty(this.txtBookPriceAdmin.Text))
                return false;
            else
                return true;
        }
        private void ClearAll()
        {
            this.txtBookIdAdmin.Clear();
            this.txtBookNameAdmin.Clear();
            this.dtpBookPublishAdmin.Text = "";
            this.cmbBookCategoryAdmin.SelectedIndex = -1;
            this.txtBookPriceAdmin.Clear();

        }

        private void btnClearInformation_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void btnDeleteInformation_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidToDelete())
                    return;

                string BookId = this.txtBookIdAdmin.Text;

                string sql = "DELETE FROM BookStoreInfo WHERE BookId = '" + BookId + "';";

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
            if (String.IsNullOrEmpty(this.txtBookIdAdmin.Text))
            {
                MessageBox.Show("Please fill in the UserId field.");
                return false;
            }
            else

                return true;
        }

        private void btnUpdateInformation_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidToUpdate())
                    return;

                string bookId = this.txtBookIdAdmin.Text;
                string newBookNameAdmin = this.txtBookNameAdmin.Text;
                string newBookCategoryAdmin = this.cmbBookCategoryAdmin.Text;
                string newBookPriceAdmin = this.txtBookPriceAdmin.Text;
                string newBookPublishAdmin = this.dtpBookPublishAdmin.Value.ToString("yyyy-MM-dd");

                string sql = "UPDATE BookStoreInfo SET BookName = '" + newBookNameAdmin + "', " +
                             "BookCategory = '" + newBookCategoryAdmin + "', " +
                             "BookPrice = '" + newBookPriceAdmin + "', " +
                             "PublishDate = '" + newBookPublishAdmin + "' " +
                             "WHERE BookId = '" + bookId + "';";

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
            if (String.IsNullOrEmpty(this.txtBookIdAdmin.Text) ||
                String.IsNullOrEmpty(this.txtBookNameAdmin.Text) ||
                String.IsNullOrEmpty(this.cmbBookCategoryAdmin.Text) ||
                String.IsNullOrEmpty(this.txtBookPriceAdmin.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return false;
            }
            else
                return true;

        }

        private void btnUserInformationAdmin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form_Admin Info = new Form_Admin();
            Info.Visible = true;
        }

        private void btnLogOutInformation_Click(object sender, EventArgs e)
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
