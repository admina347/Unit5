static string ShowColor()
{
    return Console.ReadLine();


Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы: ");

var favcoloros = new string[3];
for (int i = 0; i < favcoloros.Length ; i++ )
{
    favcoloros[i] = ShowColor();
}

Console.WriteLine("Ваши любимые цвета: ");
foreach(var color in favcoloros)
{
    Console.WriteLine(color);
}
Console.ReadKey();