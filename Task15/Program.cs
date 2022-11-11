// Принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// СДЕЛАЛ САМ:
// Console.WriteLine("Введите целое положительное число");
// int digit = Convert.ToInt32(Console.ReadLine());

// void SumNum (int a)

// {
// if (a >= 1) 
// {
//     int sum = 0;
//     for (int i = 1; i <= a; i++)
//     {
//         // sum = sum + i;
//         sum += i;
//     }
// Console.WriteLine($"Сумма чисел от 1 до {a} = {sum}");
// }    
    
// else Console.WriteLine("Некорректный ввод");
// }

// SumNum (digit);

// СДЕЛАЛИ НА СЕМИНАРЕ:
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNubers(int number)
{
    int sum = default; // значение не определено, чтобы было понятно при чтении кода (поэтому лучше не 0, а default)
    // bool b = default; - по умолчанию false
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

int sumNumbers = SumNubers(num);
Console.WriteLine($"Сумма чисел от 1 до {num} = {sumNumbers}");