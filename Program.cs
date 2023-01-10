// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите строки массива через enter: ");

string[] array = new string[4];

CreateArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
ExamArray(array);

void CreateArray(string[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
}
void PrintArray(string[] inArray)
{
    Console.Write("Введенный масив: [");
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Console.Write($"{inArray[i]}, ");
    }
    Console.Write("]");
}

void ExamArray(string[] array)
{
    Console.Write("Новый масив: [");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write($"{array[i]} ,");
        }
    }
    Console.Write("]");
}