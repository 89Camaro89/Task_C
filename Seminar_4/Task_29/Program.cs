Console.Clear();
int[] array = new int[8];


for (int i = 0; i < array.Length; i++)
{
    Console.Write("Веедите элемент массива: ");
    int x = Convert.ToInt32(Console.ReadLine());
    array[i] = x;
}
Console.Write($"Результат: [{string.Join(", ", array)}]");

