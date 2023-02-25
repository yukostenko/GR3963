//Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int secondDigit = (num/10)%10;
{
Console.WriteLine("Вторая цифра числа: " + (secondDigit));
}


