﻿// Console.WriteLine("Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
// Console.WriteLine("Введите число А:");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число B:");
// int B = int.Parse(Console.ReadLine()!);
// int result = Result(A, B);
// Console.WriteLine($"Число {A} в степени {B} равно {result}");\

// int Result(int a, int b)
// {
//     int i = 0;
//     int result = 1;
//     while (i < b)
//     {
//         result = result * a;
//         i++;
//     }
//     return result;
// }


// Console.WriteLine("Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
// Console.WriteLine("Введите число ");
// int num = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма цифр в числе, которое Вы ввели {SumNums(num)}");

// int SumNums(int num) {
//     int sum = 0;
//     int i = 0;
// while (num > 0) {
//    sum = sum + num%10;
//    num = num/10;
//    i++;
// }
// return sum;
// }


Console.WriteLine("Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine()!);
string nums = num.ToString();
Console.WriteLine($"Сумма цифр в числе, которое Вы ввели {SumNums(nums)}");

int SumNums(string num)
{
    int lenght = num.Length;
    int sum = 0;
    int i = 0;
    while (i < lenght)
    {
        sum = sum + int.Parse(num[i].ToString());
        i++;
    }
    return sum;
}


// Console.WriteLine("Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");
// int[] array = Array(8);
// Console.WriteLine($"[{String.Join(',', array)}]");

// int[] Array(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(9);
//     }
//     return array;
// }