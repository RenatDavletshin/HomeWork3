﻿// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(num / 10 % 10);