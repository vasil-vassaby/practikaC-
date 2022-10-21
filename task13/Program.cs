// Напишите программу, которая 
// выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdDigit(int num)
{
    if (num > 100 && num < 1000) return num%10;
    else if (num < 100) return 0;
    else
    {
        while (num > 1000) num = num/10;
        return num%10;
    }
}

Console.Clear();
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int digit =  Math.Abs(number); // в случае ввода отрицательного числа

int result = ThirdDigit(digit);
string res = result > 0 
             ? $"Третья цифра числа {number} => {result}"
             : "Третьей цифры нет";
Console.Write(res);