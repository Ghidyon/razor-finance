using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorFinance
{
    public static class Database
    {

        public static IEnumerable<Account> Accounts()
        {
            return new List<Account>()
            {
                new Account { Username = "ghidyon", FirstName = "Gideon", LastName = "Akunana", Email = "ghidyonakunana@outlook.com", Gender = 'M', Balance = 450,
                            AccountNumber = 00003450883, BVN = 22215479813, Address = "Independence Layout, Enugu"},
                new Account { Username = "kingalex", FirstName = "Alex", LastName = "Oz", Email = "kingalex@outlook.com", Gender = 'F', Balance = 1250,
                            AccountNumber = 00003450884, BVN = 22215479814, Address = "Achara Layout, Enugu"},
                new Account { Username = "queenlovey", FirstName = "Loveth", LastName = "Anosike", Email = "dovelovey@outlook.com", Gender = 'F', Balance = 1100,
                            AccountNumber = 00003450885, BVN = 22215479815, Address = "GRA, Enugu"},
                new Account { Username = "dayoutuber", FirstName = "Kelechi", LastName = "Youtube", Email = "kcmyoutube@outlook.com", Gender = 'M', Balance = 2500,
                            AccountNumber = 00003450886, BVN = 22215479816, Address = "Amechi, Enugu"},
                new Account { Username = "surely", FirstName = "Shola", LastName = "Nejo", Email = "nejoshola@outlook.com", Gender = 'M', Balance = 1700,
                            AccountNumber = 00003450887, BVN = 22215479817, Address = "Gariki, Enugu"}
            };
        }

        public static IEnumerable<Credential> Credentials()
        {
            return new List<Credential>
            {
                new Credential{Username = "ghidyon", FirstName = "Gideon", LastName = "Akunana", Password = "ghidyon"},
                new Credential{Username = "kingalex", FirstName = "Alex", LastName = "Oz", Password = "kingalex"},
                new Credential{Username = "queenlovey", FirstName = "Loveth", LastName = "Anosike", Password = "queenlovey"},
                new Credential{Username = "dayoutuber", FirstName = "Kelechi", LastName = "Youtube", Password = "dayoutuber"},
                new Credential{Username = "surely", FirstName = "Shola", LastName = "Nejo", Password = "surely"},
            };
        }
    }
}
