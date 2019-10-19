//-----------------------------------------------------------------------
// <copyright file="SquareRoot.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ProgramsForJUnitTesting
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// Calculates the square root of the number
    /// </summary>
    public class SquareRoot
    {
        /// <summary>
        /// Finds the square root.
        /// </summary>
        public void FindSquareRoot()
        {
            Utility utility = new Utility();
            Console.WriteLine("Enter number to find square root : ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Square root of entered number is : " + utility.SquareRoot(number));
        }
    }
}
