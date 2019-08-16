using System;

namespace Pink
{
    class Program
    {
        static void Main(string[] args)
        {
            Task13b();
        }

        static void Example1()
        {
            Console.WriteLine("Hello Sassy Queens!!!");
        }

        /* Change World to your name and run the program */
        static void Task1()
        {
            Console.WriteLine("If you can read this i'm trapped in a computer... HELP! HELP!!!!");
        }

        /* Data types */
        static void Example2()
        {
            string name = "Cthuhlu, the great destroyer of worlds, master of all things";
            int age = 300000000;
            double height = 36.6;
            bool isAwesome = true;
            Console.WriteLine("Cower before me puny mortals, for I am " + name);
            Console.WriteLine("I was born before time, over " + age + " million years ago");
            Console.WriteLine("My height is " + height + " miles high");
            Console.WriteLine("You will be crushed, as the fates spoke so it is " + isAwesome);
        }

        /* Create 4 variables of different types and print them in a text */
        static void Task2()
        {
        }

        /* Variable declaration and assignment */
        static void Example3()
        {
            int number;
            string firstName;
            number = 2 + 3;
            firstName = "Antonina";
            int anotherNumber = -1;
            char ampersand = '&';
            number = 0;
            firstName = "Vanja";
            anotherNumber = number;

        }

        /* How many variables exist after execution of each line? Note their values at each line */
        static void Task3()
        {
            int number = 5; // number = 5
            number = 10; //number = 10
            double progress = 0.1; // number = 10, progress = 0.1
            progress = 0.5; // number = 10, progress = 0.5
            number = -8; // number = -8, progress = 0.5
            int otherNumber = 6; //  number = -8, progress = 0.5, otherNumber = 6
            number = otherNumber; //  number = 6, progress = 0.5, otherNumber = 6
        }

        /* Swap two variables using an extra variable */
        static void Task4()
        {
            int a = 1;
            int b = 2;
            Console.WriteLine(a + " " + b);

            // Swap variables
            int c = a; //a = 1, b = 2, c = 1
            a = b; //a = 2, b = 2, c = 1
            b = c; //a = 2, b = 1, c = 1

            Console.WriteLine(a + " " + b);
        }

        /* Reading user input */
        static void Example5()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);
            Console.WriteLine("Hello, {0}", name);
            Console.WriteLine($"Hello, {name}");

