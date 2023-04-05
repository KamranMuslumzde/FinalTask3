// Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длинна которых меньше или равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.WriteLine("Введите строки массива через пробел: ");
string[] array1 = Console.ReadLine()!.Split(' ');
string[] array2 = new string[array1.Length];
int count = 0;
for(int i = 0; i < array1.Length; i++)
{
    if(array1[i].Length <= 3)
    {
        array2[count] = array1[i];
        count++;
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(array2);