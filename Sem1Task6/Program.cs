// Напишите программу, которая на вход принимает число и выдает,
// является ли число четным (делится ли оно на два без остатка).

// Считываем данные с консоли
string? inputLine = Console.ReadLine();
// Проверяем, чтобы данные не были пустыми
if (inputLine != null)

{
    // Парсим введенное число
    int inputNum = int.Parse(inputLine);
    // Определяем. является ли число четным
    bool outRasult = inputNum % 2 == 0;
    // Выводим данные в консоль
    Console.WriteLine(outRasult);
}
