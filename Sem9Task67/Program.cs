// Задача 67.
//Напишите программу, которая принимает на вход число
// и возвращает сумму цифр этого числа.

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
int RecSumDig(int num)// RSD(12345)+RSD(1234)+RSD(123)+RSD(12)+RSD(1)+RSD(0)
{
    if (num == 0)
    {
        return 0;
    }
    else
    {
        return num % 10 + RecSumDig(num / 10);
    }
}
int numberM = ReadData("Введите число M: ");
int res = RecSumDig(numberM);
PrintResult($"{res}");
