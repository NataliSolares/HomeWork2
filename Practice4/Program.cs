// Найти расстояние между точками в пространстве 2D/3D
int x1 = 10;
int x2 = 6;
int y1 = 8;
int y2 = 2;
int z1 = 13;
int z2 = 20;
double d2 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
double d3 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine(d2);
Console.WriteLine(d3);