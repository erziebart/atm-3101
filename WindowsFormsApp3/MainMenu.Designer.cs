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
            this.depositButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.depositSlotButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.WithdrawPanel = new System.Windows.Forms.Panel();
            this.withdrawOther = new System.Windows.Forms.RadioButton();
            this.withdraw100 = new System.Windows.Forms.RadioButton();
            this.withdraw80 = new System.Windows.Forms.RadioButton();
            this.withdraw60 = new System.Windows.Forms.RadioButton();
            this.withdraw40 = new System.Windows.Forms.RadioButton();
            this.Decrease20sToWithdrawButton = new System.Windows.Forms.Button();
            this.Increase20sToWithdrawButton = new System.Windows.Forms.Button();
            this.withdraw20 = new System.Windows.Forms.RadioButton();
            this.AmounfOf20sToWithdrawLabel = new System.Windows.Forms.Label();
            this.withdrawEnter = new System.Windows.Forms.Button();
            this.withdrawClose = new System.Windows.Forms.Button();
            this.amountToWithdrawText = new System.Windows.Forms.Label();
            this.depositPanel = new System.Windows.Forms.Panel();
            this.amountToDepositInput = new System.Windows.Forms.TextBox();
            this.depositEnter = new System.Windows.Forms.Button();
            this.depositClose = new System.Windows.Forms.Button();
            this.amountToDepositText = new System.Windows.Forms.Label();
            this.checkBalancePanel = new System.Windows.Forms.Panel();
            this.balanceAmount = new System.Windows.Forms.Label();
            this.balanceClose = new System.Windows.Forms.Button();
            this.balanceText = new System.Windows.Forms.Label();
            this.checkBalanceButton = new System.Windows.Forms.Button();
            this.WithdrawPanel.SuspendLayout();
            this.depositPanel.SuspendLayout();
            this.checkBalancePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(272, 242);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(112, 67);
            this.depositButton.TabIndex = 0;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "<balance>";
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(405, 241);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(112, 67);
            this.withdrawButton.TabIndex = 2;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(715, 14);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 25);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
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
            this.depositSlotButton.Location = new System.Drawing.Point(0, 0);
            this.depositSlotButton.Name = "depositSlotButton";
            this.depositSlotButton.Size = new System.Drawing.Size(75, 23);
            this.depositSlotButton.TabIndex = 12;
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
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            // 
            // WithdrawPanel
            // 
            this.WithdrawPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.WithdrawPanel.Controls.Add(this.withdrawOther);
            this.WithdrawPanel.Controls.Add(this.withdraw100);
            this.WithdrawPanel.Controls.Add(this.withdraw80);
            this.WithdrawPanel.Controls.Add(this.withdraw60);
            this.WithdrawPanel.Controls.Add(this.withdraw40);
            this.WithdrawPanel.Controls.Add(this.Decrease20sToWithdrawButton);
            this.WithdrawPanel.Controls.Add(this.Increase20sToWithdrawButton);
            this.WithdrawPanel.Controls.Add(this.withdraw20);
            this.WithdrawPanel.Controls.Add(this.AmounfOf20sToWithdrawLabel);
            this.WithdrawPanel.Controls.Add(this.withdrawEnter);
            this.WithdrawPanel.Controls.Add(this.withdrawClose);
            this.WithdrawPanel.Controls.Add(this.amountToWithdrawText);
            this.WithdrawPanel.Location = new System.Drawing.Point(147, 121);
            this.WithdrawPanel.Name = "WithdrawPanel";
            this.WithdrawPanel.Size = new System.Drawing.Size(395, 236);
            this.WithdrawPanel.TabIndex = 10;
            this.WithdrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // withdrawOther
            // 
            this.withdrawOther.AutoSize = true;
            this.withdrawOther.Location = new System.Drawing.Point(200, 102);
            this.withdrawOther.Name = "withdrawOther";
            this.withdrawOther.Size = new System.Drawing.Size(52, 18);
            this.withdrawOther.TabIndex = 8;
            this.withdrawOther.TabStop = true;
            this.withdrawOther.Text = "Other";
            this.withdrawOther.UseVisualStyleBackColor = true;
            this.withdrawOther.CheckedChanged += new System.EventHandler(this.withdrawOther_CheckedChanged);
            // 
            // withdraw100
            // 
            this.withdraw100.AutoSize = true;
            this.withdraw100.Location = new System.Drawing.Point(200, 73);
            this.withdraw100.Name = "withdraw100";
            this.withdraw100.Size = new System.Drawing.Size(49, 18);
            this.withdraw100.TabIndex = 9;
            this.withdraw100.TabStop = true;
            this.withdraw100.Text = "$100";
            this.withdraw100.UseVisualStyleBackColor = true;
            this.withdraw100.CheckedChanged += new System.EventHandler(this.withdraw100_CheckedChanged);
            // 
            // withdraw80
            // 
            this.withdraw80.AutoSize = true;
            this.withdraw80.Location = new System.Drawing.Point(200, 42);
            this.withdraw80.Name = "withdraw80";
            this.withdraw80.Size = new System.Drawing.Size(43, 18);
            this.withdraw80.TabIndex = 7;
            this.withdraw80.TabStop = true;
            this.withdraw80.Text = "$80";
            this.withdraw80.UseVisualStyleBackColor = true;
            this.withdraw80.CheckedChanged += new System.EventHandler(this.withdraw80_CheckedChanged);
            // 
            // withdraw60
            // 
            this.withdraw60.AutoSize = true;
            this.withdraw60.Location = new System.Drawing.Point(124, 102);
            this.withdraw60.Name = "withdraw60";
            this.withdraw60.Size = new System.Drawing.Size(43, 18);
            this.withdraw60.TabIndex = 5;
            this.withdraw60.TabStop = true;
            this.withdraw60.Text = "$60";
            this.withdraw60.UseVisualStyleBackColor = true;
            this.withdraw60.CheckedChanged += new System.EventHandler(this.withdraw60_CheckedChanged);
            // 
            // withdraw40
            // 
            this.withdraw40.AutoSize = true;
            this.withdraw40.Location = new System.Drawing.Point(124, 73);
            this.withdraw40.Name = "withdraw40";
            this.withdraw40.Size = new System.Drawing.Size(43, 18);
            this.withdraw40.TabIndex = 6;
            this.withdraw40.TabStop = true;
            this.withdraw40.Text = "$40";
            this.withdraw40.UseVisualStyleBackColor = true;
            this.withdraw40.CheckedChanged += new System.EventHandler(this.withdraw40_CheckedChanged);
            // 
            // Decrease20sToWithdrawButton
            // 
            this.Decrease20sToWithdrawButton.Location = new System.Drawing.Point(216, 147);
            this.Decrease20sToWithdrawButton.Name = "Decrease20sToWithdrawButton";
            this.Decrease20sToWithdrawButton.Size = new System.Drawing.Size(27, 25);
            this.Decrease20sToWithdrawButton.TabIndex = 6;
            this.Decrease20sToWithdrawButton.Text = "-";
            this.Decrease20sToWithdrawButton.UseVisualStyleBackColor = true;
            this.Decrease20sToWithdrawButton.Click += new System.EventHandler(this.Decrease20sToWithdrawButton_Click);
            // 
            // Increase20sToWithdrawButton
            // 
            this.Increase20sToWithdrawButton.Location = new System.Drawing.Point(181, 147);
            this.Increase20sToWithdrawButton.Name = "Increase20sToWithdrawButton";
            this.Increase20sToWithdrawButton.Size = new System.Drawing.Size(29, 25);
            this.Increase20sToWithdrawButton.TabIndex = 5;
            this.Increase20sToWithdrawButton.Text = "+";
            this.Increase20sToWithdrawButton.UseVisualStyleBackColor = true;
            this.Increase20sToWithdrawButton.Click += new System.EventHandler(this.Increase20sToWithdrawButton_Click);
            // 
            // withdraw20
            // 
            this.withdraw20.AutoSize = true;
            this.withdraw20.Location = new System.Drawing.Point(124, 42);
            this.withdraw20.Name = "withdraw20";
            this.withdraw20.Size = new System.Drawing.Size(43, 18);
            this.withdraw20.TabIndex = 4;
            this.withdraw20.TabStop = true;
            this.withdraw20.Text = "$20";
            this.withdraw20.UseVisualStyleBackColor = true;
            this.withdraw20.CheckedChanged += new System.EventHandler(this.withdraw20_CheckedChanged);
            // 
            // AmounfOf20sToWithdrawLabel
            // 
            this.AmounfOf20sToWithdrawLabel.AutoSize = true;
            this.AmounfOf20sToWithdrawLabel.Location = new System.Drawing.Point(122, 152);
            this.AmounfOf20sToWithdrawLabel.Name = "AmounfOf20sToWithdrawLabel";
            this.AmounfOf20sToWithdrawLabel.Size = new System.Drawing.Size(13, 14);
            this.AmounfOf20sToWithdrawLabel.TabIndex = 4;
            this.AmounfOf20sToWithdrawLabel.Text = "0";
            this.AmounfOf20sToWithdrawLabel.Click += new System.EventHandler(this.AmounfOf20sToWithdrawLabel_Click);
            // 
            // withdrawEnter
            // 
            this.withdrawEnter.Location = new System.Drawing.Point(143, 196);
            this.withdrawEnter.Name = "withdrawEnter";
            this.withdrawEnter.Size = new System.Drawing.Size(104, 25);
            this.withdrawEnter.TabIndex = 3;
            this.withdrawEnter.Text = "Withdraw";
            this.withdrawEnter.UseVisualStyleBackColor = true;
            this.withdrawEnter.Click += new System.EventHandler(this.WithdrawConfirmationButton_Click);
            // 
            // withdrawClose
            // 
            this.withdrawClose.Location = new System.Drawing.Point(312, 6);
            this.withdrawClose.Name = "withdrawClose";
            this.withdrawClose.Size = new System.Drawing.Size(75, 25);
            this.withdrawClose.TabIndex = 2;
            this.withdrawClose.Text = "Close";
            this.withdrawClose.UseVisualStyleBackColor = true;
            this.withdrawClose.Click += new System.EventHandler(this.closeAmountToWithdrawButton_Click);
            // 
            // amountToWithdrawText
            // 
            this.amountToWithdrawText.AutoSize = true;
            this.amountToWithdrawText.Location = new System.Drawing.Point(120, 9);
            this.amountToWithdrawText.Name = "amountToWithdrawText";
            this.amountToWithdrawText.Size = new System.Drawing.Size(106, 14);
            this.amountToWithdrawText.TabIndex = 1;
            this.amountToWithdrawText.Text = "Amount to withdraw";
            this.amountToWithdrawText.Click += new System.EventHandler(this.label4_Click);
            // 
            // depositPanel
            // 
            this.depositPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.depositPanel.Controls.Add(this.amountToDepositInput);
            this.depositPanel.Controls.Add(this.depositEnter);
            this.depositPanel.Controls.Add(this.depositClose);
            this.depositPanel.Controls.Add(this.amountToDepositText);
            this.depositPanel.Location = new System.Drawing.Point(548, 45);
            this.depositPanel.Name = "depositPanel";
            this.depositPanel.Size = new System.Drawing.Size(392, 236);
            this.depositPanel.TabIndex = 15;
            this.depositPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.depositPanel_Paint);
            // 
            // amountToDepositInput
            // 
            this.amountToDepositInput.Location = new System.Drawing.Point(154, 107);
            this.amountToDepositInput.Name = "amountToDepositInput";
            this.amountToDepositInput.Size = new System.Drawing.Size(100, 20);
            this.amountToDepositInput.TabIndex = 4;
            this.amountToDepositInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountToDepositInput_KeyPress);
            // 
            // depositEnter
            // 
            this.depositEnter.Location = new System.Drawing.Point(168, 172);
            this.depositEnter.Name = "depositEnter";
            this.depositEnter.Size = new System.Drawing.Size(75, 25);
            this.depositEnter.TabIndex = 3;
            this.depositEnter.Text = "Deposit";
            this.depositEnter.UseVisualStyleBackColor = true;
            this.depositEnter.Click += new System.EventHandler(this.depositEnter_Click);
            // 
            // depositClose
            // 
            this.depositClose.Location = new System.Drawing.Point(312, 9);
            this.depositClose.Name = "depositClose";
            this.depositClose.Size = new System.Drawing.Size(75, 25);
            this.depositClose.TabIndex = 2;
            this.depositClose.Text = "Close";
            this.depositClose.UseVisualStyleBackColor = true;
            this.depositClose.Click += new System.EventHandler(this.depositClose_Click);
            // 
            // amountToDepositText
            // 
            this.amountToDepositText.AutoSize = true;
            this.amountToDepositText.Location = new System.Drawing.Point(138, 63);
            this.amountToDepositText.Name = "amountToDepositText";
            this.amountToDepositText.Size = new System.Drawing.Size(95, 14);
            this.amountToDepositText.TabIndex = 1;
            this.amountToDepositText.Text = "Amount to Deposit";
            // 
            // checkBalancePanel
            // 
            this.checkBalancePanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.checkBalancePanel.Controls.Add(this.balanceAmount);
            this.checkBalancePanel.Controls.Add(this.balanceClose);
            this.checkBalancePanel.Controls.Add(this.balanceText);
            this.checkBalancePanel.Location = new System.Drawing.Point(139, 363);
            this.checkBalancePanel.Name = "checkBalancePanel";
            this.checkBalancePanel.Size = new System.Drawing.Size(395, 236);
            this.checkBalancePanel.TabIndex = 17;
            // 
            // balanceAmount
            // 
            this.balanceAmount.AutoSize = true;
            this.balanceAmount.Location = new System.Drawing.Point(168, 133);
            this.balanceAmount.Name = "balanceAmount";
            this.balanceAmount.Size = new System.Drawing.Size(13, 14);
            this.balanceAmount.TabIndex = 4;
            this.balanceAmount.Text = "0";
            this.balanceAmount.Click += new System.EventHandler(this.balanceAmount_Click);
            // 
            // balanceClose
            // 
            this.balanceClose.Location = new System.Drawing.Point(312, 9);
            this.balanceClose.Name = "balanceClose";
            this.balanceClose.Size = new System.Drawing.Size(75, 25);
            this.balanceClose.TabIndex = 2;
            this.balanceClose.Text = "Close";
            this.balanceClose.UseVisualStyleBackColor = true;
            this.balanceClose.Click += new System.EventHandler(this.balanceClose_Click);
            // 
            // balanceText
            // 
            this.balanceText.AutoSize = true;
            this.balanceText.Location = new System.Drawing.Point(168, 90);
            this.balanceText.Name = "balanceText";
            this.balanceText.Size = new System.Drawing.Size(46, 14);
            this.balanceText.TabIndex = 1;
            this.balanceText.Text = "Balance";
            // 
            // checkBalanceButton
            // 
            this.checkBalanceButton.Location = new System.Drawing.Point(138, 242);
            this.checkBalanceButton.Name = "checkBalanceButton";
            this.checkBalanceButton.Size = new System.Drawing.Size(112, 67);
            this.checkBalanceButton.TabIndex = 16;
            this.checkBalanceButton.Text = "Check Balance";
            this.checkBalanceButton.UseVisualStyleBackColor = true;
            this.checkBalanceButton.Click += new System.EventHandler(this.checkBalanceButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.checkBalancePanel);
            this.Controls.Add(this.depositPanel);
            this.Controls.Add(this.WithdrawPanel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.depositSlotButton);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.checkBalanceButton);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.WithdrawPanel.ResumeLayout(false);
            this.WithdrawPanel.PerformLayout();
            this.depositPanel.ResumeLayout(false);
            this.depositPanel.PerformLayout();
            this.checkBalancePanel.ResumeLayout(false);
            this.checkBalancePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button depositSlotButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel WithdrawPanel;
        private System.Windows.Forms.Label amountToWithdrawText;
        private System.Windows.Forms.Button withdrawClose;
        private System.Windows.Forms.Button withdrawEnter;
        private System.Windows.Forms.Label AmounfOf20sToWithdrawLabel;
        private System.Windows.Forms.Button Increase20sToWithdrawButton;
        private System.Windows.Forms.Button Decrease20sToWithdrawButton;
    private System.Windows.Forms.Panel depositPanel;
    private System.Windows.Forms.Button depositEnter;
    private System.Windows.Forms.Button depositClose;
    private System.Windows.Forms.Label amountToDepositText;
    private System.Windows.Forms.Button checkBalanceButton;
    private System.Windows.Forms.Panel checkBalancePanel;
    private System.Windows.Forms.Label balanceAmount;
    private System.Windows.Forms.Button balanceClose;
    private System.Windows.Forms.Label balanceText;
    private System.Windows.Forms.RadioButton withdraw40;
    private System.Windows.Forms.RadioButton withdraw60;
    private System.Windows.Forms.RadioButton withdraw20;
    private System.Windows.Forms.RadioButton withdrawOther;
    private System.Windows.Forms.RadioButton withdraw100;
    private System.Windows.Forms.RadioButton withdraw80;
    private System.Windows.Forms.TextBox amountToDepositInput;
    }
}

