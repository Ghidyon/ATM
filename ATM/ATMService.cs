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

            Console.WriteLine($"{_user.Name}, has been registered successfully!\nYou've {_user.AccountBalance} Naira in your account!");
        }
    }
}
