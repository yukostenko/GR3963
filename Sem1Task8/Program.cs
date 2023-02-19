//Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// Считываем данные с консоли
string? inputLine = Console.ReadLine();

// Проверяем, чтобы данные были не пустыми
if (inputLine != null)
{
// Парсим введенное число
int inputNumber = int.Parse(inputLine);
int startNumber = 5;
string outLine = string.Empty;
while (startNumber < inputNumber-2)
{
    outLine = outLine + startNumber + ",";
    startNumber = startNumber + 2;
}
outLine = outLine + startNumber;
// выводим данные в консоль
Console.WriteLine(outLine);
}
