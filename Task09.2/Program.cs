/*
Напишите программу, которая выводит
случайное число из отрезка [10, 99] и показывает
наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8
*/

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 => {number}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit}");


int maxDigit1 = MaxDigit(45);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit1}");

int maxDigit2 = MaxDigit(89);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit2}");


int MaxDigit(int num) // num = number
{
    int firstDigit = num / 10; // 7
    int secondDigit = num % 10; // 8
    if (firstDigit > secondDigit) return firstDigit;
    else return secondDigit;
}


int maxDigit3 = MaxDigit(12);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit3}");
