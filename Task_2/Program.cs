using System;

class Square
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Side { get; set; }

    public Square(double x, double y, double side)
    {
        X = x;
        Y = y;
        Side = side;
    }

    public double CalculateArea()
    {
        return Side * Side;
    }
}

class Cub : Square
{
    public double Height { get; set; }

    public Cub(double x, double y, double side, double height)
        : base(x, y, side)
    {
        Height = height;
    }

    public double CalculateVolume()
    {
        return CalculateArea() * Height;
    }

    public double CalculateSurfaceArea()
    {
        return 6 * CalculateArea();
    }
}

class Program
{
    static void Main()
    {
        Square square = new Square(0, 0, 5);
        Console.WriteLine($"Площа квадрата: {square.CalculateArea()}");

        Cub cub = new Cub(0, 0, 5, 10);
        Console.WriteLine($"Об'єм куба: {cub.CalculateVolume()}");
        Console.WriteLine($"Площа поверхні куба: {cub.CalculateSurfaceArea()}");

        Console.ReadKey();
    }
}

