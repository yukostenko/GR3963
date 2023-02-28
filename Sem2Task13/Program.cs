// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6//

// Считываем число (как строку)
// Задаем длину числа
// Превращаем его в массив


string? num = Console.ReadLine();
if (num.Length >= 3)
{
    char[] arr = num.ToCharArray();
    Console.WriteLine(arr[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет.");
}

// Console.WriteLine("Введите число:")
// int num = int.Parse(Console.ReadLine());
// if (num<100)
// {
//   Console.WriteLine("Третьей цифры нет.");
// }
// else
// {
//    while(num>999)
// {
//    num/=10;
// }
// Console.WriteLine(num%10);
// }

