using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1();
            //Question2();
            //Question3();
            //Question4();
            //Question5();
            //Question6();
            //Question7();
            //Question8();
        }
        static void Question1()
        {
            Console.WriteLine("{0,-28}{1,14}", "Special Characters:", "Description:");
            Console.WriteLine("{0,-28}{1,14}", "...................", "............");
            Console.WriteLine("{0,-28}{1,18}", "\\", "Single backslash");
            Console.WriteLine("{0,-28}{1,18}", "\\\\", "Double backslash");
            Console.WriteLine("{0,-28}{1,24}", "' '", "A pair of single qoute");
            Console.WriteLine("{0,-28}{1,24}", "\" \"", "A pair of double qoute");
        }
        static void Question2()
        {
            //Height input statement
            Console.Write("Enter a height: ");
            double num = double.Parse(Console.ReadLine());

            //Width input statement
            Console.Write("Enter a width: ");
            double num1 = double.Parse(Console.ReadLine());

            double area = num * num1;
            double perimeter = (num + num1) * 2;

            //Prints the user inputs and displays the area and perimeter 
            Console.WriteLine("{0,0}{1,15}{2,20}{3,25:s}", "Height", "Width", "Area", "Perimeter");
            Console.WriteLine("....................................................................");
            Console.WriteLine("{0,0}{1,16}{2,24}{3,18:f}", num, num1, area, perimeter);
        }
        static void Question3()
        {
            Console.Write("Enter the number of a month (1-12): ");
            int season = int.Parse(Console.ReadLine());

            if (season == 12 || season == 1 || season == 2)
            {
                Console.WriteLine("Summer");
            }
            else if (season >= 3 && season <= 5)
            {
                Console.WriteLine("Autumn");
            }
            else if (season >= 6 && season <= 8)
            {
                Console.WriteLine("Winter");
            }
            else if (season >= 9 && season <= 11)
            {
                Console.WriteLine("Spring");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        static void Question4()
        {
            while (true)
            {
                Console.Write("Enter a season (Winter, Summer, Autumn, Spring): ");
                string season = Console.ReadLine();
                if (season.ToLower() == "summer")
                {
                    Console.WriteLine("Summer is an oil painting");
                    break;
                }
                else if (season.ToLower() == "autumn")
                {
                    Console.WriteLine("Autumn is a mosaic of them all");
                    break;
                }
                else if (season.ToLower() == "winter")
                {
                    Console.WriteLine("Winter is an etching");
                    break;
                }
                else if (season.ToLower() == "spring")
                {
                    Console.WriteLine("Spring is a water colour");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again");
                    continue;
                }
            }
        }
        static void Question5()
        {
            //Setting variables
            double total = 0;
            int count = 0;
            double minimum = double.MaxValue;

            //Setting s user input and reading it as a number or integer
            Console.Write("How many stocks to enter price for: ");
            int stock = int.Parse(Console.ReadLine()); 

            //setting an array as a double
            double[] priceStock = new double[stock];


            for (int i = 0; i < stock; i++)
            {
                Console.Write("Enter price of stock #{0}: ", i + 1);
                priceStock[i] = double.Parse(Console.ReadLine());
                total = total + priceStock[i];

                if(priceStock[i] >= 1.5 && priceStock[i] <= 35)
                {
                    count++;
                }
                if(minimum > priceStock[i])
                {
                    minimum = priceStock[i];
                }
            }
            double average = total / stock;
            Console.WriteLine("Average Stock Price Is: {0}", average);
            Console.WriteLine("Minimum Stock Price Is: {0}", minimum);
            Console.WriteLine("Number Of Stocks Between 1.5 & 35 Are: {0}", count);

        }
        static void Question6()
        {
            Random randomNo = new Random();
            int secretNo = randomNo.Next(1, 50);

            bool check = false;

            Console.Write("Enter comma-seperated numbers to guess my secret number: ");
            string userInput = Console.ReadLine();

            string[] strArray = userInput.Split(',');

            int[] intArray = new int[strArray.Length];

            for (int i = 0; i < strArray.Length; i++)
            {
                intArray[i] = int.Parse(strArray[i]);

                if (intArray[i] == secretNo)
                {
                    check = true;
                    break;
                }
            }
            if (check == true)
                Console.WriteLine("You have won! My secret number is {0}: ", secretNo);
            else
                Console.WriteLine("You have lost! My secret number is {0}: ", secretNo);
        }
        static void Question7()
        {
            Console.Write("Enter first line of comma-seperated numbers: ");
            string first = Console.ReadLine();

            Console.Write("Enter second line of comma-seperated numbers: ");
            string second = Console.ReadLine();

            int lap = 0;

            string[] strArray1 = first.Split(',');
            double[] intArray1 = new double[strArray1.Length];

            string[] strArray2 = second.Split(',');
            double[] intArray2 = new double[strArray1.Length];

            for (int i = 0; i < intArray1.Length; i++)
            {
                for(int j = 0; j < intArray2.Length; j++)
                {
                    if (intArray1 == intArray2)
                        lap = lap + 1;
                }
            }
            Console.WriteLine("There are {0} overlap numbers between the two lines.", lap);

        }
        static void Question8()
        {
            //Setting variables
            double total = 0;

            double count = 0;

            double min = double.MaxValue;

            //Setting a user input
            Console.Write("Enter a line of comma-seperated temperatures: ");
            string temp = Console.ReadLine();

            //Setting an array 
            string[] strArray = temp.Split(',');
            double[] intArray = new double[strArray.Length];

            for(int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = double.Parse(strArray[i]);

                total = total + intArray[i];
                if (i >= 0 && i <= 5)
                {
                    count++;
                }                
                if (min > intArray[i])
                {
                    min = intArray[i];
                }
                
            }
            double average = total / count;
            Console.WriteLine("Average temperature is: {0}", average);
            Console.WriteLine("Minimum temperature is: {0}", min);
            Console.WriteLine("Count of temperatures are: {0}", count);
        }
    }
}
