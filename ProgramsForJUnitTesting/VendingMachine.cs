//-----------------------------------------------------------------------
// <copyright file="VendingMachine.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ProgramsForJUnitTesting
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// Vending Machine Program
    /// </summary>
    public class VendingMachine
    {
        /// <summary>
        /// Vending the machine.
        /// </summary>
        public void VendingMach()
        {
            Utility utility = new Utility();
            Console.WriteLine("Enter amount : ");
            int value = Convert.ToInt32(Console.ReadLine());
            utility.Note(value);
        }
     }
}
