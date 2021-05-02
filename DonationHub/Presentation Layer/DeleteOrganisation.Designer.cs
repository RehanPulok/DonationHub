
namespace DonationHub.Presentation_Layer
{
    partial class DeleteOrganisation
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
            this.BackDeleteButton = new System.Windows.Forms.Button();
            this.LogoutButtonDeleteOrganisation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchOrganisationTextBox = new System.Windows.Forms.TextBox();
            this.DeleteOrganisationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackDeleteButton
            // 
            this.BackDeleteButton.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackDeleteButton.Location = new System.Drawing.Point(15, 559);
            this.BackDeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackDeleteButton.Name = "BackDeleteButton";
            this.BackDeleteButton.Size = new System.Drawing.Size(136, 41);
            this.BackDeleteButton.TabIndex = 25;
            this.BackDeleteButton.Text = "Back";
            this.BackDeleteButton.UseVisualStyleBackColor = true;
            this.BackDeleteButton.Click += new System.EventHandler(this.BackDeleteButton_Click);
            // 
            // LogoutButtonDeleteOrganisation
            // 
            this.LogoutButtonDeleteOrganisation.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButtonDeleteOrganisation.Location = new System.Drawing.Point(415, 28);
            this.LogoutButtonDeleteOrganisation.Margin = new System.Windows.Forms.Padding(4);
            this.LogoutButtonDeleteOrganisation.Name = "LogoutButtonDeleteOrganisation";
            this.LogoutButtonDeleteOrganisation.Size = new System.Drawing.Size(136, 41);
            this.LogoutButtonDeleteOrganisation.TabIndex = 24;
            this.LogoutButtonDeleteOrganisation.Text = "Logout";
            this.LogoutButtonDeleteOrganisation.UseVisualStyleBackColor = true;
            this.LogoutButtonDeleteOrganisation.Click += new System.EventHandler(this.LogoutButtonDeleteOrganisation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchOrganisationTextBox);
            this.groupBox1.Controls.Add(this.DeleteOrganisationButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(75, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(408, 464);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Organisation";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SearchOrganisationTextBox
            // 
            this.SearchOrganisationTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchOrganisationTextBox.Location = new System.Drawing.Point(101, 115);
            this.SearchOrganisationTextBox.Name = "SearchOrganisationTextBox";
            this.SearchOrganisationTextBox.Size = new System.Drawing.Size(182, 32);
            this.SearchOrganisationTextBox.TabIndex = 24;
            // 
            // DeleteOrganisationButton
            // 
            this.DeleteOrganisationButton.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteOrganisationButton.Location = new System.Drawing.Point(131, 190);
            this.DeleteOrganisationButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteOrganisationButton.Name = "DeleteOrganisationButton";
            this.DeleteOrganisationButton.Size = new System.Drawing.Size(136, 41);
            this.DeleteOrganisationButton.TabIndex = 23;
            this.DeleteOrganisationButton.Text = "Delete";
            this.DeleteOrganisationButton.UseVisualStyleBackColor = true;
            //this.DeleteOrganisationButton.Click += new System.EventHandler(this.DeleteOrganisationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete by ID";
            // 
            // DeleteOrganisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 608);
            this.Controls.Add(this.BackDeleteButton);
            this.Controls.Add(this.LogoutButtonDeleteOrganisation);
            this.Controls.Add(this.groupBox1);
            this.Name = "DeleteOrganisation";
            this.Text = "DeleteOrganisation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackDeleteButton;
        private System.Windows.Forms.Button LogoutButtonDeleteOrganisation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SearchOrganisationTextBox;
        private System.Windows.Forms.Button DeleteOrganisationButton;
        private System.Windows.Forms.Label label1;
    }
}