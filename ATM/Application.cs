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

            Console.WriteLine("Set your PIN");
            string pin = RequestPIN();

            while (string.IsNullOrWhiteSpace(pin))
            {
                pin = PromptPin();
            }

            Console.WriteLine("\nWhat amount do you want to deposit?");
            string accountBalance = Console.ReadLine().Trim();

            int parsedAccountBalance;
            while( string.IsNullOrWhiteSpace(accountBalance) || accountBalance.Split().Length > 1 || !(int.TryParse(accountBalance, out parsedAccountBalance)) )
            {
                accountBalance = PromptUser("amount");
            }

            User user = new User
            {
                Name = name,
                Pin = pin,
                AccountBalance = int.Parse(accountBalance)
            };

            Console.WriteLine($"{user.Name}, has been registered successfully!");

            ATMService.ShowPin(user);
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

                // check if key pressed is a not a control key
                if (!char.IsControl(keyInfo.KeyChar))
                {
                    stringBuilder.Append(keyInfo.KeyChar);
                    Console.Write("*");
                }

            } while (keyInfo.Key != ConsoleKey.Enter); // while the key we're hitting is not Enter key
            return stringBuilder.ToString();
        }

        private static string PromptPin()
        {
            Console.WriteLine("PIN cannot be blank!");
            Console.WriteLine("Set your PIN");
            return RequestPIN();
        }

        private static string PromptUser(string fieldName)
        {
            Console.WriteLine($"Please, enter a valid {fieldName}");
            return Console.ReadLine().Trim();
        }
    }
}
