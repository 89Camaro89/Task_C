Console.Clear();
Console.WriteLine("Введите координату X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y1 первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z1 первой точки: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату X2 второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y2 второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z2 второй точки: ");
double z2 = Convert.ToDouble(Console.ReadLine());



Console.WriteLine(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)));
