// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.

// Запрос данных у пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return numberP;
}

// Выводим данные от пользователя
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Считаем сумму чисел
long SumSimple(int numA)
{
    long sum = 0;
    for (int i = 1; i <=numA; i++)
    {
       sum+=i;
       // sum = sum+i;
    }
    return sum;
}

long SumGauss(int numA)
{
    return ((1 + (long)numA)*(long)numA)/2;
}


int numberA = ReadData("Введите число A: ");

DateTime d1 = DateTime.Now;
long res1 = SumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
long res2 = SumGauss(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Сумма чисел от 1 до A (первый метод) равна  " + res1);
PrintResult("Сумма чисел от 1 до A (метод Гаусса) равна  " + res2);

