using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;

namespace Basics
{
    public class Car
    {
        public string Color;
        public int Date;
        private string privateStr;
        
        public Car()
        {
            Color = "yellow";
            Date = 2999;
        }

        public Car(string color, int date)
        {
            Color = color;
            Date = date;
        }

        public void DisplayCar()
        {
            Console.WriteLine("Color : " + Color);
            Console.WriteLine("Date : " + Date);
        }

        public string PrivateStr
        {
            get { return privateStr; }
            set { privateStr = value; }
        }
    }

    public class Food
    {
        private string Origin;

        public void Manger()
        {
            Console.WriteLine("Miam miam miam je mange un aliment");
        }
    }

    public class Fruit : Food
    {
        private string Name;

        public Fruit(string name)
        {
            Name = name;
        }

        new public void Manger()
        {
            Console.WriteLine("Miam miam je mange des fruits");
        }
    }

    abstract class abs
    {
        public abstract bool GetBool();
    }

    interface absInt
    {
        void absIntMethod();
    }

    enum seasons
    {
        Spring,
        Winter,
        Autumn, 
        Summer
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Color = "yellow";
            Console.WriteLine(car1.Color);
            Car car2 = new Car("green", 1993);
            Console.WriteLine(car2.Color);
            car2.DisplayCar();
            car2.PrivateStr = "blabla";
            Console.WriteLine(car2.PrivateStr);
            Fruit fruit = new Fruit("ananas");
            fruit.Manger();
        }

        private static void Variables()
        {
            int intValue = 50;
            Console.WriteLine(intValue);
            string stringValue = "Bonjour";
            Console.WriteLine(stringValue);
            float floatValue = 3.1415F;
            Console.WriteLine(floatValue);
            char charValue = 'a';
            Console.WriteLine(charValue);
            bool boolValue = true;
            Console.WriteLine(boolValue);
            const int constValue = 10;
            Console.WriteLine(constValue);
            int x = 10, y = 50;
            Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y);
            Console.WriteLine(x % y);
            string text1 = "blabla 1 ";
            string text2 = "2 blabla";
            Console.WriteLine(text1 + text2);
            Console.WriteLine($"{text1}{text2}");
            Console.WriteLine(String.Concat(text1, text2));
            int num1, num2, num3;
            char thirdValue = text1[2];
            Console.WriteLine(thirdValue);
            string userInput = Console.ReadLine();
            Console.WriteLine(userInput);
        }

        private static void Statements()
        {

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine("HelloWorld (x greater than y)");
                Console.WriteLine(1);
            }
            else if (y > x)
            {
                Console.WriteLine("y greater than x");
                Console.WriteLine(2);
            }
            else
            {
                Console.WriteLine("x and y are equals");
                Console.WriteLine(3);
            }

            bool changingBoolean;

            bool test1 = x > y;
            bool test2 = x == 3 ? true : false;
            
            if (x > y)
            {
                changingBoolean = true;
            }

            switch (x)
            {
                case 1:
                    changingBoolean = false;
                    break;
                default:
                    changingBoolean = true;
                    break;
            }

            int z = int.Parse(Console.ReadLine());
            
            switch (z)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine($"Number {z} has been input");
                    break;
                default:
                    Console.WriteLine("The number is not between 1 to 5.");
                    break;
            }

        }

        private static void Loops()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Message number : {i}");
            }

            int j = 0;
            do
            {
                Console.WriteLine($"j = {j}");
                j++;
            } while (j < 5);

            int limitInput = int.Parse(Console.ReadLine());
            for (int i = 0; i < limitInput; i++)
            {
                if (i == limitInput - 3)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            bool test2;
            for (int i = 0; i < limitInput; i++)
            {
                bool test1 = false;
                test2 = true;
                while (!test1)
                {
                    Console.WriteLine(test1);
                    Console.WriteLine(test2);
                    test1 = true;
                    test2 = false;
                    Console.WriteLine(test1);
                    Console.WriteLine(test2 + "-----");
                }
            }
        }

        private static void Arrays()
        {
            Console.WriteLine("EXO 1");
            string[] fruits = { "apple", "pineapple", "watermelon", "strawberry", "banana", "grape fruits" };
            Array.ForEach(fruits, Console.WriteLine);
            
            Console.WriteLine("EXO 2");
            Console.WriteLine("1st :");
            char[] char1 = { 'a', 'b', 'c', 'd', 'e' };
            Array.ForEach(char1, Console.WriteLine);
            Console.WriteLine("2nd :");
            string str = "blabl";
            char[] char2 = str.ToCharArray();
            Array.ForEach(char2, Console.WriteLine);
            
            Console.WriteLine("EXO 3");
            int[] randomInts = { 3, 5, 1, 4, 2 };
            Array.Sort(randomInts);
            Array.ForEach(randomInts, Console.WriteLine);

            Console.WriteLine("EXO 4");
            int[,] matrixArray = new int[4,4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrixArray[i, j] = j;
                    Console.Write(matrixArray[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("EXO 5");
            List<Object> objectsArray = new List<object>();
            string input = null;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "0")
                {
                    break;
                }
                objectsArray.Add(input);
            }
            objectsArray.Reverse();
            objectsArray.ForEach(o => Console.Write(o));

            Console.WriteLine("\nEXO 6");
            List<int> intList = new List<int>();
            Random rdn = new Random();
            int tryCount = 0;
            do
            {
                tryCount++;
                Console.WriteLine("Tries number " + tryCount + " :");
                int intListCount = intList.Count;
                for (int i = 0; i < 3 - intListCount; i++)
                {
                    intList.Add(rdn.Next(1, 7));
                }
                intList.ForEach(Console.Write);
                Console.WriteLine();
                
                var query = intList.GroupBy(x => x)
                    .Where(g => g.Count() > 1)
                    .Select(y => y.Key)
                    .ToList();

                query.ForEach(Console.Write);
                Console.WriteLine();
                if (query.Count == 0)
                {
                    intList.Clear();
                }
                else
                {
                    foreach (var q in query)
                    {
                        intList.RemoveAll(r => r == q);
                    }

                    if (intList[0] == 6 && intList.Count == 1)
                    {
                        intList.RemoveAt(0);
                    }
                }
                
                intList.ForEach(Console.Write);

            } while (intList.Count != 0);

            // 1 a 6 =x 3
            // si 2 ou plus => egaux alors remove them
            // if length == 1 && num[0] == 6 => remove them
            // count chaque essai
            
        }

        private static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        private static double Sum(double x, double y, double z)
        {
            return x + y + z;
        }

        private static int Recursive(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            return Recursive(x - 1);
        }

        private static bool Recursive2(int x)
        {
            if (x == 0)
            {
                return true;
            }
            return Recursive2(x - 1);
        }

        private static int Sums(int x, int y)
        {
            return x + y;
        }

        private static double Sums(double w, double z)
        {
            return w + z;
        }

        private static double SumOfArray(double[] array)
        {
            return array.Sum();
        }

        private static int BadFibonacci(int i)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            for (int j = 0; j < i; j++)
            {
                c = a;
                a = b;
                b = c + b;
            }
            return a;
        }

        private static int Fibonacci(int i)
        {
            if (i <= 2)
            {
                return 1;
            }

            return Fibonacci(i - 1) + Fibonacci(i - 2);
        }
        
        
    }
}