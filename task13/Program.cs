// Напишите программу, которая 
// выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdDigit(int num)
{
    if (num > 100 && num < 1000) return num%10;
    else
    {
        while (num > 1000) num = num/10;
        return num%10;
    }
}

Console.Clear();
Console.Write("Введите целое число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number < 100) Console.Write("Третьей цифры нет");      
else 
{
    int result = ThirdDigit(number);
    Console.Write($"Третья цифра числа {number} => {result}");
}