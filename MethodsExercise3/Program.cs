using System;
using System.Collections.Generic;

namespace MethodsExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //AllNums();
            //Threes();
            //AreEqual(4, 4);
            //IsEvenOrOdd(88);
            //IsPosOrNeg(-444);
            //CanVote();
            //IsWithin();
            MultiplicationTable(5);
        }
        public static void AllNums()  //this method prints -1000 to 1000
        {
            var numbers = new List<int>();
            int num = -1001;

            do
            {
                num++;
                numbers.Add(num);
            } while (num < 1000);

            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
            
        }
        public static void Threes()  //prints 3 through 999, every 3 numbers
        {
            for(int num = 3; num <= 999; num +=3)
                Console.WriteLine(num);
        }
        public static bool AreEqual(int x, int y) //test to see if both numbers are equal
        {   
            if(x == y)
            {
                Console.WriteLine("These numbers are equal.");
                return true;
            }
            else
            {
                Console.WriteLine("These numbers are not equal.");
                return false;
            }
        }
        public static void IsEvenOrOdd(int number) //test to see if number is even or odd
        {
            if(number % 2 != 0)
            {
                Console.WriteLine("The number is odd.");
            }
            else
            {
                Console.WriteLine("The number is even");
            }
        }
        public static void IsPosOrNeg(int number)
        {
            if(number < 0)
                Console.WriteLine("The number is negative.");
            else
                Console.WriteLine("The number is positive.");
        }
        public static void CanVote()
        {
            Console.WriteLine("What is your age?");
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            int yearsUntil = 18 - age;

            if(age >= 18)
                Console.WriteLine("You are old enough to vote.");
            else
            {
                Console.WriteLine($"You are not old enough to vote. You can vote in {yearsUntil} more years.");
            }

        }
        public static bool IsWithin()
        {
            Console.WriteLine("Enter a number.");
            int number;
            do
            {
                number = int.Parse(Console.ReadLine());
                if (number >= -10 && number <= 10)
                {
                    Console.WriteLine("Number is within range.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Number is not within the range.");
                    return false;
                }
            } while (number < -10 || number > 10); //might have to work on this loop
        }
        public static void MultiplicationTable(int num)
        {
            Console.WriteLine($" x  :  {num}");
            Console.WriteLine($" 1  -  {num}");
            Console.WriteLine($" 2  -  {num * 2}");
            Console.WriteLine($" 3  -  {num * 3}");
            Console.WriteLine($" 4  -  {num * 4}");
            Console.WriteLine($" 5  -  {num * 5}");
            Console.WriteLine($" 6  -  {num * 6}");
            Console.WriteLine($" 7  -  {num * 7}");
            Console.WriteLine($" 8  -  {num * 8}");
            Console.WriteLine($" 9  -  {num * 9}");
            Console.WriteLine($"10  -  {num * 10}");
            Console.WriteLine($"11  -  {num * 11}");
            Console.WriteLine($"12  -  {num * 12}");
        }
    }
}
