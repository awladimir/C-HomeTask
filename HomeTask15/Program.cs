﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int n = int.Parse(Console.ReadLine());
if ( n <= 5)
{
    Console.WriteLine("Вы ввели " + n + " это будний день недели");
    if ( n < 1)
    Console.WriteLine("Вы ошиблись введите цифру заново ");
}
else
{
    if( n == 6 )
Console.WriteLine("Вы ввели " + n + " это выходной день недели");

    if( n == 7 )
Console.WriteLine("Вы ввели " + n + " это выходной день недели");
if(n >7)
{
    Console.WriteLine("Вы ошиблись введите цифру заново ");
}
}