
namespace DonationHub.Presentation_Layer
{
    partial class SerachOrganisaiton
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
            this.LogoutButtonSearchOrganisation = new System.Windows.Forms.Button();
            this.BackSearchButton = new System.Windows.Forms.Button();
            this.SearchOrganisationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchOrganisationTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchOrganisationTextBox);
            this.groupBox1.Controls.Add(this.SearchOrganisationButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(78, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(408, 464);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Organisation";
            // 
            // LogoutButtonSearchOrganisation
            // 
            this.LogoutButtonSearchOrganisation.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButtonSearchOrganisation.Location = new System.Drawing.Point(418, 15);
            this.LogoutButtonSearchOrganisation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogoutButtonSearchOrganisation.Name = "LogoutButtonSearchOrganisation";
            this.LogoutButtonSearchOrganisation.Size = new System.Drawing.Size(136, 41);
            this.LogoutButtonSearchOrganisation.TabIndex = 21;
            this.LogoutButtonSearchOrganisation.Text = "Logout";
            this.LogoutButtonSearchOrganisation.UseVisualStyleBackColor = true;
            this.LogoutButtonSearchOrganisation.Click += new System.EventHandler(this.LogoutButtonSearchOrganisation_Click);
            // 
            // BackSearchButton
            // 
            this.BackSearchButton.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackSearchButton.Location = new System.Drawing.Point(18, 546);
            this.BackSearchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackSearchButton.Name = "BackSearchButton";
            this.BackSearchButton.Size = new System.Drawing.Size(136, 41);
            this.BackSearchButton.TabIndex = 22;
            this.BackSearchButton.Text = "Back";
            this.BackSearchButton.UseVisualStyleBackColor = true;
            this.BackSearchButton.Click += new System.EventHandler(this.BackSearchButton_Click);
            // 
            // SearchOrganisationButton
            // 
            this.SearchOrganisationButton.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchOrganisationButton.Location = new System.Drawing.Point(131, 189);
            this.SearchOrganisationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchOrganisationButton.Name = "SearchOrganisationButton";
            this.SearchOrganisationButton.Size = new System.Drawing.Size(136, 41);
            this.SearchOrganisationButton.TabIndex = 23;
            this.SearchOrganisationButton.Text = "Search";
            this.SearchOrganisationButton.UseVisualStyleBackColor = true;
            this.SearchOrganisationButton.Click += new System.EventHandler(this.SearchOrganisationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by ID";
            // 
            // SearchOrganisationTextBox
            // 
            this.SearchOrganisationTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchOrganisationTextBox.Location = new System.Drawing.Point(101, 115);
            this.SearchOrganisationTextBox.Name = "SearchOrganisationTextBox";
            this.SearchOrganisationTextBox.Size = new System.Drawing.Size(182, 32);
            this.SearchOrganisationTextBox.TabIndex = 24;
            // 
            // SerachOrganisaiton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 602);
            this.Controls.Add(this.BackSearchButton);
            this.Controls.Add(this.LogoutButtonSearchOrganisation);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SerachOrganisaiton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serach Organisaiton by ID";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SerachOrganisaiton_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SearchOrganisationTextBox;
        private System.Windows.Forms.Button SearchOrganisationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogoutButtonSearchOrganisation;
        private System.Windows.Forms.Button BackSearchButton;
    }
}