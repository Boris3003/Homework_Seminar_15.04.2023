// Проверка числа на палиндром
Console.Write("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine()!);

int a = N/10000;
int b = (N/1000)%10;
int c = (N/10)%10;
int d = N%10;

if (a == d && b ==c) Console.WriteLine("Это число палиндром");
else Console.WriteLine("Это число не палиндром");