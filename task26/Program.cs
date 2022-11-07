// программа: принимает на ввод число  и выводит кол-во цифр в числе
//7 -> 28

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int NumberOfDigits(int num)
{
    num = Math.Abs(num);
    int count = 0;
    while (num > 0) // его лучше использовать когда неизвестно кол-во итераций
    {
        num = num / 10;
        count++;
    }
    return count > 0 ? count : 1;
}

int numberOfDigits = NumberOfDigits(number);
Console.WriteLine($"Количество цифр в числе {number} = {numberOfDigits}");
