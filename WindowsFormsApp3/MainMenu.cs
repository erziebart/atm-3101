using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class MainMenu : Form
    {
        private AccountList accountList;
        private Account instanceAccount;
        private Login login;
        private int numToWithdraw;
        private long amtToDeposit;
        private ATM atm;

        public MainMenu(Account account, Login login)
        {
            InitializeComponent();
            this.accountList = new AccountList("accounts.json");
            this.instanceAccount = account;
            this.login = login;
            this.atm = new ATM("accounts.json");
            userNameLabel.Text = this.instanceAccount.CardNum;
            WithdrawPanel.Hide();
            depositPanel.Hide();
            checkBalancePanel.Hide(); 
            numToWithdraw = 0;

            disableWithdrawButtons();
        }

        public void Logout()
        {
            Close();
            login.Show();
            //Go back to login
        }

        public void Deposit(long amount, Account account)
        {
            account.Balance += amount;
            this.accountList.UpdateAcct(account);
            System.Windows.Forms.MessageBox.Show("Deposit of: $" + this.amtToDeposit.ToString() + " Successful");
        }

        public void Withdraw(int numberOf20s, Account account)
        {

            accountList.UpdateAcct(account);

            int toWithdraw = (numberOf20s * 20);

            if (!this.atm.TakeOut(numberOf20s))
            {
                return;
            }

            if (account.Balance - toWithdraw >= 0)
            {
                
                account.Balance -= toWithdraw;
                DispenseCash(numberOf20s);
                accountList.UpdateAcct(account);
                System.Windows.Forms.MessageBox.Show("Withdrawal of: $" + toWithdraw.ToString() + " Successful");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Insufficient acount funds");
            }
        }

        public void DispenseCash(int numBills)
        {
            Dispenser.DispenseCash(numBills);
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
          depositPanel.Show();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            WithdrawPanel.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void closeAmountToWithdrawButton_Click(object sender, EventArgs e)
        {
            numToWithdraw = 0;
            AmounfOf20sToWithdrawLabel.Text = 0.ToString();
            WithdrawPanel.Hide();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        { 
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void depositEnter_Click(object sender, EventArgs e)
        {
            this.amtToDeposit = Convert.ToInt64(amountToDepositInput.Text);
            if (this.amtToDeposit != 0)
            {
                Deposit(this.amtToDeposit, this.instanceAccount);
                this.amtToDeposit = 0;
                amountToDepositInput.Text = null;
                depositPanel.Hide();
            }
        }
        private void depositClose_Click(object sender, EventArgs e)
        {
           depositPanel.Hide();
        }

        private void balanceClose_Click(object sender, EventArgs e)
        {
            checkBalancePanel.Hide(); 
        }
        private void checkBalanceButton_Click(object sender, EventArgs e)
        {
            balanceAmount.Text = "$" + this.instanceAccount.Balance.ToString();
            checkBalancePanel.Show();
        }
        private void WithdrawConfirmationButton_Click(object sender, EventArgs e)
        {
            if (numToWithdraw != 0)
            {
                Withdraw(numToWithdraw, this.instanceAccount);
                numToWithdraw = 0;
                unselectAllWithdrawRadioButtons();
                AmounfOf20sToWithdrawLabel.Text = 0.ToString();
                WithdrawPanel.Hide();
            }
            //Does nothing if submit 0
            
        }

        private void unselectAllWithdrawRadioButtons()
        {
            withdraw20.Checked = false;
            withdraw40.Checked = false;
            withdraw60.Checked = false;
            withdraw80.Checked = false;
            withdraw100.Checked = false;
            withdrawOther.Checked = false;
        }

        private void AmounfOf20sToWithdrawLabel_Click(object sender, EventArgs e)
        {

        }

        private void Increase20sToWithdrawButton_Click(object sender, EventArgs e)
        {
            if(this.numToWithdraw < this.atm.getBill20Left())
            {
                this.numToWithdraw += 1;
                AmounfOf20sToWithdrawLabel.Text = "$" + (20 * this.numToWithdraw).ToString();
            }
        }

        private void Decrease20sToWithdrawButton_Click(object sender, EventArgs e)
        {
            if (numToWithdraw > 0)
            {
                this.numToWithdraw -= 1;
            }

            AmounfOf20sToWithdrawLabel.Text = "$" + (20 * this.numToWithdraw).ToString();
        }

    private void amountToDepositInput_KeyPress(object sender, KeyPressEventArgs e)
    {
      char ch = e.KeyChar;
      if(ch == 46 && amountToDepositInput.Text.IndexOf('.') != -1)
      {
        e.Handled = true;
        return;
      }

      if(!Char.IsDigit(ch) && ch != 8 && ch != 46)
      {
        e.Handled = true;
      }

    }

        private void depositPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void balanceAmount_Click(object sender, EventArgs e)
        {

        }

        private void withdraw20_CheckedChanged(object sender, EventArgs e)
        {
            disableWithdrawButtons();
            this.numToWithdraw = 1;
            AmounfOf20sToWithdrawLabel.Text = "$" + (20 * this.numToWithdraw).ToString();
        }

        private void withdraw40_CheckedChanged(object sender, EventArgs e)
        {
            disableWithdrawButtons();
            this.numToWithdraw = 2;
            AmounfOf20sToWithdrawLabel.Text = "$" + (20*this.numToWithdraw).ToString();
        }

        private void withdraw60_CheckedChanged(object sender, EventArgs e)
        {
            disableWithdrawButtons();
            this.numToWithdraw = 3;
            AmounfOf20sToWithdrawLabel.Text = "$" + (20 * this.numToWithdraw).ToString();
        }

        private void withdraw80_CheckedChanged(object sender, EventArgs e)
        {
            disableWithdrawButtons();
            this.numToWithdraw = 4;
            AmounfOf20sToWithdrawLabel.Text = "$" + (20 * this.numToWithdraw).ToString();
        }

        private void withdraw100_CheckedChanged(object sender, EventArgs e)
        {
            disableWithdrawButtons();
            this.numToWithdraw = 5;
            AmounfOf20sToWithdrawLabel.Text = "$" + (20 * this.numToWithdraw).ToString();
        }

        private void withdrawOther_CheckedChanged(object sender, EventArgs e)
        {
            enableWithdrawButtons();
            Increase20sToWithdrawButton.Enabled = true;
            Decrease20sToWithdrawButton.Enabled = true;
        }

        private void disableWithdrawButtons()
        {
            Increase20sToWithdrawButton.Enabled = false;
            Decrease20sToWithdrawButton.Enabled = false;
        }
        private void enableWithdrawButtons()
        {
            Increase20sToWithdrawButton.Enabled = true;
            Decrease20sToWithdrawButton.Enabled = true;
        }
    }
}
