using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
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
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "accounts.json");
            string json = File.ReadAllText(path);
            Account entries = JsonConvert.DeserializeObject<Account>(json);
            //foreach(Account acct in entries) {
            //    if (acct.GetCardNum().Equals(acctNum)) {
            //        return acct;
            //    }
            //}
            return entries;
        }
    }
}
