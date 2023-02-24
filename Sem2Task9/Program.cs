// Напишите программу, которая выводит случайное число из отрезка 10-99,
// и показывает наибольшую цифру этого числа.

// Введем структуру, котрая будет генерировать случайные числа.
// Выделим кусочек памяти и поместим в него синтезатор чисел.
System.Random numSintesator = new System.Random ();

// Вариант 1
// Сначала выделим случайное число из синтезатора чисел
// и поместим его в переменную
int rndNumber = numSintesator.Next(10,100);
// Выведем это число в консоль
Console.WriteLine(rndNumber);
// Определяем первое и второе числа двухзначного числа
int firstNum = rndNumber / 10;
int secondNum = rndNumber % 10;
// Записываем условие
if (firstNum > secondNum)
{
    Console.WriteLine ("Первое число " + firstNum + " больше второго " + secondNum);
}
else
{
    Console.WriteLine(secondNum);
}
// Вариант 2
char[] digits = numSintesator.Next(10,100).ToString().ToCharArray();
Console.WriteLine(digits);
int firstNumber = ((int)digits[0])-48;
int secondNumber = ((int)digits[1])-48;

//<переменная> = (условие)?<значение1>:<значение2>;
// if(условие)
//{
//    <переменная> = <значение1>;
//}
// else
//{
//  <переменная> = <значение2>; 
//}

int resultNumber = (firstNumber>secondNumber)?resultNumber=firstNumber:resultNumber=secondNumber;
Console.WriteLine(resultNumber);

// Вариант 3