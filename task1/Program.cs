﻿// Задача . Напишите программу , которая будет выдавать название дня недели по числу.

Console.WriteLine("Введите день недели");
int weekDay = int.Parse(Console.ReadLine()!);
if (weekDay == 1)
{
    Console.WriteLine("Понедельник");
}
else if (weekDay == 2)
{
    Console.WriteLine("Вторник");
}
else if (weekDay == 3)
{
    Console.WriteLine("Среда");
}
else if (weekDay == 4)
{
    Console.WriteLine("Четверг");
}
else if (weekDay == 5)
{
    Console.WriteLine("Пятница");
}
else if (weekDay == 6)
{
    Console.WriteLine("Суббота");
}
else if (weekDay == 7)
{
    Console.WriteLine("Воскресенье");
}
else 
{
    Console.WriteLine("Вы ввели не верное значение");
}