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

void printColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}

string [] Fillarray (int length)
{
    printColor($"Введите элементы массива через enter: " , ConsoleColor.DarkCyan);
    string [] array = new string [length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Console.ReadLine()!;
    }
    return array;
}

void sortArray(string [] array)
{
    printColor($"Измененный массив [", ConsoleColor.DarkGreen);
    string[] newarr = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
                newarr[i] = array[i];
                printColor($"{newarr[i]} " , ConsoleColor.DarkRed);
        }
    }
    printColor($"]" , ConsoleColor.DarkGreen);
}
    
void printArray(string[] array)
{
    printColor($"Массив [" , ConsoleColor.DarkMagenta);
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length -1)
        {
        printColor($"{array[i]}, " , ConsoleColor.DarkYellow);
        }
        else
        {
        printColor($"{array[i]} ]" , ConsoleColor.DarkMagenta);
        }
    }
}        

int length = getUserData("Введите размерность массива");
string [] array = Fillarray(length);
printArray(array);
Console.WriteLine();
sortArray(array);