//Напишите программу, которая 
//1. на вход принимает число
//2. и выдает его квадрат

//Например:
//4 -> 16
Console.Clear();
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine()); //переводит строку в число, в данном случае
Console.Write($"Квадрат числа {number} = {number*number}"); //позволяет включить переменные в текст вывода
