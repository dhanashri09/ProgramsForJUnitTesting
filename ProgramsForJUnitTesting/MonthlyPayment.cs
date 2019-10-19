//-----------------------------------------------------------------------
// <copyright file="MonthlyPayment.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ProgramsForJUnitTesting
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// Calculates the monthly payment by taking three variables as y year,p principle loan amount and r is r percent interest by using formula.
    /// </summary>
    public class MonthlyPayment
    {
        /// <summary>
        /// Function calculates the monthly salary using formula.
        /// </summary>
        public void MonthlyPay()
        {
            Utility utility = new Utility();
            Console.WriteLine("Enter principle loan amount : ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year : ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter interest : ");
            int r = Convert.ToInt32(Console.ReadLine());

            double payment = utility.MonthlyPayment(p, y, r);
            Console.WriteLine("The monthly payment is : " + payment);
        }
    }
}
