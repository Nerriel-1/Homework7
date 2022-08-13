//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.


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

void CheckArray(int[,] arr, int m, int n)
{
    if ((m > arr.GetLength(0) | n > arr.GetLength(1)))
    { Console.WriteLine("Нет такого числа"); }
    else
    { Console.WriteLine($"значение элемента строки {m} и столбца {n} равно {arr[m, n]}"); }

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

Console.WriteLine("Введите количество строку массива :");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбец массива :");
int n = int.Parse(Console.ReadLine());

int rows = new Random().Next(2,5);
int columns = new Random().Next(2,5);

int[,] array = GetArray(rows, columns, 1, 9);

PrintArray(array);
CheckArray(array, m, n);
