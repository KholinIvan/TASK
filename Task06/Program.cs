// Задача 9. Выводит случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа:
// 
// 78 -> 8
// 12 -> 2
// 85 -> 8

int number = new Random().Next(10, 100); // последнее число не включается в диапазон, поэтому ставим 100
Console.WriteLine($"Случайное число из отрезка 10-99 -> {number}");

int firstDigit = number / 10; // 78 / 10 =7 (целочисленное деление, т.к. переменная у нас int)
int secondDigit = number % 10; // 78 % 10 = 8 (деление с остатком)

if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа равна {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа равна {secondDigit}");

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; -> тернарный оператор
// (если условие выполняется, тогда (?) переменной присваивается первое значение, иначе (:) второе)
// Console.WriteLine($"Наибольшая цифра числа равна {maxDigit}");

// Console.Write($"Наибольшая цифра числа {number} равна ");
// Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit); -> без использования переменной int maxDigit