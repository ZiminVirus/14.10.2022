// Задача 27: Напишите программу, которая 
// принимает на вход число и 
// выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int sumDigitNum = SumDigitNum (num);

Console.WriteLine ($"{num} -> {sumDigitNum}");

int SumDigitNum(int numb)
{
int count = 1;
int sum = default;
int numb2 = 0;
    while (count < numb)
    {
        numb2 = (numb/count)% 10;
        count = count * 10;
        sum += numb2;
    }
    return (sum);
}