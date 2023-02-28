//Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// int num = int.Parse(Console.ReadLine());
// if (num > 0 && num < 6)
// {
//     Console.WriteLine("Это рабочий день.");
// }
// else
// {
//     Console.WriteLine("Этот день выходной.");
// }

Dictionary<int, string> daysOfWeek = new Dictionary<int, string>();

// Добавляем дни недели в словарь
daysOfWeek.Add(1, "Будний день.");
daysOfWeek.Add(2, "Будний день.");
daysOfWeek.Add(3, "Будний день.");
daysOfWeek.Add(4, "Будний день.");
daysOfWeek.Add(5, "Будний день.");
daysOfWeek.Add(6, "Выходной день.");
daysOfWeek.Add(7, "Выходной день.");


// Просим ввести день недели
Console.Write("Введите день недели (1-7):");
int dayOfWeek = int.Parse(Console.ReadLine());

if(daysOfWeek.ContainsKey(dayOfWeek))
{
    Console.WriteLine(daysOfWeek[dayOfWeek]);
}
else
{
    Console.WriteLine("Это не день недели."); 
}
