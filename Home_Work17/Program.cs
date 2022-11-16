// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Сколько чисел будете вводить?");
int amount = Convert.ToInt32(Console.ReadLine());

int[] EnterNumbers(int amo)
{
    Console.WriteLine("Введите числа: ");
    int[] array = new int[amo];
    for (int i = 0; i < amo; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int AboveZero(int[] array, int amo)
{
    int count = 0;
    for (int i = 0; i < amo; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

if (amount <= 0) Console.WriteLine("Нужна цифра больше нуля");
else
{
    int[] numbers = EnterNumbers(amount);
    int aboveZero = AboveZero(numbers, amount);

    if (aboveZero == 1) Console.WriteLine($"Вы ввели одно число больше 0");
    else if (aboveZero == 2 || aboveZero == 3 || aboveZero == 4) Console.WriteLine($"Вы ввели {aboveZero} числа больше 0");
    else Console.WriteLine($"Вы ввели {aboveZero} чисел больше 0");
}