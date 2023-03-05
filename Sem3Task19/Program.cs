// Задача №19 
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод проверяет, является ли число палиндроном
bool PalinTest(int num)
{
    bool res = false;
    if ((num / 10000 == num % 10) && ((num / 1000) % 10 == (num / 10) % 10))
    {
        res = true;
        if (res == true)
        {
            Console.WriteLine("Это число палиндром.");
        }
    }
    else
    {
        Console.WriteLine("Это число не палиндром.");
    }
    return res;
}

int num = ReadData("Введите пятизначное число: ");
bool res = PalinTest(num);





