using System;
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

        //public Account FindAcct(string acctNum) {

        //    return new Account();
        //}
    }
}
