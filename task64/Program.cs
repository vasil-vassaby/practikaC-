// Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int num)
{
    if (num > 0)
    {
        int i = 0;
        Console.Write(i < num - 1 ? $"{num}, " : $"{num} ");
        i--;
        NaturalNumbers(num - 1);
    }

}

NaturalNumbers(number);