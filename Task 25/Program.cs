﻿// Задача 25: Напишите цикл, 
// который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine ("Введите число A");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите число B");
int num2 = Convert.ToInt32 (Console.ReadLine());

double exp = (Math.Pow(num1, num2));

Console.WriteLine ($"{num1}, {num2} -> {exp}");

