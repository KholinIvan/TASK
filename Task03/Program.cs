// Выдаёт название дня недели по заданному номеру:
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите целое число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 0 || number > 7)
{
   Console.WriteLine($"Числу {number} не соответствует день недели");
}
else if (number == 1)
{
   Console.WriteLine($"Числу {number} соответствует день недели ПОНЕДЕЛЬНИК");
}
else if (number == 2)
{
   Console.WriteLine($"Числу {number} соответствует день недели ВТОРНИК");
}
else if (number == 3)
{
   Console.WriteLine($"Числу {number} соответствует день недели СРЕДА");
}
else if (number == 4)
{
   Console.WriteLine($"Числу {number} соответствует день недели ЧЕТВЕРГ");
}
else if (number == 5)
{
   Console.WriteLine($"Числу {number} соответствует день недели ПЯТНИЦА");
}
else if (number == 6)
{
   Console.WriteLine($"Числу {number} соответствует день недели СУББОТА");
}
else if (number == 7)
{
   Console.WriteLine($"Числу {number} соответствует день недели ВОСКРЕСЕНЬЕ");
}