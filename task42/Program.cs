// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// int ConvertToBin(int num)
// {
//     int result = default;
//     while (num > 0)
//     {
//         result += num % 2;
//         result *= 10;
//         num /= 2;
//     }
//     return result;
// }

// int ReverseNumber(int par)
// {
//     int res = default;
//     while (par > 9 || par > 0)
//     {
//         res += par % 10;
//         res *= 10;
//         par /= 10;
//     }
//     res += par % 10;
//     return res;
// }

// Console.Write(ReverseNumber(ConvertToBin(number)));

int ReverseNumber(int num2)
{
    int result = default;
    while (num2 > 9)
    {
        result += num2 % 10;
        result *= 10;
        num2 /= 10;
    }
    result += num2 % 10;
    return result;
}


int ConvertToBin(int num)
{
    int res = default;

    while (num > 0)
    {
        res += num % 2;
        res *= 10;
        num /= 2;
        ConvertToBin(num);
    }
    return res;
}

int result = ConvertToBin(number);
int number2 = ReverseNumber(result);
Console.WriteLine(result);

Console.WriteLine(" введите число в десятичной системе");
int number = Convert.ToInt32(Console.ReadLine());

int Binare(int num)
{
    string st = "";
    while (num > 0)
    {
        string temp = Convert.ToString(num % 2);
        st = temp + st;
        num = num / 2;
    }

    int bin = Convert.ToInt32(st);
    return bin;
}
System.Console.WriteLine($"Число {number} в двоичной системе выглядит {Binare(number)}");
