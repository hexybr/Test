//Написать программу, которая из имеющегося массива строк формирует массив из строк,длинна которых меньше либо равна 3 символа.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Console.WriteLine("Введите количество элементов изначального масива:");
int index = int.Parse(Console.ReadLine()!);
string[] initial = new string[index];

void FillArray(string[] initial)
{
    Console.WriteLine($"Введите элементы изначального массива:");
    for (index = 0; index < initial.Length; index++)
    {
        initial[index] = Console.ReadLine()!;
    }
}
void PrintArray(string[] initial)
{
    Console.WriteLine("Исходный массив:");
    for (index = 0; index < initial.Length; index++)
    {
        Console.Write(initial[index] + " ");
    }
    Console.WriteLine();
}

void Sample(string[] initial)
{
    int index2 = 0;
    for (index = 0; index < initial.Length; index++)
    {
        if (initial[index].Length <= 3)
        {
            index2++;
        }
    }

    string[] second = new string[index2];

    for (index2 = 0; index2 < second.Length;)
    {
        for (index = 0; index < initial.Length; index++)
        {
            if (initial[index].Length <= 3)
            {
                second[index2] = initial[index];
            }
            index2++;
        }
    }


    Console.WriteLine("Выходной массив:");
    for (index2 = 0; index2 < second.Length; index2++)
    {
        Console.Write(second[index2] + " ");
    }
    Console.WriteLine();
}

FillArray(initial);
PrintArray(initial);
Sample(initial);