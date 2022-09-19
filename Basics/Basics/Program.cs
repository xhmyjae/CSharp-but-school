using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;

namespace Basics
{
    internal class Program
    {
        public static void Main(string[] args)
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
            char thirdValue = text1[3];
            Console.WriteLine(thirdValue);
            string userInput = Console.ReadLine();
            Console.WriteLine(userInput);

        }
    }
}