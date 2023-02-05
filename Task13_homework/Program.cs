/*
Напишите программу, которая выводит
третью цифру заданного числа или сообщает, что третьей
цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 0) number = number * -1;

if(number / 100 < 1)
{
    Console.Write("Третьей цифры нет");
}
else 
{
    while(number > 999)
    {
        number = number / 10;
    }
    number = number % 10;

    Console.Write(number);
}
*/


int DivisionByTen(string par, int num)
// division - возвращаем результат деления на 10
// modulo - возвращаем остаток от деления на 10
{
    if (par == "division") return(num / 10);
    if (par == "modulo")   return(num % 10);
    return 0;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = number * -1;

if (number / 100 < 1)
{
    Console.Write("Третьей цифры нет");
}
else
{
    while (number > 999)
    {
        number = DivisionByTen("division", number);
    }
    number = DivisionByTen("modulo", number);

    Console.Write(number);
}
