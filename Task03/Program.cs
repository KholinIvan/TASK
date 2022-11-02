// Выдаёт название дня недели по заданному номеру:
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите целое число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
   Console.WriteLine($"Числу {number} соответствует день недели ПОНЕДЕЛЬНИК");
}
if (number == 2)
{
   Console.WriteLine($"Числу {number} соответствует день недели ВТОРНИК");
}
if (number == 3)
{
   Console.WriteLine($"Числу {number} соответствует день недели СРЕДА");
}
if (number == 4)
{
   Console.WriteLine($"Числу {number} соответствует день недели ЧЕТВЕРГ");
}
if (number == 5)
{
   Console.WriteLine($"Числу {number} соответствует день недели ПЯТНИЦА");
}
if (number == 6)
{
   Console.WriteLine($"Числу {number} соответствует день недели СУББОТА");
}
if (number == 7)
{
   Console.WriteLine($"Числу {number} соответствует день недели ВОСКРЕСЕНЬЕ");
}
else (number > 7 || number < 1);
{
   Console.WriteLine($"Числу {number} не соответствует день недели");
}