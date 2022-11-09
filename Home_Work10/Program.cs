// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

// Math.Pow(2, 10); число 2 в степени 10

Console.WriteLine("Введите число (N): ");
int n = Convert.ToInt32(Console.ReadLine());

void TableOfСubes(int number)
{
    if (number > 0)
    {
        for (int i = 1; i <= number; i++)
        {
        Console.WriteLine($"{i,5} | {Math.Pow(i, 3)}");
        }
    }
    else Console.WriteLine("Введите натуральное число");
}

TableOfСubes(n);