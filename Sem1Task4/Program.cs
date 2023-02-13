//Напишите программу, которая на вход принимает три числа 
// и выдает максимальное из этих чисел.

// Ввод первого числа.
Console.Write("Введите первое число: ");
string? numLineA = Console.ReadLine();
// Ввод второго числа.
Console.Write("Введите второе число: ");
string? numLineB = Console.ReadLine();
// Ввод третьего числа
Console.Write("Введите третье число: ");
string? numLineC = Console.ReadLine();
// Проверяем, чтобы данные были не пустими.
if (numLineA != null && numLineB != null && numLineC != null)

{
    // Парсим введеные числа.
    int numA = int.Parse(numLineA);
    int numB = int.Parse(numLineB);
    int numC = int.Parse(numLineC);
    // Назначаем максимальное число
    int max = numA;

    if (numA > max) max = numA;
    if (numB > max) max = numB;
    if (numC > max) max = numC;
    {
    Console.Write("max = "+max);
    }
}