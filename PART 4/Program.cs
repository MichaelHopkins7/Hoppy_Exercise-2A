using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PART_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCount;
            string input;
            double sumTotal;
            do
            {
                Console.WriteLine($"Please enter test score(s) to be averaged.");
                Console.WriteLine("Enter \"Average\" to get the average grade.\n"); //tells how to get the average
                inputCount = 0; //resets count of numbers input
                sumTotal = 0; //resets sum of numbers input
                input = Console.ReadLine();
                
                do
                {
                    try //(using this to deal with non-number inputs
                    {
                        if ((input != "") && (input != "Average"))
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

                                Console.WriteLine("Please enter another test score."); //ask for another number
                                input = Console.ReadLine();
                            }
                        }
                        else if (input == "Average") // if user inputs "Average" takes average
                        {
                            string grade;
                            double testAverage = sumTotal / inputCount;
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
                            Console.WriteLine($"The average is {testAverage} for a grade of {grade}.\n");
                            input = ""; //to go the ask to quit or begin again
                        }
                        else
                        {
                            Console.WriteLine("If you wish to exit or begin again, press \"Enter\".");
                            Console.WriteLine("Otherwise please enter a test score.");
                            input = Console.ReadLine();
                        }
                    }
                    catch (FormatException) //tells the user to only input numbers when entry can't be parsed
                    {
                        Console.WriteLine("Please input numbers only!");
                        Console.WriteLine($"Please enter another test score or enter \"Average\" to get the average grade."); //ask for another number
                        Console.WriteLine("Press \"Enter\" to quit.");
                        input = Console.ReadLine();
                    }
                }
                while (input != "");
                Console.WriteLine("If you would like to quit press \"Enter\".");
                Console.WriteLine("Otherwise enter any character and press \"Enter\".");
                input = Console.ReadLine();
            }
            while (input != "");
        }
    }
}
