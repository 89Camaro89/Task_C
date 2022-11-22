Console.Clear();
Console.WriteLine("Введите 1-ое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-е число:");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max)
{
    max = b;
}

if (c > max)
{
    max = c;
}

Console.WriteLine($"Наибольшее из введённых чисел {max}");
