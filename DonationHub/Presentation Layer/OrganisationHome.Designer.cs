
namespace DonationHub.Presentation_Layer
{
    partial class OrganisationHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EventDataGridView = new System.Windows.Forms.DataGridView();
            this.LogoutButtonOrganisationHome = new System.Windows.Forms.Button();
            this.UpdateEventButtonOrganisationHome = new System.Windows.Forms.Button();
            this.AddEventButtonOrganisationHome = new System.Windows.Forms.Button();
            this.BackButtonOrganisationHome = new System.Windows.Forms.Button();
            this.DeleteEventButtonOrganisationHome = new System.Windows.Forms.Button();
            this.updateProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.updateProfileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteEventButtonOrganisationHome);
            this.groupBox1.Controls.Add(this.AddEventButtonOrganisationHome);
            this.groupBox1.Controls.Add(this.UpdateEventButtonOrganisationHome);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 498);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // EventDataGridView
            // 
            this.EventDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventDataGridView.Location = new System.Drawing.Point(274, 27);
            this.EventDataGridView.Name = "EventDataGridView";
            this.EventDataGridView.Size = new System.Drawing.Size(392, 498);
            this.EventDataGridView.TabIndex = 2;
            // 
            // LogoutButtonOrganisationHome
            // 
            this.LogoutButtonOrganisationHome.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButtonOrganisationHome.Location = new System.Drawing.Point(575, 543);
            this.LogoutButtonOrganisationHome.Name = "LogoutButtonOrganisationHome";
            this.LogoutButtonOrganisationHome.Size = new System.Drawing.Size(91, 33);
            this.LogoutButtonOrganisationHome.TabIndex = 21;
            this.LogoutButtonOrganisationHome.Text = "Logout";
            this.LogoutButtonOrganisationHome.UseVisualStyleBackColor = true;
            // 
            // UpdateEventButtonOrganisationHome
            // 
            this.UpdateEventButtonOrganisationHome.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateEventButtonOrganisationHome.Location = new System.Drawing.Point(28, 226);
            this.UpdateEventButtonOrganisationHome.Name = "UpdateEventButtonOrganisationHome";
            this.UpdateEventButtonOrganisationHome.Size = new System.Drawing.Size(174, 33);
            this.UpdateEventButtonOrganisationHome.TabIndex = 24;
            this.UpdateEventButtonOrganisationHome.Text = "Update Event";
            this.UpdateEventButtonOrganisationHome.UseVisualStyleBackColor = true;
            // 
            // AddEventButtonOrganisationHome
            // 
            this.AddEventButtonOrganisationHome.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEventButtonOrganisationHome.Location = new System.Drawing.Point(28, 135);
            this.AddEventButtonOrganisationHome.Name = "AddEventButtonOrganisationHome";
            this.AddEventButtonOrganisationHome.Size = new System.Drawing.Size(174, 33);
            this.AddEventButtonOrganisationHome.TabIndex = 25;
            this.AddEventButtonOrganisationHome.Text = "Add Event";
            this.AddEventButtonOrganisationHome.UseVisualStyleBackColor = true;
            this.AddEventButtonOrganisationHome.Click += new System.EventHandler(this.AddEventButtonOrganisationHome_Click);
            // 
            // BackButtonOrganisationHome
            // 
            this.BackButtonOrganisationHome.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButtonOrganisationHome.Location = new System.Drawing.Point(12, 543);
            this.BackButtonOrganisationHome.Name = "BackButtonOrganisationHome";
            this.BackButtonOrganisationHome.Size = new System.Drawing.Size(91, 33);
            this.BackButtonOrganisationHome.TabIndex = 26;
            this.BackButtonOrganisationHome.Text = "Logout";
            this.BackButtonOrganisationHome.UseVisualStyleBackColor = true;
            // 
            // DeleteEventButtonOrganisationHome
            // 
            this.DeleteEventButtonOrganisationHome.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteEventButtonOrganisationHome.Location = new System.Drawing.Point(28, 321);
            this.DeleteEventButtonOrganisationHome.Name = "DeleteEventButtonOrganisationHome";
            this.DeleteEventButtonOrganisationHome.Size = new System.Drawing.Size(174, 33);
            this.DeleteEventButtonOrganisationHome.TabIndex = 26;
            this.DeleteEventButtonOrganisationHome.Text = "Delete Event";
            this.DeleteEventButtonOrganisationHome.UseVisualStyleBackColor = true;
            // 
            // updateProfileToolStripMenuItem
            // 
            this.updateProfileToolStripMenuItem.Name = "updateProfileToolStripMenuItem";
            this.updateProfileToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.updateProfileToolStripMenuItem.Text = "Update Profile";
            this.updateProfileToolStripMenuItem.Click += new System.EventHandler(this.updateProfileToolStripMenuItem_Click);
            // 
            // OrganisationHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 588);
            this.Controls.Add(this.BackButtonOrganisationHome);
            this.Controls.Add(this.LogoutButtonOrganisationHome);
            this.Controls.Add(this.EventDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrganisationHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrganisationHome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrganisationHome_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EventDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView EventDataGridView;
        private System.Windows.Forms.Button DeleteEventButtonOrganisationHome;
        private System.Windows.Forms.Button AddEventButtonOrganisationHome;
        private System.Windows.Forms.Button UpdateEventButtonOrganisationHome;
        private System.Windows.Forms.Button LogoutButtonOrganisationHome;
        private System.Windows.Forms.Button BackButtonOrganisationHome;
        private System.Windows.Forms.ToolStripMenuItem updateProfileToolStripMenuItem;
    }
}