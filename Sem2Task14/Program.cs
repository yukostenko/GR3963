// Задача 14
// Напишите программу, которая принимает на вход число
// и проверяет одновременно кратно ли оно 7 и 23.

Console.Write("Введите число:");
int num = int.Parse(Console.ReadLine() ?? "0");
//if ((num%23==0)&&(num%7==0))
bool oper = (num%23==0 && num%7==0);
if(oper)
{
    Console.WriteLine("Число кратно 7 и 23 одновременно.");
}
else
{
    Console.WriteLine("Число не кратно 7 и 23.");
}
