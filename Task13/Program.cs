// Принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A(3,6); В(2,1) -> 5,09 
// A(7,-5); B(1,-1) -> 7,21

Console.WriteLine("Введите координаты точки A: ");
int ax = Convert.ToInt32(Console.ReadLine());
int ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
int bx = Convert.ToInt32(Console.ReadLine());
int by = Convert.ToInt32(Console.ReadLine());

double Dist(int aX, int aY, int bX, int bY)
{
    int catX = aX - bX;
    int catY = aY - bY;
    double distanse = Math.Sqrt(catX * catX + catY * catY);
    double res = Math.Round(distanse, 2, MidpointRounding.ToZero);   
    return (res);
}

double resault = Dist(ax, ay, bx, by);
Console.WriteLine(resault);

// double d = Math.Sqrt(45); // метод корень квадратный
// double res = Math.Round(d, 2, MidpointRounding.ToZero); // метод округление (число, до какого знака, правило округления, чтобы 0,099 превратилось не в 0,1, а в 0,09)
