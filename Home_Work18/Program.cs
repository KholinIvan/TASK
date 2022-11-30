// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите по очереди числа: b1, k1, b2 и k2 для уравнений: Y = k1 * X + b1, Y = k2 * X + b2: ");
int b1 = Convert.ToInt32(Console.ReadLine());
int k1 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());
int k2 = Convert.ToInt32(Console.ReadLine());

double IntersectionPointX(int c1, int m1, int c2, int m2)
{
    return ((double)(c1 - c2) / (m2 - m1));
}

double IntersectionPointY(double z, int c1, int m1)
{
    return (m1 * z + c1);
}

if (k1 == k2 && b1 == b2) Console.WriteLine("У этих прямых нет точки пересечения, т.к. они лежат одна на другой");
else if (k1 == k2) Console.WriteLine("У этих прямых нет точки пересечения, т.к. они параллельны");
else if (b1 == b2) Console.WriteLine($"Точка пересечения двух прямых: (0; {b1})");
else
{
    double x = IntersectionPointX(b1, k1, b2, k2);
    double y = IntersectionPointY(x, b1, k1);
    Console.WriteLine($"Точка пересечения двух прямых: ({x}; {y})");
}


// y = 5x + 2
// y = 9x + 4

// 5x + 2 = 9x + 4
// -4x = 2
// x = -0,5

// y = -2,5 + 2 = -0,5