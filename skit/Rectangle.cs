class Rectangle : Shape
{
    public double Area{
        get{
            return Width*Height;
        }
    }
    public double Circumferance{
        get{
            return Width*2 + Height*2;
        }
    }

    public Rectangle(double width, double height) : base(width, height)
    {
    }
}