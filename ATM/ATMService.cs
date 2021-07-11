using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public static class ATMService
    {
        //private static int _vault = 5000;
        private static User _user;

        public static void ShowPin()
        {
            Console.WriteLine($"{_user.Pin} is the new user's pin!");
        }

        public static void Register(User model)
        {
            _user = new User()
            {
                Name = model.Name,
                Pin = model.Pin,
                AccountBalance = model.AccountBalance
            };
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n{_user.Name}, has been registered successfully!\nYou've N{_user.AccountBalance:n} in your account!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void ValidatePinEnglish(bool isLoggedIn)
        {
            while (!isLoggedIn)
            {
                Translation.PromptPinEnglish();
                string PIN = Application.RequestPIN();

                while (string.IsNullOrWhiteSpace(PIN))
                {
                    Translation.PromptPinEnglish();
                    PIN = Application.RequestPIN();
                }

                isLoggedIn = IsValidated(PIN, _user.Pin);
                if (!isLoggedIn)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nIncorrect PIN!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.WriteLine($"\n\nWelcome {_user.Name}!");
        }

        public static void ValidatePinPidgin(bool isLoggedIn)
        {
            while (!isLoggedIn)
            {
                Translation.PromptPinPidgin();
                string PIN = Application.RequestPIN();

                while (string.IsNullOrWhiteSpace(PIN))
                {
                    Translation.PromptPinPidgin();
                    PIN = Application.RequestPIN();
                }

                isLoggedIn = IsValidated(PIN, _user.Pin);
                if (!isLoggedIn)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDis PIN no legit!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.WriteLine($"\n\nWelcome {_user.Name}!");
        }
        
        public static void ValidatePinIgbo(bool isLoggedIn)
        {
            while (!isLoggedIn)
            {
                Translation.PromptPinIgbo();
                string PIN = Application.RequestPIN();

                while (string.IsNullOrWhiteSpace(PIN))
                {
                    Translation.PromptPinIgbo();
                    PIN = Application.RequestPIN();
                }

                isLoggedIn = IsValidated(PIN, _user.Pin);
                if (!isLoggedIn)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nPIN a adaba ro!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.WriteLine($"\n\nNnoo {_user.Name}!");
        }


        public static AccountOperation SelectOperationEnglish()
        {
            Translation.PromptOperationEnglish();
            string operation = Console.ReadLine().Trim();

            while (string.IsNullOrWhiteSpace(operation) || (operation != "1" && operation != "2" && operation != "3"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Translation.OperationErrorMessageEnglish();
                Console.ForegroundColor = ConsoleColor.White;
                Translation.PromptOperationEnglish();
                operation = Console.ReadLine().Trim();
            }

            return MatchOperation(operation);
        }
        
        public static AccountOperation SelectOperationPidgin()
        {
            Translation.PromptOperationPidgin();
            string operation = Console.ReadLine().Trim();

            while (string.IsNullOrWhiteSpace(operation) || (operation != "1" && operation != "2" && operation != "3"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Translation.OperationErrorMessagePidgin();
                Console.ForegroundColor = ConsoleColor.White;
                Translation.PromptOperationPidgin();
                operation = Console.ReadLine().Trim();
            }

            return MatchOperation(operation);
        }
        
        public static AccountOperation SelectOperationIgbo()
        {
            Translation.PromptOperationIgbo();
            string operation = Console.ReadLine().Trim();

            while (string.IsNullOrWhiteSpace(operation) || (operation != "1" && operation != "2" && operation != "3"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Translation.OperationErrorMessageIgbo();
                Console.ForegroundColor = ConsoleColor.White;
                Translation.PromptOperationIgbo();
                operation = Console.ReadLine().Trim();
            }

            return MatchOperation(operation);
        }

        public static AccountOperation MatchOperation(string operation)
        {
            switch (operation)
            {
                case "1":
                    return AccountOperation.Withdrawal;
                case "2":
                    return AccountOperation.CheckBalance;
                case "3":
                    return AccountOperation.End;
                default:
                    return AccountOperation.SelectOperation;
            }
        }

        public static Language SelectLanguage()
        {
            Console.WriteLine("\nChoose your preferred language:\n1. English\n2. Pidgin\n3. Igbo");
            string language = Console.ReadLine().Trim();

            while (string.IsNullOrWhiteSpace(language) || (language != "1" && language != "2" && language != "3"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Language Selection\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Choose your preferred language using the number key:\n1. English\n2. Pidgin\n3. Igbo");
                language = Console.ReadLine().Trim();
            }

            return MatchLanguageSelection(language);
        }

        public static Language MatchLanguageSelection(string language)
        {
            switch (language)
            {
                case "1":
                    return Language.English;
                case "2":
                    return Language.Pidgin;
                case "3":
                    return Language.Igbo;
                default:
                    return Language.ChooseLanguage;
            }
        }

        private static bool IsValidated(string pin, string PIN)
        {
            return (pin == PIN) ? true : false;
        }
    }
}
