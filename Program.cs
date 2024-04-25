using System;

namespace AssignmentCSI_Conditions_Loops
/* 
Kady Tran
04/24/2024
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Menu();
        } // End of main

        public static void Problem1()
        {
            // To display problem name and task
            Console.WriteLine("Positive, Negative, or Zero");
            Console.WriteLine("Task: Write a program to take an integer input from the user. Determine if the number is positive, negative, or zero. Display the result.");

            // Prompting user for an input
            Console.Write("Please enter a whole number: ");
            int userWholeNumber = int.Parse(Console.ReadLine());

            // If statement to determine whether the number is positive, negative, or zero and displaying the appropriate message for each condition
            if (userWholeNumber == 0)
            {
                Console.WriteLine("Your whole number is a zero."); // Zero
            }
            else if (userWholeNumber < 1)
            {
                Console.WriteLine("Your whole number is a negative."); // Negative
            }
            else if (userWholeNumber >= 1)
            {
                Console.WriteLine("Your whole number is a positive."); // Positive
            }

        } // End of Problem1()

        public static void Problem2()
        {
            // To display problem name and task
            Console.WriteLine("Largest of Three ( using if / else if / else )");
            Console.WriteLine("Task: Write a program to take three different numbers as input. Determine the largest of the three numbers and display it");

            // Asking user input for 3 numbers
            Console.Write("Please enter the first whole number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Please enter the second whole number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Please enter the third whole number: ");
            int num3 = int.Parse(Console.ReadLine());

            // Using if / else if / else statement to determine which number is the largest out of the three and displays the appropriate message

            if (num1 > num2 && num1 > num3) // Checks to see if number 1 is greater than both number 2 and number 3
            {
                Console.WriteLine("The largest number is " + num1);
            }
            else if (num2 > num1 && num2 > num3) // Checks number 2 for whether it is greater than both number 1 and 3.
            {
                Console.WriteLine("The largest number is " + num2);
            }
            else // if the conditions are not met for any of the two statements above, this results in number 3 being the largest number.
            {
                Console.WriteLine("The largest number is " + num3);
            }

        } // End of problem2

        public static void Problem3()
        {
            // To display problem name and task
            Console.WriteLine("Check for a Vowel");
            Console.WriteLine("Write a program that takes an alphabet as input. Check whether the input is a vowel (a, e, i, o, u) or a consonant.");

            // Prompting user for an alphabet letter
            Console.Write("Enter an alphabet letter: ");
            string userLetter = Console.ReadLine();

            // Using if statement to check whether the input is a vowel or a consonant 
            // If user enters a capitalized letter, the "ToLower()" will convert it into a lowercase letter so we won't have to have repeating code
            // Just attached ".ToLower()" to the end of my userLetter string since I couldn't figure out how to use char.ToLower() without errors

            if (userLetter.ToLower() == "a" || userLetter.ToLower() == "e" || userLetter.ToLower() == "i" || userLetter.ToLower() == "o" || userLetter.ToLower() == "u")
            {
                Console.WriteLine("Vowel");
            }
            else // If the alphabet letter is anything besides a, e, i, o, u, then it'll be a consonant
            {
                Console.WriteLine("Consonant");
            }

        } // End of problem3

        public static void Problem4()
        {
            // To display problem name and task
            Console.WriteLine("Multiplication Table");
            Console.WriteLine("Task: Write a program to print the multiplication table of a given number up to 10. Ask the user for a number, then print out the related multiplication table.");

            // Creating a variable
            int userNum;
            // Prompting user for a number
            Console.Write("Please enter a number: ");
            userNum = int.Parse(Console.ReadLine());

            // Using for loop since we know how long the loop should execute for
            for (int i = 1; // declaring "i" to be our multiplier
                i <= 10; // starting off with the value 1 up until we reach 10
                i++) // it will increase by 1
            {
                Console.WriteLine(i * userNum); // Displaying the multiplication from * 1 up until * 10
            }

        } // End of problem4

        public static void Problem5()
        {
            // To display problem name and task
            Console.WriteLine("Check if a Number is Prime");
            Console.WriteLine("Write a program to determine if a given number is a prime number (a number only divisible by 1 and itself).");

            // Prompting user for a number
            Console.Write("Please enter a prime number: ");
            int userPrimeNum = int.Parse(Console.ReadLine());

            // Setting a boolean for the isPrime variable
            bool numberIsPrime = true;

            // I am setting it to true now because for my for statement, I will be setting it to false

            for (int i = 2; // declaring i with 2 because prime number has two factors
                    i <= Math.Sqrt(userPrimeNum); // square rooting the user's prime number to check to see if it's divisible
                    i++) // Incrementer

            {
                if (userPrimeNum % i == 0)
                {
                    numberIsPrime = false; // Setting this boolean to false because the number is divisible by i, which is 2, and that means it's not a prime number
                    break; // Exiting the loop (idk fully what this is but this is what I found in online resources), so it doesn't result me in having repeating outputs
                }// end of if statement
            }

            // Displaying whether the number is prime or not
            if (numberIsPrime)
            {
                Console.WriteLine(userPrimeNum + " is a prime number.");
            }
            else
            {
                Console.WriteLine(userPrimeNum + " is not a prime number.");
            }

    } // End of Problem5

        public static void Problem6()
        {
            // To display problem name
            Console.WriteLine("FizzBuzz");
            Console.WriteLine("Write a program that prints the numbers from 1 to 100. However:");
            Console.WriteLine("- For multiples of three, print FIZZ instead of the number.");
            Console.WriteLine("- For multiples of five, print BUZZ.");
            Console.WriteLine("- For numbers that are multiples of both three and five, print FIZZBUZZ.");

            // Setting int variables for multiples of three and five
            int multiplesOfThree = 3;
            int multiplesOfFive = 5;

            // Using for loop
            for (int i = 1; // starting the count at 1
                i <= 100; // stopping the count at 100
                i++) // counting the number by 1
            {
                if (i % multiplesOfThree == 0 && i % multiplesOfFive == 0) // Starting off th eif statement for numbers that are multiples of both three and five because I found out that when I put this last, it doesn't display at all in the console
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % multiplesOfThree == 0) // Multiples of three
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % multiplesOfFive == 0) // Multiples of five
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i); // Displaying the numbers
                }

            }


        } // End of problem6

        public static void Menu()
        {
            bool isRunning = true;

            do
            {// Start menu, what you see first
                Console.WriteLine("1 - Conditional Questions");
                Console.WriteLine("2 - Loop Questions");
                Console.WriteLine("3 - Exit");
                string userResponse = Console.ReadLine();

                // Conditional Questions
                if (userResponse == "1")
                {
                    // Create a menu structure that lets the user choose conditions or loops. Then a sub menu that lets the user choose which of the questions to try. ( This will use a next if / else structure ). This menu is designed to loop until the user wants to exit.

                    Console.WriteLine("1 - Positive, Negative, or Zero");
                    Console.WriteLine("2 - Largest of Three");
                    Console.WriteLine("3 - Check for a vowel");
                    Console.WriteLine("Press any other key to go back to the menu");
                    userResponse = Console.ReadLine(); // Notice reusing our userResponse variable

                    if (userResponse == "1")
                    {
                        Problem1();
                    }
                    else if (userResponse == "2")
                    {
                        Problem2();
                    }
                    else if (userResponse == "3")
                    {
                        Problem3();
                    }
                    else if (userResponse != "1" && userResponse != "2" && userResponse != "3") // This else if statement makes sure that whatever the user types, if it's not any of the 1-3, it'll send them back to the start menu
                    {
                        Menu();
                    }
                }
                // Loop Questions
                else if (userResponse == "2")
                {
                    Console.WriteLine("4 - Multiplication Table");
                    Console.WriteLine("5 - Check if a Number is Prime");
                    Console.WriteLine("6 - FizzBuzz");
                    Console.WriteLine("Press any other key to go back to the menu");
                    userResponse = Console.ReadLine(); // Notice reusing our userResponse variable
                    if (userResponse == "4")
                    {
                        Problem4();
                    }
                    else if (userResponse == "5")
                    {
                        Problem5();
                    }
                    else if (userResponse == "6")
                    {
                        Problem6();
                    }
                    else if (userResponse != "4" && userResponse != "5" && userResponse != "6") 
                    {
                        Menu();
                    }
                }
                // Exit
                else if (userResponse == "3")
                {
                    Console.WriteLine("Thank you and have a good day.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Please enter a valid option");
                }

            } while (isRunning);
            // Menu decision structure


        } // end of menu



    }// End of class
}// End of namespace
