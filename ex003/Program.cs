// Таблица кубов чисел от 1 до N
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

int cube = 1;
for (int count = 1; count<=N; count++)
{
    cube = count*count*count;
    Console.WriteLine($"{cube}");
} 