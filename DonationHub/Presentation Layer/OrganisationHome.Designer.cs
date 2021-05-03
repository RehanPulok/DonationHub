
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
            this.updateProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EventDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateEventTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EventIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EventNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteEventButtonOrganisationHome = new System.Windows.Forms.Button();
            this.AddEventButtonOrganisationHome = new System.Windows.Forms.Button();
            this.UpdateEventButtonOrganisationHome = new System.Windows.Forms.Button();
            this.EventDataGridView = new System.Windows.Forms.DataGridView();
            this.LogoutButtonOrganisationHome = new System.Windows.Forms.Button();
            this.BackButtonOrganisationHome = new System.Windows.Forms.Button();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            // updateProfileToolStripMenuItem
            // 
            this.updateProfileToolStripMenuItem.Name = "updateProfileToolStripMenuItem";
            this.updateProfileToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.updateProfileToolStripMenuItem.Text = "Update Profile";
            this.updateProfileToolStripMenuItem.Click += new System.EventHandler(this.updateProfileToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EventDateTimePicker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CreateEventTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.EventIDTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.EventNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DeleteEventButtonOrganisationHome);
            this.groupBox1.Controls.Add(this.AddEventButtonOrganisationHome);
            this.groupBox1.Controls.Add(this.UpdateEventButtonOrganisationHome);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 498);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // EventDateTimePicker
            // 
            this.EventDateTimePicker.Location = new System.Drawing.Point(28, 118);
            this.EventDateTimePicker.Name = "EventDateTimePicker";
            this.EventDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.EventDateTimePicker.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Date";
            // 
            // CreateEventTextBox
            // 
            this.CreateEventTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateEventTextBox.Location = new System.Drawing.Point(28, 46);
            this.CreateEventTextBox.Name = "CreateEventTextBox";
            this.CreateEventTextBox.Size = new System.Drawing.Size(182, 32);
            this.CreateEventTextBox.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Event Name";
            // 
            // EventIDTextBox
            // 
            this.EventIDTextBox.Enabled = false;
            this.EventIDTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventIDTextBox.Location = new System.Drawing.Point(28, 271);
            this.EventIDTextBox.Name = "EventIDTextBox";
            this.EventIDTextBox.Size = new System.Drawing.Size(182, 32);
            this.EventIDTextBox.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Event ID";
            // 
            // EventNameTextBox
            // 
            this.EventNameTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNameTextBox.Location = new System.Drawing.Point(26, 342);
            this.EventNameTextBox.Name = "EventNameTextBox";
            this.EventNameTextBox.Size = new System.Drawing.Size(182, 32);
            this.EventNameTextBox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 306);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Event Name";
            // 
            // DeleteEventButtonOrganisationHome
            // 
            this.DeleteEventButtonOrganisationHome.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteEventButtonOrganisationHome.Location = new System.Drawing.Point(28, 448);
            this.DeleteEventButtonOrganisationHome.Name = "DeleteEventButtonOrganisationHome";
            this.DeleteEventButtonOrganisationHome.Size = new System.Drawing.Size(174, 33);
            this.DeleteEventButtonOrganisationHome.TabIndex = 26;
            this.DeleteEventButtonOrganisationHome.Text = "Delete Event";
            this.DeleteEventButtonOrganisationHome.UseVisualStyleBackColor = true;
            this.DeleteEventButtonOrganisationHome.Click += new System.EventHandler(this.DeleteEventButtonOrganisationHome_Click);
            // 
            // AddEventButtonOrganisationHome
            // 
            this.AddEventButtonOrganisationHome.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEventButtonOrganisationHome.Location = new System.Drawing.Point(28, 162);
            this.AddEventButtonOrganisationHome.Name = "AddEventButtonOrganisationHome";
            this.AddEventButtonOrganisationHome.Size = new System.Drawing.Size(174, 33);
            this.AddEventButtonOrganisationHome.TabIndex = 25;
            this.AddEventButtonOrganisationHome.Text = "Add Event";
            this.AddEventButtonOrganisationHome.UseVisualStyleBackColor = true;
            this.AddEventButtonOrganisationHome.Click += new System.EventHandler(this.AddEventButtonOrganisationHome_Click);
            // 
            // UpdateEventButtonOrganisationHome
            // 
            this.UpdateEventButtonOrganisationHome.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateEventButtonOrganisationHome.Location = new System.Drawing.Point(28, 399);
            this.UpdateEventButtonOrganisationHome.Name = "UpdateEventButtonOrganisationHome";
            this.UpdateEventButtonOrganisationHome.Size = new System.Drawing.Size(174, 33);
            this.UpdateEventButtonOrganisationHome.TabIndex = 24;
            this.UpdateEventButtonOrganisationHome.Text = "Update Event";
            this.UpdateEventButtonOrganisationHome.UseVisualStyleBackColor = true;
            this.UpdateEventButtonOrganisationHome.Click += new System.EventHandler(this.UpdateEventButtonOrganisationHome_Click);
            // 
            // EventDataGridView
            // 
            this.EventDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventDataGridView.Location = new System.Drawing.Point(274, 66);
            this.EventDataGridView.Name = "EventDataGridView";
            this.EventDataGridView.Size = new System.Drawing.Size(392, 510);
            this.EventDataGridView.TabIndex = 2;
            this.EventDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventDataGridView_CellClick);
            // 
            // LogoutButtonOrganisationHome
            // 
            this.LogoutButtonOrganisationHome.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButtonOrganisationHome.Location = new System.Drawing.Point(575, 27);
            this.LogoutButtonOrganisationHome.Name = "LogoutButtonOrganisationHome";
            this.LogoutButtonOrganisationHome.Size = new System.Drawing.Size(91, 33);
            this.LogoutButtonOrganisationHome.TabIndex = 21;
            this.LogoutButtonOrganisationHome.Text = "Logout";
            this.LogoutButtonOrganisationHome.UseVisualStyleBackColor = true;
            this.LogoutButtonOrganisationHome.Click += new System.EventHandler(this.LogoutButtonOrganisationHome_Click);
            // 
            // BackButtonOrganisationHome
            // 
            this.BackButtonOrganisationHome.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButtonOrganisationHome.Location = new System.Drawing.Point(12, 552);
            this.BackButtonOrganisationHome.Name = "BackButtonOrganisationHome";
            this.BackButtonOrganisationHome.Size = new System.Drawing.Size(91, 33);
            this.BackButtonOrganisationHome.TabIndex = 26;
            this.BackButtonOrganisationHome.Text = "Back";
            this.BackButtonOrganisationHome.UseVisualStyleBackColor = true;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Enabled = false;
            this.IDTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextBox.Location = new System.Drawing.Point(318, 28);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(182, 32);
            this.IDTextBox.TabIndex = 38;
            this.IDTextBox.TextChanged += new System.EventHandler(this.IDTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(270, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "ID";
            // 
            // OrganisationHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 588);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label5);
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
            this.Load += new System.EventHandler(this.OrganisationHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox EventIDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EventNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker EventDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CreateEventTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label5;
    }
}