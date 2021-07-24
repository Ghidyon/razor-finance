using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorFinance
{
    class Authentication
    {
        private static readonly IEnumerable<Account> _accounts = Database.Accounts();
        private static readonly IEnumerable<Credential> _credentials = Database.Credentials();

        public static List<Account> RetrieveAccountData(string username)
        {
            var accountData = _accounts.Where(data => data.Username.Equals(username)).ToList();
            return accountData;
        }

        public static List<Credential> GetUserCredentials(string username)
        {
            List<Credential> userCredentials = _credentials.Where(data => data.Username.Equals(username.ToLower())).ToList();
            return userCredentials;
        }

        public static bool IsValidated(string username, string password)
        {
            List<Credential> userCredentials = GetUserCredentials(username);
            return userCredentials?.Any(data => data.Password.Equals(password)) ?? false;
        }
    }
}
