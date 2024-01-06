namespace ProjectFinal
{
    partial class Form_User
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
            this.dtpPublishDateUser = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookPriceUser = new System.Windows.Forms.TextBox();
            this.lblBookPriceUser = new System.Windows.Forms.Label();
            this.cmbBookCategoryUser = new System.Windows.Forms.ComboBox();
            this.txtBookNameUser = new System.Windows.Forms.TextBox();
            this.txtBookIdUser = new System.Windows.Forms.TextBox();
            this.lblBookCategoryUser = new System.Windows.Forms.Label();
            this.lblBookNameUser = new System.Windows.Forms.Label();
            this.lblBookIdUser = new System.Windows.Forms.Label();
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBookDetailsUser = new System.Windows.Forms.Button();
            this.btnClearUSer = new System.Windows.Forms.Button();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.btnLogOutUser = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.dtpPublishDateUser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBookPriceUser);
            this.panel1.Controls.Add(this.lblBookPriceUser);
            this.panel1.Controls.Add(this.cmbBookCategoryUser);
            this.panel1.Controls.Add(this.txtBookNameUser);
            this.panel1.Controls.Add(this.txtBookIdUser);
            this.panel1.Controls.Add(this.lblBookCategoryUser);
            this.panel1.Controls.Add(this.lblBookNameUser);
            this.panel1.Controls.Add(this.lblBookIdUser);
            this.panel1.Controls.Add(this.lblWelcomeUser);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 208);
            this.panel1.TabIndex = 0;
            // 
            // dtpPublishDateUser
            // 
            this.dtpPublishDateUser.Location = new System.Drawing.Point(596, 154);
            this.dtpPublishDateUser.Name = "dtpPublishDateUser";
            this.dtpPublishDateUser.Size = new System.Drawing.Size(172, 20);
            this.dtpPublishDateUser.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(407, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "PUBLISHED DATE";
            // 
            // txtBookPriceUser
            // 
            this.txtBookPriceUser.Location = new System.Drawing.Point(596, 118);
            this.txtBookPriceUser.Name = "txtBookPriceUser";
            this.txtBookPriceUser.Size = new System.Drawing.Size(172, 20);
            this.txtBookPriceUser.TabIndex = 8;
            this.txtBookPriceUser.TextChanged += new System.EventHandler(this.txtBookPriceUser_TextChanged);
            // 
            // lblBookPriceUser
            // 
            this.lblBookPriceUser.AutoSize = true;
            this.lblBookPriceUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookPriceUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblBookPriceUser.Location = new System.Drawing.Point(520, 118);
            this.lblBookPriceUser.Name = "lblBookPriceUser";
            this.lblBookPriceUser.Size = new System.Drawing.Size(70, 24);
            this.lblBookPriceUser.TabIndex = 7;
            this.lblBookPriceUser.Text = "PRICE";
            // 
            // cmbBookCategoryUser
            // 
            this.cmbBookCategoryUser.FormattingEnabled = true;
            this.cmbBookCategoryUser.Items.AddRange(new object[] {
            "CSE",
            "EEE",
            "LAW",
            "BBA"});
            this.cmbBookCategoryUser.Location = new System.Drawing.Point(173, 154);
            this.cmbBookCategoryUser.Name = "cmbBookCategoryUser";
            this.cmbBookCategoryUser.Size = new System.Drawing.Size(171, 21);
            this.cmbBookCategoryUser.TabIndex = 6;
            // 
            // txtBookNameUser
            // 
            this.txtBookNameUser.Location = new System.Drawing.Point(173, 117);
            this.txtBookNameUser.Name = "txtBookNameUser";
            this.txtBookNameUser.Size = new System.Drawing.Size(172, 20);
            this.txtBookNameUser.TabIndex = 5;
            this.txtBookNameUser.TextChanged += new System.EventHandler(this.txtBookNameUser_TextChanged);
            // 
            // txtBookIdUser
            // 
            this.txtBookIdUser.Location = new System.Drawing.Point(173, 81);
            this.txtBookIdUser.Name = "txtBookIdUser";
            this.txtBookIdUser.Size = new System.Drawing.Size(172, 20);
            this.txtBookIdUser.TabIndex = 4;
            this.txtBookIdUser.TextChanged += new System.EventHandler(this.txtBookIdUser_TextChanged);
            // 
            // lblBookCategoryUser
            // 
            this.lblBookCategoryUser.AutoSize = true;
            this.lblBookCategoryUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookCategoryUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblBookCategoryUser.Location = new System.Drawing.Point(43, 152);
            this.lblBookCategoryUser.Name = "lblBookCategoryUser";
            this.lblBookCategoryUser.Size = new System.Drawing.Size(123, 24);
            this.lblBookCategoryUser.TabIndex = 3;
            this.lblBookCategoryUser.Text = "CATEGORY";
            // 
            // lblBookNameUser
            // 
            this.lblBookNameUser.AutoSize = true;
            this.lblBookNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookNameUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblBookNameUser.Location = new System.Drawing.Point(32, 113);
            this.lblBookNameUser.Name = "lblBookNameUser";
            this.lblBookNameUser.Size = new System.Drawing.Size(134, 24);
            this.lblBookNameUser.TabIndex = 2;
            this.lblBookNameUser.Text = "BOOK NAME";
            // 
            // lblBookIdUser
            // 
            this.lblBookIdUser.AutoSize = true;
            this.lblBookIdUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookIdUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblBookIdUser.Location = new System.Drawing.Point(73, 77);
            this.lblBookIdUser.Name = "lblBookIdUser";
            this.lblBookIdUser.Size = new System.Drawing.Size(93, 24);
            this.lblBookIdUser.TabIndex = 1;
            this.lblBookIdUser.Text = "BOOK ID";
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.AutoSize = true;
            this.lblWelcomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblWelcomeUser.Location = new System.Drawing.Point(201, 12);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(205, 39);
            this.lblWelcomeUser.TabIndex = 0;
            this.lblWelcomeUser.Text = "WELCOME ";
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookId,
            this.BookName,
            this.BookCategory,
            this.BookPrice,
            this.PublishDate});
            this.dgvUser.Location = new System.Drawing.Point(3, 283);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.Size = new System.Drawing.Size(795, 162);
            this.dgvUser.TabIndex = 2;
            // 
            // BookId
            // 
            this.BookId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookId.DataPropertyName = "BookId";
            this.BookId.HeaderText = "BOOK ID";
            this.BookId.Name = "BookId";
            this.BookId.ReadOnly = true;
            // 
            // BookName
            // 
            this.BookName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "BOOK NAME";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // BookCategory
            // 
            this.BookCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookCategory.DataPropertyName = "BookCategory";
            this.BookCategory.HeaderText = "CATEGORY";
            this.BookCategory.Name = "BookCategory";
            this.BookCategory.ReadOnly = true;
            // 
            // BookPrice
            // 
            this.BookPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookPrice.DataPropertyName = "BookPrice";
            this.BookPrice.HeaderText = "PRICE";
            this.BookPrice.Name = "BookPrice";
            this.BookPrice.ReadOnly = true;
            // 
            // PublishDate
            // 
            this.PublishDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PublishDate.DataPropertyName = "PublishDate";
            this.PublishDate.HeaderText = "PUBLISHED DATE";
            this.PublishDate.Name = "PublishDate";
            this.PublishDate.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnBookDetailsUser);
            this.panel2.Controls.Add(this.btnClearUSer);
            this.panel2.Controls.Add(this.btnSearchUser);
            this.panel2.Controls.Add(this.btnLogOutUser);
            this.panel2.Location = new System.Drawing.Point(3, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 62);
            this.panel2.TabIndex = 3;
            // 
            // btnBookDetailsUser
            // 
            this.btnBookDetailsUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBookDetailsUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookDetailsUser.ForeColor = System.Drawing.Color.Lime;
            this.btnBookDetailsUser.Location = new System.Drawing.Point(9, 4);
            this.btnBookDetailsUser.Name = "btnBookDetailsUser";
            this.btnBookDetailsUser.Size = new System.Drawing.Size(186, 56);
            this.btnBookDetailsUser.TabIndex = 3;
            this.btnBookDetailsUser.Text = "BOOK\'S INFORMATION";
            this.btnBookDetailsUser.UseVisualStyleBackColor = false;
            this.btnBookDetailsUser.Click += new System.EventHandler(this.btnBookDetailsUser_Click);
            // 
            // btnClearUSer
            // 
            this.btnClearUSer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClearUSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearUSer.ForeColor = System.Drawing.Color.Yellow;
            this.btnClearUSer.Location = new System.Drawing.Point(445, 3);
            this.btnClearUSer.Name = "btnClearUSer";
            this.btnClearUSer.Size = new System.Drawing.Size(132, 56);
            this.btnClearUSer.TabIndex = 2;
            this.btnClearUSer.Text = "CLEAR";
            this.btnClearUSer.UseVisualStyleBackColor = false;
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUser.ForeColor = System.Drawing.Color.Cyan;
            this.btnSearchUser.Location = new System.Drawing.Point(255, 4);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(132, 56);
            this.btnSearchUser.TabIndex = 1;
            this.btnSearchUser.Text = "SEARCH";
            this.btnSearchUser.UseVisualStyleBackColor = false;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // btnLogOutUser
            // 
            this.btnLogOutUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLogOutUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOutUser.ForeColor = System.Drawing.Color.Red;
            this.btnLogOutUser.Location = new System.Drawing.Point(631, 3);
            this.btnLogOutUser.Name = "btnLogOutUser";
            this.btnLogOutUser.Size = new System.Drawing.Size(154, 56);
            this.btnLogOutUser.TabIndex = 0;
            this.btnLogOutUser.Text = "LOG OUT";
            this.btnLogOutUser.UseVisualStyleBackColor = false;
            this.btnLogOutUser.Click += new System.EventHandler(this.btnLogOutUser_Click);
            // 
            // Form_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_User";
            this.Text = "Form_User";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBookDetailsUser;
        private System.Windows.Forms.Button btnClearUSer;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.Button btnLogOutUser;
        private System.Windows.Forms.Label lblWelcomeUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishDate;
        private System.Windows.Forms.Label lblBookIdUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookPriceUser;
        private System.Windows.Forms.Label lblBookPriceUser;
        private System.Windows.Forms.ComboBox cmbBookCategoryUser;
        private System.Windows.Forms.TextBox txtBookNameUser;
        private System.Windows.Forms.TextBox txtBookIdUser;
        private System.Windows.Forms.Label lblBookCategoryUser;
        private System.Windows.Forms.Label lblBookNameUser;
        private System.Windows.Forms.DateTimePicker dtpPublishDateUser;
    }
}