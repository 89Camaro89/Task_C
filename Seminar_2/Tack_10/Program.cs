Console.Clear();
int n = new Random().Next(100, 999);
Console.WriteLine($"Случайное число {n}");
string stringNumber = Convert.ToString(n);
Console.WriteLine($"вторая цифра этого числа {stringNumber[1]}");