using System;

public class TRTriangle
{
    public double Side { get; private set; }

    // Конструктор без параметрів
    public TRTriangle()
    {
        Side = 1.0;
    }

    // Конструктор з параметрами
    public TRTriangle(double side)
    {
        Side = side;
    }

    // Конструктор копіювання
    public TRTriangle(TRTriangle triangle)
    {
        Side = triangle.Side;
    }

    // Введення даних
    public void Input()
    {
        Console.Write("Введіть довжину сторони трикутника: ");
        Side = double.Parse(Console.ReadLine());
    }

    // Виведення даних
    public void Output()
    {
        Console.WriteLine($"Довжина сторони трикутника: {Side}");
    }

    // Визначення площі
    public double Area()
    {
        return (Math.Sqrt(3) / 4) * Math.Pow(Side, 2);
    }

    // Визначення периметру
    public double Perimeter()
    {
        return 3 * Side;
    }

    // Порівняння з іншим трикутником
    public bool Equals(TRTriangle other)
    {
        return this.Side == other.Side;
    }

    // Перевантаження операторів +, -, *
    public static TRTriangle operator +(TRTriangle a, TRTriangle b)
    {
        return new TRTriangle(a.Side + b.Side);
    }

    public static TRTriangle operator -(TRTriangle a, TRTriangle b)
    {
        return new TRTriangle(a.Side - b.Side);
    }

    public static TRTriangle operator *(TRTriangle a, double multiplier)
    {
        return new TRTriangle(a.Side * multiplier);
    }

    public static TRTriangle operator *(double multiplier, TRTriangle a)
    {
        return new TRTriangle(a.Side * multiplier);
    }
}


class Program
{
    static void Main()
    {
        // Створення об'єктів TRTriangle
        TRTriangle triangle1 = new TRTriangle();
        TRTriangle triangle2 = new TRTriangle(3.0);
        TRTriangle triangle3 = new TRTriangle(triangle2);

        // Введення даних для triangle1
        triangle1.Input();

        // Виведення даних
        triangle1.Output();
        triangle2.Output();
        triangle3.Output();

        // Обчислення площі та периметру
        Console.WriteLine($"Площа triangle1: {triangle1.Area()}");
        Console.WriteLine($"Периметр triangle1: {triangle1.Perimeter()}");

        // Порівняння трикутників
        Console.WriteLine($"triangle1 дорівнює triangle2: {triangle1.Equals(triangle2)}");
        Console.WriteLine($"triangle2 дорівнює triangle3: {triangle2.Equals(triangle3)}");

        // Перевантаження операторів
        TRTriangle sumTriangle = triangle1 + triangle2;
        TRTriangle diffTriangle = triangle1 - triangle2;
        TRTriangle scaledTriangle1 = triangle1 * 2.0;
        TRTriangle scaledTriangle2 = 2.0 * triangle2;

        // Виведення результатів перевантаження операторів
        Console.WriteLine("Сума triangle1 і triangle2:");
        sumTriangle.Output();
        Console.WriteLine("Різниця triangle1 і triangle2:");
        diffTriangle.Output();
        Console.WriteLine("Масштабування triangle1 на 2:");
        scaledTriangle1.Output();
        Console.WriteLine("Масштабування triangle2 на 2:");
        scaledTriangle2.Output();
    }
}
