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
  public partial class Login : Form
  {
    //ATM atm;

    public Login(/*ATM atm*/)
    {
      //this.atm = atm;
      InitializeComponent();
    }

    private void Login_Load(object sender, EventArgs e){}

    private void AcctNumBox_TextChanged(object sender, EventArgs e){}

    private void PinBox_TextChanged(object sender, EventArgs e){}

    private void AcctLabel_Click(object sender, EventArgs e){}

    private void PinLabel_Click(object sender, EventArgs e){}

    private void LoginButton_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    private bool IsValidAcct(Account acct, string pin)
    {
      return (acct.Pin.Equals(pin) && !acct.IsLocked);
    }

    private void OpenMainMenu(Account acct)
    {
      //MainMenu menu = new MainMenu(acct, atm);
      //this.Hide();
      //menu.Show();
    }
  }
}
