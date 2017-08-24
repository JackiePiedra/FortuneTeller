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

            Console.WriteLine("Welcome to Fortune Teller! Let's start by asking you some questions..");
            Console.WriteLine("\n\n**IMPORTANT**");
            Console.WriteLine("If you don't want to hear your fortune, answer any of the questions with QUIT");
            Console.WriteLine("\n\nWhat is your first name?");

            string firstName = Console.ReadLine();
            string quitNow = "quit";    //Quit option at each point of user input
            bool quitOption = firstName.Equals(quitNow, StringComparison.CurrentCultureIgnoreCase);
            if(quitOption == true)
            {
                Console.WriteLine("\n\n\t\t\tNobody likes a quitter....\n\n\n");
                Environment.Exit(0);
            }


            Console.WriteLine("\nExcellent! Now, what is your last name?");
            string lastName = Console.ReadLine();

            //Quit option at each point of user input
            quitOption = lastName.Equals(quitNow, StringComparison.CurrentCultureIgnoreCase);
            if (quitOption == true)
            {
                Console.WriteLine("\n\n\t\t\tNobody likes a quitter....\n\n\n");
                Environment.Exit(0);
            }

            Console.WriteLine("\nWhat is your age? Shhh... we won't tell..");
            string userAgeString = Console.ReadLine();

            //Quit option at each point of user input
            quitOption = userAgeString.Equals(quitNow, StringComparison.CurrentCultureIgnoreCase);
            if (quitOption == true)
            {
                Console.WriteLine("\n\n\t\t\tNobody likes a quitter....\n\n\n");
                Environment.Exit(0);
            }
            int userAge = int.Parse(userAgeString); //setting to integer if they are not quitting
            
            Console.WriteLine("\nWhat is your birth month, entered as a number?");
            Console.WriteLine("For example, January is 1, February is 2, and so on..");
            string birthMonthString = Console.ReadLine();

            //Quit option at each point of user input
            quitOption = birthMonthString.Equals(quitNow, StringComparison.CurrentCultureIgnoreCase);
            if (quitOption == true)
            {
                Console.WriteLine("\n\n\t\t\tNobody likes a quitter....\n\n\n");
                Environment.Exit(0);
            }
            int birthMonth = int.Parse(birthMonthString); //setting to integer if they are not quitting
            

            Console.WriteLine("\nWhat is your favorite ROYGBIV color? \n(Hint: If you don't know the ROYGBIV colors, type 'Help' for a list)");
            string colorInput = Console.ReadLine().ToLower();
            string helpRequest = "help"; //ignorecase -- try to rewrite using this

            //Quit option at each point of user input
            quitOption = colorInput.Equals(quitNow, StringComparison.CurrentCultureIgnoreCase);
            if (quitOption == true)
            {
                Console.WriteLine("\n\n\t\t\tNobody likes a quitter....\n\n\n");
                Environment.Exit(0);
            }

            if (colorInput == helpRequest)
            {
                Console.WriteLine("\nR is red \nO is orange \nY is yellow \nG is green \nB is blue \nI is indigo \nV is violet \n\nWhich of these is your favorite color?");
                colorInput = Console.ReadLine().ToLower();
            }

            //Quit option at each point of user input
            quitOption = colorInput.Equals(quitNow, StringComparison.CurrentCultureIgnoreCase);
            if (quitOption == true)
            {
                Console.WriteLine("\n\n\t\t\tNobody likes a quitter....\n\n\n");
                Environment.Exit(0);
            }

            
            Console.WriteLine("\nAnd finally... how many siblings do you have?");
            string numSiblingsString = Console.ReadLine();

            //Quit option at each point of user input
            quitOption = numSiblingsString.Equals(quitNow, StringComparison.CurrentCultureIgnoreCase);
            if (quitOption == true)
            {
                Console.WriteLine("\n\n\t\t\tNobody likes a quitter....\n\n\n");
                Environment.Exit(0);
            }
            int numSiblings = int.Parse(numSiblingsString); //setting this to integer if they are not quitting

            //-----------Part 2
            //Age - use modulus to determine whether even/odd
            int yearsToRetire;
            if (userAge % 2 == 0)
            {
                yearsToRetire = 5;
            }
            else
            {
                yearsToRetire = 20;
            }
            
            //Siblings - used if/else initially but switched over to switch case
            string vacHome;

            /*if (numSiblings == 0)
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
            } */

            switch (numSiblings) //using switch case instead
            {
                case 0:
                    vacHome = "Mykonos";
                    break;
                case 1:
                    vacHome = "Maui";
                    break;
                case 2:
                    vacHome = "Milan";
                    break;
                case 3:
                    vacHome = "The Maldives";
                    break;
                default:
                    vacHome = "Detroit";
                    break;
            }                   

            //ROYGBIV - set the variables to each of the colors in lowercase, use ToLower() to convert input to lowercase
            string modeTransport;
            if (colorInput == "red")
            {
                modeTransport = "Ferrari";
            }
            else if (colorInput == "orange")
            {
                modeTransport = "Porsche";
            }
            else if (colorInput == "yellow")
            {
                modeTransport = "Lamborghini";
            }
            else if (colorInput == "green")
            {
                modeTransport = "Bugatti";
            }
            else if (colorInput == "blue")
            {
                modeTransport = "Bentley";
            }
            else if (colorInput == "indigo")
            {
                modeTransport = "Rolls Royce";
            }
            else //if (colorInput == "violet")
            {
                modeTransport = "Mercedes Benz";
            }
            
            //Birth month - use if/else if/else to set ranges
            string bankAccount;
            if (birthMonth >= 1 && birthMonth <= 4)
            {
                bankAccount = "$1,000,000";
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                bankAccount = "$100";
            }
            else
            {
                bankAccount = "$24,000,000";
            }

            //-----------Part 3
            //Return a statement with the fortune - CW with each of the variables and strings connecting the statement
            Console.WriteLine("\n\n\nFortune Teller says...");
            
            Console.WriteLine("\n\t" + firstName + " " + lastName + " will retire in " + yearsToRetire + " years");
            Console.WriteLine("\twith " + bankAccount + " in the bank, \n\ta vacation home in " + vacHome + ",");
            Console.WriteLine("\tand a " +modeTransport + ".\n\n");
            
            //program needs to handle whether user inputs upper or lower case letters

            //----------Stretch
            //Give user ability to quit program at any time by entering QUIT at any point of data entry
            //Program will print "Nobody likes a quitter..." before ending
        }
    }
}


