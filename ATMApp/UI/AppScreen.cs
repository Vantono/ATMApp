using ATMApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.UI
{
    public static class AppScreen
    {
        internal static void Welcome()
        {
            //Clears the console screen
            Console.Clear();
            Console.Title = "My ATM Application";
            //Change the Foreground color
            Console.ForegroundColor = ConsoleColor.White;

            //Set the Welcome Message
            Console.WriteLine("\n\n------------------Welcome to ATM App------------------\n\n");
            Console.WriteLine("Please insert your ATM Card");
            Console.WriteLine("Note: Actually ATM machine will accept and validate" +
                "physical ATM Card, read the Card Number and validate it.");
            Utility.PressEnterToContinue();
        }
        internal static UserAccount UserLoginForm()
        {
            UserAccount tempUserAccount = new UserAccount();

            tempUserAccount.CardNumber = Validator.Convert<long>("your card number");
            tempUserAccount.CardPin = Convert.ToInt32(Utility.GetSecretInput("Enter your card ping"));

            return tempUserAccount;
        }

    }
}
