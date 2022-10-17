//напишите программу, которая 
//выводит случайное число из отрезка [10, 99] 
//и показывает наибольшую цифру числа

//78 -> 8
//12 -> 2
//85 -> 8

Console.Clear();
int ran = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 => {ran}");

//int firstDigit = ran / 10; // 78/10= 7
//int secondDigit = ran % 10; // 78%10= 8

//if (secondDigit > firstDigit) Console.WriteLine($"Максимальная цифра числа = {secondDigit}");
//else Console.WriteLine($"Максимальная цифра числа = {firstDigit}");

//int res = Math.Max(firstDigit, secondDigit);
//Console.WriteLine($"Максимальная цифра числа = {res}");

//тернарный оператор 1
//int maxDigit = secondDigit > firstDigit ? secondDigit : firstDigit;
//Console.WriteLine($"Максимальная цифра числа = {maxDigit}");

//условный оператор
//int result = default; //значение по умолчанию для инт это 0
//if (secondDigit > firstDigit) result = secondDigit;
//else result = firstDigit;
//Console.WriteLine($"Максимальная цифра числа = {result}");

//тернарный оператор 2
//Console.WriteLine($"Максимальная цифра {ran} равна");
//Console.WriteLine(secondDigit > firstDigit ? secondDigit : firstDigit);

int MaxDigit(int random)
//тип, имя с большой буквы, аргументы
{
    int firstDigit = random / 10; 
    int secondDigit = random % 10; 
    return secondDigit > firstDigit ? secondDigit : firstDigit;
}
int maxDigit = MaxDigit(ran);
Console.WriteLine($"Наибольшая цифра числа {ran} = {maxDigit}");