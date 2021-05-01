
namespace DonationHub.Presentation_Layer
{
    partial class DeleteUser
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
            this.BackButtonUserDelete = new System.Windows.Forms.Button();
            this.LogoutButtonDeleteUser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchOrganisationTextBox = new System.Windows.Forms.TextBox();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButtonUserDelete
            // 
            this.BackButtonUserDelete.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButtonUserDelete.Location = new System.Drawing.Point(13, 556);
            this.BackButtonUserDelete.Margin = new System.Windows.Forms.Padding(4);
            this.BackButtonUserDelete.Name = "BackButtonUserDelete";
            this.BackButtonUserDelete.Size = new System.Drawing.Size(136, 41);
            this.BackButtonUserDelete.TabIndex = 28;
            this.BackButtonUserDelete.Text = "Back";
            this.BackButtonUserDelete.UseVisualStyleBackColor = true;
            this.BackButtonUserDelete.Click += new System.EventHandler(this.BackButtonUserDelete_Click);
            // 
            // LogoutButtonDeleteUser
            // 
            this.LogoutButtonDeleteUser.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButtonDeleteUser.Location = new System.Drawing.Point(382, 32);
            this.LogoutButtonDeleteUser.Margin = new System.Windows.Forms.Padding(4);
            this.LogoutButtonDeleteUser.Name = "LogoutButtonDeleteUser";
            this.LogoutButtonDeleteUser.Size = new System.Drawing.Size(136, 41);
            this.LogoutButtonDeleteUser.TabIndex = 27;
            this.LogoutButtonDeleteUser.Text = "Logout";
            this.LogoutButtonDeleteUser.UseVisualStyleBackColor = true;
            this.LogoutButtonDeleteUser.Click += new System.EventHandler(this.LogoutButtonDeleteUser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchOrganisationTextBox);
            this.groupBox1.Controls.Add(this.DeleteUserButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(408, 464);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete User";
            // 
            // SearchOrganisationTextBox
            // 
            this.SearchOrganisationTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchOrganisationTextBox.Location = new System.Drawing.Point(101, 115);
            this.SearchOrganisationTextBox.Name = "SearchOrganisationTextBox";
            this.SearchOrganisationTextBox.Size = new System.Drawing.Size(182, 32);
            this.SearchOrganisationTextBox.TabIndex = 24;
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUserButton.Location = new System.Drawing.Point(131, 189);
            this.DeleteUserButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(136, 41);
            this.DeleteUserButton.TabIndex = 23;
            this.DeleteUserButton.Text = "Delete";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
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
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 610);
            this.Controls.Add(this.BackButtonUserDelete);
            this.Controls.Add(this.LogoutButtonDeleteUser);
            this.Controls.Add(this.groupBox1);
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButtonUserDelete;
        private System.Windows.Forms.Button LogoutButtonDeleteUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SearchOrganisationTextBox;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.Label label1;
    }
}