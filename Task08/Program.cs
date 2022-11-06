// Принимает на вход два числа и
// выводит является ли второе число кратным первому.
// Если число 1 не кратно числу 2, то выводим остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите два целых числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

int emainder = num1 % num2;
if (emainder == 0) Console.WriteLine($"Число {num1} кратно числу {num2}");
else Console.WriteLine($"Число {num1} не кратно числу {num2}, остаток: {emainder}");