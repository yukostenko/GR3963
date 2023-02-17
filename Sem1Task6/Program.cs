// Напишите программу, которая на вход принимает число и выдает,
// является ли число четным (делится ли оно на два без остатка).

// Вводим число
Console.WriteLine("Введите число: ");
string? inputLine = Console.ReadLine();

if (inputLine != null)

{
    int inputNum = int.Parse(inputLine);
    int evenNum = inputNum % 2;
    while (inputNum % 2)
    {
    evenNum != inputNum % 2;
    evenNum = inputNum+1;
    }
   Console.WriteLine(evenNum +"Это число четное");
}
   