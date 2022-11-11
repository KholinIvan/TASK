// Принимает на вход число и выдаёт кол-во цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Count(int number)
{
    int count = 1;
    for (int i = 0; i < number; i++)
    {
        number = number / 10;
        count++;
    }
    return count;
}

int sum = Count(num);
Console.WriteLine($"Количество цифр в числе {num} -> {sum}");