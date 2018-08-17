﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoppy_2A_PART2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int inputCount;
            double sumTotal;
            do
            {
                input = ""; //clears input initially
                // Setting up to repeat request for numbers to be entered once ten numbers have been given
                Console.WriteLine("Please enter ten test scores to be averaged.\n");
                inputCount = 0; //resets count of numbers input
                sumTotal = 0; //resets sum of numbers input
                input = Console.ReadLine();

                if (input != "")
                {
                    try //(using this to deal with non-number inputs
                    {
                        do
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
                                if (inputCount < 10) // checks how many numbers have been entered since the start
                                {
                                    Console.WriteLine("Please enter another test score."); //ask for another number
                                    input = Console.ReadLine();
                                }
                                if (inputCount == 10) // if we have ten numbers then we need to show the total
                                {
                                    string grade;
                                    double testAverage = sumTotal / 10;
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
                        while (inputCount != 10);
                    }
                    catch (FormatException) //tells the user to only input numbers when entry can't be parsed
                    {
                        Console.WriteLine("Please input numbers only!");
                    }
                }
            }
            while (input != "");
        }
    }
}
