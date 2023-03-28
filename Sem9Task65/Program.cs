//Задача 65.
//Задайте значение m и n. Напишите программу, которая найдет все натуральные 
// элементы в промежутке от m до n.

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
string RecMN(int m, int n)
{
    string res = String.Empty;
    if (m >= n)
    {
        res = n.ToString(); // точка остановки рекурсии
    }
    else
    {
        res = res + m + " " + RecMN(m + 1, n); //следующий вызов
    }
    return res;
}

int numberM = ReadData("Введите число M: ");
int numberN = ReadData("Введите число N: ");
string result = numberM<numberN?RecMN(numberM,numberN):RecMN(numberN,numberM);
PrintResult(result);

