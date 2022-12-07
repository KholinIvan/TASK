// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите позицию элемента в двумерном массиве (строку и столбец): ");
int row = Convert.ToInt32(Console.ReadLine());
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};

void PrintPositionMatrix(int[,] mat, int x, int y)
{
    Console.WriteLine($"Значение элемента на данной позиции -> {mat[x, y]}");
}

if (row < 3 && column < 4) PrintPositionMatrix(matrix, row, column);
else Console.WriteLine($"Элемента на позиции {row}, {column} - нет");