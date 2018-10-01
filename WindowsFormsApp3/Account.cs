using System;
namespace WindowsFormsApp3
{
    public class Account
    {
        private readonly string cardNum, pin;
        private readonly long lastAccess;
        private bool isLocked;
        private double balance;

        public Account(string c, string p, int a, bool l, double b)
        {
            this.cardNum = c;
            this.pin = p;
            this.lastAccess = System.DateTime.Now.Ticks;
            this.isLocked = l;
            this.balance = b;
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
    }
}
