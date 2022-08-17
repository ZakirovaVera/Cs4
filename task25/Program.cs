// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int firstNum = GetNumberFromUser("Введите целое число 1: ", "Ошибка ввода!");
int secondNum = GetNumberFromUser("Введите целое число 2: ", "Ошибка ввода!");

int result = NumberToPowerNumber(firstNum, secondNum);

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

int NumberToPowerNumber(int number, int power)
{
    int numberPower = 1;
    for (int i = 1; i <= power; i++)
    {
        numberPower = numberPower * number;
    }
    return numberPower;
}
Console.WriteLine($"{firstNum} в степени {secondNum} = {result}");