using System;
using System.Threading.Tasks;

namespace RazorFinance
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Task.Run(() => Application.Run());
        }
    }
}
