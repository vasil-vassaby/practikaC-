// Напишите программу которая 
//выводит случайное трехзначное число 
//и удаляет вторую цифру этого числа
//456 -> 46
//82 -> 72

Console.Clear();
int ran = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число => {ran}");

//int firstDigit = ran / 100; 
//int thirdDigit = ran % 10; 
//int result = firstDigit*10 + thirdDigit;
//Console.WriteLine($"Полученное число = {result}");

int DelSecondDigit(int random)
{
    int firstDigit = ran / 100; 
    int thirdDigit = ran % 10; 
    return firstDigit*10 + thirdDigit;
}
int result = DelSecondDigit(ran);
Console.WriteLine($"Полученное число = {result}");