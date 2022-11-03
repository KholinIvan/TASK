// Вводит трёхзначное число, выводит последнюю цифру этого числа.
// 387 -> 7

Console.WriteLine("Введите целое трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int lastDigit = number % 10; // 387 % 10 = 7 (деление с остатком, 387/10 = 38,7 -> остаток 7, что нам и нужно)
Console.WriteLine($"Последняя цифра числа {number}: {lastDigit}");