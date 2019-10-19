//-----------------------------------------------------------------------
// <copyright file="utility.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ProgramsForJUnitTesting
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// Utility for all programs
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// i and total are the variables
        /// </summary>
        private static int i, total;

        /// <summary>
        /// The notes is integer type array
        /// </summary>
        private static int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };

        /// <summary>
        /// Notes the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        public void Note(int value)
        {
            if (value / notes[i] != 0)
            {
                total += value / notes[i];
                Console.WriteLine(notes[i] + " rs notes : " + (value / notes[i]));
                value = value % notes[i];
            }

            i++;

            if (value == 0)
            {
                Console.WriteLine("Total notes : " + total);
                return;
            }

            this.Note(value);
        }

        /// <summary>
        /// Day of weeks the specified month.
        /// </summary>
        /// <param name="month">The month.</param>
        /// <param name="date">The date.</param>
        /// <param name="year">The year.</param>
        /// <returns> It return day of the date </returns>
        public int DayOfWeek(int month, int date, int year)
        {
            int y = (year - (14 - month)) / 12;
            int x = y + (y / 4) - (y / 100) + (y / 400);
            int m = (month + 12) * (14 - month) / 12 - 2;
            int d = (date + x + ((31 * m) / 12)) % 7;
            return d;
        }

        /// <summary>
        /// Temperature the conversion fahrenheit  to celsius.
        /// </summary>
        /// <param name="fer">The fer is the fahrenheit temperature.</param>
        /// <returns>This function returns celsius temperature which is converted from fahrenheit</returns>
        public double TemperatureConversionFToC(double fer)
        {
            return (fer - 32) * 5 / 9;
        }

        /// <summary>
        /// Temperature the conversion celsius to fahrenheit.
        /// </summary>
        /// <param name="cel">The cel.</param>
        /// <returns>This function returns fahrenheit temperature which is converted from celsius</returns>
        public double TemperatureConversionCToF(double cel)
        {
            return ((9 * cel) / 5) + 32;
        }

        /// <summary>
        /// Squares the root.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>It returns the square root of the number</returns>
        public double SquareRoot(double c)
        {
            double t = c;
            double epsilon = 1e-15;
            while (Math.Abs(t - c / t) > (epsilon * t))
            {
                t = (c / t) + (t / 2);
            }

            return t;
        }

        /// <summary>
        /// Monthly payment.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <param name="y">The y.</param>
        /// <param name="r">The r.</param>
        /// <returns>It returns payment</returns>
        public double MonthlyPayment(double p, double y, double r)
        {
            double n = 12 * y;
            double r0 = r / (12 * 100);
            double payment = (p * r0 / 1) - Math.Pow(1 + r0, -n);

            return payment;
        }

        /// <summary>
        /// Converts to binary.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>It returns decimal value</returns>
        public int ToBinary(int number)
        {
            int decimalValue = 0;
            int baseValue = 1;
            int reminderValue;
            while (number > 0)
            {
                reminderValue = number % 10;
                decimalValue = decimalValue + (reminderValue * baseValue);
                number = number / 10;
                baseValue = baseValue * 2;
            }

            return decimalValue;
        }

        /// <summary>
        /// Powers the of two.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>It returns false if the number is not power of two</returns>
        public bool PowerOfTwo(int number)
        {
            int i = 0, temp = (int)Math.Pow(2, i);
            while (temp < number)
            {
                if (temp == number)
                {
                    return true;
                }

                i++;
            }

            return false;
        }

        /// <summary>
        /// Swaps the nibbles.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>It returns array which is swapped</returns>
        public int[] SwapNibbles(int[] array)
        {
            int temp, j = array.Length - 4;

            for (int i = 0; i < 4; i++)
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;

                j++;
            }

            return array;
        }  

        /*public void ShowArray(int[] array)
        {
            for (int i = 0; i < array.length; i++)
            {

            }
        }*/
    }
}
