/* 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

int N;
Console.Write($"Введите N: ");
int.TryParse(Console.ReadLine()!, out N);

int i = 1;
Console.Write($"{N} -> ");
while (i <= N)
{
    Console.Write($"{Math.Pow(i, 3)} ");
    i++;
}