// Напишите программу, которая на вход принимает два числа
// и выдает, какое число большее, в какое меньшее.

// Ввод первого числа.
Console.Write("Введите первое число: ");
string? numLineA = Console.ReadLine();
// Ввод второго числа.
Console.Write("Введите второе число: ");
string? numLineB = Console.ReadLine();
// Проверяем, чтобы данные не были пустыми.
if (numLineA != null && numLineB != null)

{
    // Парсим введеные числа.
    int numA = int.Parse(numLineA);
    int numB = int.Parse(numLineB);

    int max = numA;
    int min = numB;

    if (numA > numB) max = numA; min = numB;
    if (numB > numA) max = numB; min = numA;
    {
        Console.Write("max = " + numA);
        Console.WriteLine("min = " + numB);
    }
}


