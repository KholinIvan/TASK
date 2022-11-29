// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ConvertToBin(int num10)
{
    int num2 = 0;
    int i = 10;
    while (num10 > 0)
    {
        num2 += num10 % 2;
        if (num2 == 0)
        {
            while (num10 > 0)
            {
                num2 = num2 + i;
                i = i * 10;
                num10 /= 2;
            }
        }
        else
        {
            num2 *= 10;
            num10 /= 2;
        }
    }
    return num2;
}

int RevertNumber(int par)
{
    int result = default;
    while (par > 9)
    {
        result += par % 10;
        result *= 10;
        par /= 10;
    }
    result += par % 10;
    return result;
}

int nuM = ConvertToBin(number);
int num = RevertNumber(nuM);
if (number % 2 == 0) Console.WriteLine(num - 1);
else Console.WriteLine(num);



// Вариант:
// Console.WriteLine("Введите число в десятичной системе счисления: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int Binare(int num)
// {
//     string st = "";
//     while (num > 0)
//     {
//         string temp = Convert.ToString(num % 2);
//         st = temp + st;
//         num = num / 2;
//     }
//     int bin = Convert.ToInt32(st);
//     return bin;
// }

// Console.WriteLine($"Число {number} в двоичной системе счисления выглядит так: {Binare(number)}");