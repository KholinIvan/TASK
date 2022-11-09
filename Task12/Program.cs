// По заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (X и Y).

Console.Write("Введите четверть: ");
int num = Convert.ToInt32(Console.ReadLine());

string Quarter(int number)
{
    if (number == 1) return "X > 0 и Y > 0";
    if (number == 2) return "X < 0 и Y > 0";
    if (number == 3) return "X < 0 и Y < 0";   
    if (number == 4) return "X > 0 и Y < 0";
    return "Введите корректное значение номера четверти (это цифры: 1, 2, 3 или 4)";
}

string quarter = Quarter(num);
Console.WriteLine(quarter);