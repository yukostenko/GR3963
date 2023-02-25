// Задача 11
// Напишите программу, которая выводит случайное
// трехзначное число и удаляет второую цифру этого числа

int num = new Random().Next(100, 1000);
Console.WriteLine("Случайное число - " + num);
int lastDigit = num % 10;
int firstDigit = num / 100;
num = firstDigit*10+lastDigit;
Console.WriteLine("Результат работы - " + num);

//Console.WriteLine((num / 100)*10+(num % 10));
