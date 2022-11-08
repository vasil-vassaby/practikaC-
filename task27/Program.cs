// Напишите программу, которая 
// принимает на вход число и 
// выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumOfDigits(int num)
{
    num = Math.Abs(num);
    int sum = default;
    while (num > 0)
    {
        sum = sum + num % 10;
        num /= 10;
    }
    return sum;
}

int result = SumOfDigits(number);
Console.WriteLine($"Сумма цифр в числе {number} = {result}");