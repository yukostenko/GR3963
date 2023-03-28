// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// Печать результата
void PrintResult(string prefix)
{
    Console.Write(prefix);
}

// Рекуретный метод
int RecSumDigMN(int m, int n)
{
    if (m >= n)
    {
        return n; // точка остановки рекурсии
    }
    else
    {
        return m + RecSumDigMN(m + 1, n);
    }

}

int numberM = ReadData("Введите число M: ");
int numberN = ReadData("Введите число N: ");
int result = numberM < numberN ? RecSumDigMN(numberM, numberN) : RecSumDigMN(numberN, numberM);
PrintResult($"{result}");
