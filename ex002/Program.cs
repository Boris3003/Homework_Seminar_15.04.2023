// Расстояние между двумя точками в 3D пространстве
int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
int x1 = Prompt("Введите координату X первой точки: ");
int y1 = Prompt("Введите координату Y первой точки: ");
int z1 = Prompt("Введите координату Z первой точки: ");
int x2 = Prompt("Введите координату X второй точки: ");
int y2 = Prompt("Введите координату Y второй точки: ");
int z2 = Prompt("Введите координату Z второй точки: ");

double d = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
d = Math.Sqrt((z1-z2)*(z1-z2)+d*d);

Console.WriteLine($"Расстояние между точками равно: {d}");