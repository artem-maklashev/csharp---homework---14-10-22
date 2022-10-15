/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

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

double[] ArrayInit(int length)
{
    double[] array = new double[length];
    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = (double)rnd.Next(-10, 11);
    }
    return array;
}

void PrintArray(double[] array)
{
    foreach (double item in array)
    {
        Console.Write($"{item} ");
    }
}

(double max, double min) MaxMinElements(double[] array)
{
    double max = array[0];
    double min = array[0];

    foreach (var item in array)
    {
        if (item > max) max = item;
        if (item < min) min = item;
    }
    return (max, min);
}

int len = GetNumber("Введите размерность масиива: ");
double[] array = ArrayInit(len);
(double max, double min) = MaxMinElements(array);
double diff = max - min;
PrintArray(array);
Console.WriteLine($"\n=> {max} - ({min}) = {diff} тип числа {diff.GetType()}");
