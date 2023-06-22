﻿/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите номер дня недели (число от 1 до 7), и я скажу, выходной ли это. Мы в России, поэтому первый день недели - понедельник.");

int dayNum = Convert.ToInt32(Console.ReadLine());

if ((dayNum > 0)&(dayNum<6)) Console.WriteLine($"День номер {dayNum} — не выходной.");
else if ((dayNum == 6)|(dayNum == 7)) Console.WriteLine($"День номер {dayNum} — выходной.");
else Console.WriteLine("Вы меня обманываете, дня с таким номером нет!");