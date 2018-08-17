using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int inputCount;
            double sumTotal;
            int numberOfVar;
            bool tryAgain;
            do// Setting up to repeat request for numbers to be entered once ten numbers have been given
            {
                
                do
                {
                    input = "a"; //set input initially to trigger
                    Console.WriteLine("Please enter the number of scores.");
                    input = Console.ReadLine();
                    tryAgain = false;
                    numberOfVar = 0;
                    try
                    {
                        if (input != "")
                        {
                            numberOfVar = int.Parse(input);
                            tryAgain = false;
                            input = "";
                        }
                        
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter integers only.");
                        tryAgain = true;
                    }
                }
                while (tryAgain || (input != ""));
                if (numberOfVar != 0)
                {
                    Console.WriteLine($"Please enter {numberOfVar} test score(s) to be averaged.\n");
                    inputCount = 0; //resets count of numbers input
                    sumTotal = 0; //resets sum of numbers input
                    input = Console.ReadLine();

                    
                       
                    do
                    {
                        try //(using this to deal with non-number inputs
                        {
                            if (input != "")
                            {
                                var numIn = double.Parse(input); //Tries to parse the input into a double input

                                if ((numIn < 0) || (numIn > 100))
                                {
                                    Console.WriteLine("Please enter a score from 0 to 100.");
                                    Console.WriteLine("Please enter another test score.");
                                    input = Console.ReadLine();
                                }
                                else
                                {
                                    sumTotal = sumTotal + numIn; //adds number entered to the total of the numbers
                                    inputCount = ++inputCount; //increases the count of how many numbers have been entered
                                    if (inputCount < numberOfVar) // checks how many numbers have been entered since the start
                                    {
                                        Console.WriteLine("Please enter another test score."); //ask for another number
                                        input = Console.ReadLine();
                                    }
                                    if (inputCount == numberOfVar) // if we have ten numbers then we need to show the total
                                    {
                                        string grade;
                                        double testAverage = sumTotal / numberOfVar;
                                        if (testAverage >= 90)
                                        {
                                            grade = "A";
                                        }
                                        else if ((testAverage >= 80) && (testAverage < 90))
                                        {
                                            grade = "B";
                                        }
                                        else if ((testAverage >= 70) && (testAverage < 80))
                                        {
                                            grade = "C";
                                        }
                                        else if ((testAverage >= 60) && (testAverage < 70))
                                        {
                                            grade = "D";
                                        }
                                        else
                                        {
                                            grade = "F";
                                        }
                                        Console.WriteLine($"The average is {testAverage} for a grade of {grade}.");

                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("If you wish to exit or begin again, press \"Enter\".");
                                Console.WriteLine("Otherwise please enter a test score.");
                                input = Console.ReadLine();
                                if (input == "")
                                {
                                    inputCount = numberOfVar;
                                }
                            }
                        }
                        catch (FormatException) //tells the user to only input numbers when entry can't be parsed
                        {
                        Console.WriteLine("Please input numbers only!");
                        Console.WriteLine("Please enter another test score."); //ask for another number
                        input = Console.ReadLine();
                        }
                    }
                     while (inputCount != numberOfVar);
                        
                }
                Console.WriteLine($"If you are finished press \"Enter\", otherwise press any character then \"Enter\".");
                input = Console.ReadLine();
            }
            while (input != "");
        }
    }
}
