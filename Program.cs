using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment2
{
    //Ihaka August 06245455
    //I pledge by honour that the programs in this file is soley my own work
    class Tester
    {
        static void Main(string[] args)
        {
            //Question1();
            //Question2();
            //Question3();
            //Question4();
            //Question5();
        }

        #region Question 1
        static void Question1()
        {
            //Creating an array with static values
            Card[] hand = {
                new Card("Spade", 3),
                new Card("Club", 10),
                new Card("Diamond", 11),
                new Card("Heart", 9),
                new Card("Diamond", 13),
            };
            ProcessHand(hand);
        }
        static void ProcessHand(Card[] cards)
        {
            int total = 0;
            foreach (Card c in cards)
            {
                c.DisplayCard();
                total += c.Face;
            }
            Console.WriteLine("\nTotal face value of hand: {0}", total);
        }
        //Created card class
        class Card
        {
            //string constructor with suit as the
            //property and get/set as parameters
            public string Suit { get; set; }
            //int constructor with face as the
            //property and get/set as parameters
            public int Face { get; set; }
            //public constructor with card as the
            //property and parameters string and int 
            //to set variables.
            public Card(string s, int f)
            {
                Suit = s;
                Face = f;
            }
            public void DisplayCard() 
            { 
                Console.WriteLine("The card is {0}  {1}", Suit, Face);
            }
        }
        #endregion
        #region Question 2
        static void Question2()
        {
            //The first static array with 5 values
            Box[] boxArray1 = {
                                 new Box("white", 4, 3, 2),
                                 new Box("red", 9, 5, 6),
                                 new Box("purple", 3, 6, 12),
                                 new Box("orange", 15, 10, 4),
                                 new Box("black", 4, 14, 10),
                              };
            //The second static array with 5 values
            Box[] boxArray2 = {
                                 new Box("pink", 3, 4, 2),
                                 new Box("red", 10, 2, 4),
                                 new Box("white", 8, 5, 7),
                                 new Box("blue", 14, 4, 10),
                                 new Box("bindle", 10, 15, 4),
            
                              };
            //int variables set to equal 0
            int overlap2 = 0;
            int overlap1 = 0;
            //foreach loop to retrieve data from first array
            foreach (Box b1 in boxArray1)
            {
                //foreach loop to retrieve data from second array
                foreach (Box b2 in boxArray2)
                {
                    //If statement to compare the color from both tables 
                    if (b1.Colour == b2.Colour)
                    {
                        //an increment if the values are the same
                        overlap1++;
                    }
                    //If statement to compare the volume from both tables 
                    if (b1.GetVolume() == b2.GetVolume())
                    {
                        //an increment if the values are the same
                        overlap2++;
                    }
                }
            }
            //Printing the result of overlapping data
            Console.WriteLine("There are {0} Box objects with overlapping colours between the two arrays", overlap1);
            Console.WriteLine("There are {0} Box objects with overlapping volume between the two arrays", overlap2);
        }
        class Container
        {
            //String constructor with colour as the property
            public string Colour { get; set; }
            public Container(string c)
            {
                Colour = c;
            }
            public virtual string GetContainerType()//Override method
            {
                return "Unknown";
            }
        }
        class Box : Container
        {
            public int Height { get; set; }
            public int Width { get; set; }
            public int Length { get; set; }
            public Box(string c, int h, int w, int l)
                : base(c)
            {
                Height = h;
                Width = w;
                Length = l;
            }
            public override string GetContainerType()//Override method
            {
                return "Box";
            }
            //a method to calculate the volume by
            //multiplying the height, weight and length. eg (area)
            public int GetVolume()
            {
                return Height * Width * Length;
            }
        }
        #endregion
        #region Question 3
        static void Question3()
        {
            //User input
            Console.Write("Enter a number: ");
            //reading the input as an integer
            int num = int.Parse(Console.ReadLine());
            int total = CalcSum(num);
            Console.WriteLine("The sum of all digits of the number {0} is {1}", num, total);
        }

        static int CalcSum(int num)
        {
            //An if statement that returns the user input
            //if the number id less than 10
            if (num < 10)
            {
                return num;
            }
            //The else statement takes both numbers from the 
            //user input and adds the together
            else
            {
                int lastDigit = num % 10;
                int Digit = lastDigit;
                int subNumber = num / 10;
                int subResult = CalcSum(subNumber);
                int result = Digit + subResult;
                return result;
            }
        }
        #endregion
        #region Question 4
        static void Question4()
        {
            //Creating a list called bag and putting static
            //values into the list
            List<Bag> bags = new List<Bag>();
            bags.Add(new Bag("Blue", 25));
            bags.Add(new Bag("Red", 35));
            bags.Add(new Bag("White", 30));
            //The calculation of the volume is put into the
            //variable totalVolume so it can be retrieved in
            //the console.writeline.
            int totalVolume = CalcTotalVolume(bags);
            Console.WriteLine("Total volume of bags: {0}", totalVolume);
        }
        static int CalcTotalVolume(List<Bag> baglist)
        {
            //If the list has no values return nothing or "0"
            if (baglist.Count == 0)
            {
                return 0;
            }
            //puts the first volume element into variable first
            //then grabs the rest of the list and puts it into sublist
            //the total is the first element plus the remaining elements 
            //in the list
            else
            {
                int first = baglist[0].Volume;
                List<Bag> subList = baglist.GetRange(1, baglist.Count - 1);
                int total = first + CalcTotalVolume(subList);
                return total;
            }
        }
        class Bag
        {
            public string Colour { get; set; }
            public int Volume { get; set; }
            public Bag(string col, int vol)
            {
                Colour = col;
                Volume = vol;
            }
        }
        #endregion
        #region Question 5
        static void Question5()
        {
            //printing and formatting the end results
            StudentApp app = new StudentApp("Data.txt");
            Console.WriteLine(new String('-', 50));
            app.PrintData();
            Console.WriteLine(new String('-', 50));
            Console.WriteLine("Max score:" + app.GetMaxScore());
            Console.WriteLine("Number of scores between 50-80: " + app.CountScoreRange());
            app.PromoteScore();
            Console.WriteLine("Total score (after 10 marks promotion): " +
            RecursiveGetTotalScore(app.Students));
        }
        static double RecursiveGetTotalScore(List<Student> list)
        {
            //An if statement that returns nothing if the list
            //has no values
            if (list.Count == 0)
            {
                return 0;
            }
            //else put the first element into a variable called firsstelim
            //then grab the rest in the list and put it into sublist
            //total equals the first element plus the rest of the list
            else
            {
                Student firstElim = list[0];
                List<Student> subList = list.GetRange(1, list.Count - 1);
                double total = firstElim.Score + RecursiveGetTotalScore(subList);
                return total;
            }           
        }
     }
     class StudentApp
     {
         public List<Student> Students { get; set; }
         public StudentApp(string filename)
         {
            Students = new List<Student>();
            ReadData(filename);
         }
         public void ReadData(string filename)
         {
             using (StreamReader sr = new StreamReader(filename)) 
             {
                 while(sr.EndOfStream == false)
                 {
                    //reading the data text as a string and spliting the info
                    //by commas. then formatting is as, first element string and second element as
                    //a double
                     string[] datalist = sr.ReadLine().Split(',');
                     Student s = new Student(datalist[0], double.Parse(datalist[1]));
                     Students.Add(s);
                 }
             }
         }
        //Displays all students data from the text file
         public void PrintData()
         {
             foreach (Student i in Students)
             {
                 i.DisplayInfo();
             }
         }
        //This statement searchers through every student
        //to look for the highest score. If one student 
        //has a higher score than previous student ist is replaced
         public double GetMaxScore()
         {
            double max = Students[0].Score;
            foreach(Student s in Students)
            {
                if (s.Score > max)
                    max = s.Score;
            }
            return max;
         }
         public int CountScoreRange()
         {
            int range = 0;
            //If the score is greater than 50 or less than 80
            //for every student increment the range
            foreach(Student s in Students)
            {
                if (s.Score > 50 && s.Score < 80)
                    range++;
            }
            return range;
         }
         public void PromoteScore()
        {
            foreach(Student s in Students)
            {
                if (s.Score <= 90)
                    s.Score += 10;
                else
                {
                    s.Score += 100 - s.Score;
                }
            }
        }
     }
    class Student
    {
        public string ID { get; set; }
        public double Score { get; set; }
        public Student(string id, double score)
        {
            ID = id;
            Score = score;
        }
        //Setting/format to display all data
        public void DisplayInfo()
        {
            Console.WriteLine("{0} {1}", ID, Score);
        }
    }
    #endregion
}//End of namespace
