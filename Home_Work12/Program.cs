// Задача 27:
// Принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

int SumNum(int num)
{
int count = 0;
while (num > 0)
{
count = count + num % 10;
num = num / 10;
}
return count;
}

int sum = SumNum(number);
Console.WriteLine($"Сумма цифр числа {number} = {sum}");