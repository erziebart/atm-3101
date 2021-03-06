﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class ATM
    {
        private int bill20sLeft;
        private AccountList accounts;

        public ATM(string jsonFilename)
        {
            bill20sLeft = 500;
            accounts = new AccountList(jsonFilename);
    
        }

        public Boolean TakeOut(int number)
        {
            if (bill20sLeft - number >= 0)
            {
                bill20sLeft -= number;
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ATM lacks sufficient funds to process request.");
                return false;
            }
        }

        public AccountList GetDatabase()
        {
            return accounts;
        }

        public int getBill20Left()
        {
            return this.bill20sLeft;
        }

  
    }
}
