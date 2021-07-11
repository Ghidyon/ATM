using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public static class Translation
    {
        public static void PromptPinEnglish()
        {
            Console.WriteLine("\nInsert PIN");
        }

        public static void PromptPinPidgin()
        {
            Console.WriteLine("\nChook ya PIN");
        }

        public static void PromptPinIgbo()
        {
            Console.WriteLine("\nTinye PIN gi");
        }

        public static void PromptOperationEnglish()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Withdrawal\n2. Check Balance\n3. Quit");
        }
        
        public static void PromptOperationPidgin()
        {
            Console.WriteLine("Wetin you wan do?");
            Console.WriteLine("1. Collect Money\n2. Check How Much You Get\n3. Commot");
        }
        
        public static void PromptOperationIgbo()
        {
            Console.WriteLine("Ke Ihe Ichoro Ime?");
            Console.WriteLine("1. Were Ego\n2. Le Ego Di N'aha Gi\n3. Puo");
        }

        public static void OperationErrorMessageEnglish()
        {
            Console.WriteLine("Invalid Selection!\n");
        }
        
        public static void OperationErrorMessagePidgin()
        {
            Console.WriteLine("Wetin you press no follow o!\n");
        }
        
        public static void OperationErrorMessageIgbo()
        {
            Console.WriteLine("Fichaa anya pinye ya ozo!\n");
        }
    }
}
