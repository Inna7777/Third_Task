//Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координаты X точки A");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y точки A");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Z точки A");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты X точки B");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y точки B");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты z точки B");
int z2 = Convert.ToInt32(Console.ReadLine());

double DistancAB (int x1, int y1, int x2, int y2, int z1, int z2)
{
    double result =0;
    result = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
    return result;
}

Console.WriteLine($"Расстояние между точками = " +DistancAB(x1,y1,x2,y2,z1,z2));
