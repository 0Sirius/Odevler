using System;
using System.Linq;

namespace Kafama_göre
{
    class Program
    {
        static void Main(string[] args)
        {
           // Add();
            var resualt= Add2(20, 30);
            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(number1, number2);

            //Console.WriteLine(resualt);
            //Console.WriteLine(result2);
            Console.WriteLine(multiply (2, 2));
            Console.WriteLine(multiply2(2, 2, 3));
            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));
        }
        static void Add()
        {
            Console.WriteLine("Added!!");

        }
        static int Add2(int number1, int number2)
        {
            var result  =  number1 + number2;
            return result;

        }
        static int Add3(int number1, int number2)
        {
            return number1 + number2;
        }
        static int multiply(int number1,int number2)
        {
            return number2 * number1;
        }
        static int multiply2(int number1, int number2, int number3)
        {
            return number2 * number1 * number3;
        }
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
