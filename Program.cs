using System;

static int[] GetArrayFromConsole()
{

    var result = new int[5];

    for (int i = 0; i < result.Length; i++)
    {
        Console.WriteLine("Введите элемент массива номер {0}", i + 1);
        result[i] = int.Parse(Console.ReadLine());
    }

    return result;
}

static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
{
    sortedasc = SortArrayAsc(array);
    Console.WriteLine("\nСортировка массива от меньшего к большему: ");
    foreach (var item in sortedasc)
    {
        Console.Write(item);
    }

    sorteddesc = SortArrayDesc(array);
    Console.WriteLine("\nСортировка массива от большего к меньшему: ");
    foreach (var item in sorteddesc)
    {
        Console.Write(item);
    }
    

}

static int[] SortArrayAsc(int[] result)
{
    int temp = 0;

    for (int i = 0; i < result.Length; i++)
    {
        for (int j = i + 1; j < result.Length; j++)
        {
            if (result[i] > result[j])
            {
                temp = result[i];
                result[i] = result[j];
                result[j] = temp;
            }
        }
    }

    return result;
}

static int[] SortArrayDesc(int[] result)
{
    int temp = 0;

    for (int i = 0; i < result.Length; i++)
    {
        for (int j = i + 1; j < result.Length; j++)
        {
            if (result[i] < result[j])
            {
                temp = result[i];
                result[i] = result[j];
                result[j] = temp;
            }
        }
    }

    return result;
}

int[] array = GetArrayFromConsole();

Console.WriteLine("Вы ввели: ");

foreach (var item in array)
{
    Console.Write(item);
}

int[] desc, asc;
SortArray(array, out desc, out asc);

//Console.WriteLine("\nСортировка: ");



Console.ReadKey();