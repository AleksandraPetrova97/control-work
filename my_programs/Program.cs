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

int length = getUserData("Введите размерность массива");

string [] Fillarray (int length)
{
    Console.Write($"Введите элемент: ");
    string [] array = new string [length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Console.ReadLine()!;
    }
    return array;
}
string [] array = Fillarray(length);


void sortArray(string [] array)
{
    Console.Write($" Измененный массив [");
    string[] newarr = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
                newarr[i] = array[i];
                Console.Write($"{newarr[i]} ");
        }
    }
    Console.Write($"]");
}
    

void printArray(string[] array)
{
    Console.Write($"Массив [");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length -1)
        {
        Console.Write($"{array[i]},");
        }
        else
        {
        Console.WriteLine($"{array[i]}]");
        }
    }
}        
printArray(array);
sortArray(array);