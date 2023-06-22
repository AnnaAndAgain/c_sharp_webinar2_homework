﻿/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число:");
int N = Convert.ToInt32(Console.ReadLine());

if (((N > 99) & (N < 1000)) | ((N > -1000) & (N < -99)))
{
    int digit = (Math.Abs(N) % 100 - Math.Abs(N) % 10) / 10;
    Console.WriteLine($"Вторая цифра: {digit}");
}
else Console.WriteLine("Это не трехзначное число! Нехорошо обманывать компьютер.");