﻿using System;
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
  public partial class Login : Form
  {
    private ATM atm;

    public Login(ATM atm)
    {
      this.atm = atm;
      InitializeComponent();
    }

    private void Login_Load(object sender, EventArgs e){}

    private void AcctNumBox_TextChanged(object sender, EventArgs e){}

    private void PinBox_TextChanged(object sender, EventArgs e){}

    private void AcctLabel_Click(object sender, EventArgs e){}

    private void PinLabel_Click(object sender, EventArgs e){}

    private void LoginButton_Click(object sender, EventArgs e)
    {
      Submit();
    }

    /* submit the user input to the system */
    private void Submit()
    {
      // get the account number and pin from the user input
      String acctNum = this.AcctNumBox.Text;
      String pin = this.PinBox.Text;

      // load the user from the database that matches the account number
      AccountList db = atm.GetDatabase();
      Account user = db.FindAcct(acctNum);

      // check if the account pin is correct
      if (user != null)
      {
        if (IsValidLogin(user, pin))
        {
          // open the user's main menu screen
          OpenMainMenu(user);
        }
        else
        {
          // lock the user account and update in database
          user.Lock();
          db.UpdateAcct(user);
        }
      }
      else
      {
        // the account does not exist
        Console.WriteLine("Account not found");
      }
    }

    /* returns true if the user is allowed to access the account */
    private bool IsValidLogin(Account acct, string pin)
    {
      return (acct.Pin.Equals(pin) && !acct.IsLocked);
    }

    /* opens the user's main menu */
    private void OpenMainMenu(Account acct)
    {
      //MainMenu menu = new MainMenu(acct, atm);
      //this.Hide();
      //menu.Show();
      Console.WriteLine("Showing Main Menu");
    }
  }
}
