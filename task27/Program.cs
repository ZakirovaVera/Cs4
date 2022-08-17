﻿// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11 (4+5+2)
// 82 -> 10
// 9012 -> 12

Console.Clear();

int num = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");

Console.WriteLine("Cумма цифр в числе");

int sumDigits = GetSumDigits(num);
Console.WriteLine($"\t{num} -> {sumDigits}");

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

// Возвращает сумму цифр в числе number
int GetSumDigits(int number)
{
    int sum = 0;
    while (Math.Abs(number) > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}