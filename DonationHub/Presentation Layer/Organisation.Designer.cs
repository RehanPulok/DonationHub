
namespace DonationHub.Presentation_Layer
{
    partial class Organisation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Organisation));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DonateMoneyButton = new System.Windows.Forms.Button();
            this.DonateFoodButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DonateMoneyButton);
            this.groupBox1.Controls.Add(this.DonateFoodButton);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(41, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 573);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // DonateMoneyButton
            // 
            this.DonateMoneyButton.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonateMoneyButton.Location = new System.Drawing.Point(408, 358);
            this.DonateMoneyButton.Name = "DonateMoneyButton";
            this.DonateMoneyButton.Size = new System.Drawing.Size(169, 38);
            this.DonateMoneyButton.TabIndex = 10;
            this.DonateMoneyButton.Text = "Donate Money";
            this.DonateMoneyButton.UseVisualStyleBackColor = true;
            this.DonateMoneyButton.Click += new System.EventHandler(this.DonateMoneyButton_Click);
            // 
            // DonateFoodButton
            // 
            this.DonateFoodButton.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonateFoodButton.Location = new System.Drawing.Point(408, 436);
            this.DonateFoodButton.Name = "DonateFoodButton";
            this.DonateFoodButton.Size = new System.Drawing.Size(169, 38);
            this.DonateFoodButton.TabIndex = 9;
            this.DonateFoodButton.Text = "Donate Food";
            this.DonateFoodButton.UseVisualStyleBackColor = true;
            this.DonateFoodButton.Click += new System.EventHandler(this.DonateFoodButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 264);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(341, 303);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Organisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 628);
            this.Controls.Add(this.groupBox1);
            this.Name = "Organisation";
            this.Text = "Organistion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Biddyanando_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DonateMoneyButton;
        private System.Windows.Forms.Button DonateFoodButton;
    }
}