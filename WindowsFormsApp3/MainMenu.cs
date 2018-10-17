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

        public MainMenu(Account account, Login login)
        {
            InitializeComponent();
            this.accountList = new AccountList("accounts.json");
            this.instanceAccount = account;
            this.login = login;
            label1.Text = this.instanceAccount.Balance.ToString();
            userNameLabel.Text = this.instanceAccount.CardNum;
            panel1.Hide();
            numToWithdraw = 0;
        }

        public void Logout()
        {
            Close();
            login.Show();
            //Go back to login
        }

        public void Deposit(int amount, Account account)
        {
            account.Balance += amount;
            label1.Text = account.Balance.ToString();
            this.accountList.UpdateAcct(account);
        }

        public void Withdraw(int numberOf20s, Account account)
        {
            // ATM.takeOut((numberOf20s * 20));
            // Dispenser.DispenseCash(numberOf20s_;
            accountList.UpdateAcct(account);

            int toWithdraw = (numberOf20s * 20);

            if (account.Balance - toWithdraw >= 0)
            {
                account.Balance -= toWithdraw;
                label1.Text = account.Balance.ToString();
                DispenseCash(numberOf20s);
                accountList.UpdateAcct(account);
            }
        }
        public void DepositEnvelope()
        {
            DepositSlot.AcceptEnvelope();
        }

        public void DispenseCash(int numBills)
        {
            Dispenser.DispenseCash(numBills);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit(60, this.instanceAccount);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void closeAmountToWithdrawButton_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        { 
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void depositSlotButton_Click(object sender, EventArgs e)
        {
            DepositEnvelope();
        }

        private void WithdrawConfirmationButton_Click(object sender, EventArgs e)
        {
            Withdraw(numToWithdraw, this.instanceAccount);
            numToWithdraw = 0;
            AmounfOf20sToWithdrawLabel.Text = 0.ToString();
            panel1.Hide();
        }

        private void AmounfOf20sToWithdrawLabel_Click(object sender, EventArgs e)
        {

        }

        private void Increase20sToWithdrawButton_Click(object sender, EventArgs e)
        {
            this.numToWithdraw += 1;
            AmounfOf20sToWithdrawLabel.Text = this.numToWithdraw.ToString();
        }

        private void Decrease20sToWithdrawButton_Click(object sender, EventArgs e)
        {
            if (numToWithdraw > 0)
            {
                this.numToWithdraw -= 1;
            }

            AmounfOf20sToWithdrawLabel.Text = this.numToWithdraw.ToString();
        }
    }
}
