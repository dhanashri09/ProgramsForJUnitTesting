//-----------------------------------------------------------------------
// <copyright file="TemperatureConversion.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ProgramsForJUnitTesting
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// Converts Fahrenheit  temperature into celsius and vice-versa using formula.
    /// </summary>
    public class TemperatureConversion
    {
        /// <summary>
        /// Converts temperature.
        /// </summary>
        public void Temperature()
        {
            try
            {
                Utility utility = new Utility();
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("1 : Convert Temperature From Fahrenheit to Celsius");
                    Console.WriteLine("2 : Convert Temperature From Celsius to Fahrenheit");
                    Console.WriteLine("3 : Exit");
                    Console.WriteLine("Enter your choice : \n");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter Farenheit Temperature : ");
                            double fer = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Celsius Temperature is : " + utility.TemperatureConversionFToC(fer));
                            break;
                        case 2:
                            Console.WriteLine("Enter Celsius Temperature : ");
                            double cel = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Farenheit Temperature : " + utility.TemperatureConversionCToF(cel));
                            break;
                        case 3:
                            flag = false;
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Enter valid input ");
            }
        }
    }
}
