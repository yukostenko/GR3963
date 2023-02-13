// Задача №3
// Напишите программу, 
// которая будет выдавать навание дня недели по заданному номеру.

// Ввод номера дня недели
Console.Write("Введите номер дня недели: ");
string? LineDay = Console.ReadLine();
if (LineDay != null)

{
    int day = int.Parse(LineDay);
    String[] dayWeek = new String[7];
    dayWeek[0] = "Понедельник";
    dayWeek[1] = "Вторник";
    dayWeek[2] = "Среда";
    dayWeek[3] = "Четверг";
    dayWeek[4] = "Пятница";
    dayWeek[5] = "Суббота";
    dayWeek[6] = "Воскресенье";
    Console.Write(dayWeek[day - 1]);
}