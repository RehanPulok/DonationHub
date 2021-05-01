
namespace DonationHub.Presentation_Layer
{
    partial class Admin
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
            this.LogoutButtonAdmin = new System.Windows.Forms.Button();
            this.OrganisationListDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteOrganisationButtonAdminHome = new System.Windows.Forms.Button();
            this.AddOrganisationButtonAdminHome = new System.Windows.Forms.Button();
            this.BackButtonAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrganisationListDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoutButtonAdmin
            // 
            this.LogoutButtonAdmin.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButtonAdmin.Location = new System.Drawing.Point(548, 46);
            this.LogoutButtonAdmin.Name = "LogoutButtonAdmin";
            this.LogoutButtonAdmin.Size = new System.Drawing.Size(107, 38);
            this.LogoutButtonAdmin.TabIndex = 26;
            this.LogoutButtonAdmin.Text = "Logout";
            this.LogoutButtonAdmin.UseVisualStyleBackColor = true;
            this.LogoutButtonAdmin.Click += new System.EventHandler(this.LogoutButtonAdmin_Click);
            // 
            // OrganisationListDataGridView
            // 
            this.OrganisationListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrganisationListDataGridView.Location = new System.Drawing.Point(321, 109);
            this.OrganisationListDataGridView.Name = "OrganisationListDataGridView";
            this.OrganisationListDataGridView.Size = new System.Drawing.Size(334, 515);
            this.OrganisationListDataGridView.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteOrganisationButtonAdminHome);
            this.groupBox1.Controls.Add(this.AddOrganisationButtonAdminHome);
            this.groupBox1.Location = new System.Drawing.Point(39, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 438);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // DeleteOrganisationButtonAdminHome
            // 
            this.DeleteOrganisationButtonAdminHome.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteOrganisationButtonAdminHome.Location = new System.Drawing.Point(28, 266);
            this.DeleteOrganisationButtonAdminHome.Name = "DeleteOrganisationButtonAdminHome";
            this.DeleteOrganisationButtonAdminHome.Size = new System.Drawing.Size(192, 33);
            this.DeleteOrganisationButtonAdminHome.TabIndex = 26;
            this.DeleteOrganisationButtonAdminHome.Text = "Delete Organisation";
            this.DeleteOrganisationButtonAdminHome.UseVisualStyleBackColor = true;
            this.DeleteOrganisationButtonAdminHome.Click += new System.EventHandler(this.DeleteOrganisationButtonAdminHome_Click);
            // 
            // AddOrganisationButtonAdminHome
            // 
            this.AddOrganisationButtonAdminHome.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrganisationButtonAdminHome.Location = new System.Drawing.Point(28, 135);
            this.AddOrganisationButtonAdminHome.Name = "AddOrganisationButtonAdminHome";
            this.AddOrganisationButtonAdminHome.Size = new System.Drawing.Size(174, 33);
            this.AddOrganisationButtonAdminHome.TabIndex = 25;
            this.AddOrganisationButtonAdminHome.Text = "Add Organisation";
            this.AddOrganisationButtonAdminHome.UseVisualStyleBackColor = true;
            this.AddOrganisationButtonAdminHome.Click += new System.EventHandler(this.AddOrganisationButtonAdminHome_Click);
            // 
            // BackButtonAdmin
            // 
            this.BackButtonAdmin.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButtonAdmin.Location = new System.Drawing.Point(39, 609);
            this.BackButtonAdmin.Name = "BackButtonAdmin";
            this.BackButtonAdmin.Size = new System.Drawing.Size(107, 38);
            this.BackButtonAdmin.TabIndex = 27;
            this.BackButtonAdmin.Text = "Back";
            this.BackButtonAdmin.UseVisualStyleBackColor = true;
            this.BackButtonAdmin.Click += new System.EventHandler(this.BackButtonAdmin_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 671);
            this.Controls.Add(this.BackButtonAdmin);
            this.Controls.Add(this.LogoutButtonAdmin);
            this.Controls.Add(this.OrganisationListDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.OrganisationListDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogoutButtonAdmin;
        private System.Windows.Forms.DataGridView OrganisationListDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteOrganisationButtonAdminHome;
        private System.Windows.Forms.Button AddOrganisationButtonAdminHome;
        private System.Windows.Forms.Button BackButtonAdmin;
    }
}