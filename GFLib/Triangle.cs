

namespace GFLib
{
    internal class Triangle : IFigure
    {
        public double Leg1 {
            get {
                return Leg1;
            }
            set {
                if (0 > value) {
                    throw new ArgumentException("Please enter a valid value");
                }
                else {
                    Leg1 = value;
                }
            }
        }
        public double Leg2 {
            get {
                return Leg2;
            }
            set {
                if (0 > value) {
                    throw new ArgumentException("Please enter a valid value");
                }
                else {
                    Leg2 = value;
                }
            }
        }
        public double angle {
            get {
                return angle;
            }
            set {
                if (value == 0) {
                    throw new ArgumentException("Please enter a valid value");
                }
                else {
                    angle = value;
                }
            }
        }
        public double Perimeter {
            get {
                return SolvePerimeter();
            }
            
        }
        public double Area {
            get {
                return SolveArea();
            }
            
        }
        public Triangle(int Leg1, int Leg2, int angle) {

        }
        public Triangle(float Leg1, float Leg2, float angle) {

        }
        public Triangle(double Leg1, double Leg2, double angle) {

        }
        public Triangle(short Leg1, short Leg2, short angle) {

        }
        public Triangle(object Leg1, object Leg2, object angle) {


        }
        override double SolveArea() {

        }

        override double SolvePerimeter() {

        }
    }
}
