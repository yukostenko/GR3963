// Напишите программу, которая на вход принимает два числа
// и выдает, какое число большее, в какое меньшее.

// ввод первого числа
Console.Write("Введите первое число: ");
string? numLineA = Console.ReadLine();
// ввод второго числа
Console.Write("Введите второе число: ");
string? numLineB = Console.ReadLine();

if (numLineA != null && numLineB != null)

{
    int numA = int.Parse(numLineA);
    int numB = int.Parse(numLineB);

    int max = numA;

    if (numA > max) max = numA;
    if (numB > max) max = numB;
    {
    Console.Write("max = "+max);
    }
}