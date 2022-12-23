// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

Console.WriteLine("Программа выводит третью цифру числа (начиная отсчет слева)");

Console.SetCursorPosition(10,2);

Console.Write ("Введите целое число, N = ");

int num = int.Parse(Console.ReadLine() ?? "0");

int check = 0, rest = 1;

Console.SetCursorPosition(10,4);

while (rest > 0)
{
    check = check + 1;

    rest = num/(int)Math.Pow(10,check);
}
if (check < 3)
{
  Console.WriteLine ("Число содержит менее трех цифр"); 
}
else
{
Console.Write ("Третья цифра числа: ");
Console.WriteLine(num/(int)Math.Pow(10,check-3)%10);
}
Console.SetCursorPosition(1,6);

Console.Write("* * *");
