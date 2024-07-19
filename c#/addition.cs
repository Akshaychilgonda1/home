using System;
namespace Addition
{
    class AdditionOfTwoValue
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("enter first number");
            int a=Convert.Inint(Console.ReadLine());
            Console.WriteLine("enter second number");
            int b=Convert.int(Console.ReadLine());
            int c= a+b;
            Console.WriteLine(c);

        }
    }
}