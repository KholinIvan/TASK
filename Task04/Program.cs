// Вводит натуральное число и выводит все значения от - этого числа до + этого числа:
// 4 -> -4 -3 -2 -1 0 1 2 3 4 

Console.WriteLine("Введите целое число больше нуля: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int count = -number;
    while (count <= number)
    {
        Console.Write($"{count} ");
        count++;
        // count = count + 1;
    }
}
else Console.WriteLine("Введите целое положительное число!");