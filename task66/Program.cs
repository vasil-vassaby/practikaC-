// Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int m, int n)
{
    if (m == 0) return (n * (n + 1)) / 2;            
    else if (n == 0) return (m * (m + 1)) / 2;       
    else if (m == n) return m;                       
    else if (m < n) return n + SumNumbers(m, n - 1); 
    return n + SumNumbers(m, n + 1);
}

if (numberM >= 0 && numberN >= 0)
{
    int result = SumNumbers(numberM, numberN);
    Console.WriteLine($"Сумма натуральных элементов в промежутке от {numberM} до {numberN} = {result}");
}
else Console.WriteLine($"Введите натуральные числа!");