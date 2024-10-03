using System;

class Vector
{
    public int X { get; set; }
    public int Y { get; set; }

    public Vector(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1.X + v2.X, v1.Y + v2.Y);
    }

    public void Display()
    {
        Console.WriteLine($"{X} {Y}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first vector:");
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        Vector vector1 = new Vector(x1, y1);

        Console.WriteLine("Enter the second vector:");
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        Vector vector2 = new Vector(x2, y2);

        Vector sumVector = vector1 + vector2;

        Console.WriteLine("Sum of the vectors:");
        sumVector.Display();
    }
}
