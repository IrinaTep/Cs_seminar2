/*
Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.
*/

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstDigit = number / 100;

if (firstDigit >= 1 && firstDigit <= 9)
{
    int thirdDigit = number % 10;
    int secondDigit = (number - (firstDigit * 100 + thirdDigit)) / 10;

    Console.WriteLine($"Вторая цифра числа {number} => {secondDigit}");
}
else Console.WriteLine("Некорректный ввод");