            Console.WriteLine("What is your favourite number?");
            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);
            Console.WriteLine($"{number * 2} is twice as much!");
        }

        /* Read two numbers and print their sum */
        static void Task5()
        {
            Console.WriteLine("Hey stranger, pick a number");
            string numberStr1 = Console.ReadLine();
            int number1 = int.Parse(numberStr1);
            Console.WriteLine("cool cool, now pick a second number");
            string numberStr2 = Console.ReadLine();
            int number2 = int.Parse(numberStr2);
            int numberPlus = number1 + number2;
            Console.WriteLine($"Add them together and what do you get? {numberPlus}!");
        }

        /* Operators
         * arithmetic: + - * / % += -= *= /= ++ --
         * logical: ! && ||
         * ternary: ? :
         */
        static void Example6()
        {
            string hello = "Hello" + " " + "world";
            int i = (5 + 20 - 7) / 3;
            i++;
            i--;
            i += 5;
            i -= 10;
            i *= 10;
            double d = (1.5 - 3) / 7;
            bool b = (i > 5 && i < 3) || (i + 1) * 2 == 3 || i % 2 == 0;
            string value = i == 6 ? "yes" : "no";
        }

        /* Write a program that counts seconds since the lesson started.
         * It should ask the user for number of hours, minutes and seconds and the print the total number of seconds */
        static void Task6()
        {
            Console.WriteLine("I'm bored. Let's count the seconds since we started learning C#. How many hours have we been at this?");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("How many minutes?");
            int minutes = int.Parse(Console.ReadLine());
            Console.WriteLine("How many seconds?");
            int seconds = int.Parse(Console.ReadLine());
            int totalSeconds = (hours * (60 * 60)) + (minutes * 60) + seconds;
            Console.WriteLine("So that's " + totalSeconds, "!");

        }

        /* Convert km/h speed to m/s */
        static void Task7()
        {
        }

        /* Ask the user 3 yes/no questions. Check if all the answers are correct and print "Success" or "Failure" */
        static void Task8()
        {
            Console.WriteLine("Lets play a game, answer yes or no. First question: Is the world flat?");
            bool answer1IsCorrect = Console.ReadLine() == "No";
            Console.WriteLine("Do vaccines cause autism?");
            bool answer2IsCorrect = Console.ReadLine() == "No";
            Console.WriteLine("Are men and women equally capable?");
            bool answer3IsCorrect = Console.ReadLine() == "Yes";
            Console.WriteLine((answer1IsCorrect && answer2IsCorrect && answer3IsCorrect) ? "Success" : "Failure");
        }

        /* If-statements */
        static void Example9()
        {
            Console.WriteLine("Write a number and I'll tell you the truth!");
            int number = int.Parse(Console.ReadLine());
            if (number > 5)
            {
                Console.WriteLine(number + " is larger than 5.");
            }
            else if (number < 5)
            {
                Console.WriteLine(number + " is smaller than 5.");
            }
            else
            {
                Console.WriteLine(number + " is equal to 5.");
            }
        }

        /* Ask the user for two numbers, a < b. Print which one is larger. Don't forget about the equals case! */
        static void Task9()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine($"{a} > {b}");
            }
            else if (a < b)
            {
                Console.WriteLine("a is smaller than b");
            }
            else
            {
                Console.WriteLine("a is equal to b");
            }
            Console.WriteLine(a > b ? $"{a} > {b}" : (a < b ? $"{a} < {b}" : $"{a} = {b}"));
        }

        /* while-loop */
        static void Example10()
        {
            int count = 0;
            while (count <= 10)
            {
                Console.WriteLine(count);
                count++;
            }
        }

        /* Print numbers 10 to 1 using a while-loop */
        static void Task10()
        {
            int countDown = 10;
            while (countDown >= 0)
            {
                Console.WriteLine(countDown);
                countDown--;
            }
        }

        /* for-loop */
        static void Example11()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        /* Ask the user how many times she wants to be motivated. Print "You're te best!" the given number of times. */
        static void Task11()
        {
            Console.WriteLine("How many times would you like to be motivated?");
            string motivate = (Console.ReadLine());
            int number = int.Parse(motivate);
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine("You go girl!");
            }
        }
        static void Task12()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 4; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        /* Print the following pattern using loops:
        
        *
        **
        ***   
        ****   
        *****   
        ****   
        ***   
        **     
        *       
        
        */



        /* Random */


        static void Example13()
        {
            Random random = new Random();
            int value = random.Next(2);
            Console.WriteLine("Take a guess: 0 or 1?");
            int guess = int.Parse(Console.ReadLine());
            Console.WriteLine(guess == value ? "You're lucky!" : "Better luck next time!");
        }

        /* Make the user guess a random number between 1 and 3 until she gets it right. */
        static void Task13()
        {
            Random randomNumber = new Random();
            int value = randomNumber.Next(3) + 1;
            Console.WriteLine("Take a guess: 1, 2 or 3?");
            int guess = int.Parse(Console.ReadLine());
            while (guess != value)
            {
                Console.WriteLine("That's not it, try again");
            }


        }

        static void Task13b()
        {
            Random random = new Random();
            int value = random.Next(0, 4);

            bool svar = true;

            do
            {
                Console.WriteLine("Take a guess on a number between 1-3?");
                int guess = int.Parse(Console.ReadLine());

                if (guess == value)
                {
                    Console.WriteLine("Congrats! U won!");
                    svar = false;
                }
                else
                {
                    Console.WriteLine("U picked the wrong number, try again");
                }
            } while (svar == true);

        }



    /* Use Math */
    static void Example14()
{
    Console.WriteLine($"Pi = {Math.PI}");
    Console.WriteLine($"Pi = {Math.Round(Math.PI)}");
    Console.WriteLine($"Pi = {Math.Round(Math.PI, 2)}");
    Console.WriteLine();
}

/* Write a program that calculates the area of a circle, given a radius that the user supplies.
 * Round the answerr to two decimals. */
static void Task14()
{
}

/* Write a program that calculates the diagonal of a TV given its width and height. */
static void Task15()
{
}

/* Use DateTime */
static void Example16()
{
    DateTime now = DateTime.Now;
    Console.WriteLine(now);
    DateTime today = DateTime.Today;
    Console.WriteLine(today);
    DateTime tomorrow = today.AddDays(1);
    Console.WriteLine(tomorrow);
    var timeTillTomorrow = tomorrow.Subtract(now);
    Console.WriteLine((int)timeTillTomorrow.TotalMinutes + " minutes till tomorrow");
}

/* Write a program that calculates the number of days till your next birthday. */
static void Task16()
{
}
}
}
