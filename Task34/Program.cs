/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int GetNumber(string message)
{
    int result = 0;
    bool isCorect = false;

    while (!isCorect)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result))
            isCorect = true;
        else
        {
            Console.Clear();
            Console.WriteLine("Введено не число. Повторите ввод.");
        }
    }
    return result;
}

int[] ArrayInit(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

int EvenCount(int[] array)
{
    int count = 0;

    foreach (int item in array)
    {
        if (item % 2 == 0)
            count += 1;
    }
    return count;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
}

Console.Clear();
int len = GetNumber("Веедите размерность массива: ");
int[] array = ArrayInit(len);
int countsOfEven = EvenCount(array);
PrintArray(array);
Console.WriteLine($"-> {countsOfEven} четных чисел в массиве");
