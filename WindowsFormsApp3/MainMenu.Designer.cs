namespace WindowsFormsApp3
{
    partial class MainMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.depositSlotButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Decrease20sToWithdrawButton = new System.Windows.Forms.Button();
            this.Increase20sToWithdrawButton = new System.Windows.Forms.Button();
            this.AmounfOf20sToWithdrawLabel = new System.Windows.Forms.Label();
            this.WithdrawConfirmationButton = new System.Windows.Forms.Button();
            this.closeAmountToWithdrawButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "Deposit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "<balance>";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(371, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 67);
            this.button2.TabIndex = 2;
            this.button2.Text = "Withdraw";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(715, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 4;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Account balance:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(68, 9);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(71, 14);
            this.userNameLabel.TabIndex = 6;
            this.userNameLabel.Text = "<user-name>";
            // 
            // depositSlotButton
            // 
            //this.depositSlotButton.Location = new System.Drawing.Point(715, 68);
            //this.depositSlotButton.Name = "depositSlotButton";
            //this.depositSlotButton.Size = new System.Drawing.Size(18, 401);
            //this.depositSlotButton.TabIndex = 7;
            //this.depositSlotButton.Text = "Envelope";
            //this.depositSlotButton.UseVisualStyleBackColor = true;
            //this.depositSlotButton.Click += new System.EventHandler(this.depositSlotButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Account id:";
            // 
            // button4
            // 
            //this.button4.Location = new System.Drawing.Point(194, 369);
            //this.button4.Name = "button4";
            //this.button4.Size = new System.Drawing.Size(289, 99);
            //this.button4.TabIndex = 9;
            //this.button4.Text = "Dispenser";
            //this.button4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.Decrease20sToWithdrawButton);
            this.panel1.Controls.Add(this.Increase20sToWithdrawButton);
            this.panel1.Controls.Add(this.AmounfOf20sToWithdrawLabel);
            this.panel1.Controls.Add(this.WithdrawConfirmationButton);
            this.panel1.Controls.Add(this.closeAmountToWithdrawButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(194, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 208);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Decrease20sToWithdrawButton
            // 
            this.Decrease20sToWithdrawButton.Location = new System.Drawing.Point(177, 144);
            this.Decrease20sToWithdrawButton.Name = "Decrease20sToWithdrawButton";
            this.Decrease20sToWithdrawButton.Size = new System.Drawing.Size(75, 25);
            this.Decrease20sToWithdrawButton.TabIndex = 6;
            this.Decrease20sToWithdrawButton.Text = "-";
            this.Decrease20sToWithdrawButton.UseVisualStyleBackColor = true;
            this.Decrease20sToWithdrawButton.Click += new System.EventHandler(this.Decrease20sToWithdrawButton_Click);
            // 
            // Increase20sToWithdrawButton
            // 
            this.Increase20sToWithdrawButton.Location = new System.Drawing.Point(82, 144);
            this.Increase20sToWithdrawButton.Name = "Increase20sToWithdrawButton";
            this.Increase20sToWithdrawButton.Size = new System.Drawing.Size(75, 25);
            this.Increase20sToWithdrawButton.TabIndex = 5;
            this.Increase20sToWithdrawButton.Text = "+";
            this.Increase20sToWithdrawButton.UseVisualStyleBackColor = true;
            this.Increase20sToWithdrawButton.Click += new System.EventHandler(this.Increase20sToWithdrawButton_Click);
            // 
            // AmounfOf20sToWithdrawLabel
            // 
            this.AmounfOf20sToWithdrawLabel.AutoSize = true;
            this.AmounfOf20sToWithdrawLabel.Location = new System.Drawing.Point(97, 82);
            this.AmounfOf20sToWithdrawLabel.Name = "AmounfOf20sToWithdrawLabel";
            this.AmounfOf20sToWithdrawLabel.Size = new System.Drawing.Size(13, 14);
            this.AmounfOf20sToWithdrawLabel.TabIndex = 4;
            this.AmounfOf20sToWithdrawLabel.Text = "0";
            this.AmounfOf20sToWithdrawLabel.Click += new System.EventHandler(this.AmounfOf20sToWithdrawLabel_Click);
            // 
            // WithdrawConfirmationButton
            // 
            this.WithdrawConfirmationButton.Location = new System.Drawing.Point(234, 180);
            this.WithdrawConfirmationButton.Name = "WithdrawConfirmationButton";
            this.WithdrawConfirmationButton.Size = new System.Drawing.Size(75, 25);
            this.WithdrawConfirmationButton.TabIndex = 3;
            this.WithdrawConfirmationButton.Text = "Withdraw";
            this.WithdrawConfirmationButton.UseVisualStyleBackColor = true;
            this.WithdrawConfirmationButton.Click += new System.EventHandler(this.WithdrawConfirmationButton_Click);
            // 
            // closeAmountToWithdrawButton
            // 
            this.closeAmountToWithdrawButton.Location = new System.Drawing.Point(234, 3);
            this.closeAmountToWithdrawButton.Name = "closeAmountToWithdrawButton";
            this.closeAmountToWithdrawButton.Size = new System.Drawing.Size(75, 25);
            this.closeAmountToWithdrawButton.TabIndex = 2;
            this.closeAmountToWithdrawButton.Text = "Close";
            this.closeAmountToWithdrawButton.UseVisualStyleBackColor = true;
            this.closeAmountToWithdrawButton.Click += new System.EventHandler(this.closeAmountToWithdrawButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "Amount of 20\'s to withdraw";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.depositSlotButton);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button depositSlotButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button closeAmountToWithdrawButton;
        private System.Windows.Forms.Button WithdrawConfirmationButton;
        private System.Windows.Forms.Label AmounfOf20sToWithdrawLabel;
        private System.Windows.Forms.Button Increase20sToWithdrawButton;
        private System.Windows.Forms.Button Decrease20sToWithdrawButton;
    }
}

