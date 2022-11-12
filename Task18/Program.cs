// Выводит массив из 8 элементов, заполненный 0 и 1 в случайном порядке.
// [1,0,1,1,0,1,0,0]


// int[] array = new int[8]; // 0 0 0 0 0 0 0 0 (по умолчанию нули)

int number = 8;

int[] Array(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
    array[i] = new Random().Next(0, 2); // от 0 до 1, т.к. последнее 2 не учитывается
    }
    return array; 
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
    Console.Write(array[i]);
    if (i < array.Length - 1)
    {
       Console.Write(", "); 
    }
    }
    Console.Write("]");
}

int[] newArray = Array(number);
PrintArray(newArray);