namespace WindowsFormsApp3
{
  partial class Login
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
      this.PinBox = new System.Windows.Forms.TextBox();
      this.AcctLabel = new System.Windows.Forms.Label();
      this.PinLabel = new System.Windows.Forms.Label();
      this.LoginButton = new System.Windows.Forms.Button();
      this.AcctNumBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // PinBox
      // 
      this.PinBox.Location = new System.Drawing.Point(350, 183);
      this.PinBox.Name = "PinBox";
      this.PinBox.Size = new System.Drawing.Size(218, 26);
      this.PinBox.TabIndex = 1;
      this.PinBox.TextChanged += new System.EventHandler(this.PinBox_TextChanged);
      // 
      // AcctLabel
      // 
      this.AcctLabel.AutoSize = true;
      this.AcctLabel.Location = new System.Drawing.Point(183, 137);
      this.AcctLabel.Name = "AcctLabel";
      this.AcctLabel.Size = new System.Drawing.Size(128, 20);
      this.AcctLabel.TabIndex = 2;
      this.AcctLabel.Text = "Account Number";
      this.AcctLabel.Click += new System.EventHandler(this.AcctLabel_Click);
      // 
      // PinLabel
      // 
      this.PinLabel.AutoSize = true;
      this.PinLabel.Location = new System.Drawing.Point(276, 186);
      this.PinLabel.Name = "PinLabel";
      this.PinLabel.Size = new System.Drawing.Size(35, 20);
      this.PinLabel.TabIndex = 3;
      this.PinLabel.Text = "PIN";
      this.PinLabel.Click += new System.EventHandler(this.PinLabel_Click);
      // 
      // LoginButton
      // 
      this.LoginButton.Location = new System.Drawing.Point(350, 237);
      this.LoginButton.Name = "LoginButton";
      this.LoginButton.Size = new System.Drawing.Size(75, 31);
      this.LoginButton.TabIndex = 4;
      this.LoginButton.Text = "Login";
      this.LoginButton.UseVisualStyleBackColor = true;
      this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
      // 
      // AcctNumBox
      // 
      this.AcctNumBox.Location = new System.Drawing.Point(350, 134);
      this.AcctNumBox.Name = "AcctNumBox";
      this.AcctNumBox.Size = new System.Drawing.Size(218, 26);
      this.AcctNumBox.TabIndex = 5;
      this.AcctNumBox.TextChanged += new System.EventHandler(this.AcctNumBox_TextChanged);
      // 
      // Login
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.AcctNumBox);
      this.Controls.Add(this.LoginButton);
      this.Controls.Add(this.PinLabel);
      this.Controls.Add(this.AcctLabel);
      this.Controls.Add(this.PinBox);
      this.Name = "Login";
      this.Text = "Login";
      this.Load += new System.EventHandler(this.Login_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TextBox PinBox;
    private System.Windows.Forms.Label AcctLabel;
    private System.Windows.Forms.Label PinLabel;
    private System.Windows.Forms.Button LoginButton;
    private System.Windows.Forms.TextBox AcctNumBox;
  }
}