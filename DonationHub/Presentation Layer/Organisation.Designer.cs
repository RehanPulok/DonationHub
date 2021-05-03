
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
            this.EventDataGridView = new System.Windows.Forms.DataGridView();
            this.DonateMoneyButton = new System.Windows.Forms.Button();
            this.DonateFoodButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EventDataGridView);
            this.groupBox1.Controls.Add(this.DonateMoneyButton);
            this.groupBox1.Controls.Add(this.DonateFoodButton);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(41, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 573);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // EventDataGridView
            // 
            this.EventDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventDataGridView.Location = new System.Drawing.Point(17, 289);
            this.EventDataGridView.Name = "EventDataGridView";
            this.EventDataGridView.Size = new System.Drawing.Size(361, 284);
            this.EventDataGridView.TabIndex = 11;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 49);
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
            ((System.ComponentModel.ISupportInitialize)(this.EventDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DonateMoneyButton;
        private System.Windows.Forms.Button DonateFoodButton;
        private System.Windows.Forms.DataGridView EventDataGridView;
    }
}