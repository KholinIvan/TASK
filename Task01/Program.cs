// 1. Программа на вход принимает число и
// 2. выдаёт квадрат этого числа
// Например:
// 4 -> 16
// -3 -> 9

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

// string str = Console.ReadLine();
// int number = Convert.ToInt32(str);

int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");