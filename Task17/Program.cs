// Принимает на вход число N и выдаёт произведение чисел от 1 до N (факториал).
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Factorial(int n)
{
n = Math.Abs(n);
int factorial = 1;
int count = 1;
    for (int i = 0; i < n; i++)
    {
        factorial = factorial * count;
        count++;
    }
    return factorial;
}

int sum = Factorial(num);
Console.WriteLine($"Факториал {num} = {sum}");