﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"Вторая цифра этого числа: {(num/10)%10}");