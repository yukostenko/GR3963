﻿// Задача 12
//Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кртвным первому.
// Если второе число некратно первому, то  программа выводит остаток от деления. 

Console.Write("Введите первое число:");
int num1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число:");
int num2 = int.Parse(Console.ReadLine() ?? "0");
int rem = num1 % num2;
if (rem == 0)
{
    Console.WriteLine("Второе число кратно первому.");
}
else
{
   Console.WriteLine("Второе число некратно первому. Остаток " + (rem));
}

