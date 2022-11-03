// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три целых числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

int maxNumber = number2;
if (number1 > number2)
    {
        maxNumber = number1;
    }
if (maxNumber > number3)
    {
        Console.WriteLine($"Максимальное число из этих трёх: {maxNumber}");
    }
else Console.WriteLine($"Максимальное число из этих трёх: {number3}");