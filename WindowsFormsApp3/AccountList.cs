using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp3
{
    // This class handles reading and writing json like a database
    public class AccountList
    {
        private readonly string acctFile;

        public AccountList(string s)
        {
            this.acctFile = s;
        }

        // Deserialize the json into a list of Account objects
        // Iterate through the list to find the object with matching account number
        // Return that object
        // If not found, return null
        public Account FindAcct(string acctNum) {
            //string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), acctFile);
            string path = "../../" + acctFile;
            string json = File.ReadAllText(path);
            List<Account> accts = JsonConvert.DeserializeObject<List<Account>>(json);
            foreach(Account a in accts) {
                if (a.CardNum.Equals(acctNum)){
                    return a;
                }
            }
            return null;
        }

        // Deserialize json into a list of account objects
        // Go through the list and find the account to update
        // Store that account in a variable
        // Remove that account from the list
        // Add the passed in account to the list
        // Serialize the json and write to file
        public void UpdateAcct(Account acct) {
            string path = "../../" + acctFile;
            string json = File.ReadAllText(path);
            List<Account> entries = JsonConvert.DeserializeObject<List<Account>>(json);
            Account toRemove = new Account();
            foreach (Account a in entries)
            {
                if (a.CardNum.Equals(acct.CardNum))
                {
                    toRemove = a;
                }
            }
            entries.Remove(toRemove);
            entries.Add(acct);

            string newJSON = JsonConvert.SerializeObject(entries.ToArray(), Formatting.Indented);
            File.WriteAllText(path, newJSON);
        }
    }
}