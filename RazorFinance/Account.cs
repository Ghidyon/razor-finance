using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorFinance
{
    public class Account
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long AccountNumber { get; set; }
        public long BVN { get; set; }
        public int Balance { get; set; }
        public string Address { get; set; }
        public char Gender { get; set; }
    }
}
