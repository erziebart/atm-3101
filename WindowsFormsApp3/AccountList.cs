using System;
using System.IO;
using Newtonsoft.Json;

namespace WindowsFormsApp3
{
    public class AccountList
    {
        private readonly string acctFile;
        private readonly JsonSerializer js;

        public AccountList(string s)
        {
            this.acctFile = s;
            this.js = new JsonSerializer();
        }

        public Account FindAcct(string acctNum) {
            string json = File.ReadAllText("accounts.json");
            return new Account();
        }
    }
}
