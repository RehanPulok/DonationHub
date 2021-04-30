
namespace DonationHub.Presentation_Layer
{
    partial class Payment
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
            this.BkashPaymentButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Bkash = new System.Windows.Forms.TabPage();
            this.Card = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PinTextBox = new System.Windows.Forms.TextBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.CardAmountTextBox = new System.Windows.Forms.TextBox();
            this.CardPinTextBox = new System.Windows.Forms.TextBox();
            this.CardNoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CardPaymentButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Bkash.SuspendLayout();
            this.Card.SuspendLayout();
            this.SuspendLayout();
            // 
            // BkashPaymentButton
            // 
            this.BkashPaymentButton.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BkashPaymentButton.Location = new System.Drawing.Point(75, 236);
            this.BkashPaymentButton.Name = "BkashPaymentButton";
            this.BkashPaymentButton.Size = new System.Drawing.Size(151, 33);
            this.BkashPaymentButton.TabIndex = 1;
            this.BkashPaymentButton.Text = "Make Payment";
            this.BkashPaymentButton.UseVisualStyleBackColor = true;
            this.BkashPaymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Bkash);
            this.tabControl1.Controls.Add(this.Card);
            this.tabControl1.Location = new System.Drawing.Point(12, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(316, 330);
            this.tabControl1.TabIndex = 2;
            // 
            // Bkash
            // 
            this.Bkash.Controls.Add(this.AmountTextBox);
            this.Bkash.Controls.Add(this.PinTextBox);
            this.Bkash.Controls.Add(this.PhoneNumberTextBox);
            this.Bkash.Controls.Add(this.label3);
            this.Bkash.Controls.Add(this.label2);
            this.Bkash.Controls.Add(this.label1);
            this.Bkash.Controls.Add(this.BkashPaymentButton);
            this.Bkash.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bkash.Location = new System.Drawing.Point(4, 22);
            this.Bkash.Name = "Bkash";
            this.Bkash.Padding = new System.Windows.Forms.Padding(3);
            this.Bkash.Size = new System.Drawing.Size(308, 304);
            this.Bkash.TabIndex = 1;
            this.Bkash.Text = "Bkash";
            this.Bkash.UseVisualStyleBackColor = true;
            // 
            // Card
            // 
            this.Card.Controls.Add(this.CardAmountTextBox);
            this.Card.Controls.Add(this.CardPinTextBox);
            this.Card.Controls.Add(this.CardNoTextBox);
            this.Card.Controls.Add(this.label4);
            this.Card.Controls.Add(this.label5);
            this.Card.Controls.Add(this.label6);
            this.Card.Controls.Add(this.CardPaymentButton);
            this.Card.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card.Location = new System.Drawing.Point(4, 22);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(308, 304);
            this.Card.TabIndex = 2;
            this.Card.Text = "Card";
            this.Card.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(147, 75);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(155, 32);
            this.PhoneNumberTextBox.TabIndex = 5;
            // 
            // PinTextBox
            // 
            this.PinTextBox.Location = new System.Drawing.Point(147, 124);
            this.PinTextBox.Name = "PinTextBox";
            this.PinTextBox.Size = new System.Drawing.Size(155, 32);
            this.PinTextBox.TabIndex = 6;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(147, 172);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(155, 32);
            this.AmountTextBox.TabIndex = 7;
            // 
            // CardAmountTextBox
            // 
            this.CardAmountTextBox.Location = new System.Drawing.Point(149, 152);
            this.CardAmountTextBox.Name = "CardAmountTextBox";
            this.CardAmountTextBox.Size = new System.Drawing.Size(155, 32);
            this.CardAmountTextBox.TabIndex = 14;
            // 
            // CardPinTextBox
            // 
            this.CardPinTextBox.Location = new System.Drawing.Point(149, 104);
            this.CardPinTextBox.Name = "CardPinTextBox";
            this.CardPinTextBox.Size = new System.Drawing.Size(155, 32);
            this.CardPinTextBox.TabIndex = 13;
            // 
            // CardNoTextBox
            // 
            this.CardNoTextBox.Location = new System.Drawing.Point(149, 55);
            this.CardNoTextBox.Name = "CardNoTextBox";
            this.CardNoTextBox.Size = new System.Drawing.Size(155, 32);
            this.CardNoTextBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Card Number";
            // 
            // CardPaymentButton
            // 
            this.CardPaymentButton.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardPaymentButton.Location = new System.Drawing.Point(77, 216);
            this.CardPaymentButton.Name = "CardPaymentButton";
            this.CardPaymentButton.Size = new System.Drawing.Size(151, 33);
            this.CardPaymentButton.TabIndex = 8;
            this.CardPaymentButton.Text = "Make Payment";
            this.CardPaymentButton.UseVisualStyleBackColor = true;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 368);
            this.Controls.Add(this.tabControl1);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Payment_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.Bkash.ResumeLayout(false);
            this.Bkash.PerformLayout();
            this.Card.ResumeLayout(false);
            this.Card.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BkashPaymentButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Bkash;
        private System.Windows.Forms.TabPage Card;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.TextBox PinTextBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CardAmountTextBox;
        private System.Windows.Forms.TextBox CardPinTextBox;
        private System.Windows.Forms.TextBox CardNoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CardPaymentButton;
    }
}