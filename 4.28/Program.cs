using System;

namespace _4._28
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            a = int.Parse(Console.ReadLine());
            b = a / 100;
            c = a % 100 / 10;
            d = a % 10;
            if (a > 999)
                Console.WriteLine("Число не трехзначное");
            else if (b == d)
                Console.WriteLine("Число является палиндромом");
            else
                Console.WriteLine("Число не является палиндромом");
        }
    }
}
