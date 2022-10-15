/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

int GetNumber(string message)
{
    Console.Clear();
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
        array[i] = rnd.Next(-10, 11);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
}

int SummOfNotEven(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        summ += array[i];
    }
    return summ;
}

int len = GetNumber("Введите размерность массива: ");
int[] array = ArrayInit(len);
int summ = SummOfNotEven(array);
PrintArray(array);
Console.WriteLine($"-> сумма нечетных элементов массива {summ}");