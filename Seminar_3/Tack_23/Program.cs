
Console.Clear();
int n = new Random().Next(0, 10);
Console.WriteLine($"Слуайное число: {n} ");

for (int i = 1; i <= n; i++)
{
    Console.Write($"{i * i * i} ");
}
