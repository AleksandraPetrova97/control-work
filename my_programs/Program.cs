// Написать программу, которая из имеющигося массива строк
//формирует массив из строк, длина которых меньше 
//либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int getUserData(string message)
{
    Console.WriteLine(message);
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}

string [] GetArray (int length, int start, int end)
{
    string [] array = new string [length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}


void printArray(string[] array)
{
    Console.Write($"В массиве [");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length -1)
        {
        Console.Write($"{array[i]},");
        }
        else
        {
        Console.WriteLine($"{array[i]}] - {Sumnum} чётных чисел");
        }
    }
}