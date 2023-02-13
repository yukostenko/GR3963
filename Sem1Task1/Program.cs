// Задача №1
// Напишите программу, которая на вход принимает два числа 
// и проверяет, является ли первое число квадратом второго.

// ввод первого числа
Console.Write("Введите первое число: ");
string? numLine1 = Console.ReadLine();
// ввод второго числа
Console.Write("Введите второе число: ");
string? numLine2 = Console.ReadLine();

if (numLine1 != null && numLine2 != null)

{
    int num1 = int.Parse(numLine1);
    int num2 = int.Parse(numLine2);
    if (num2 * num2 == num1)
    {
        Console.WriteLine("Первое число является квадратом второго!");
    }
    else
    {
        Console.WriteLine("Первое число не является квадратом второго!");
    }
}

