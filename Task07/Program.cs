// Выводит случайное трёхзначное число и
// удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трёхзначное число -> {number}");

int Digit1 = number / 100;
int Digit3 = number % 10;
int newNumber = Digit1 * 10 + Digit3;

Console.WriteLine($"Число без второй цифры -> {newNumber}");