namespace Exer01
{
    public class Retangulo
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
            return System.Math.Sqrt(Height * Height + Width * Width);
        }
    }
}

