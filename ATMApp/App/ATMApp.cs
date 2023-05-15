using ATMApp.Domain.Entities;
using ATMApp.Domain.Intefaces;
using ATMApp.UI;
using System.Runtime.CompilerServices;

namespace ATMApp.App
{
    public class ATMApp : IUserLogin
    {
        private List<UserAccount> userAccounts;
        private UserAccount selectedAccount;



        public void InitializeData()
        {
            userAccounts = new List<UserAccount>
            {
                new UserAccount
                {
                    Id = 1,
                    FullName = "Vasilis Antonopoulos",
                    AccountNumber = 123456,
                    CardNumber = 321,
                    CardPin = 123123,
                    AccountBalance = 1300.0m,
                    isLocked = false,
                },
                new UserAccount
                {
                    Id = 2,
                    FullName = "Andreas Sarantonopoulos",
                    AccountNumber = 15516,
                    CardNumber = 2341,
                    CardPin = 123123,
                    AccountBalance = 20000.0m,
                    isLocked = true,
                },
                new UserAccount
                {
                    Id = 3,
                    FullName = "Chara Kyr",
                    AccountNumber = 1122116,
                    CardNumber = 5671,
                    CardPin = 456123,
                    AccountBalance = 0.0m,
                    isLocked = false,
                }


            };

        }
        public void CheckUserCardNumAndPassword()
        {
            bool isCorrectionLogin = false;

            UserAccount tempUserAccount = new UserAccount();
            tempUserAccount.CardNumber = Validator.Convert<long>("your card number");
            tempUserAccount.CardPin = Convert.ToInt32(Utility.GetSecretInput("Enter your card ping"));
            Console.WriteLine("Checking Card Number and Pin...");
            int timer = 10;
            for (int i = 0;i < timer;i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(200);
            }
            Console.Clear();
        }

    }
}