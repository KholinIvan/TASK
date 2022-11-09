// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A по осям X,Y,Z: ");
int ax = Convert.ToInt32(Console.ReadLine());
int ay = Convert.ToInt32(Console.ReadLine());
int az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B по осям X,Y,Z: ");
int bx = Convert.ToInt32(Console.ReadLine());
int by = Convert.ToInt32(Console.ReadLine());
int bz = Convert.ToInt32(Console.ReadLine());

double Dist(int aX, int aY, int aZ, int bX, int bY, int bZ)
{
    int catX = aX - bX;
    int catY = aY - bY;
    int catZ = aZ - bZ;
    double distanse = Math.Sqrt(catX*catX + catY*catY + catZ*catZ);
    double res = Math.Round(distanse, 2, MidpointRounding.ToZero);   
    return (res);
}

double resault = Dist(ax, ay, az, bx, by, bz);
Console.WriteLine($"Расстояние между точками А и В в 3D-пространстве составляет: {resault}");