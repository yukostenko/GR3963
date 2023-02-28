﻿// Задача №22
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод выводит таблицу квадратов
string LineBuilder (int num, int pow)
{
    string res = String.Empty;
    for (int i = 1; i <= num; i++)
    {
        res = res + Math.Pow(i, pow) + "\t ";
    }
    return res;
}

int num = ReadData("Введите число: ");
Console.WriteLine(LineBuilder(num,1));
Console.WriteLine(LineBuilder(num,2));

