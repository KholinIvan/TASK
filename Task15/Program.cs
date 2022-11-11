// Принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите целое положительное число");
int digit = Convert.ToInt32(Console.ReadLine());

void SumNum (int a)

{
if (a >= 1) 
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum = sum + i;
    }
Console.WriteLine($"Сумма чисел от 1 до {a} = {sum}");
}    
    
else Console.WriteLine("Некорректный ввод");
}

SumNum (digit);