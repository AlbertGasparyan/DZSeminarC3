// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
System.Console.Clear();

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()??"0");

System.Console.Write($"Введите степень для числа {num}: ");
int num2 = Convert.ToInt32(Console.ReadLine()??"0");

int step = num;

for (int i = 1; i < num2; i++)
{
step = step * num;
}
Console.WriteLine("A в степени B равно: " + step);