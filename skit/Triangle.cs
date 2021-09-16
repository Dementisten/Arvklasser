using System;

class Triangle : Shape
{

    public double Area{
        get{
            return (Width*Height)/2;
        }
    }
    
    public double Circumferance{
        get{
            
            return Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2)) + Width + Height;
        }
    }


    public Triangle(double width, double height) : base(width, height)
    {
    }
}