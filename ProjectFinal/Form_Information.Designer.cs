namespace ProjectFinal
{
    partial class Form_Information
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpBookPublishAdmin = new System.Windows.Forms.DateTimePicker();
            this.lblBookPublishAdmin = new System.Windows.Forms.Label();
            this.txtBookPriceAdmin = new System.Windows.Forms.TextBox();
            this.lblBookPrice = new System.Windows.Forms.Label();
            this.txtBookNameAdmin = new System.Windows.Forms.TextBox();
            this.txtBookIdAdmin = new System.Windows.Forms.TextBox();
            this.lblBookCategoryAdmin = new System.Windows.Forms.Label();
            this.cmbBookCategoryAdmin = new System.Windows.Forms.ComboBox();
            this.lblBookNameAdmin = new System.Windows.Forms.Label();
            this.lblBookIdAdmin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBookDetailsInformation = new System.Windows.Forms.Button();
            this.btnSearchInformation = new System.Windows.Forms.Button();
            this.btnClearInformation = new System.Windows.Forms.Button();
            this.btnDeleteInformation = new System.Windows.Forms.Button();
            this.btnUpdateInformation = new System.Windows.Forms.Button();
            this.btnSaveInformation = new System.Windows.Forms.Button();
            this.btnLogOutInformation = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUserInformationAdmin = new System.Windows.Forms.Button();
            this.dgvInformation = new System.Windows.Forms.DataGridView();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.dtpBookPublishAdmin);
            this.panel1.Controls.Add(this.lblBookPublishAdmin);
            this.panel1.Controls.Add(this.txtBookPriceAdmin);
            this.panel1.Controls.Add(this.lblBookPrice);
            this.panel1.Controls.Add(this.txtBookNameAdmin);
            this.panel1.Controls.Add(this.txtBookIdAdmin);
            this.panel1.Controls.Add(this.lblBookCategoryAdmin);
            this.panel1.Controls.Add(this.cmbBookCategoryAdmin);
            this.panel1.Controls.Add(this.lblBookNameAdmin);
            this.panel1.Controls.Add(this.lblBookIdAdmin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 190);
            this.panel1.TabIndex = 0;
            // 
            // dtpBookPublishAdmin
            // 
            this.dtpBookPublishAdmin.Location = new System.Drawing.Point(578, 144);
            this.dtpBookPublishAdmin.Name = "dtpBookPublishAdmin";
            this.dtpBookPublishAdmin.Size = new System.Drawing.Size(182, 20);
            this.dtpBookPublishAdmin.TabIndex = 10;
            // 
            // lblBookPublishAdmin
            // 
            this.lblBookPublishAdmin.AutoSize = true;
            this.lblBookPublishAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookPublishAdmin.Location = new System.Drawing.Point(400, 141);
            this.lblBookPublishAdmin.Name = "lblBookPublishAdmin";
            this.lblBookPublishAdmin.Size = new System.Drawing.Size(172, 25);
            this.lblBookPublishAdmin.TabIndex = 9;
            this.lblBookPublishAdmin.Text = "Published Date";
            // 
            // txtBookPriceAdmin
            // 
            this.txtBookPriceAdmin.Location = new System.Drawing.Point(577, 112);
            this.txtBookPriceAdmin.Name = "txtBookPriceAdmin";
            this.txtBookPriceAdmin.Size = new System.Drawing.Size(183, 20);
            this.txtBookPriceAdmin.TabIndex = 8;
            // 
            // lblBookPrice
            // 
            this.lblBookPrice.AutoSize = true;
            this.lblBookPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookPrice.Location = new System.Drawing.Point(445, 107);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new System.Drawing.Size(126, 25);
            this.lblBookPrice.TabIndex = 7;
            this.lblBookPrice.Text = "Book Price";
            // 
            // txtBookNameAdmin
            // 
            this.txtBookNameAdmin.Location = new System.Drawing.Point(179, 107);
            this.txtBookNameAdmin.Name = "txtBookNameAdmin";
            this.txtBookNameAdmin.Size = new System.Drawing.Size(183, 20);
            this.txtBookNameAdmin.TabIndex = 6;
            // 
            // txtBookIdAdmin
            // 
            this.txtBookIdAdmin.Location = new System.Drawing.Point(179, 70);
            this.txtBookIdAdmin.Name = "txtBookIdAdmin";
            this.txtBookIdAdmin.Size = new System.Drawing.Size(183, 20);
            this.txtBookIdAdmin.TabIndex = 5;
            // 
            // lblBookCategoryAdmin
            // 
            this.lblBookCategoryAdmin.AutoSize = true;
            this.lblBookCategoryAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookCategoryAdmin.Location = new System.Drawing.Point(10, 137);
            this.lblBookCategoryAdmin.Name = "lblBookCategoryAdmin";
            this.lblBookCategoryAdmin.Size = new System.Drawing.Size(167, 25);
            this.lblBookCategoryAdmin.TabIndex = 4;
            this.lblBookCategoryAdmin.Text = "Book Category";
            // 
            // cmbBookCategoryAdmin
            // 
            this.cmbBookCategoryAdmin.FormattingEnabled = true;
            this.cmbBookCategoryAdmin.Items.AddRange(new object[] {
            "CSE",
            "EEE",
            "BBA",
            "LAW"});
            this.cmbBookCategoryAdmin.Location = new System.Drawing.Point(179, 141);
            this.cmbBookCategoryAdmin.Name = "cmbBookCategoryAdmin";
            this.cmbBookCategoryAdmin.Size = new System.Drawing.Size(183, 21);
            this.cmbBookCategoryAdmin.TabIndex = 3;
            // 
            // lblBookNameAdmin
            // 
            this.lblBookNameAdmin.AutoSize = true;
            this.lblBookNameAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookNameAdmin.Location = new System.Drawing.Point(41, 101);
            this.lblBookNameAdmin.Name = "lblBookNameAdmin";
            this.lblBookNameAdmin.Size = new System.Drawing.Size(132, 25);
            this.lblBookNameAdmin.TabIndex = 2;
            this.lblBookNameAdmin.Text = "Book Name";
            // 
            // lblBookIdAdmin
            // 
            this.lblBookIdAdmin.AutoSize = true;
            this.lblBookIdAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookIdAdmin.Location = new System.Drawing.Point(80, 66);
            this.lblBookIdAdmin.Name = "lblBookIdAdmin";
            this.lblBookIdAdmin.Size = new System.Drawing.Size(91, 25);
            this.lblBookIdAdmin.TabIndex = 1;
            this.lblBookIdAdmin.Text = "Book Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(201, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "BOOK\'S INFORMATION";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnBookDetailsInformation);
            this.panel2.Controls.Add(this.btnSearchInformation);
            this.panel2.Controls.Add(this.btnClearInformation);
            this.panel2.Controls.Add(this.btnDeleteInformation);
            this.panel2.Controls.Add(this.btnUpdateInformation);
            this.panel2.Controls.Add(this.btnSaveInformation);
            this.panel2.Controls.Add(this.btnLogOutInformation);
            this.panel2.Location = new System.Drawing.Point(2, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 77);
            this.panel2.TabIndex = 1;
            // 
            // btnBookDetailsInformation
            // 
            this.btnBookDetailsInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBookDetailsInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookDetailsInformation.ForeColor = System.Drawing.Color.White;
            this.btnBookDetailsInformation.Location = new System.Drawing.Point(3, 4);
            this.btnBookDetailsInformation.Name = "btnBookDetailsInformation";
            this.btnBookDetailsInformation.Size = new System.Drawing.Size(128, 67);
            this.btnBookDetailsInformation.TabIndex = 10;
            this.btnBookDetailsInformation.Text = "BOOK DETAILS";
            this.btnBookDetailsInformation.UseVisualStyleBackColor = false;
            this.btnBookDetailsInformation.Click += new System.EventHandler(this.btnBookDetailsInformation_Click);
            // 
            // btnSearchInformation
            // 
            this.btnSearchInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearchInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchInformation.ForeColor = System.Drawing.Color.White;
            this.btnSearchInformation.Location = new System.Drawing.Point(134, 4);
            this.btnSearchInformation.Name = "btnSearchInformation";
            this.btnSearchInformation.Size = new System.Drawing.Size(100, 67);
            this.btnSearchInformation.TabIndex = 9;
            this.btnSearchInformation.Text = "SEARCH";
            this.btnSearchInformation.UseVisualStyleBackColor = false;
            this.btnSearchInformation.Click += new System.EventHandler(this.btnSearchInformation_Click);
            // 
            // btnClearInformation
            // 
            this.btnClearInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClearInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearInformation.ForeColor = System.Drawing.Color.White;
            this.btnClearInformation.Location = new System.Drawing.Point(237, 4);
            this.btnClearInformation.Name = "btnClearInformation";
            this.btnClearInformation.Size = new System.Drawing.Size(100, 67);
            this.btnClearInformation.TabIndex = 8;
            this.btnClearInformation.Text = "CLEAR";
            this.btnClearInformation.UseVisualStyleBackColor = false;
            this.btnClearInformation.Click += new System.EventHandler(this.btnClearInformation_Click);
            // 
            // btnDeleteInformation
            // 
            this.btnDeleteInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteInformation.ForeColor = System.Drawing.Color.White;
            this.btnDeleteInformation.Location = new System.Drawing.Point(343, 4);
            this.btnDeleteInformation.Name = "btnDeleteInformation";
            this.btnDeleteInformation.Size = new System.Drawing.Size(103, 66);
            this.btnDeleteInformation.TabIndex = 7;
            this.btnDeleteInformation.Text = "DELETE";
            this.btnDeleteInformation.UseVisualStyleBackColor = false;
            this.btnDeleteInformation.Click += new System.EventHandler(this.btnDeleteInformation_Click);
            // 
            // btnUpdateInformation
            // 
            this.btnUpdateInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdateInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInformation.ForeColor = System.Drawing.Color.White;
            this.btnUpdateInformation.Location = new System.Drawing.Point(452, 3);
            this.btnUpdateInformation.Name = "btnUpdateInformation";
            this.btnUpdateInformation.Size = new System.Drawing.Size(100, 67);
            this.btnUpdateInformation.TabIndex = 5;
            this.btnUpdateInformation.Text = "UPDATE";
            this.btnUpdateInformation.UseVisualStyleBackColor = false;
            this.btnUpdateInformation.Click += new System.EventHandler(this.btnUpdateInformation_Click);
            // 
            // btnSaveInformation
            // 
            this.btnSaveInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveInformation.ForeColor = System.Drawing.Color.White;
            this.btnSaveInformation.Location = new System.Drawing.Point(558, 3);
            this.btnSaveInformation.Name = "btnSaveInformation";
            this.btnSaveInformation.Size = new System.Drawing.Size(100, 67);
            this.btnSaveInformation.TabIndex = 4;
            this.btnSaveInformation.Text = "SAVE";
            this.btnSaveInformation.UseVisualStyleBackColor = false;
            this.btnSaveInformation.Click += new System.EventHandler(this.btnSaveInformation_Click);
            // 
            // btnLogOutInformation
            // 
            this.btnLogOutInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogOutInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOutInformation.ForeColor = System.Drawing.Color.White;
            this.btnLogOutInformation.Location = new System.Drawing.Point(664, 3);
            this.btnLogOutInformation.Name = "btnLogOutInformation";
            this.btnLogOutInformation.Size = new System.Drawing.Size(127, 67);
            this.btnLogOutInformation.TabIndex = 1;
            this.btnLogOutInformation.Text = "LOGOUT";
            this.btnLogOutInformation.UseVisualStyleBackColor = false;
            this.btnLogOutInformation.Click += new System.EventHandler(this.btnLogOutInformation_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnUserInformationAdmin);
            this.panel3.Controls.Add(this.dgvInformation);
            this.panel3.Location = new System.Drawing.Point(2, 276);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(794, 173);
            this.panel3.TabIndex = 2;
            // 
            // btnUserInformationAdmin
            // 
            this.btnUserInformationAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUserInformationAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserInformationAdmin.ForeColor = System.Drawing.Color.White;
            this.btnUserInformationAdmin.Location = new System.Drawing.Point(-6, 1);
            this.btnUserInformationAdmin.Name = "btnUserInformationAdmin";
            this.btnUserInformationAdmin.Size = new System.Drawing.Size(137, 172);
            this.btnUserInformationAdmin.TabIndex = 2;
            this.btnUserInformationAdmin.Text = "USER\'S INFORMATION";
            this.btnUserInformationAdmin.UseVisualStyleBackColor = false;
            this.btnUserInformationAdmin.Click += new System.EventHandler(this.btnUserInformationAdmin_Click);
            // 
            // dgvInformation
            // 
            this.dgvInformation.AllowUserToAddRows = false;
            this.dgvInformation.AllowUserToDeleteRows = false;
            this.dgvInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookId,
            this.BookName,
            this.BookCategory,
            this.BookPrice,
            this.PublishDate});
            this.dgvInformation.Location = new System.Drawing.Point(134, 3);
            this.dgvInformation.Name = "dgvInformation";
            this.dgvInformation.ReadOnly = true;
            this.dgvInformation.Size = new System.Drawing.Size(657, 166);
            this.dgvInformation.TabIndex = 0;
            // 
            // BookId
            // 
            this.BookId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookId.DataPropertyName = "BookId";
            this.BookId.HeaderText = "Book Id";
            this.BookId.Name = "BookId";
            this.BookId.ReadOnly = true;
            // 
            // BookName
            // 
            this.BookName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "Book Name";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // BookCategory
            // 
            this.BookCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookCategory.DataPropertyName = "BookCategory";
            this.BookCategory.HeaderText = "Category";
            this.BookCategory.Name = "BookCategory";
            this.BookCategory.ReadOnly = true;
            // 
            // BookPrice
            // 
            this.BookPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookPrice.DataPropertyName = "BookPrice";
            this.BookPrice.HeaderText = "Price";
            this.BookPrice.Name = "BookPrice";
            this.BookPrice.ReadOnly = true;
            // 
            // PublishDate
            // 
            this.PublishDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PublishDate.DataPropertyName = "PublishDate";
            this.PublishDate.HeaderText = "Published Date";
            this.PublishDate.Name = "PublishDate";
            this.PublishDate.ReadOnly = true;
            // 
            // Form_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Information";
            this.Text = "Form_Information";
            this.Load += new System.EventHandler(this.Form_Information_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBookIdAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBookCategoryAdmin;
        private System.Windows.Forms.ComboBox cmbBookCategoryAdmin;
        private System.Windows.Forms.Label lblBookNameAdmin;
        private System.Windows.Forms.TextBox txtBookNameAdmin;
        private System.Windows.Forms.TextBox txtBookIdAdmin;
        private System.Windows.Forms.DateTimePicker dtpBookPublishAdmin;
        private System.Windows.Forms.Label lblBookPublishAdmin;
        private System.Windows.Forms.TextBox txtBookPriceAdmin;
        private System.Windows.Forms.Label lblBookPrice;
        private System.Windows.Forms.DataGridView dgvInformation;
        private System.Windows.Forms.Button btnLogOutInformation;
        private System.Windows.Forms.Button btnSaveInformation;
        private System.Windows.Forms.Button btnUpdateInformation;
        private System.Windows.Forms.Button btnDeleteInformation;
        private System.Windows.Forms.Button btnClearInformation;
        private System.Windows.Forms.Button btnSearchInformation;
        private System.Windows.Forms.Button btnBookDetailsInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishDate;
        private System.Windows.Forms.Button btnUserInformationAdmin;
    }
}