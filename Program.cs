using System;

class Program
{
    static void Main(string[] args)
    {
        var someName = "Евгения";
        var someAge = 20;
        Console.WriteLine(someName);

        GetName(ref someName);

        Console.WriteLine(someName);

        ChangeAge(someAge);

        Console.WriteLine(someAge);

        Console.ReadKey();
    }
    static void GetName(ref string name)
    {
        Console.WriteLine("Введите имя");
        name = Console.ReadLine();

    }

    static void ChangeAge(int age)
    {
        Console.WriteLine("Введите Возраст");
        age = Convert.ToInt32(Console.ReadLine());

    }

}
