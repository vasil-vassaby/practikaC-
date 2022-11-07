// программа: принимает на ввод число N и выводит произведение чисел от 1 до N
//5 -> 120

Console.Clear();
Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

int ProductOfNumbers(int num)
{
    int product = 1; //если накопитель, в счетчике нельзя использовать
    for (int i = 1; i <= num; i++) product *= i;
    return product;
}

int productOfNumbers = ProductOfNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {productOfNumbers}");