using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace COMP100.A4
{
    class Program
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
        /// Write code to produce a table of numbers from 10 to 1, with their squares and cubes. 
        /// You must use a loop and your table must look professional.
        /// </summary>
        private static void Question1()
        {
            for (int runs = 10; runs > 0; runs--)
            {
                Console.WriteLine($" {runs,5} {runs*runs, 5} {runs*runs*runs, 5}");
            }
        }

        /// <summary>
        /// Write code that displays a conversion table from Fahrenheit to Celsius. It must request
        /// the starting Fahrenheit value, the ending Fahrenheit value, and the increment. 
        /// Thus, instead of the condition checking for a fixed count, the condition checks for 
        /// the ending Fahrenheit value. 
        /// You must use a loop and your table must look professional.
        /// </summary>
        private static void Question2()
        {
            Console.Write("Enter the starting Farenheit value: ");
            double starting = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the ending Farenheit value: ");
            double ending = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the increment of the Farenheit value: ");
            double increment = Convert.ToDouble(Console.ReadLine());
            string a = "\u00B0";
            Console.WriteLine($"     {a}F            {a}C");
            for (; starting<ending; starting += increment)
            {
                double celsius = (starting - 32) * 5 / 9;
                Console.WriteLine($"{starting,7}{$"{celsius:0.0}",15}");
            }
        }

        /// <summary>
        /// Write code that calculates and displays the amount of money available in a 
        /// bank account that initially has $1,000 deposited in it and that earns 8 percent 
        /// interest a year. It should display the amount available at the end of each year 
        /// for a period of ten years. Use the relationship that the money available at the
        /// end of each year equals the amount of money in the account at the start of the
        /// year plus .08 times the amount available at the start of the year.
        /// 
        /// Your output should be formatted as shown below:
        /// 
        /// Year Balance
        ///  1   $1,080.00
        ///  2   $1,166.40
        ///  3   $1,259.71
        ///  4   $1,360.49
        ///  5   $1,469.33
        ///  6   $1,586.87
        ///  7   $1,713.82
        ///  8   $1,850.93
        ///  9   $1,999.00
        /// 10   $2,158.92
        /// 
        /// </summary>
        private static void Question3()
        {
            double cash = 1000;
            Console.WriteLine(" Year Balance");
            for (int i = 1; i <= 10; i++)
            {
                cash *= 1.08;
                Console.WriteLine($"{i, 3}   {cash:c}");
            }
        }

        /// <summary>
        /// Write code that continuously requests a grade. If the grade is less than 0 or 
        /// greater than 100, your program should print an appropriate message informing the 
        /// user that an invalid grade has been entered, else the grade should be added to a 
        /// total. If the grade is 999, the program should exit the loop and display the sum, 
        /// number of valid grades and the average of the valid grades entered. (You must NOT 
        /// display an invalid message) 
        /// P.S. The value 999 is use to terminate the cycle and should not be used in any of 
        /// the calculation. You must not display an “Invalid grade”
        /// </summary>
        private static void Question4()
        {
            int sum = 0;
            while (sum<999)
            {
                Console.Write("Grade = ");
                int grade = Convert.ToInt32(Console.ReadLine());
                if (grade>100 || grade < 0)
                {
                    Console.WriteLine("Invalid! Wrong input! Enter number from 0 to 100");
                }
                else
                {
                    sum += grade;
                }
            }
            Console.WriteLine($"Summary grade = {sum}");
        }

        /// <summary>
        /// Print the decimal, octal, and hexadecimal values of all characters between the 
        /// start and stop characters entered by a user. For example, if the user enters an 
        /// a and a z, the program should print all the characters between a and z and their 
        /// respective numerical values. Make sure that the second character entered by the 
        /// user occurs later in the alphabet than the first character. If it does not, write 
        /// a loop that repeatedly asks the user for a valid second character until one is 
        /// entered.
        /// 
        /// Your output should be formatted as shown below:
        /// 
        /// Letter   Decimal   Octal   Hex
        ///      a	      97     141	61
	    ///      b	      98     142    62
	    ///      c        99     143	63
	    ///      d       100     144	64
	    ///      e	     101     145	65
        ///
        /// </summary>
        private static void Question5()
        {
            Console.Write("Enter first letter: ");
            int firstChar = Convert.ToInt32(Convert.ToChar(Console.ReadLine()));
            Console.Write("Enter second letter: ");
            int secondChar = Convert.ToInt32(Convert.ToChar(Console.ReadLine()));
            Console.WriteLine("Letter  Decimal  Octal  Hex");
            for (; firstChar < secondChar; firstChar++)
                Console.WriteLine($"{Convert.ToChar(firstChar),6} {firstChar,8} {Convert.ToString(firstChar, 8),6} {Convert.ToString(firstChar, 16),4}");
        }

        /// <summary>
        /// Write code to compute the (x, y) pairs for the equation below for x in the 
        /// range 1 to 5 in 0.5 increments.
        /// 
        /// Equation: y = 2x² - x - 6 
        /// 
        /// Your output should be formatted as shown below:
        /// 
        /// x	  2x²   -x	   -6    y
        /// 1.0	  2.0	-1.0   -6   -5.0
        /// 1.5	  4.5	-1.5   -6	-3.0
        /// 2.0	  8.0	-2.0   -6	 0.0
        /// 2.5	 12.5	-2.5   -6	 4.0
        ///
        /// </summary>
        private static void Question6()
        {
            Console.WriteLine($"x     2x{Convert.ToChar(178)}    -x     -6    y");
            for (double x = 1.0; x <= 5.0; x += 0.5)
            {
           
                Console.WriteLine($"{string.Format("{0:0.0}", x)}{string.Format("{0:0.0}", 2 * x * x), 6}{string.Format("{0:0.0}", -x),8}{-6,5}{string.Format("{0:0.0}", 2 * x * x - x - 6),7}");
            }
        }

        /// <summary>
        /// Write code to reverse the digits of a positive integer number. For example, if 
        /// the number 8735 is entered, the number displayed should be 5378. (Hint: Use a do 
        /// statement and continuously strip off and display the units digit of the number. 
        /// If the variable num initially contains the number entered, the units digit is 
        /// obtained as (num % 10). After a units digit is displayed, dividing the number 
        /// by 10 sets up the number for the next iteration. Thus, (8735 % 10) is 5 and 
        /// (8735 / 10) is 873. The do statement should continue as long as the remaining 
        /// number is not zero).
        /// </summary>
        private static void Question7()
        {
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string finalNumber = "";
            do
            {
                finalNumber += number % 10;
                number /= 10;
            } while (number > 1);
            Console.WriteLine($"Your number in reverse = {finalNumber}");
        }
    }
}
