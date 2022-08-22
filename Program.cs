using System;

class MainClass
{
    static void Main(string[] args)
    {

        Console.WriteLine(Factorial(20));

        //Console.ReadKey();
    }

    static long Factorial(long x)
    {
        if (x == 0)
        {
            return 1;
        }
        else
        {
            return x * Factorial(x - 1);
        }
    }

}