using System;

namespace Assignment2
{
    public class Program
    {
        #region Hidden

        public static void Main(string[] args)
        {
            string number;
            do
            {
                Console.Write("Enter the number (1-7) for the question to run or 0 to exit: ");
                number = Console.ReadLine();
                ShowTitle(number);

                switch (number)
                {
                    case "1":
                        Question1();
                        break;
                    case "2":
                        Question2();
                        break;
                    case "3":
                        Question3();
                        break;
                    case "4":
                        Question4();
                        break;
                    case "5":
                        Question5();
                        break;
                    case "6":
                        Question6();
                        break;
                    case "7":
                        Question7();
                        break;
                }
            } while (number != "0");
        }

        public static void ShowTitle(string number)
        {
            Console.Clear();
            Console.WriteLine("Question {0}", number);
            Console.WriteLine("------------");
            Console.WriteLine();
        }
        
        #endregion

        /// <summary>
        /// Write code to prompt the user to enter their first name, middle initial
        /// and last name. Then read their input and display the user's name three 
        /// times using the following three formats:
        ///     first last
        ///     first middle last
        ///     last, first middle
        /// </summary>
        public static void Question1()
        {
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your middle name:");
            string middleName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine($"{firstName} {lastName}");
            Console.WriteLine($"{firstName} {middleName} {lastName}");
            Console.WriteLine($"{lastName}, {firstName} {middleName}");
        }

        /// <summary>
        /// Write code to prompt the user for two integers. Then read their input and
        /// display the sum and the difference of the two integers.
        /// </summary>
        public static void Question2()
        {
            Console.WriteLine("Enter first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sum = {(firstNumber + secondNumber)}");
            Console.WriteLine($"Difference = {(firstNumber - secondNumber)}");
        }

        /// <summary>
        /// Write code to calculate the area of a circle. The user will enter the radius
        /// of the circle and the program will calculate and display the area. 
        /// You must accept decimal places as input.
        /// Formula: area = 3.14 * radius * radius
        /// </summary>
        public static void Question3()
        {
            Console.WriteLine("Enter radius:");
            decimal radius = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Area of circle = {(Convert.ToDecimal(3.14) * radius * radius)}");
        }

        /// <summary>
        /// Write code to prompt the user to enter a single character. Then read their 
        /// input and display the following message: You entered <char>
        /// For this question, you must use a variable of type char.
        /// </summary>
        public static void Question4()
        {
            Console.WriteLine("Enter Char: ");
            char message = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"You entered {message}");
        }

        /// <summary>
        /// Write code to ask the user a simple true or false question and then read
        /// their answer. The code should then display the message: Your answer was <bool>
        /// For this question, you must use a variable of type boolean.
        /// </summary>
        public static void Question5()
        {
            Console.WriteLine("Is water blue? \n Answer true or false:");
            bool boolean = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"Your answer was {boolean}");
        }

        /// <summary>
        /// Write code to prompt the user to enter how many siblings they have.
        /// Then read their input and display a message saying: I also have <int> siblings
        /// </summary>
        public static void Question6()
        {
            Console.WriteLine("How many siblings do you have?");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"I also have {firstNumber} siblings");
        }

        /// <summary>
        /// Adult tickets cost $3.75 and child tickets cost $2.25. Write code to prompt 
        /// the user for the number of adult tickets and the number of child tickets 
        /// that they want. Then display the total cost.
        /// </summary>
        public static void Question7()
        {
            Console.WriteLine("How many tickets for adults do you need?");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many tickets for children do you need?:");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Total will be {(firstNumber*3.75 + secondNumber*2.25)} $");
        }
    }
}