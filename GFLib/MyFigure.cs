

namespace GFLib
{
    public abstract class MyFigure : IFigure
    {
        public double Perimeter {
            get {
                return CalculatePerimeter();
            }

        }
        public double Area {
            get {
                return CalculateArea();
            }

        }
        public virtual double CalculateArea() 
        {
            return Area;
        }

        public virtual double CalculatePerimeter() 
            {
            return Perimeter;
        }

    }
}
