/*
Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/


/*
Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7)
{
    Console.WriteLine("Некорректный номер дня недели");
}
else if (number > 5)
{
    Console.WriteLine("Это выходной");
}
else
    Console.WriteLine("Это будний");
*/

bool CheckWeekDay(string par, int num)
{
    if (par == "correct")
        return(num < 1 || num > 7);
    else
        return(num > 5);
}

Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (CheckWeekDay("correct", number))
{
    Console.WriteLine("Некорректный номер дня недели");
}
else if (CheckWeekDay("holiday", number))
{
    Console.WriteLine("Это выходной");
}
else
    Console.WriteLine("Это будний");