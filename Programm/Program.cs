// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1)
            Console.Write(", ");

        else
        {
            Console.Write(".");
        }
    }
}

string[] SortArray(string[] array)
{
    int index = 0;
    string[] newArray = new string[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[index] = array[i];
            index++;
        }
    }

    Array.Resize(ref newArray, index);
    return newArray;
}

void start()
{
    Console.WriteLine("Задайте размер массива: ");
    int arrayLen = int.Parse(Console.ReadLine());

    string[] wordArray = new string[arrayLen];
    FillArray(wordArray);

    Console.WriteLine("Первоначальный массив: ");
    PrintArray(wordArray);

    Console.WriteLine();

    Console.WriteLine("Новый массив: ");
    PrintArray(SortArray(wordArray));
}

start();