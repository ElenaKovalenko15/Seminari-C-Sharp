﻿//Квадрат числа возвращает
Console.Write("Введите целое число: ");

string userInputStr = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInputStr);

//int userNumber = int.Parse(Console.ReadLine() ?? "");

//int result = (int)Math.Pow(userNumber, 2);

int result = userNumber * userNumber;

Console.WriteLine($"{userNumber} -> {result}");
