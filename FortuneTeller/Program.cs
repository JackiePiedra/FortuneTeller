using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------Part 1 
            //Asking user for information (first name, last name, age, birth month(int), favorite color, #siblings)
            //Set variables for each input from user
            //ROYGBIV - ask them to enter HELP if they need the colors listed, CW the list of colors and repeat question
            Console.WriteLine("Welcome to Fortune Teller! Let's start with some questions. \n\nWhat is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("Now, please enter your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter your age:");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Now, please enter your month of birth as a number \n(January is 1, February is 2, and so on):");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorite ROYGBIV color? \n(Hint: If you don't know the ROYGBIV colors, type 'Help' for a list)");
            string colorInput = Console.ReadLine().ToLower();
            string helpRequest = "help"; //ignorecase -- try to rewrite using this
            if (colorInput == helpRequest)
            {
                Console.WriteLine("R is red \nO is orange \nY is yellow \nG is green \nB is blue \nI is indigo \nV is violet \n\nWhich of these is your favorite color?");
                colorInput = Console.ReadLine().ToLower();
            }
            //else
            //{
            //    string faveColor = colorInput;
            //}
            Console.WriteLine("Finally... how many siblings do you have?");
            int numSiblings = int.Parse(Console.ReadLine());

            //-----------Part 2
            //Age - use modulus to determine whether even/odd
            if (userAge % 2 == 0)
            {
                bool ageEven = true;
            }
            else
            {
                bool ageEven = false;
            }
            //Siblings - use switch case for each scenario
            string vacHome;
            if (numSiblings == 0)
            {
                vacHome = "Mykonos";
            }
            else if (numSiblings == 1)
            {
                vacHome = "Maui";
            }
            else if (numSiblings == 2)
            {
                vacHome = "Milan";
            }
            else if (numSiblings == 3)
            {
                vacHome = "the Maldives";
            }
            else
            {
                vacHome = "Detroit";
            }
            Console.WriteLine(vacHome);

            //ROYGBIV - set the variables to each of the colors in lowercase, use ToLower() to convert input to lowercase
            string modeTransport;
            if(colorInput == "red")
            {

            }

            string orange = "orange";
            string yellow = "yellow";
            string green = "green";
            string blue = "blue";
            string indigo = "indigo";
            string violet = "violet";

            //Birth month - use if/else if/else to set ranges

            //-----------Part 3
            //Return a statement with the fortune - CW with each of the variables and strings connecting the statement
        }
    }
}


