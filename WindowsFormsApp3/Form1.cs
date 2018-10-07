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
    public partial class Form1 : Form
    {
        private AccountList accountList;
        private Account instanceAccount;
        public Form1()
        {
            InitializeComponent();
            this.accountList = new AccountList("accounts.json");
            this.instanceAccount = accountList.FindAcct("123456781234");
            // Right now this is hardcoded to use a specific account. Once we have a login protocol, switch out the manual string for whatever is passed
        }

        public void Logout()
        {
            //Close();
            //Go back to login
        }

        public void Deposit(int amount, Account account)
        {
            account.Balance += amount;
            // DepositSlot.AcceptEnvelope()
            this.accountList.UpdateAcct(account);
        }

        public void Withdraw(int numberOf20s, Account account)
        {
            // ATM.takeOut((numberOf20s * 20));
            account.Balance -= (numberOf20s * 20);
            // Dispenser.DispenseCash(numberOf20s_;
            accountList.UpdateAcct(account);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
