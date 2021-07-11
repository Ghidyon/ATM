using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public static class Application
    {
        public static void Run()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("You've reached the ATM Console Application\n");
            stringBuilder.AppendLine("Please enter your Name");
            Console.WriteLine(stringBuilder.ToString());

            string name = Console.ReadLine().Trim();

            while (string.IsNullOrWhiteSpace(name))
            {
                name = PromptUser("name");
            }

            Console.WriteLine("Set your 4-digit PIN");
            string pin = RequestPIN();

            while (string.IsNullOrWhiteSpace(pin) || pin.Length < 4 || pin.Length > 4)
            {
                pin = PromptPin();
            }

            int amountDeposited = 0;
            do
            {
                Console.WriteLine("\nHow much do you want to deposit?");
                string accountBalance = Console.ReadLine().Trim();
                while (string.IsNullOrWhiteSpace(accountBalance) || accountBalance.Split().Length > 1 || !(int.TryParse(accountBalance, out amountDeposited)))
                {
                    accountBalance = PromptUser("amount");
                }
                if (amountDeposited < 5000)
                {
                    Console.WriteLine("Minimum deposit is N5000");
                }
            } while (amountDeposited < 5000);
            
            User user = new User
            {
                Name = name,
                Pin = pin,
                AccountBalance = amountDeposited
            };

            ATMService.Register(user);

            ATMService.ShowPin();
        }

        private static string RequestPIN()
        {
            // store characters in stringbuilder to be able to build the * characters
            StringBuilder stringBuilder = new StringBuilder();

            // variable for the console keys information
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true); // sets the console to not display the character

                // check if key pressed is a numberkey
                if (char.IsDigit(keyInfo.KeyChar))
                {
                    stringBuilder.Append(keyInfo.KeyChar);
                    Console.Write("*");
                }

            } while (keyInfo.Key != ConsoleKey.Enter); // while the key we're hitting is not Enter key
            return stringBuilder.ToString();
        }

        private static string PromptPin()
        {
            Console.WriteLine("\nSet your 4-digit PIN");
            return RequestPIN();
        }

        private static string PromptUser(string fieldName)
        {
            Console.WriteLine($"Please, enter a valid {fieldName}");
            return Console.ReadLine().Trim();
        }

    }
}
