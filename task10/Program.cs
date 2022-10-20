// Напишите программу, которая 
// принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit(int num)
{
    int num1 = num/10; // 456/10 = 45
    int num2 = num1 % 10; // 45%10 = 5
    return num2;
}

Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SecondDigit(number);
Console.Write($"Вторая цифра числа {number} => {result}");