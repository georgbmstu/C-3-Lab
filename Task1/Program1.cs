struct Vector
{
    public int x;
    public int y;
    public int z;
    public Vector(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public static Vector operator +(Vector v1, Vector v2)
        => new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
    public static Vector operator *(Vector v1, Vector v2)
        => new Vector(v1.x * v2.x, v1.y * v2.y, v1.z * v2.z);
    public static Vector operator *(Vector v, int scalar)
        => new Vector(v.x * scalar, v.y * scalar, v.z * scalar);
    public static bool operator ==(Vector v1, Vector v2)
        => Module(v1) == Module(v2);
    public static bool operator !=(Vector v1, Vector v2)
        => Module(v1) != Module(v2);
    public static bool operator >(Vector v1, Vector v2)
        => Module(v1) > Module(v2);
    public static bool operator <(Vector v1, Vector v2)
        => Module(v1) < Module(v2);
    public static bool operator >=(Vector v1, Vector v2)
        => Module(v1) >= Module(v2);
    public static bool operator <=(Vector v1, Vector v2)
        => Module(v1) <= Module(v2);
    private static double Module(Vector v)
        => Math.Sqrt(v.x * v.x + v.y * v.y + v.z * v.z);
}
class Program
{
    static void Main()
    {
        Vector v1 = new Vector(1, 2, 3);
        Vector v2 = new Vector(4, 5, 6);
        Vector sum = v1 + v2;
        Vector product = v1 * v2;
        Vector scaled = v1 * 3;
        Console.WriteLine("Сумма: (" + sum.x + ", " + sum.y + ", " + sum.z + ")");
        Console.WriteLine("Произведение: (" + product.x + ", " + product.y + ", " + product.z + ")");
        Console.WriteLine("Умножение на число: (" + scaled.x + ", " + scaled.y + ", " + scaled.z + ")");
        Console.WriteLine("v1 == v2: " + (v1 == v2));
        Console.WriteLine("v1 != v2: " + (v1 != v2));
        Console.WriteLine("v1 > v2: " + (v1 > v2));
        Console.WriteLine("v1 < v2: " + (v1 < v2));
        Console.WriteLine("v1 >= v2: " + (v1 >= v2));
        Console.WriteLine("v1 <= v2: " + (v1 <= v2));
    }
}