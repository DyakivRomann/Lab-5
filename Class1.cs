using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Boss
{
    public abstract string name { get; }
    public abstract float Area();
}

class Quadrilateral : Boss
{
    public override string name => "Quadrilateral";

    public float a { get; set; }
    public float b { get; set; }
    public float c { get; set; }
    public float d { get; set; }

    public override float Area()
    {
        float perimeter = (a + b + c + d) / 2;
        return (float)Math.Sqrt((perimeter - a) * (perimeter - b) * (perimeter - c) * (perimeter - d));
    }
}

class Parallelogram : Boss
{
    public override string name => "Parallelogram";

    public float Base { get; set; }
    public float Height { get; set; }

    public override float Area()
    {
        return Base * Height;
    }
}

class Rhomb : Boss
{
    public override string name => "Rhomb";
    public float diagonal1 { get; set; }
    public float diagonal2 { get; set; }

    public override float Area()
    {
        return (diagonal1 * diagonal2) / 2;
    }
}

class Rectangle : Boss
{
    public override string name => "Rectangle";
    public float sideA { get; set; }
    public float sideB { get; set; }

    public override float Area()
    {
        return sideA * sideB;
    }
}

class Square : Boss
{
    public override string name => "Square";
    public float Side { get; set; }

    public override float Area()
    {
        return Side * Side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Please choose a figure: ");
            Console.WriteLine("1. Quadrilateral");
            Console.WriteLine("2. Parallelogram");
            Console.WriteLine("3. Rhomb");
            Console.WriteLine("4. Rectangle");
            Console.WriteLine("5. Square");

            int choice = int.Parse(Console.ReadLine());

            Boss figure;

            switch (choice)
            {
                case 1:
                    figure = new Quadrilateral { a = 3, b = 4, c = 6, d = 8 };
                    break;
                case 2:
                    figure = new Parallelogram { Base = 6, Height = 4 };
                    break;
                case 3:
                    figure = new Rhomb { diagonal1 = 8, diagonal2 = 10 };
                    break;
                case 4:
                    figure = new Rectangle { sideA = 17, sideB = 14 };
                    break;
                case 5:
                    figure = new Square { Side = 5 };
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose a valid option.");
                    continue;
            }

            Console.WriteLine($"Figure: {figure.name} | Area: {figure.Area()}");

            Console.WriteLine("Do you want to continue? (Y/N)");
            string input = Console.ReadLine().ToUpper();

            if (input == "N")
            {
                break;
            }
        }
    }
}