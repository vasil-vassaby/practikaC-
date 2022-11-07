// программа: принимает на ввод число  и выводит кол-во цифр в числе
//7 -> 28

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int NumberOfDigits(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

int numberOfDigits = NumberOfDigits(number);
Console.WriteLine($"Количество цифр в числе {number} = {numberOfDigits}");
