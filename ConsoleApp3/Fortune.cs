using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define variables

            string firstName;
            string lastName;
            int age;
            int birthMonth;
            string favColor;
            int siblings;
            int retireYears;
            string helpText = "Select a favorite color from the following: Red, Orange, Yellow, Green, Blue, Indigo or Violet.";

            // Start UI
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of the month in which you were born.");
            birthMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your favorite color? (Select from the ROYGBIV colors, or enter Help for a list of the colors.)");
            favColor = Console.ReadLine();
            if (favColor == "Help")
                {
                    Console.WriteLine("Select your favorite color from the following: Red, Orange, Yellow, Green, Blue, Indigo or Violet.");
                    favColor = Console.ReadLine();
                }
            else if (favColor == "Red")
                {
                favColor = "Red";
                }
            else if (favColor == "Orange")
            {
                favColor = "Orange";
            }
            else if (favColor == "Yellow")
            {
                favColor = "Yellow";
            }
            else if (favColor == "Green")
            {
                favColor = "Green";
            }
            else if (favColor == "Blue")
            {
                favColor = "Blue";
            }
            else if (favColor == "Indigo")
            {
                favColor = "Indigo";
            }
            else if (favColor == "Violet")
            {
                favColor = "Violet";
            }
            Console.WriteLine("How many siblings do you have?");
            siblings = Convert.ToInt32(Console.ReadLine());

            // APPLICATION LOGIC

            // Determine odd or even year and calculate years until retirement.
            var oddCheck = age % 2;
            if (oddCheck == 0)
            {
                retireYears = 10;
            }
            else
            {
                retireYears = 9;
            }

            // Determine vacation home based on number of siblings
            var vacationHome = "Youngstown";
            if (siblings == 1)
            {
                vacationHome = "Ohio City";
            }
            else if (siblings == 2)
            {
                vacationHome = "the Gold Coast of Lakewood, Ohio";
            }
            else if (siblings == 3)
            {
                vacationHome = "the penthouse of Terminal Tower";
            }
            else if (siblings >= 4)
            {
                vacationHome = "Milan";
            }

            // Determine mode of transportation based on ROYGBIV color selection.
            var transpo = "bus pass";
            if (favColor == "Red")
            {
                transpo = "bus pass";
            }
            else if (favColor == "Orange")
            {
                transpo = "Hyperloop";
            }
            else if (favColor == "Yellow")
            {
                transpo = "Impala";
            }
            else if (favColor == "Green")
            {
                transpo = "rickshaw";
            }
            else if (favColor == "Blue")
            {
                transpo = "unicycle";
            }
            else if (favColor == "Indigo")
            {
                transpo = "esclator";
            }
            else if (favColor == "Violet")
            {
                transpo = "Yugo";
            }

            // Determine money based on birth month

            decimal moneyvalue = 0.00m;

            if (birthMonth < 0)
            {
                moneyvalue = 0.00m;
            }
            else if (birthMonth > 12)
            {
                moneyvalue = 0.00m;
            }
            else if (birthMonth <= 4)
            {
                moneyvalue = 100.00m;
            }
            else if (birthMonth <= 8)
            {
                moneyvalue = 500.00m;
            }
            else if (birthMonth <= 12)
            {
                moneyvalue = 800.00m;
            }

            // Concatenated output

            Console.WriteLine(firstName + " " + lastName + " will retire in " + retireYears + " years with $" + moneyvalue + " in the bank, a vacation home in " + vacationHome + ", and a " + transpo + ".");
            
        }
    }
}
