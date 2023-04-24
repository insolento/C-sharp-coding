using System;

namespace Assignment3
{
    class Program
    {
        #region Hidden

        public static void Main(string[] args)
        {
            string number;
            do
            {
                Console.Write("Enter the number (1-10) for the question to run or 0 to exit: ");
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
                    case "8":
                        Question8();
                        break;
                    case "9":
                        Question9();
                        break;
                    case "10":
                        Question10();
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
        /// Write code that prompts the user for a menu choice.
        /// The program will display a message based on the following:
        ///   Choice            Message
        ///   1                 "Calculate area"
        ///   2                 "Calculate volume"
        ///   3                 "Calculate surface area"
        ///   4                 "Exit the program"
        ///   any other input   "ERROR: Invalid choice"
        /// </summary>
        public static void Question1()
        {
            Console.WriteLine("Enter the number 1-4: ");
            string number = Console.ReadLine();
            string result = "ERROR: Invalid choice";

            switch (number)
            {
                case "1":
                    result = "Calculate area";
                    break;
                case "2":
                    result = "Calculate volume";
                    break;
                case "3":
                    result = "Calculate surface area";
                    break;
                case "4":
                    result = "Exit the program";
                    break;
            }
            Console.WriteLine(result);
        }

        /// <summary>
        /// Write code that allows the user to enter two integers and a character.
        /// If the character is 'A', then add the two integers.
        /// If the character is 'S', then subtract the second integer from the first.
        /// Otherwise, multiply the integers.
        /// Display the results of the arithmetic.
        /// </summary>
        public static void Question2()
        {
            Console.WriteLine("Enter first number:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter \'A\' if you want to add numbers, \'S\' to substract: ");
            string character = Console.ReadLine();
            if (character == "A")
            {
                Console.WriteLine(number1 + number2);
            } else if (character == "S")
            {
                Console.WriteLine(number1 - number2);
            } else
            {
                Console.WriteLine(number1 * number2);
            }
        }

        /// <summary>
        /// Write code that prompts the user for the number of cources and residency status
        /// (domestic or international) and calculates tuition cost. Cost is calculated based on the
        /// folowing:
        ///     Domestic        $325 per course
        ///     International   $1375 per course
        /// You decide how you want the user to enter their residency status and prompt accordingly.
        /// You must use named constants for the cost per course.
        /// Display the total cost.
        /// </summary>
        public static void Question3()
        {
            int domesticPrice = 325;
            int internationalPrice = 1375;
            Console.WriteLine("Are you international? 3(write \'true\' or \'false\')");
            bool isInternational = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many courses do you have:");
            int courses = Convert.ToInt32(Console.ReadLine());
            if (isInternational) {
                Console.WriteLine($"Your tuition fees will be {(internationalPrice * courses):c}");
            } else
            {
                Console.WriteLine($"Your tuition fees will be {(domesticPrice * courses):c}");
            }
        }

        /// <summary>
        /// Write code that prompts the user for a day of the week. The program will display a 
        /// message based on the following:
        ///     Choice      Message
        ///     Sun         Home
        ///     Mon         Work
        ///     Tue         Work
        ///     Wed         Home
        ///     Thu         Work
        ///     Fri         Work
        ///     Sat         Work
        /// </summary>
        public static void Question4()
        {
            Console.WriteLine("Name of days: Sun, Mon, Tue, Wed, Thu, Fri, Sat");
            Console.WriteLine("Enter the day you want to see: ");
            string day = Console.ReadLine();
            switch (day)
            {
                case "Sun":
                    Console.WriteLine("You should be Home");
                    break;
                case "Mon":
                    Console.WriteLine("You should be at Work");
                    break;
                case "Tue":
                    Console.WriteLine("You should be at Work");
                    break;
                case "Wed":
                    Console.WriteLine("You should be Home");
                    break;
                case "Thu":
                    Console.WriteLine("You should be at Work");
                    break;
                case "Fri":
                    Console.WriteLine("You should be at Work");
                    break;
                case "Sat":
                    Console.WriteLine("You should be at Work");
                    break;
                default:
                    Console.WriteLine("Error... Wrong input");
                    break;
            };
        }

        /// <summary>
        /// Write code for a furniture company. Ask the user to choose Pine, Oak or Mahogany.
        /// Show the price of a table manufactured with the choosen wood. Pine tables cost $100, 
        /// Oak tables cost $125, and Mahogany tables cost $310. You must use named constants and
        /// a switch statement. You must accept any variation on the case (Eg. Pine, pine, PINE, piNe, etc
        /// </summary>
        public static void Question5()
        {
            Console.WriteLine("You can choose material for your table between Pine, Oak or Mahogany:");
            string wood = Console.ReadLine().ToLower();
            switch (wood)
            {
                case "pine":
                    Console.WriteLine($"Price of Pine table is {100:c}");
                    break;
                case "oak":
                    Console.WriteLine($"Price of Oak table is {125:c}");
                    break;
                case "mahogary":
                    Console.WriteLine($"Price of Mahogany table is {310:$}");
                    break;
                default:
                    Console.WriteLine("We don't have tables with this material");
                    break;
            }
        }

        /// <summary>
        /// Write code that prompts the user for an hourly pay rate. If the value entered is less than
        /// $5.65, display an error message
        /// </summary>
        public static void Question6()
        {
            Console.WriteLine("Enter the hourly pay rate:");
            double salary = Convert.ToDouble(Console.ReadLine());
            if (salary<5.65)
            {
                Console.WriteLine("Error... That's too low...");
            } else
            {
                Console.WriteLine("That's fine");
            };
        }

        /// <summary>
        /// Write code that prompt a user for an hourly pay rate. If the user enters a value less than
        /// $5.65 or greater than $49.99, prompt the user again. If the user enters an invalid value again,
        /// display an appropriate error message. If the user enters a valid value on either the first or
        /// second attempt, display the pay rate as well as the weekly rate which is calculated as 40 times 
        /// the hourly rate.
        /// </summary>
        public static void Question7()
        {
            Console.WriteLine("Enter your hourly rate: ");
            double hourlyRate = Convert.ToDouble(Console.ReadLine());
            if (hourlyRate<5.65 || hourlyRate>49.99)
            {
                Console.WriteLine("Try one more time: ");
                double secondHourlyRate = Convert.ToDouble(Console.ReadLine());
                if (secondHourlyRate < 5.65 || secondHourlyRate > 49.99)
                {
                    Console.WriteLine("Error! Incorect number second time!!!");
                }
                else
                {
                    Console.WriteLine($"Your weekly rate is {(secondHourlyRate * 40):c}");
                }
            } else
            {
                Console.WriteLine($"Your weekly rate is {(hourlyRate * 40):c}");
            }
            
        }

        /// <summary>
        /// Write a program for a college's admissions office. The user enters a numeric high school grade
        /// point average (ex. 3.2) and an admission test score. Print the message "Accept" if the student
        /// meets either of the following requirements:
        ///     A grade point average of 3.0 or higher and an admission test score of at least 60
        ///     A grade point average of less than 3.0 and an admission test score of at least 80
        /// If the student does not meet either of the qualification criteria, print "Reject"
        /// </summary>
        public static void Question8()
        {
            Console.WriteLine("Enter high school grade point: ");
            double highSchool = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter admission test score:");
            int admission = Convert.ToInt16(Console.ReadLine());
            if ((highSchool >= 3.0) && (admission >= 60))
            {
                Console.WriteLine("Accept");
            } else if (admission >= 80)
            {
                Console.WriteLine("Accept");
            } else
            {
                Console.WriteLine("Reject");
            }
        }

        /// <summary>
        /// Write code that prompts the uesr for an hourly pay rate and hours worked. Compute gross pay
        /// (hours times pay rate), withholding tax, and net pay (gross pay minus withholding tax).
        /// Withholding tax is computed as a percentage of gross pay based on the following:
        ///     Gross pay                       Withholding Percentage
        ///     Up to an including 300.00       10%
        ///     300.01 and up                   12%
        /// </summary>
        public static void Question9()
        {
            Console.WriteLine("Enter your hourly pay rate:");
            double hourly = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter how many ours did you work:");
            double hours = Convert.ToDouble(Console.ReadLine());
            double grossPay = hourly * hours;
            Console.WriteLine($"Your gross pay is {Convert.ToInt32(grossPay)}$");
            double taxes = 0;
            if (grossPay >= 300.01)
            {
                taxes = grossPay *0.12;
            } else
            {
                taxes = grossPay * 0.10;
            }
            Console.WriteLine($"Your taxes will be {taxes:c}");
            Console.WriteLine($"Your net pay will be {grossPay - taxes:c}");
        }

        /// <summary>
        /// Write code for a lawn-mowing service. The lawn-mowing season lasts 20 weeks. The weekly fee
        /// for mowing a lot under 400 square feet is $25. The fee for a lot that is 400 square feet or more,
        /// but under 600 square feet, is $35 per week. The fee for a lot that is 600 square feet or over is 
        /// $50 per week. Prompt the user for the length and width of a lawn, and then print the weekly
        /// mowing fee, as well as the total fee for the 20-week season.
        /// </summary>
        public static void Question10()
        {
            Console.WriteLine("Enter the length of the lawn:");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the width of the lawn:");
            double width = Convert.ToDouble(Console.ReadLine());
            double square = length * width;
            if (square < 400)
            {
                Console.WriteLine($"Your weekly mowing fee is {25:c} and total fee for 20 weeks is {500:c}");
            }
            else if (square >= 600)
            {
                Console.WriteLine($"Your weekly mowing fee is {50:c} and total fee for 20 weeks is {1000:c}");
            }
            else
            {
                Console.WriteLine($"Your weekly mowing fee is {35:c} and total fee for 20 weeks is {700:c}");
            }
        }
    }
}
