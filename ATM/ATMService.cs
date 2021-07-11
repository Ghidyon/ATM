using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public static class ATMService
    {
        private static int _vault = 5000;
        //private static User _user;

        public static void ShowPin(User model)
        {
            Console.WriteLine($"{model.Pin} is the new user's pin!");
        }
    }
}
