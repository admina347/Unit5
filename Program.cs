using System;

class MainClass
{

    static string ShowColor(string username)
    {
        Console.WriteLine("{0} Напишите свой любимый цвет на английском с маленькой буквы: ", username);
        var color = Console.ReadLine();

        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Your color is default color yellow!");
                break;
        }

        return color;
    }

    public static void Main(string[] args)
    {

        (string name, int age) anketa;

        Console.Write("Введите имя: ");
        anketa.name = Console.ReadLine();
        Console.Write("Введите возраст с цифрами: ");
        anketa.age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя: {0}", anketa.name);
        Console.WriteLine("Ваш возраст: {0}", anketa.age);

        Console.ReadKey();



        var favcoloros = new string[3];
        for (int i = 0; i < favcoloros.Length; i++)
        {
            favcoloros[i] = ShowColor(anketa.name);
        }

        Console.WriteLine("Ваши любимые цвета: ");
        foreach (var color in favcoloros)
        {
            Console.WriteLine(color);
        }
        Console.ReadKey();

    }
}