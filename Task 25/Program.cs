// Задача 25: Напишите цикл, 
// который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine ("Введите число A");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите число B");
int num2 = Convert.ToInt32 (Console.ReadLine());
int exponent = 1;
int exponention = Exponention (exponent, num1, num2);

int Exponention (int exp, int numb1, int numb2)
{
    int count = 1;
    while (count <= numb2)
    {
        exp = exp * numb1;
        count ++;
    }
    return (exp);
}
Console.WriteLine ($"{num1}, {num2} -> {exponention}");

