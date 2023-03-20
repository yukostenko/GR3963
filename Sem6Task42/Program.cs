// Задача №42
// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.

// Запрос данных у пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Вывод полученных данных
void PrintData(string msg)
{
    Console.WriteLine(msg);
}
// Метод преобразования числа из десятичного в двоичное

// string DecToBin(int num)
// {
//     string res = String.Empty;
//     while (num > 0)
//     {
//         res = num % 2 + res;
//         num = num / 2;
//     }
//     return res;
// }

string DecToBinNativ(int num, int baseI)
{
    return Convert.ToString(num, baseI);
}

int num = ReadData("Введите число: ");
//string res = DecToBin(num);
string res8 = DecToBinNativ(num, 8);
string res16 = DecToBinNativ(num, 16);
PrintData("Число в восьмиричной системе: " + res8);
PrintData("Число в шестнадцатиричной системе: " + res16);
