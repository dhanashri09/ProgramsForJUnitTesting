//-----------------------------------------------------------------------
// <copyright file="ToBinary.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ProgramsForJUnitTesting
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// Converts binary number into decimal number
    /// </summary>
    public class ToBinary
    {
        /// <summary>
        /// Binary to decimal.
        /// </summary>
        public void BinaryToDecimal()
        {
            Utility utility = new Utility();
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = utility.ToBinary(number);
            Console.WriteLine("Converted decimal number is : " + result);
        }
    }
}
