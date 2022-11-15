// Итоговая проверочная работа
Console.Clear();
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] Array = new string[n];
string[] Array2 = new string[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Введите строку {i + 1} : ");
    Array[i] = Console.ReadLine();
    if (Array[i].Length <=3)
    {
        Array2[i] = Array[i];
    }
}
Console.WriteLine($"Полученный исходный массив: {string.Join(", ", Array)}");
Console.Write("Строки длиной до 3-x символов: ");
for (int i = 0; i < n; i++)
{
    if (Array2[i] != null)
    {
        Console.Write($"\"{Array2[i]}\" \t");
    }
}
