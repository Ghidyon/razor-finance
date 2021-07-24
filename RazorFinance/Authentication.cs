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

        public static async Task<List<Account>> RetrieveAccountData(string username)
        {
            var accountData = _accounts.Where(data => data.Username.Equals(username.ToLower())).ToList();
            return accountData;
        }

        public static async Task<List<Credential>> GetUserCredentials(string username)
        {
            List<Credential> userCredentials = _credentials.Where(data => data.Username.Equals(username.ToLower())).ToList();
            return userCredentials;
        }

        public static async Task<bool> IsValidated(List<Credential> userCredentials, string password)
        {
            return userCredentials?.Any(data => data.Password.Equals(password)) ?? false;
        }
    }
}
