// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2} ");
            else Console.Write($"{matrix[i, j],2}");
        }
        Console.WriteLine(" |");
    }
}

double[] AverageSumColumn(int[,] column)
{
    double[] sum = new double[column.GetLength(1)];
    for (int j = 0; j < column.GetLength(1); j++)
    {
        for (int i = 0; i < column.GetLength(0); i++)
        {
            sum[j] += column[i, j];
        }
        sum[j] = Math.Round((double)(sum[j] / column.GetLength(0)), 1, MidpointRounding.ToZero);
    }
    return sum;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[,] array2D = CreateMatrixRndInt(3, 4, 0, 9);
PrintMatrix(array2D);

Console.WriteLine();

double[] averageSumColumn = AverageSumColumn(array2D);
Console.WriteLine("Среднее арифметическое элементов в каждом столбце массива:");
PrintArray(averageSumColumn);