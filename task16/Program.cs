// Написать программу, которая
//будет принимать на вход два числа
//и проверяет является ли одно число квадратом второго

Console.Clear();
Console.Write("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a*a == b || b*b ==a) Console.Write("Да");
else Console.Write("Нет");