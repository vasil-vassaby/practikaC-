// Напишите программу, которая 
// принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Palindrome(int num)
{
if (num >= 10000 && num < 100000)
{
    int num1 = num;
    int num2 = 0;
    while (num1 > 0)
    {
        num2 = num2 * 10 + num1 % 10;
        num1 = num1 / 10;
    }
    if (num2 == num) Console.Write($"Число {num} является палиндромом");
    else Console.Write($"Число {num} не является палиндромом");
}
else Console.Write("Введите натуральное пятизначное число!");
}
Palindrome(number);