//-----------------------------------------------------------------------
// <copyright file="DayOfWeek.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ProgramsForJUnitTesting
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// Finds the day of the entered date for ex : if you entered 9/12/2005 it returns the day of that date as monday
    /// </summary>
    public class DayOfWeek
    {
        /// <summary>
        /// Finds the day of the entered date.
        /// </summary>
        public void FindDay()
        {
            Utility utility = new Utility();
            int month, year, date;
            string[] da = { "sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            Console.WriteLine("Enter Date");
            date = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Year");
            year = Convert.ToInt32(Console.ReadLine());
            int d = utility.DayOfWeek(month, date, year);
            Console.WriteLine("Entered date is " + date + "/" + month + "/" + year);
            Console.WriteLine("The day of week is " + da[d]);
        }
    }
}
