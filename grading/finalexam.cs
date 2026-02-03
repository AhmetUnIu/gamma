using System;
using System.Collections.Generic;
using System.Linq;

class Figure
{
    private int dimension;

    public Figure(int d)
    {
        Dimension = d;
    }

    public int Dimension
    {
        get { return dimension; }
        set { dimension = value; }
    }

    public virtual int GetArea()
    {
        return 0;
    }
}

class Rectangle : Figure
{
    private int width;
    private int length;

    public Rectangle(int w, int l) : base(2)
    {
        Width = w;
        Length = l;
    }

    public int Width
    {
        get { return width; }
        set { width = value; }
    }

    public int Length
    {
        get { return length; }
        set { length = value; }
    }

    public override int GetArea()
    {
        return Width * Length;
    }
}

class Program
{
    static void Main()
    {
        
        List<Rectangle> rectangles = new List<Rectangle>()
        {
            new Rectangle(3, 4),
            new Rectangle(5, 6),
            new Rectangle(2, 8)
        };

        
        for (int i = 0; i < rectangles.Count; i++)
        {
            Console.WriteLine("Rectangle " + (i + 1) + ": Area = " + rectangles[i].GetArea());
        }

        
        double averageArea = rectangles.Average(r => r.GetArea());

        Console.WriteLine("\nAverage Area: " + averageArea);
    }
}
