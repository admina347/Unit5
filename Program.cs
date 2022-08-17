using System;

static int[] GetArrayFromConsole() {
  var result = new int[5];

  for (int i = 0; i < result.Length; i++) {
    Console.WriteLine("Введите элемент массива номер {0}", i + 1);
    result[i] = int.Parse(Console.ReadLine());
  }

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

		foreach(var item in result)
		{
			Console.Write(item);
		}

  return result;
}

GetArrayFromConsole();