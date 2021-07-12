﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public static class Translation
    {
        public static void EnglishPromptPin()
        {
            Console.WriteLine("\nInsert PIN");
        }

        public static void PidginPromptPin()
        {
            Console.WriteLine("\nChook ya PIN");
        }

        public static void IgboPromptPin()
        {
            Console.WriteLine("\nTinye PIN gi");
        }

        public static void EnglishPromptOperation()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Withdrawal\n2. Check Balance\n3. Quit");
        }
        
        public static void PidginPromptOperation()
        {
            Console.WriteLine("Wetin you wan do?");
            Console.WriteLine("1. Collect Money\n2. Check How Much You Get\n3. Commot");
        }
        
        public static void IgboPromptOperation()
        {
            Console.WriteLine("Ke Ihe Ichoro Ime?");
            Console.WriteLine("1. Were Ego\n2. Le Ego Di N'aha Gi\n3. Puo");
        }

        public static void EnglishOperationErrorMessage()
        {
            Console.WriteLine("Invalid Selection!\n");
        }
        
        public static void PidginOperationErrorMessage()
        {
            Console.WriteLine("Wetin you press no follow o!\n");
        }
        
        public static void IgboOperationErrorMessage()
        {
            Console.WriteLine("Fichaa anya pinye ya ozo!\n");
        }
        
        public static void EnglishWithdrawalErrorMessage()
        {
            Console.WriteLine("Please enter multiples of N1,000 or N500\n");
        }
        
        public static void EnglishWithdrawalPrompt()
        {
            Console.WriteLine("Please select an option\n1. 5,000\n2. 10,000\n3. 20,000\n4. Enter Amount\n");
        }

        public static void PidginWithdrawalErrorMessage()
        {
            Console.WriteLine("Na only 1k or 5h we dey pay o!\n");
        }

        public static void PidginWithdrawalPrompt()
        {
            Console.WriteLine("How much you want?\n1. 5,000\n2. 10,000\n3. 20,000\n4. Enter Amount\n");
        
        }public static void IgboWithdrawalErrorMessage()
        {
            Console.WriteLine("Soo N1,000 ma obu N500 k'anyi na-akwu we dey pay o!\n");
        }

        public static void IgboWithdrawalPrompt()
        {
            Console.WriteLine("Ego Ole Ka Ichoro\n1. 5,000\n2. 10,000\n3. 20,000\n4. Enter Amount\n");
        }
    }
}
