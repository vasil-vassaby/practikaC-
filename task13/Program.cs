// Напишите программу, которая 
// выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdDigit(int num)
{
    while (num > 1000) num = num / 10;
    return num % 10;
}

Console.Clear();
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int digit = Math.Abs(number); // в случае ввода отрицательного числа

if (digit > 99)
{
    int result = ThirdDigit(digit);
    Console.Write($"Третья цифра числа {number} => {result}");
}
else Console.Write("Третьей цифры нет");