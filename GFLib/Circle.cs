

namespace GFLib
{
    internal class Circle : MyFigure,IFigure
    {
        public double radius {
            get {
                return radius;
            }
            set {
                if (0 > value) {
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
            this.radius = radius;
        }
        public Circle(float radius = 0) 
        {
            this.radius = radius;
        }
        public Circle(double radius = 0) 
        {
            this.radius = radius;
        }
        public Circle(short radius = 0)
        {
            this.radius = radius;
        }
        public Circle(string radius) 
        {
            try
            {
                this.radius = Convert.ToDouble(radius);
            }
            catch 
            {
                throw new ArgumentException("Please enter a valid value");
            }

        }
        public override double CalculateArea() 
        {
            return Math.PI * radius * radius;
        }
        public override double CalculatePerimeter() 
        {
            return 2 * Math.PI * radius;
        }

    }
}