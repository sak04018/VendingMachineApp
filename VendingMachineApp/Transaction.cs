using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace VendingMachineApp
{
    enum VendingSelection
    {
        Exit,
        Chips,
        ChocolateBars,
        CandyBags,
        Pastries,
        MiscSnacks
    }
    enum Chips
    {
        Doritos,
        Cheetos,
        Ruffles,
        LaysBBQ,
        SunChips
    }
    enum ChocolateBars
    {
        Snickers,
        KitKat,
        MilkyWay,
        Butterfinger,
        Twix
    }
    enum CandyBags
    {
        Starburst,
        Skittles,
        Twizzlers,
        SourPatchKids,
        JujyFruits
    }
    enum Pastries
    {
        PopTart,
        CinnamonRolls,
        ChocolateChipCookie,
        MiniDonuts,
        ApplePie
    }
    enum MiscSnacks
    {
        Altoids,
        DentyneICE,
        TridentWhite,
        BeefJerky,
        SmokedAlmonds
    }

    class Transaction
    {
        #region Properties
        public int TransactionNumber { get; set; }
        public string Selection { get; set; }
        public string SnackName { get; set; }
        public DateTime TransactionDate { get; set; }

        #endregion

        #region Constructors
        public Transaction()
        {
            TransactionDate = DateTime.Now;
        }
        #endregion

        private static class Constants
        {
            public static decimal snackPrice = 2.00M;

        }

        #region Methods
        /// <summary>
        /// Indicate price based on selection 
        /// </summary>
        /// <param name="selection"></param>


        /// <summary>
        /// Deposit coins or bills to pay for vending product. 
        /// Must be in correct currency format (Nickels, Dimes, Quarters, Dollar bills)
        /// </summary>
        /// <param name="deposit"></param>
        public void DepositMoney(string selection)
        {
            decimal snackPrice = 0;
            decimal TotalDeposit = 0;

            if (selection == "Chips")
            {
                snackPrice = 1.25M;
            }
            else if (selection == "ChocolateBars")
            {
                snackPrice = 2.00M;
            }
            else if (selection == "CandyBags")
            {
                snackPrice = 2.25M;
            }
            else if (selection == "Pastries")
            {
                snackPrice = 1.50M;
            }
            else if (selection == "MiscSnacks")
            {
                snackPrice = 1.75M;
            }

            Console.WriteLine($"Please deposit ${snackPrice}");
            
            while (snackPrice > TotalDeposit) 
            {
                Console.WriteLine("Machine accepts nickels(.05), dimes(.10), quarters(.25) and dollars (1.00). ");
                Console.Write("Deposit amount: ");
                var deposit = Convert.ToDecimal(Console.ReadLine());
                switch (deposit)
                {
                    case 0:
                        return;
                    case .05M:
                        TotalDeposit += .05M;
                        break;
                    case .10M:
                        TotalDeposit += .10M;
                        break;
                    case .25M:
                        TotalDeposit += .25M;
                        break;
                    case 1.00M:
                        TotalDeposit += 1.00M;
                        break;
                    default:
                        Console.WriteLine("Please insert correct currency");
                        break;
                }

                if (TotalDeposit == snackPrice)
                {
                    Console.WriteLine("Dispensing selection");
                }
                else if (TotalDeposit < snackPrice)
                {
                    Console.WriteLine($"Additional deposit of ${snackPrice - TotalDeposit} required");
                }
                else if (TotalDeposit > snackPrice)
                {
                    Console.WriteLine($"Dispensing Change ${TotalDeposit - snackPrice}");
                }
            } 
        }
        #endregion

    }
}
