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

// Доп. задача: Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает. Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или меньше
// Доп. задача с усложнением: на отгадывание дается 3 попытки.

Console.WriteLine("Задача 'Дополнительная' ");

int randomNumber = RandomNumber(0, 1000);

int RandomNumber(int min, int max){   
  return new Random().Next(min, max);
}

void CheckingTheNumber(int myNumber, int randomNumber) {

  if (myNumber > randomNumber) {
    Console.WriteLine("Не угадал, твоё число великовато");
  }
  else Console.WriteLine("Не угадал, твоё число маловато");
}

void AttemptCounter(int maxCounter){

  int counter = 1;
  while (counter <= maxCounter) {

    Console.Write("Попытка номер " + counter);
    Console.Write(".   Введи число: ");
    int myNumber = Convert.ToInt32(Console.ReadLine());

    if (myNumber == randomNumber){
      Console.WriteLine("Поздравляю, ты угадал! ");
      break;
    }
    else {
      CheckingTheNumber(myNumber, randomNumber);
      counter++;
    }
  }
}

Console.WriteLine("Игра до 3 попыток");
AttemptCounter(3);

Console.WriteLine("В основные попытки не уложился. Продолжим ? (напиши да/нет)");

string? yesNo = Console.ReadLine();

if (yesNo == "да"){
AttemptCounter(1000);
}
else Console.Write("Загаданное число было: " + randomNumber);