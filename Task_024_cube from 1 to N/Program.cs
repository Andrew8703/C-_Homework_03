// Найти кубы чисел от 1 до N
Console.Write("Введите верхний предел диапазона: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Диапазон от 1 до " + N + "\t");
for (int i = 1; i <= N; i++)
    Console.Write(i + "\t");
Console.WriteLine();
for (int i = 1; i <= N; i++)
    Console.Write(i * i * i + "\t");