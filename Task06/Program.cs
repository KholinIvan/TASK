// Задача 9. Выводит случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа:
// 
// 78 -> 8
// 12 -> 2
// 85 -> 8

int number = new Random().Next(10, 100); // последнее число не включается в диапазон, поэтому ставим 100
Console.WriteLine($"Случайное число из отрезка 10-99 -> {number}");

// int firstDigit = number / 10; // 78 / 10 =7 (целочисленное деление, т.к. переменная у нас int)
// int secondDigit = number % 10; // 78 % 10 = 8 (деление с остатком)

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа равна {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа равна {secondDigit}");

// // Альтернативные способы:
// // Условный оператор:
// int result = default;
// if (firstDigit > secondDigit) result = firstDigit;
// else result = secondDigit;
// Console.WriteLine($"Наибольшая цифра числа равна {result}");
// // Тернарный оператор 1:
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; // если условие выполняется, тогда (?) переменной присваивается первое значение, иначе (:) второе
// Console.WriteLine($"Наибольшая цифра числа равна {maxDigit}");
// // Тернарный оператор 2:
// Console.Write($"Наибольшая цифра числа {number} равна ");
// Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit); // без использования переменной int maxDigit


int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа равна {maxDigit}");