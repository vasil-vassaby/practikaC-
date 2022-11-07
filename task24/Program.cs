// программа: принимает на ввод число А и выводит сумму данного числа от 1 до А
//7 -> 28

Console.Clear();
Console.Write("Введите число А: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num) 
{
    int sum = default; //если накопитель, в счетчике нельзя использовать
    for (int i = 1; i <= num; i++) sum += i;
    return sum;
}

int sumNumbers = SumNumbers(number);
 Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");