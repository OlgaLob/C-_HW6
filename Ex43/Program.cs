Console.Clear();
 
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine()!);
 
double[] Point = FindPoint(b1,k1,b2,k2);
 
Console.WriteLine($"{Point[0]} {Point[1]}");
 
 
 
double[] FindPoint(double b1, double k1, double b2, double k2)
{
    double[] result = new double[2];
    result[0] = (b2 - b1) / (k1 - k2);
    result[1] = k1 * result[0] + b1;
 
    return result;
}