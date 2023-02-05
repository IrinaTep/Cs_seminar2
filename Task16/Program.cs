/*
Напишите программу, которая принимает на
вход два числа и проверяет, является ли одно
число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/

bool Square(int firstNumber, int secondNumber)
{
    return((firstNumber * firstNumber == secondNumber) || (secondNumber * secondNumber == firstNumber));
}

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

bool result = Square(firstNumber, secondNumber);

/*
if(result) Console.WriteLine("Да");
else Console.WriteLine("Нет");
*/

string res = result ? "Да" : "Нет";

Console.WriteLine(res);