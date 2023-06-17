/* Напишите программу,
которая принимает на вход цифру,
обозначающую день недели, и проверяет,
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber)
{
  if (dayNumber == 6 || dayNumber == 7)
  {
  Console.WriteLine("(Этот день выходной) -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7)
  {
    Console.WriteLine("В неделе семь дней");
  }
  else Console.WriteLine("(Этот день не выходной) -> нет");
}

CheckingTheDayOfTheWeek(dayNumber);

