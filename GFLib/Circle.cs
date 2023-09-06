

namespace GFLib
{
    public class Circle : IFigure
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
        public double Perimeter {
            get {
                return SolvePerimeter();
            }
            
        }
        public double Area 
            {
            get {
                return SolveArea();
            }
            
        }
        public Circle(int radius = 0) 
        {
            
        }
        public Circle(float radius = 0) {

        }
        public Circle(double radius = 0) {

        }
        public Circle(short radius = 0) {

        }
        public Circle(object radius) {


        }
        private double SolveArea() 
        {

        }
        private double SolvePerimeter() {

        }

    }
}