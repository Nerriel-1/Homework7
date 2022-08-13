// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} | ");
        }
        Console.WriteLine();
    }
}

void GetAverage(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum = sum + arr[i, j];
        }
        Console.WriteLine($"{ sum / arr.GetLength(0)} ");
    }
}

Console.WriteLine("Введите количество строк массива :");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива :");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 2, 9);

PrintArray(array);
GetAverage(array);