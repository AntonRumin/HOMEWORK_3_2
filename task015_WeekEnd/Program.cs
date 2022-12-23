// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

Console.WriteLine ("Определение выходных дней");

bool control = true;

int x = 10, y = 3, count = 0;

while (control == true)
{
    Console.SetCursorPosition(x,y+count);

    Console.Write ("Введите номер дня недели (от 1 до 7), N = ");

    int n = int.Parse(Console.ReadLine() ?? "0");

    control = false;


    Console.SetCursorPosition(x,y+3+count);

switch (n)
{
case 1:
    Console.WriteLine("Понедельник, первый рабочий день");
break;
case 2:
    Console.WriteLine("Вторник, второй рабочий день");
break;
case 3:
    Console.WriteLine("Среда, третий рабочий день");
break;
case 4:
    Console.WriteLine("Четверг, четвертй рабочий день");
break;
case 5:
    Console.WriteLine("Пятница, пятый рабочий день");
break;
case 6:
    Console.WriteLine("Суббота, первый выходной день");
break;
case 7:
    Console.WriteLine("Воскресенье, второй выходной день");
break;
default:
    Console.WriteLine("Введен номер больше 7. Попробуйте ещё раз!");
    control = true;
    count = count + 5;
break;
}
}
Console.SetCursorPosition(x,y+6+count);

Console.Write("* * *");


