using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Xml;

namespace Basics
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Loops();
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
    }
}