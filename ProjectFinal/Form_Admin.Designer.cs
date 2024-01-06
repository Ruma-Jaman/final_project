namespace ProjectFinal
{
    partial class Form_Admin
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPasswordAdmin = new System.Windows.Forms.TextBox();
            this.lblPasswordAdmin = new System.Windows.Forms.Label();
            this.txtRoleAdmin = new System.Windows.Forms.TextBox();
            this.txtUserNameAdmin = new System.Windows.Forms.TextBox();
            this.txtUserIdAdmin = new System.Windows.Forms.TextBox();
            this.lblRoleAdmin = new System.Windows.Forms.Label();
            this.lblUserNameAdmin = new System.Windows.Forms.Label();
            this.lblUserIdAdmin = new System.Windows.Forms.Label();
            this.lblWelcomeAdmin = new System.Windows.Forms.Label();
            this.btnBookInformationAdmin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdminDelete = new System.Windows.Forms.Button();
            this.btnClearAdmin = new System.Windows.Forms.Button();
            this.btnUpdateAdmin = new System.Windows.Forms.Button();
            this.btnSaveAdmin = new System.Windows.Forms.Button();
            this.btnSearchAdmin = new System.Windows.Forms.Button();
            this.btnUserDetails = new System.Windows.Forms.Button();
            this.btnLogOutAdmin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.txtPasswordAdmin);
            this.panel1.Controls.Add(this.lblPasswordAdmin);
            this.panel1.Controls.Add(this.txtRoleAdmin);
            this.panel1.Controls.Add(this.txtUserNameAdmin);
            this.panel1.Controls.Add(this.txtUserIdAdmin);
            this.panel1.Controls.Add(this.lblRoleAdmin);
            this.panel1.Controls.Add(this.lblUserNameAdmin);
            this.panel1.Controls.Add(this.lblUserIdAdmin);
            this.panel1.Controls.Add(this.lblWelcomeAdmin);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 195);
            this.panel1.TabIndex = 1;
            // 
            // txtPasswordAdmin
            // 
            this.txtPasswordAdmin.Location = new System.Drawing.Point(146, 132);
            this.txtPasswordAdmin.Name = "txtPasswordAdmin";
            this.txtPasswordAdmin.Size = new System.Drawing.Size(177, 20);
            this.txtPasswordAdmin.TabIndex = 10;
            // 
            // lblPasswordAdmin
            // 
            this.lblPasswordAdmin.AutoSize = true;
            this.lblPasswordAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordAdmin.Location = new System.Drawing.Point(26, 127);
            this.lblPasswordAdmin.Name = "lblPasswordAdmin";
            this.lblPasswordAdmin.Size = new System.Drawing.Size(114, 25);
            this.lblPasswordAdmin.TabIndex = 9;
            this.lblPasswordAdmin.Text = "Password";
            // 
            // txtRoleAdmin
            // 
            this.txtRoleAdmin.Location = new System.Drawing.Point(146, 164);
            this.txtRoleAdmin.Name = "txtRoleAdmin";
            this.txtRoleAdmin.Size = new System.Drawing.Size(177, 20);
            this.txtRoleAdmin.TabIndex = 8;
            // 
            // txtUserNameAdmin
            // 
            this.txtUserNameAdmin.Location = new System.Drawing.Point(146, 99);
            this.txtUserNameAdmin.Name = "txtUserNameAdmin";
            this.txtUserNameAdmin.Size = new System.Drawing.Size(177, 20);
            this.txtUserNameAdmin.TabIndex = 6;
            // 
            // txtUserIdAdmin
            // 
            this.txtUserIdAdmin.Location = new System.Drawing.Point(146, 67);
            this.txtUserIdAdmin.Name = "txtUserIdAdmin";
            this.txtUserIdAdmin.Size = new System.Drawing.Size(177, 20);
            this.txtUserIdAdmin.TabIndex = 5;
            // 
            // lblRoleAdmin
            // 
            this.lblRoleAdmin.AutoSize = true;
            this.lblRoleAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleAdmin.Location = new System.Drawing.Point(80, 159);
            this.lblRoleAdmin.Name = "lblRoleAdmin";
            this.lblRoleAdmin.Size = new System.Drawing.Size(60, 25);
            this.lblRoleAdmin.TabIndex = 4;
            this.lblRoleAdmin.Text = "Role";
            // 
            // lblUserNameAdmin
            // 
            this.lblUserNameAdmin.AutoSize = true;
            this.lblUserNameAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameAdmin.Location = new System.Drawing.Point(15, 94);
            this.lblUserNameAdmin.Name = "lblUserNameAdmin";
            this.lblUserNameAdmin.Size = new System.Drawing.Size(128, 25);
            this.lblUserNameAdmin.TabIndex = 2;
            this.lblUserNameAdmin.Text = "User Name";
            // 
            // lblUserIdAdmin
            // 
            this.lblUserIdAdmin.AutoSize = true;
            this.lblUserIdAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIdAdmin.Location = new System.Drawing.Point(53, 62);
            this.lblUserIdAdmin.Name = "lblUserIdAdmin";
            this.lblUserIdAdmin.Size = new System.Drawing.Size(87, 25);
            this.lblUserIdAdmin.TabIndex = 1;
            this.lblUserIdAdmin.Text = "User Id";
            // 
            // lblWelcomeAdmin
            // 
            this.lblWelcomeAdmin.AutoSize = true;
            this.lblWelcomeAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeAdmin.Location = new System.Drawing.Point(233, 9);
            this.lblWelcomeAdmin.Name = "lblWelcomeAdmin";
            this.lblWelcomeAdmin.Size = new System.Drawing.Size(213, 39);
            this.lblWelcomeAdmin.TabIndex = 0;
            this.lblWelcomeAdmin.Text = "WELCOME ";
            // 
            // btnBookInformationAdmin
            // 
            this.btnBookInformationAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBookInformationAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookInformationAdmin.ForeColor = System.Drawing.Color.White;
            this.btnBookInformationAdmin.Location = new System.Drawing.Point(3, 4);
            this.btnBookInformationAdmin.Name = "btnBookInformationAdmin";
            this.btnBookInformationAdmin.Size = new System.Drawing.Size(137, 163);
            this.btnBookInformationAdmin.TabIndex = 1;
            this.btnBookInformationAdmin.Text = "BOOK\'S INFORMATION";
            this.btnBookInformationAdmin.UseVisualStyleBackColor = false;
            this.btnBookInformationAdmin.Click += new System.EventHandler(this.btnBookInformationAdmin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.btnAdminDelete);
            this.panel2.Controls.Add(this.btnClearAdmin);
            this.panel2.Controls.Add(this.btnUpdateAdmin);
            this.panel2.Controls.Add(this.btnSaveAdmin);
            this.panel2.Controls.Add(this.btnSearchAdmin);
            this.panel2.Controls.Add(this.btnUserDetails);
            this.panel2.Controls.Add(this.btnLogOutAdmin);
            this.panel2.Location = new System.Drawing.Point(0, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 73);
            this.panel2.TabIndex = 2;
            // 
            // btnAdminDelete
            // 
            this.btnAdminDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdminDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminDelete.ForeColor = System.Drawing.Color.White;
            this.btnAdminDelete.Location = new System.Drawing.Point(349, 3);
            this.btnAdminDelete.Name = "btnAdminDelete";
            this.btnAdminDelete.Size = new System.Drawing.Size(103, 66);
            this.btnAdminDelete.TabIndex = 6;
            this.btnAdminDelete.Text = "DELETE";
            this.btnAdminDelete.UseVisualStyleBackColor = false;
            this.btnAdminDelete.Click += new System.EventHandler(this.btnAdminDelete_Click);
            // 
            // btnClearAdmin
            // 
            this.btnClearAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClearAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAdmin.ForeColor = System.Drawing.Color.White;
            this.btnClearAdmin.Location = new System.Drawing.Point(243, 3);
            this.btnClearAdmin.Name = "btnClearAdmin";
            this.btnClearAdmin.Size = new System.Drawing.Size(100, 67);
            this.btnClearAdmin.TabIndex = 5;
            this.btnClearAdmin.Text = "CLEAR";
            this.btnClearAdmin.UseVisualStyleBackColor = false;
            this.btnClearAdmin.Click += new System.EventHandler(this.btnClearAdmin_Click);
            // 
            // btnUpdateAdmin
            // 
            this.btnUpdateAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdateAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAdmin.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAdmin.Location = new System.Drawing.Point(458, 2);
            this.btnUpdateAdmin.Name = "btnUpdateAdmin";
            this.btnUpdateAdmin.Size = new System.Drawing.Size(100, 67);
            this.btnUpdateAdmin.TabIndex = 4;
            this.btnUpdateAdmin.Text = "UPDATE";
            this.btnUpdateAdmin.UseVisualStyleBackColor = false;
            this.btnUpdateAdmin.Click += new System.EventHandler(this.btnUpdateAdmin_Click);
            // 
            // btnSaveAdmin
            // 
            this.btnSaveAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAdmin.ForeColor = System.Drawing.Color.White;
            this.btnSaveAdmin.Location = new System.Drawing.Point(564, 2);
            this.btnSaveAdmin.Name = "btnSaveAdmin";
            this.btnSaveAdmin.Size = new System.Drawing.Size(100, 67);
            this.btnSaveAdmin.TabIndex = 3;
            this.btnSaveAdmin.Text = "SAVE";
            this.btnSaveAdmin.UseVisualStyleBackColor = false;
            this.btnSaveAdmin.Click += new System.EventHandler(this.btnSaveAdmin_Click);
            // 
            // btnSearchAdmin
            // 
            this.btnSearchAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearchAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAdmin.ForeColor = System.Drawing.Color.White;
            this.btnSearchAdmin.Location = new System.Drawing.Point(137, 3);
            this.btnSearchAdmin.Name = "btnSearchAdmin";
            this.btnSearchAdmin.Size = new System.Drawing.Size(100, 67);
            this.btnSearchAdmin.TabIndex = 2;
            this.btnSearchAdmin.Text = "SEARCH";
            this.btnSearchAdmin.UseVisualStyleBackColor = false;
            this.btnSearchAdmin.Click += new System.EventHandler(this.btnSearchAdmin_Click);
            // 
            // btnUserDetails
            // 
            this.btnUserDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUserDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserDetails.ForeColor = System.Drawing.Color.White;
            this.btnUserDetails.Location = new System.Drawing.Point(3, 3);
            this.btnUserDetails.Name = "btnUserDetails";
            this.btnUserDetails.Size = new System.Drawing.Size(128, 67);
            this.btnUserDetails.TabIndex = 1;
            this.btnUserDetails.Text = "USER DETAILS";
            this.btnUserDetails.UseVisualStyleBackColor = false;
            this.btnUserDetails.Click += new System.EventHandler(this.btnUserDetails_Click);
            // 
            // btnLogOutAdmin
            // 
            this.btnLogOutAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogOutAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOutAdmin.ForeColor = System.Drawing.Color.White;
            this.btnLogOutAdmin.Location = new System.Drawing.Point(670, 3);
            this.btnLogOutAdmin.Name = "btnLogOutAdmin";
            this.btnLogOutAdmin.Size = new System.Drawing.Size(127, 67);
            this.btnLogOutAdmin.TabIndex = 0;
            this.btnLogOutAdmin.Text = "LOGOUT";
            this.btnLogOutAdmin.UseVisualStyleBackColor = false;
            this.btnLogOutAdmin.Click += new System.EventHandler(this.btnLogOutAdmin_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBookInformationAdmin);
            this.panel3.Controls.Add(this.dgvAdmin);
            this.panel3.Location = new System.Drawing.Point(3, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 170);
            this.panel3.TabIndex = 2;
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AllowUserToAddRows = false;
            this.dgvAdmin.AllowUserToDeleteRows = false;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.UserName,
            this.UserPassword,
            this.UserRole});
            this.dgvAdmin.Location = new System.Drawing.Point(143, 3);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.ReadOnly = true;
            this.dgvAdmin.Size = new System.Drawing.Size(648, 164);
            this.dgvAdmin.TabIndex = 0;
            // 
            // UserId
            // 
            this.UserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "User ID";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "User Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // UserPassword
            // 
            this.UserPassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserPassword.DataPropertyName = "UserPassword";
            this.UserPassword.HeaderText = "Password";
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.ReadOnly = true;
            // 
            // UserRole
            // 
            this.UserRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserRole.DataPropertyName = "UserRole";
            this.UserRole.HeaderText = "Role";
            this.UserRole.Name = "UserRole";
            this.UserRole.ReadOnly = true;
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Admin";
            this.Text = "Form_Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUserIdAdmin;
        private System.Windows.Forms.Label lblRoleAdmin;
        private System.Windows.Forms.Label lblUserNameAdmin;
        private System.Windows.Forms.Label lblUserIdAdmin;
        private System.Windows.Forms.Label lblWelcomeAdmin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtRoleAdmin;
        private System.Windows.Forms.TextBox txtUserNameAdmin;
        private System.Windows.Forms.Button btnBookInformationAdmin;
        private System.Windows.Forms.Button btnClearAdmin;
        private System.Windows.Forms.Button btnUpdateAdmin;
        private System.Windows.Forms.Button btnSaveAdmin;
        private System.Windows.Forms.Button btnSearchAdmin;
        private System.Windows.Forms.Button btnUserDetails;
        private System.Windows.Forms.Button btnLogOutAdmin;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRole;
        private System.Windows.Forms.Label lblPasswordAdmin;
        private System.Windows.Forms.TextBox txtPasswordAdmin;
        private System.Windows.Forms.Button btnAdminDelete;
    }
}

