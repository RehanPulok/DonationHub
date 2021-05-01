
namespace DonationHub.Presentation_Layer
{
    partial class ViewOrganisation
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
            this.EventDataGridView = new System.Windows.Forms.DataGridView();
            this.LogoutButtonViewOrganisation = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.updateProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOrganisationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchOrganisationByIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.EventDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EventDataGridView
            // 
            this.EventDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventDataGridView.Location = new System.Drawing.Point(12, 66);
            this.EventDataGridView.Name = "EventDataGridView";
            this.EventDataGridView.Size = new System.Drawing.Size(592, 517);
            this.EventDataGridView.TabIndex = 12;
            this.EventDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventDataGridView_CellContentClick);
            // 
            // LogoutButtonViewOrganisation
            // 
            this.LogoutButtonViewOrganisation.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButtonViewOrganisation.Location = new System.Drawing.Point(513, 27);
            this.LogoutButtonViewOrganisation.Name = "LogoutButtonViewOrganisation";
            this.LogoutButtonViewOrganisation.Size = new System.Drawing.Size(91, 33);
            this.LogoutButtonViewOrganisation.TabIndex = 20;
            this.LogoutButtonViewOrganisation.Text = "Logout";
            this.LogoutButtonViewOrganisation.UseVisualStyleBackColor = true;
            this.LogoutButtonViewOrganisation.Click += new System.EventHandler(this.LogoutButtonViewOrganisation_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateProfileToolStripMenuItem,
            this.viewOrganisationToolStripMenuItem1,
            this.transactionToolStripMenuItem1,
            this.searchOrganisationByIDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // updateProfileToolStripMenuItem
            // 
            this.updateProfileToolStripMenuItem.Name = "updateProfileToolStripMenuItem";
            this.updateProfileToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.updateProfileToolStripMenuItem.Text = "Update Profile";
            this.updateProfileToolStripMenuItem.Click += new System.EventHandler(this.updateProfileToolStripMenuItem_Click);
            // 
            // viewOrganisationToolStripMenuItem1
            // 
            this.viewOrganisationToolStripMenuItem1.Name = "viewOrganisationToolStripMenuItem1";
            this.viewOrganisationToolStripMenuItem1.Size = new System.Drawing.Size(115, 20);
            this.viewOrganisationToolStripMenuItem1.Text = "View Organisation";
            // 
            // transactionToolStripMenuItem1
            // 
            this.transactionToolStripMenuItem1.Name = "transactionToolStripMenuItem1";
            this.transactionToolStripMenuItem1.Size = new System.Drawing.Size(79, 20);
            this.transactionToolStripMenuItem1.Text = "Transaction";
            // 
            // searchOrganisationByIDToolStripMenuItem
            // 
            this.searchOrganisationByIDToolStripMenuItem.Name = "searchOrganisationByIDToolStripMenuItem";
            this.searchOrganisationByIDToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
            this.searchOrganisationByIDToolStripMenuItem.Text = "Search Organisation by ID";
            // 
            // ViewOrganisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 625);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LogoutButtonViewOrganisation);
            this.Controls.Add(this.EventDataGridView);
            this.Name = "ViewOrganisation";
            this.Text = "ViewOrganisation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewOrganisation_FormClosing);
            this.Load += new System.EventHandler(this.ViewOrganisation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EventDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EventDataGridView;
        private System.Windows.Forms.Button LogoutButtonViewOrganisation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOrganisationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchOrganisationByIDToolStripMenuItem;
    }
}