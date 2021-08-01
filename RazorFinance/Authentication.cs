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

        public static async Task<List<Account>> RetrieveAccountDataAsync(string username) =>
            await Task.Run(() => _accounts.Where(data => data.Username.Equals(username.ToLower())).ToList());

        public static async Task<List<Credential>> GetUserCredentialsAsync(string username) =>
            await Task.Run(() => _credentials.Where(data => data.Username.Equals(username.ToLower())).ToList());

        public static async Task<bool> IsValidatedAsync(List<Credential> userCredentials, string password) =>
            await Task.Run(() => userCredentials?.Any(data => data.Password.Equals(password)) ?? false);
    }
}
