
namespace DonationHub.Presentation_Layer
{
    partial class AdminHome
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteUserButtonAdminHome = new System.Windows.Forms.Button();
            this.AddUserButtonAdminHome = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organisationListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserListDataGridView = new System.Windows.Forms.DataGridView();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteUserButtonAdminHome);
            this.groupBox1.Controls.Add(this.AddUserButtonAdminHome);
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 438);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // DeleteUserButtonAdminHome
            // 
            this.DeleteUserButtonAdminHome.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUserButtonAdminHome.Location = new System.Drawing.Point(28, 266);
            this.DeleteUserButtonAdminHome.Name = "DeleteUserButtonAdminHome";
            this.DeleteUserButtonAdminHome.Size = new System.Drawing.Size(174, 33);
            this.DeleteUserButtonAdminHome.TabIndex = 26;
            this.DeleteUserButtonAdminHome.Text = "Delete User";
            this.DeleteUserButtonAdminHome.UseVisualStyleBackColor = true;
            this.DeleteUserButtonAdminHome.Click += new System.EventHandler(this.DeleteUserButtonAdminHome_Click);
            // 
            // AddUserButtonAdminHome
            // 
            this.AddUserButtonAdminHome.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserButtonAdminHome.Location = new System.Drawing.Point(28, 135);
            this.AddUserButtonAdminHome.Name = "AddUserButtonAdminHome";
            this.AddUserButtonAdminHome.Size = new System.Drawing.Size(174, 33);
            this.AddUserButtonAdminHome.TabIndex = 25;
            this.AddUserButtonAdminHome.Text = "Add User";
            this.AddUserButtonAdminHome.UseVisualStyleBackColor = true;
            this.AddUserButtonAdminHome.Click += new System.EventHandler(this.AddUserButtonAdminHome_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userListToolStripMenuItem,
            this.organisationListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userListToolStripMenuItem
            // 
            this.userListToolStripMenuItem.Name = "userListToolStripMenuItem";
            this.userListToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.userListToolStripMenuItem.Text = "User List";
            // 
            // organisationListToolStripMenuItem
            // 
            this.organisationListToolStripMenuItem.Name = "organisationListToolStripMenuItem";
            this.organisationListToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.organisationListToolStripMenuItem.Text = "Organisation List";
            this.organisationListToolStripMenuItem.Click += new System.EventHandler(this.organisationListToolStripMenuItem_Click);
            // 
            // UserListDataGridView
            // 
            this.UserListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserListDataGridView.Location = new System.Drawing.Point(294, 90);
            this.UserListDataGridView.Name = "UserListDataGridView";
            this.UserListDataGridView.Size = new System.Drawing.Size(334, 515);
            this.UserListDataGridView.TabIndex = 4;
            this.UserListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserListDataGridView_CellContentClick);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.Location = new System.Drawing.Point(521, 27);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(107, 38);
            this.LogoutButton.TabIndex = 23;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 645);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.UserListDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminHome_FormClosing);
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteUserButtonAdminHome;
        private System.Windows.Forms.Button AddUserButtonAdminHome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organisationListToolStripMenuItem;
        private System.Windows.Forms.DataGridView UserListDataGridView;
        private System.Windows.Forms.Button LogoutButton;
    }
}