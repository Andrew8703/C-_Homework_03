// Найти расстояние между точками в пространстве 2D/3D
int x1 = new Random().Next(-10, 10); int y1 = new Random().Next(-10, 10); int z1 = new Random().Next(-10, 10);
int x2 = new Random().Next(-10, 10); int y2 = new Random().Next(-10, 10); int z2 = new Random().Next(-10, 10);
double distance = 0;
Console.WriteLine("x1 = " + x1 + " y1 = " + y1 + " z1 = " + z1);
Console.WriteLine("x2 = " + x2 + " y2 = " + y2 + " z2 = " + z2);
if (z1 == 0 && z2 == 0)
{
    distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    Console.WriteLine("Расстояние между точками в 2D пространстве = " + Math.Round(distance,3));
}
else
{
    distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    Console.WriteLine("Расстояние между точками в 3D пространстве = " + Math.Round(distance,3));
}