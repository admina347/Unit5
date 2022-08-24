using System;

class Program
{
    static (string Name, string LastName, int Age, bool Pet, string[] Pets, string[] Colors) User; //Кортеж пользователя
    static void Main(string[] args)
    {
        //Полчить в кортеж данные которые ввел пользователь - возвращаемые методом
        User = GetUserInfo();
        //Вывести на экран данные пользователя передать данные кортежа в метод
        ShowUserInfo(User.Name, User.LastName, User.Age, User.Pet, User.Pets, User.Colors);
    }

    //Метод, который заполняет данные с клавиатуры по пользователю (возвращает кортеж): User
    static (string Name, string LastName, int Age, bool Pet, string[] Pets, string[] Colors) GetUserInfo()
    {
        string inputstr;    //Введенная строка
        int inputint;       //Введенная строка - число
        //Имя;
        do
        {
            Console.WriteLine("Введите Имя");
            inputstr = Console.ReadLine();
        } while (ChekStr(inputstr));
        User.Name = inputstr;
        //Фамилия;
        do
        {
            Console.WriteLine("Введите Фамилию");
            inputstr = Console.ReadLine();
        } while (ChekStr(inputstr));
        User.LastName = inputstr;
        //Возраст; 
        do
        {
            Console.WriteLine("Введите корректный возраст цифрами");
            inputstr = Console.ReadLine();
        } while (CheckNum(inputstr, out inputint));
        User.Age = inputint;
        //Наличие питомца;
        bool PetEx;
        do
        {
            Console.WriteLine("{0} Есть пиомцы? Да/Нет", User.Name);
            inputstr = Console.ReadLine();
        } while (ChekPets(inputstr, out PetEx));
        User.Pet = PetEx;
        //Если питомец есть, то запросить количество питомцев;
        if (User.Pet == true)
        {
            do
            {
                Console.WriteLine("{0} а сколько пиомцев? Введите число", User.Name);
                inputstr = Console.ReadLine();
            } while (CheckNum(inputstr, out inputint));
            //Если питомец есть, вызвать метод, принимающий на вход количество питомцев и возвращающий массив их кличек (заполнение с клавиатуры);
            User.Pets = CreateArrayPets(inputint);
        }//Нет питомцев - создать пустой массив
        else
        {
            User.Pets = new string[0];
        }        
        //Запросить количество любимых цветов;
        do
        {
            Console.WriteLine("{0} сколько любимых цветов? Введите число", User.Name);
            inputstr = Console.ReadLine();
        } while (CheckNum(inputstr, out inputint));
        //Вызвать метод, который возвращает массив любимых цветов по их количеству (заполнение с клавиатуры);
        User.Colors = CreateArrayColors(inputint);

        return User;
    }
    //Проверка числа
    static bool CheckNum(string number, out int cornumber)
    {
        if (int.TryParse(number, out int intnum))
        {
            //число
            if (intnum > 0 && intnum < 100)
            {
                cornumber = intnum;
                return false;
            }
        }
        {
            cornumber = 0;
            return true;
        }
    }
    //Проверка строки (исключить цифры)
    static bool ChekStr(string s)
    {
        foreach (var item in s)
        {
            if (char.IsDigit(item))
                return true; //если хоть один символ число, то выкидываешь true
        }
        return false; //если ни разу не выбило в цикле, значит, все символы - это буквы
    }
    //Проверка наличия питомца
    static bool ChekPets(string s, out bool petex)
    {
        if (s == "да" || s == "Да")
        {
            petex = true;
            return false;
        }
        if (s == "Нет" || s == "нет")
        {
            petex = false;
            return false;
        }
        petex = false;
        return true;
    }
    //Создать массив питомцев
    static string[] CreateArrayPets(int PetsCount)
    {
        var result = new string[PetsCount];
        string istr;   //Введенные данные
        for (int i = 0; i < result.Length; i++)
        {
            do
            {
                Console.WriteLine("Введите Имя питомца {0}", i + 1);
                istr = Console.ReadLine();
            } while (ChekStr(istr));  
            result[i] = istr;
        }
        return result;
    }
    //Создать массив любимых цветов
    static string[] CreateArrayColors(int ColorCount)
    {
        var result = new string[ColorCount];
        string istr;   //Введенные данные
        for (int i = 0; i < result.Length; i++)
        {
            do
            {
                Console.WriteLine("Введите любимый цвет номер {0} на английском с маленькой буквы", i + 1);
                istr = Console.ReadLine();
            }   while (ChekStr(istr));            
            result[i] = istr;
        }
        return result;
    }
    //Метод выводит на экран полученные от пользователя данные
    static void ShowUserInfo(string Name, string LastName, int Age, bool Pet, string[] Pets, string[] Colors)
    {
        Console.Clear();
        Console.WriteLine("5.6. Итоговый проект");
        Console.WriteLine("Анкета пользователя");
        Console.WriteLine("Имя: {0}", Name);
        Console.WriteLine("Фамилия: {0}", LastName);
        Console.WriteLine("Возраст: {0}", Age);
        if(Pet == true) 
        {
            Console.WriteLine("Наличие питомца: Да");
            Console.WriteLine("Количество питомцев: {0}", Pets.Length);
            Console.Write("Клички питомцев: ");
            for(int i = 0; i < Pets.Length; i++) 
            {
                if(i == Pets.Length - 1)
                Console.Write(Pets[i] + ".");
                else Console.Write(Pets[i] + ", ");
            }
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Наличие питомца: Нет");
        }
        Console.WriteLine("Количество любимых цветов: {0}", Colors.Length);
        Console.Write("Любимые цвета: ");
        for(int i = 0; i < Colors.Length; i++) 
        {
            if(i == Colors.Length - 1)
            Console.Write(Colors[i] + ".");
            else Console.Write(Colors[i] + ", ");
        }
        Console.WriteLine("");
        Console.ReadKey();
    }
}