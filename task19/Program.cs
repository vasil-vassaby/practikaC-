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

bool Palindrome(int num)
{
    int num1 = num;
    int num2 = 0;
    while (num1 > 0)
    {
        num2 = num2 * 10 + num1 % 10;
        num1 = num1 / 10;
    }
    if (num2 == num) return true;
    return false;
}

if (number >= 10000 && number < 100000)
{
    bool result = Palindrome(number);
    if (result) Console.Write($"Число {number} является палиндромом");
    else Console.Write($"Число {number} не является палиндромом");
}
else Console.Write("Введите натуральное пятизначное число!");