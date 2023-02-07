// // Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear ();
int Coordinate(string coorName, string pointName)
{
    System.Console.WriteLine($"Введите координату {coorName} точки {pointName}");
    return Convert.ToInt32(Console.ReadLine());
}

int х1 = Coordinate("х", "a");
int y1 = Coordinate("y", "a");
int z1 = Coordinate("z", "a");
int х2 = Coordinate("х", "b");
int y2 = Coordinate("y", "b");
int z2 = Coordinate("z", "b");

double Calculator(double х1, double х2, double у1, double у2, double z1, double z2)
{
    double action1 = Math.Pow (х2-х1, 2);
    double action2 = Math.Pow(y2-y1, 2);
    double action3 = Math.Pow(z2-z1, 2);
    double result = Math.Sqrt(action1 + action2 + action3);
    return result;
}
 
 double length = Calculator (х1, х2, y1, y2, z1, z2);
 System.Console.WriteLine($"Длина отрезка равна > {length:F3}");