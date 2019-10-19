//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ProgramsForJUnitTesting
{
    using System;

    /// <summary>
    /// Main Method Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
         public static void Main(string[] args)
        {
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("1 : Vending Machine");
                    Console.WriteLine("2 : Day Of Week");
                    Console.WriteLine("3 : Temperature Conversion");
                    Console.WriteLine("4 : Square Root");
                    Console.WriteLine("5 : Monthly Payment");
                    Console.WriteLine("6 : Binary To Decimal Conversion");
                    Console.WriteLine("7 : Binary Nibble Swap");
                    Console.WriteLine("8 : Exit");
                    Console.WriteLine("Enter your choice : ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    switch (choice)
                    {
                        case 1:
                            VendingMachine vendingMachine = new VendingMachine();
                            vendingMachine.VendingMach();
                            Console.WriteLine();
                            break;
                        case 2:
                            DayOfWeek dayOfWeek = new DayOfWeek();
                            dayOfWeek.FindDay();
                            Console.WriteLine();
                            break;
                        case 3:
                            TemperatureConversion temperatureConversion = new TemperatureConversion();
                            temperatureConversion.Temperature();
                            Console.WriteLine();
                            break;
                        case 4:
                            SquareRoot squareRoot = new SquareRoot();
                            squareRoot.FindSquareRoot();
                            Console.WriteLine();
                            break;
                        case 5:
                            MonthlyPayment monthlyPayment = new MonthlyPayment();
                            monthlyPayment.MonthlyPay();
                            Console.WriteLine();
                            break;
                        case 6:
                            ToBinary toBinary = new ToBinary();
                            toBinary.BinaryToDecimal();
                            Console.WriteLine();
                            break;
                        case 7:

                            break;
                        case 8:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Choice not found");
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Enter valid input");
            }
        }
    }
}
