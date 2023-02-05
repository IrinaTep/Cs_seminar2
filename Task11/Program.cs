/*
Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого
числа.
456 -> 46
782 -> 72
918 -> 98
*/

int randomNumber = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число => {randomNumber}");
int finishNumber = GetNumber(randomNumber);
Console.WriteLine($"Конечное число => {finishNumber}");

GetNumber(randomNumber);

int GetNumber(int number)
{
    int firstNumber = number / 100;
    int secondNumber = number % 10;

    int result = firstNumber * 10 + secondNumber;
    return result;
}

