// Задача №40
// Напишите программу, которая принимает на вход
// три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.

// Запрос данных у пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Вывод полученных данных
void PrintData(string msg, bool res)
{
    Console.WriteLine(msg+res);
}
// 
bool Test(int a, int b, int c)
{
    return(a <= b + c);
}

//Метод проверки существования треугольника с длинами заданной длины
bool TriangleTest(int a, int b, int c)
{
    if ((Test(a,b,c)) && (Test(b,a,c)) && (Test(c,b,a))) return true;
    else return false;
}

int LengthA = ReadData ("Введите длинe треугольника a: ");
int LengthB = ReadData ("Введите длинe треугольника b: ");
int LengthC = ReadData ("Введите длинe треугольника c: ");
PrintData("Треугольник с такими сторнами может существовать: ", TriangleTest(LengthA, LengthB, LengthC));


