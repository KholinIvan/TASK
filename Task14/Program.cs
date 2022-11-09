// Принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4

Console.WriteLine("Введите число (N): ");
int n = Convert.ToInt32(Console.ReadLine());

void TableOfSquares(int number)
{
    if (number > 0)
    {
        for (int i = 1; i <= number; i++)
        {
        Console.WriteLine($"{i,4} {i * i,4}"); // цифра 4 - отступ
        }
    }
    else Console.WriteLine("Введите натуральное число");
}

TableOfSquares(n);