using System;

class Program
{
    static void Main(string[] args)
    {
        int c = 3;
        Console.Write(Sum(5, 3, out c) + " ");
        Console.Write(c);
        Console.ReadLine();
    }

    static int Sum(int a, int b, out int c)
    {
        c = a++;
        return a + b;
    }
}