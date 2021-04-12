using System;

namespace Input_Validation_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1
            Payroll_Program_with_Input_Validation();

            //#2
            Theater_Seating_Revenue_with_Input_Validation();

            //#3
            Fat_Gram_Calculator();

            //#4
            Speeding_Violation_Calculator();

            //#5
            Rock_Paper_Scissors();

        }//End of Main
        static string Prompt(string text)
        {
            Console.Write(text + " ");
            return Console.ReadLine();
        }//End of Prompt Int
        static int PromptInt(string text)
        {
            Console.Write(text + " ");
            return int.Parse(Console.ReadLine());
        }//End of Prompt Int
        static double PromptDouble(string text)
        {
            Console.Write(text + " ");
            return double.Parse(Console.ReadLine());
        }//End of Prompt Double
        static void Payroll_Program_with_Input_Validation()
        {
            double payRate = 0.0;
            double hoursWorked = 0.0;
            double grossPay = 0.0;

            Console.WriteLine("PayRoll Program with Input Validation");

            do
            {
                payRate = PromptDouble($"Please enter hourly rate: \t $");
                if (payRate < 7.50 || payRate > 18.25)
                    Console.WriteLine("Please, enter a valid hourly rate that is between $7.50 and $18.25.");
            } while (payRate < 7.50 || payRate > 18.25);

            do
            {
                hoursWorked = PromptDouble($"Please enter hours worked: \t");
                if (hoursWorked < 0)
                    Console.WriteLine("You cannot enter a negative number of hours worked.");
                if (hoursWorked > 40)
                    Console.WriteLine("You cannot have worked over 40 hours this week.");
            } while (hoursWorked < 0 || hoursWorked > 40);

            grossPay = payRate * hoursWorked;
            Console.WriteLine($"\nYour gross pay is ${grossPay:N}.");
        }
        static void Theater_Seating_Revenue_with_Input_Validation()
        {
            Console.WriteLine("\nTheater Seating Revenue with Input Validation");

            int seatsA = 0, seatsB = 0, seatsC = 0;
            int totalA = 20, totalB = 15, totalC = 10;
            int finalTotal;

            do
            {
                seatsA = PromptInt($"How many seats were sold for Section A? \t ");
                if (seatsA > 300)
                {
                    Console.WriteLine("There are only 300 seats in Section A. Please, enter in a lower number.");
                    seatsA = int.Parse(Console.ReadLine());
                }

                totalA = totalA * seatsA;

                seatsB = PromptInt($"How many seats were sold for Section B? \t ");
                if (seatsB > 500)
                {
                    Console.WriteLine("There are only 500 seats in Section B. Please, enter in a lower number.");
                    seatsB = int.Parse(Console.ReadLine());
                }

                totalB = totalB * seatsB;

                seatsC = PromptInt($"How many seats were sold for Section C? \t ");
                if (seatsC > 200)
                {
                    Console.WriteLine("There are only 200 seats in Section A. Please, enter in a lower number.");
                    seatsC = int.Parse(Console.ReadLine());
                }

                totalC = totalC * seatsC;

                //Total cost altogether
                finalTotal = totalC + totalB + totalA;

                Console.WriteLine($"\nThe income genrated from ticket sales is ${finalTotal:N}.");
            } while (seatsA > 300 || seatsB > 500 || seatsC > 200);
        }
        static void Fat_Gram_Calculator()
        {
            Console.WriteLine("\nFat Gram Calculator");

            double fatGrams = 0.0, calories = 0.0, percentageOfCalories = 0.0;

            do
            {
                fatGrams = PromptDouble("Enter in a number for fat grams: ");
                if(fatGrams < 0)
                {
                    Console.WriteLine("ERROR! Please enter a positive number for fat grams: ");
                    fatGrams = double.Parse(Console.ReadLine());
                }

                calories = PromptDouble("Enter in a number for calories: ");
                if(calories < 0)
                {
                    Console.WriteLine("ERROR! Please enter a positive number for calories: ");
                    calories = double.Parse(Console.ReadLine());
                }
            } while (fatGrams < 0 || calories < 0);

            while(calories > (fatGrams = fatGrams * 9))
            {
                Console.WriteLine($"\nError! {calories} Calories cannot be greater than {fatGrams} fat grams.");
                calories = PromptDouble("Please, re-enter the amount of calories.");
            }

            percentageOfCalories = (fatGrams) / calories;

            Console.WriteLine($"\nThere is {percentageOfCalories:N}% of calories that comes from fat.");

            if(percentageOfCalories < 30)
            {
                Console.WriteLine("This food is low in fat.");
            }

        }
        static void Speeding_Violation_Calculator()
        {
            Console.WriteLine("\nSpeeding Violation Calculator");

            int speedLimit = 0, driverSpeed = 0;

            do
            {
                speedLimit = PromptInt($"Speed Limit: \t ");
                while(speedLimit < 20)
                {
                    speedLimit = PromptInt($"Error! There is no speed limit that is less than 20." +
                        "Enter in a new speed limit: \t ");
                }
                
                while(speedLimit > 70)
                {
                    speedLimit = PromptInt($"Error! There is no speed limit that over 70." +
                        "Enter in a new speed limit: \t ");
                }
            } while (speedLimit < 20 || speedLimit > 70);

            do
            {
                driverSpeed = PromptInt($"Driver's Speed: \t ");
                while (driverSpeed < speedLimit)
                {
                    driverSpeed = PromptInt($"Enter in a higher number for the driver's speed: \t");
                }
            } while (driverSpeed < speedLimit);

            driverSpeed = driverSpeed - speedLimit;

            Console.WriteLine($"\nThe driver was going {driverSpeed} mph over the speed limit.");
        }
        static void Rock_Paper_Scissors()
        {
            int rock = 1, paper = 2, scissors = 3;
            string inputChoice = ""; //user's word choice
            int inputChoiceNumber; //user's number choice

            Console.WriteLine("Welcome to Rock, Paper, Scissors Game~!");

            do
            {
                int computer = 0;
                Random numberChoice = new Random(); //Makes Random Number
                computer = numberChoice.Next(1, 4); //Assigns random number

                inputChoice = Prompt("Do you want to enter in Rock, Paper, or Scissors?").ToLower();

                while (inputChoice != "rock" || inputChoice != "paper" || inputChoice != "scissors") {
                    inputChoice = Prompt("Error! Please enter in 'scissors', 'paper', or 'rock'.").ToLower();
                }//End of if statement

                if (inputChoice == "rock")
                {
                    inputChoiceNumber = 1;

                    if (computer == 2)
                    {
                        Console.WriteLine("You lose. The computer chose paper.");
                    }
                    else if (computer == 3)
                    {
                        Console.WriteLine("You win~! The computer chose scissors.");
                    }
                    else if (inputChoiceNumber == computer)
                    {
                        Console.WriteLine($"You and the computer chose {inputChoice}. Play the game again.");
                    }

                }
                else if (inputChoice == "paper")
                {
                    inputChoiceNumber = 2;

                    if (computer == 1)
                    {
                        Console.WriteLine("You win~! The computer chose rock.");
                    }
                    else if (computer == 3)
                    {
                        Console.WriteLine("You lose. The computer chose scissors.");
                    }
                    else if (computer == inputChoiceNumber)
                    {
                        Console.WriteLine($"You and the computer chose {inputChoice}. Play the game again.");
                    }

                }
                else if (inputChoice.ToLower() == "scissors")
                {
                    inputChoiceNumber = 3;

                    if (computer == 1)
                    {
                        Console.WriteLine("You lose. The computer chose rock.");
                    }
                    else if (computer == 2)
                    {
                        Console.WriteLine("You win~! The computer chose paper.");
                    }
                    else if (inputChoiceNumber == computer)
                    {
                        Console.WriteLine($"You and the computer chose {inputChoice}. Play the game again.");
                    }
                }

                Console.WriteLine("-----------------");
            } while (inputChoice != " ");
        }
    }
}
