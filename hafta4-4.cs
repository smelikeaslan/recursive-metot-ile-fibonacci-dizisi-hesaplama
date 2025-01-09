using System;

namespace FibonacciRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fibonacci dizisinde kaçıncı sayıyı görmek istiyorsunuz? ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sonuc = Fibonacci(n);
            Console.WriteLine($"{n}. Fibonacci sayısı: {sonuc}");
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            Console.ReadKey();
        }
    }
}