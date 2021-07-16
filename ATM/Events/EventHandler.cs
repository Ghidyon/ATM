using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Events
{
    public static class EventHandler
    {
        public static void RecordDebitAlert(object sender, DebitEventArgs model)
        {
            Console.WriteLine("Debit Alert!");
            Console.WriteLine($"Amount: N{model.WithdrawalAmount:n}");
            Console.WriteLine($"Account: {model.AccountNumber}");
            Console.WriteLine($"Time: {DateTime.Now}\n");
        }
    }
}
