using System;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan jumlah bilangan Fibonacci yang ingin ditampilkan: ");
        int n = int.Parse(Console.ReadLine());

        int a = 0, b = 1, next;

        Console.WriteLine("Bilangan Fibonacci:");
        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");

            next = a + b;
            a = b;
            b = next;
        }
    }
}