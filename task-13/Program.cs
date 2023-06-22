/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число:");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (N > 99) 
{
    while (N > 999) 
    {
        N = N / 10;
    }
    int digit = N%10;
    System.Console.WriteLine($"Третья цифра слева {digit}. Я хорошо угадываю?)");
}
else System.Console.WriteLine("третьей цифры нет");