using System;

namespace Assignment5
{
    class Program
    {
        static int[] givenNumbers = { 0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2 };
        static string[] poem = "mary had a little lamb its fleece was white as snow".Split();
        static string? input;

        public static void Main(string[] args)
        {
            do
            {
                DisplayMenu();
            } while (input != "0");
        }


        private static void DisplayMenu()
        {
            string choice = "";
            do
            {
                Console.WriteLine();
                Console.WriteLine("Main Menu");
                Console.WriteLine();
                Console.WriteLine("1) Calculate Sum");
                Console.WriteLine("2) Calculate Average");
                Console.WriteLine("3) Display Numbers");
                Console.WriteLine("4) Display Poem");
                Console.WriteLine("5) Create Numbers Array");
                Console.WriteLine("0) To Exit");
                Console.Write("Enter the value: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        input = "0";
                        break;
                    case "1":
                        int sum = CalculateSum(5);
                        Console.WriteLine($"Sum = {sum}");
                        break;
                    case "2":
                        double average = CalculateAverage(5);
                        Console.WriteLine($"Average value = {average}");
                        break;
                    case "3":
                        DisplayIntArray(givenNumbers);
                        Array.Reverse(givenNumbers);
                        Console.WriteLine();
                        DisplayIntArray(givenNumbers);
                        break;
                    case "4":
                        DisplayStringArray(poem);
                        Array.Sort(poem);
                        Console.WriteLine();
                        DisplayStringArray(poem);
                        break;
                    case "5":
                        int[] array = CreateIntArray();
                        Console.Write("Array : ");
                        DisplayIntArray(array);
                        break;
                    default:
                        Console.WriteLine("Error...! Wrong input...!");
                        break;
                }
            } while (choice != "0");
        }


        private static int CalculateSum(int cycles)
        {
            int sum = 0;
            for (int i=0; i<cycles;i++)
            {
                Console.Write("Enter the number please: ");
                sum += Convert.ToInt32(Console.ReadLine());
            }
            return sum;
        }

        private static double CalculateAverage(int cycles)
        {
            double sum = 0;
            for (int i=0; i<cycles;i++)
            {
                Console.Write("Enter the number please: ");
                sum += Convert.ToDouble(Console.ReadLine());
            }
            double average = sum / cycles;
            return average;
        }

        private static void DisplayIntArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
        }

        private static void DisplayStringArray(string[] array)
        {
            foreach (string i in array)
            {
                Console.Write($"{i} ");
            }
        }

        private static int[] CreateIntArray()
        {
            Console.Write("Enter the lenght of array: ");
            int cycles = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[cycles];
            for (int i=0;i<cycles;i++)
            {
                Console.Write("Enter the number please: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array;
        }
    }
}
