// По заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (X и Y).

Console.Write("Введите четверть: ");
string num = Console.ReadLine();

string Quarter(string number)
{
    if (number == "1") return "X > 0 и Y > 0";
    if (number == "2") return "X < 0 и Y > 0";
    if (number == "3") return "X < 0 и Y < 0";   
    if (number == "4") return "X > 0 и Y < 0";
    return "Некорректный ввод";
}

string quarter = Quarter(num);
Console.WriteLine(quarter);