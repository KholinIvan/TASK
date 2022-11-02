// Принимает на вход два числа и проверяет, является ли первое число квадратом второго.

Console.WriteLine("Введите два числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2 * num2)
{
    Console.WriteLine("Первое число является квадратом второго числа");
}
else
{
    Console.WriteLine("Первое число НЕ является квадратом второго числа");
}