namespace C_PointExample;

public class Point
{
    private double x, y;

    public static Point NewCartesianPoint(double x, double y)
    {
        return new Point(x, y);
    }

    public static Point NewPolarPoint(double rho, double theta)
    {
        return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
    }

    private Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return $"x: {x}, y: {y}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        var polarPoint = Point.NewPolarPoint(1.0, Math.PI / 2);
        System.Console.WriteLine(polarPoint);
        var cartesianPoint = Point.NewCartesianPoint(1.0, 2.0);
        System.Console.WriteLine(cartesianPoint);
    }
}
