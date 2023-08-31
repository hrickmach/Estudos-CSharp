using System;

namespace POOExe3
{
    public class Rectangle
    {
        public double Height;
        public double Width;

        public double Area()
        {
            return Height * Width;
        }
        public double Perimeter()
        {
            return 2 * (Height + Width);
        }
        public double Diagonal()
        {
            return Math.Sqrt(Height * Height + Width * Width);
        }
    }
}