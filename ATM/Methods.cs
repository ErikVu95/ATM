using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Methods
    {
        public List<AccountInfo> CardHolders = new();
        int option;
        public AccountInfo currentUser;
        Random random = new();

        public Methods()
        {
            CardHolders.Add(new("Dani", "Mcswaggy", "1111", 9999));
            CardHolders.Add(new("Erik", "Kosegutt", "6942013371", 250000));
            CardHolders.Add(new("Marija", "CopyPaste", "37287474", 2893));
            CardHolders.Add(new("Adrian", "sæter", "37287474", 2893));
        }

        public void AddUser()
        {
            //ordne 10 nummere, klarer ikke int med så langt nummer
            int randomNumber = random.Next(1000000000, 1999999999);
            var convertedNumber = Convert.ToString(randomNumber);


            var option = "0";
            Console.WriteLine("Would you like to create or log into an existing account?");
            option = Console.ReadLine();
            if (option == "1")
            {
                Console.WriteLine("Type your first name");
                var firstName = Console.ReadLine();
                Console.WriteLine("Type your last name");
                var lastName = Console.ReadLine();
                var cardNumber = convertedNumber;

                double balance = 0;

                CardHolders.Add(new(firstName, lastName, cardNumber, balance));
            }
            if (option == "2")
            {

            }
            else
            {
                Environment.Exit(0);
            }
        }

        public void Login()
        {
            int tries = 3;

            while (tries > 0)
            {
                Console.WriteLine("Type in your cardnumber");
                var loginCardNum = Console.ReadLine();
                currentUser = CardHolders.FirstOrDefault(user => user.CardNumber == loginCardNum);

                if (currentUser != null)
                {
                    Console.WriteLine($"Welcome {currentUser.FirstName} {currentUser.LastName}\n");
                    ExecuteOptions();
                }

                else
                {
                    tries--;
                    Console.WriteLine($"You have {tries} tries left.");
                }
            }
        }

        public void PrintOptions()
        {
            Console.WriteLine("Please choose an option: ");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check balance");
            Console.WriteLine("4. Logout");
        }

        public void Deposit()
        {
            Console.WriteLine("How much would you like to deposit?");
            double depositMoney = 0;
            try
            {
                depositMoney = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.Clear(); Console.WriteLine("Error\n");
            }
            if (depositMoney != 0)
            {
                Console.Clear();
                currentUser.CardBalance += depositMoney;
                Console.WriteLine($"{depositMoney} has been added to your balance.\n");
            }
        }

        public void Withdraw()
        {
            Console.WriteLine("How much would you like to withdraw?");
            double depositMoney = 0;
            try
            {
                depositMoney = Convert.ToDouble(Console.ReadLine());
            }
            catch { Console.Clear(); Console.WriteLine("Error\n"); }
            if (depositMoney != 0)
            {
                Console.Clear();
                currentUser.CardBalance -= depositMoney;
                Console.WriteLine($"{depositMoney} has been withdrawn from your balance.");
            }

        }

        public void CheckBalance()
        {
            Console.WriteLine($"Your balance is {currentUser.CardBalance} NOK.");
        }

        public void ExecuteOptions()
        {
            do
            {
                PrintOptions();
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch { Console.WriteLine("Option failed at login"); }
                if (option == 1) { Deposit(); }
                else if (option == 2) { Withdraw(); }
                else if (option == 3) { CheckBalance(); }
                else if (option == 4) { Environment.Exit(0); }
                else { break; }
            } while (option != 5);
        }

        //public void ExecuteOptions()
        //{
        //    while (true)
        //    {
        //        PrintOptions();
        //        string option = Console.ReadLine();
        //        if (option == "1") { Deposit(); }
        //        else if (option == "2") { Withdraw(); }
        //        else if (option == "3") { CheckBalance(); }
        //        else if (option == "4") { Environment.Exit(0); }
        //        else
        //        {
        //            Console.WriteLine("Invalid number");
        //            break;
        //        }
        //    }
        //}
    }
}
