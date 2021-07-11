using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // sets the title of the console
            Console.Title = "Automated Teller Machine";

            // sets the text color of the console, also known as the foreground color
            //Console.ForegroundColor = ConsoleColor.White;

            //Console.WriteLine("Hello User! Please enter your 4 digit pin!");

            //Console.WriteLine($"This is your pin: {pin}");

            Application.Run();

            // display the pin as masked asterisks
            Console.ReadKey();
        }

        
    }
}
