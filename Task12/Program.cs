﻿/*
 Напишите программу, которая будет принимать на
вход два числа и выводить, является ли первое число
кратным второму. Если число 1 не кратно числу 2, то
программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/

int MultipleNum(int num1, int num2)
{
   return num1 % num2; 
}

Console.WriteLine("Введите два числа: ");

int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());

int remainder = MultipleNum(firstNumber, secondNumber);

if(remainder == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно, остаток {remainder}");
}


