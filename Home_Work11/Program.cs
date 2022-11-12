// Задача 25:
// Цикл на вход принимает два числа (А и В) и возводит число А в натуральную степень В.
// 3, 5 -> 243
// 2, 4 -> 16

Console.WriteLine("Введите два числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int Degree(int num1, int num2)
{
int stor = num1;
    for (int i = 1; i < num2; i++)
    {
    stor *= num1; 
    }
return stor;
}

if (b > 0)
{
int result = Degree(a, b);
Console.WriteLine($"{a} в степени {b} = {result}");
}
else Console.WriteLine("Второе число должно быть натуральным, т.е. больше нуля");