// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.WriteLine("Нахождение второй цифры трехзначного числа");

Console.SetCursorPosition(10,3);

Console.Write ("Введите трёхзначное число, N = ");

int n = int.Parse(Console.ReadLine() ?? "0");

int num = Math.Abs(n);

Console.SetCursorPosition(10,6);

if (num/100 >10 || num/100 < 1)
{
    Console.Write ("Введенное число не является трёхзначным");
}
else
{
    Console.Write ("Вторая цифра числа N, В = ");    
    Console.WriteLine (num%100/10);
}
Console.SetCursorPosition(6,9);

Console.Write("* * *");

