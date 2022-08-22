using System;

class MainClass
{
    static void Main(string[] args)
    {

        Console.WriteLine(Factorial(20));

        //Console.ReadKey();
    }

    static decimal Factorial(decimal x)
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