﻿// Написать программу, которая
//будет принимать на вход два числа
//и выводить является ли первое значение кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток деления
//34, 5 - не кратно, остаток 4


Console.Clear();
Console.Write("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a % b == 0) Console.Write("Кратно");
else Console.Write($"Не кратно, остаток {a % b}");