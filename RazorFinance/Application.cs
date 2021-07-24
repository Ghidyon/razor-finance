using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorFinance
{
    public static class Application
    {
        public static async Task Run()
        {
            PromptUsername: 
            Console.WriteLine("Enter your login details\nEnter username");
            string username = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(username))
            {
                goto PromptUsername;
            }

            var userCredentials = Authentication.GetUserCredentials(username);
            var accountData = Authentication.RetrieveAccountData(username);

            PromptPassword:
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(password))
            {
                goto PromptPassword;
            }

            // display data on validation
            var isValidated = Authentication.IsValidated(username, password);
            if (isValidated)
            {
                foreach (var data in accountData)
                {
                    Console.WriteLine($"Welcome Back {data.FirstName} {data.LastName}");
                    Console.WriteLine("Your details are:");
                    Console.WriteLine($"Email: {data.Email}");
                    Console.WriteLine("Account No: {0}****{1}", data.AccountNumber.ToString().Substring(0, 3), data.AccountNumber.ToString()[7..]);
                    Console.WriteLine($"Account Balance: {data.Balance}");
                    Console.WriteLine("BVN: {0}*****{1}", data.BVN.ToString().Substring(0, 3), data.BVN.ToString()[8..]);
                    Console.WriteLine($"Branch: {data.Address}");
                }
            }
            else
            {
                Console.WriteLine("Invalid Credentials! Try Again!");
                goto PromptPassword;
            }
            
        }
    }
}
