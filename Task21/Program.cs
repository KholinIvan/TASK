// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

bool FindNumber(int[] array, int num)
{
    int i = 0;
    while (i < array.Length)
    {
        if (array[i] == num) return true;
        i++;
    }
    return false;
}


int[] arr = CreateArrayRndInt(5, 0, 1000);
PrintArray(arr);

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool findNumber = FindNumber(arr, number);

if (findNumber) Console.WriteLine("Данное число присутствует в массиве");
else Console.WriteLine("Данного числа в массиве нет");