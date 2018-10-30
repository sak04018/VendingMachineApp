using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace VendingMachineApp
{
    class Program
    {
        bool a = false;
        static void Main(string[] args)
        {
            Console.WriteLine("*************************");
            Console.WriteLine("Welcome to your YumYum vending machine!");
            Console.WriteLine("*************************");
            while (true)
            {
                try
                {
                    Console.WriteLine("Please make a selection from the following vending options:");
                    var vendingSelection = Enum.GetNames(typeof(VendingSelection));
                    for (var i = 1; i < vendingSelection.Length; i++)
                    {
                        Console.WriteLine($"{i}. {vendingSelection[i]}");
                    }
                    Console.Write("Please select an option or press '0' to exit: ");
                    var option = Convert.ToInt32(Console.ReadLine());
                    var selection = vendingSelection[option];
                    switch (option)
                    {
                        case 0:
                            return;

                        case 1:
                            {
                                var chipTypes = Enum.GetNames(typeof(Chips));
                                for (var i = 0; i < chipTypes.Length; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {chipTypes[i]}");
                                }
                                Console.Write("Please enter choice from listed Chips: ");
                                var chipTypeOption = Convert.ToInt32(Console.ReadLine());
                                var snackName = chipTypes[chipTypeOption - 1];
                                var chip = VendingMachine.NewTransaction(selection, snackName);
                                Console.WriteLine("Dispensing selection. Enjoy your snack!");
                                break;
                            }

                        case 2:
                            {
                                var barTypes = Enum.GetNames(typeof(ChocolateBars));
                                for (var i = 0; i < barTypes.Length; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {barTypes[i]}");
                                }
                                Console.Write("Please enter choice from listed Chocolate Bars: ");
                                var barTypeOption = Convert.ToInt32(Console.ReadLine());
                                var snackName = barTypes[barTypeOption - 1];
                                var bar = VendingMachine.NewTransaction(selection, snackName);
                                Console.WriteLine("Dispensing selection. Enjoy your snack!");
                                break;
                            }

                        case 3:
                            {
                                var bagTypes = Enum.GetNames(typeof(CandyBags));
                                for (var i = 0; i < bagTypes.Length; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {bagTypes[i]}");
                                }
                                Console.Write("Please enter choice from listed Candy Bags: ");
                                var bagTypeOption = Convert.ToInt32(Console.ReadLine());
                                var snackName = bagTypes[bagTypeOption - 1];
                                var bag = VendingMachine.NewTransaction(selection, snackName);
                                Console.WriteLine("Dispensing selection. Enjoy your snack!");
                                break;
                            }

                        case 4:
                            {
                                var pastryTypes = Enum.GetNames(typeof(Pastries));
                                for (var i = 0; i < pastryTypes.Length; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {pastryTypes[i]}");
                                }
                                Console.Write("Please enter choice from listed Pastries: ");
                                var pastryTypeOption = Convert.ToInt32(Console.ReadLine());
                                var snackName = pastryTypes[pastryTypeOption - 1];
                                var pastry = VendingMachine.NewTransaction(selection, snackName);
                                Console.WriteLine("Dispensing selection. Enjoy your snack!");
                                break;
                            }

                        case 5:
                            {
                                var miscTypes = Enum.GetNames(typeof(MiscSnacks));
                                for (var i = 0; i < miscTypes.Length; i++)
                                {
                                    Console.Write($"{i + 1}. {miscTypes[i]}");
                                }
                                Console.Write("Please enter choice from listed Misc Snacks: ");
                                var miscTypeOption = Convert.ToInt32(Console.ReadLine());
                                var snackName = miscTypes[miscTypeOption - 1];
                                var misc = VendingMachine.NewTransaction(selection, snackName);
                                Console.WriteLine("Dispensing selection. Enjoy your snack!");
                                break;
                            }
                        default:
                            break;
                    }
                }

                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Choose a valid selection and try again");
                }
                catch (ArgumentNullException ax)
                {
                    Console.WriteLine($"Error: {ax.Message}");
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong! Please try again.");
                }
            }
                
            
        }
       
    }
}
