// Задача 69.
//Напишите программу, которая будет принимать два числа A и B, 
// и она возведет А в степень В с помощью рекурсии.

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

long RecPow(int a, int b) //Pow метод возведения в степень
{
    if (b <= 1) return a;
    else
    {
        return a * RecPow(a, b - 1);
    }
}
long MyPow(int a, int b)
{
    if (b == 2)
    {
        return 4;
    }
    else
    {
        return MyPow(a, b / 2) * MyPow(a, b / 2);
    }
}


Console.Clear();
int numberA = ReadData("Введите число A: ");
int numberB = ReadData("Введите число B: ");
long res = RecPow(numberA, numberB);
long res1 = MyPow(numberA, numberB);
PrintResult($"Результат возведения числа А в степень  В равен: {res}");
Console.WriteLine();
PrintResult($"Результат возведения числа А в степень В равен: {res1}");