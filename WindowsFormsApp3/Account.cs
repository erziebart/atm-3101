using System;
namespace WindowsFormsApp3
{
    public class Account
    {
        public string cardNum {get; set;}
        public string pin { get; set; }
        public double lastAccess { get; set; }
        public bool isLocked { get; set; }
        public double balance { get; set; }

        public Account()
        {
        }

        // Unlock the account
        public void Lock() {
            this.isLocked = true;
        }

        // Lock the account
        public void Unlock() {
            this.isLocked = false;
        }

        // Add specified amount to account balance
        public void Deposit(double x) {
            this.balance += x;
        }

        // Subtract specified amount from account balance
        public void Withdraw(double x) {
            this.balance -= x;
        }

        public string GetCardNum() {
            return this.cardNum;
        }
    }
}
