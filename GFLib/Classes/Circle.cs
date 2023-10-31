using GFLib.Interfaces;

namespace GFLib.Classes
{
    public class Circle : MyFigure, IFigure
    {
        private double radius;
        private double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (0 > value)
                {
                    throw new ArgumentException("Please enter a valid value");
                }
                else
                {
                    radius = value;
                }
            }
        }
        public Circle(int radius = 0)
        {
            Radius = radius;
        }
        public Circle(float radius = 0)
        {
            Radius = radius;
        }
        public Circle(double radius = 0)
        {
            Radius = radius;
        }
        public Circle(short radius = 0)
        {
            Radius = radius;
        }
        public Circle(string radius)
        {
            try
            {
                Radius = Convert.ToDouble(radius);
            }
            catch
            {
                throw new ArgumentException("Please enter a valid value");
            }

        }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

    }
}