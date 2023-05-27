// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear(); //очистить консоль
Console.Write("Введи трёхзначное число: "); //ввод числа
int Number = Convert.ToInt32(Console.ReadLine()); //переводим строку в число и вносим в переменную Number
if (Number < 100 || Number > 999)
{
   Console.WriteLine("ошибка");
}
else
{
   string SecondDigitNumber = Convert.ToString(Number); //переводим число в строку и вносим в переменную SecondDigitNumber
   Console.WriteLine("вторая цифра этого числа -> "+SecondDigitNumber[1]); //выводим второе по счёту значение в строке SecondDigitNumber
}

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введи число: "); //ввод данных
int Number = Convert.ToInt32(Console.ReadLine()); //вносим полученые данные в переменную 
string NumberText = Convert.ToString(Number); //переводим число в строку и вносим в переменную SecondDigitNumber
if (NumberText.Length > 2) //если длинна введённого числа > 2, 
{
  Console.WriteLine("третья цифра -> " + NumberText[2]); //то выводим - "третья цифра -> NumberText[2]"
}
else { //иначе - вывод текста "третьей цифры нет"
  Console.WriteLine("-> третьей цифры нет");
}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введи цифру, обозначающую день недели: "); //ввод данных
int dayNumber = Convert.ToInt32(Console.ReadLine()); //вносим полученые данные в переменную dayNumber

void Weekend (int dayNumber) // переносим число из переменной dayNumber в невозвращаемую переменную
{
  if (dayNumber == 6 || dayNumber == 7) //если dayNumber == 6 и ==7,
  {
  Console.WriteLine("этот день выходной"); // то, вывод "этот день выходной"
  }
  else if (dayNumber < 1 || dayNumber > 7) //иначе,если dayNumber < 1 и > 7
  {
    Console.WriteLine("это не день недели"); // то, вывод "это не день недели"
  }
  else Console.WriteLine("этот день не выходной"); // в остальных случаях вывод "этот день не выходной"
}

Weekend(dayNumber);
