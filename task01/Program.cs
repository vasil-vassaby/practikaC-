﻿// 1. Напишите программу, которая 
//на вход принимает два числа 
//и проверяет, является ли первое число квадратом второго.
//Пример:
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
//a = -3 b = 9 -> нет

Console.Write("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b*b) Console.Write("Верно");
else Console.Write("Не верно");