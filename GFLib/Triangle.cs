

namespace GFLib
{
    internal class Triangle : MyFigure,IFigure
    {
        private double Leg1 {
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
        private double Leg2 {
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
        private double Leg3 {
            get {
                return Leg3;
            }
            set {
                if (0 > value) {
                    throw new ArgumentException("Please enter a valid value");
                }
                else {
                    Leg3 = value;
                }
            }
        }
        private double angle {
            get {
                return angle;
            }
            set {
                if (value == 0 && value >= 180) {
                    throw new ArgumentException("Please enter a valid value");
                }
                else {
                    angle = value;
                }
            }
        }
        private double angle2 {
            get {
                return angle2;
            }
            set {
                if (value == 0 && value >=180) {
                    throw new ArgumentException("Please enter a valid value");
                }
                else {
                    angle2 = value;
                }
            }
        }
        private double angle3 {
            get {
                return angle3;
            }
            set {
                angle3 = 180 - angle - angle2;
                if(angle3 < 0) 
                {
                    throw new ArgumentException("Please enter a valid value for angle1 and angle2");
                }
            }
        }
        private Triangle() { }
        public Triangle(int Leg1, int Leg2, int angle)
        {

            this.Leg1 = Leg1;
            this.Leg2 = Leg2;
            this.angle = angle;
            this.Leg3 = Math.Sqrt(Leg1* Leg1 + Leg2 * Leg2 - 2*Leg1*Leg2*Math.Cos(angle));
        }
        public Triangle(float Leg1, float Leg2, float angle)
        {
            this.Leg1 = Leg1;
            this.Leg2 = Leg2;
            this.angle = angle;
            this.Leg3 = Math.Sqrt(Leg1 * Leg1 + Leg2 * Leg2 - 2 * Leg1 * Leg2 * Math.Cos(angle));
        }
        public Triangle(double Leg1, double Leg2, double angle) 
        {
            this.Leg1 = Leg1;
            this.Leg2 = Leg2;
            this.angle = angle;
            this.Leg3 = Math.Sqrt(Leg1 * Leg1 + Leg2 * Leg2 - 2 * Leg1 * Leg2 * Math.Cos(angle));
        }
        public Triangle(short Leg1, short Leg2, short angle) 
        {
            this.Leg1 = Leg1;
            this.Leg2 = Leg2;
            this.angle = angle;
            this.Leg3 = Math.Sqrt(Leg1 * Leg1 + Leg2 * Leg2 - 2 * Leg1 * Leg2 * Math.Cos(angle));
        }
        public Triangle(string Leg1, string Leg2, string angle)
        {
            try 
            {
                this.Leg1 = Convert.ToDouble(Leg1);
                this.Leg2 = Convert.ToDouble(Leg2);
                this.angle = Convert.ToDouble(angle);
                this.Leg3 = Math.Sqrt(this.Leg1 * this.Leg1 + this.Leg2 * this.Leg2 - 2 * this.Leg1 * this.Leg2 * Math.Cos(this.angle));
            }
            catch 
            {
                throw new ArgumentException("Please enter a valid value");
            }
           
        }
        public static Triangle Two_Angles(double Leg1, double angle, double angle2) 
        {
            Triangle triangle = new Triangle();
            triangle.Leg1 = Leg1;
            triangle.angle = angle;
            triangle.angle2 = angle2;
            triangle.Leg2 = Leg1 * Math.Sin(angle)/Math.Sin(triangle.angle3);
            triangle.Leg3 = Leg1 * Math.Sin(angle2) / Math.Sin(triangle.angle3);
            return triangle;
        }
        public static Triangle Two_Angles(int Leg1, int angle, int angle2) 
        {
            Triangle triangle = new Triangle();
            triangle.Leg1 = Leg1;
            triangle.angle = angle;
            triangle.angle2 = angle2;
            triangle.Leg2 = Leg1 * Math.Sin(angle) / Math.Sin(triangle.angle3);
            triangle.Leg3 = Leg1 * Math.Sin(angle2) / Math.Sin(triangle.angle3);
            return triangle;
        }
        public bool isRight() 
        {
            try 
            {
                if ((Leg1 * Leg1 + Leg2 * Leg2 == Leg3 * Leg3) || (Leg1 * Leg1 + Leg3 * Leg3 == Leg2 * Leg2) || (Leg3 * Leg3 + Leg2 * Leg2 == Leg1 * Leg1)) {
                    return true;
                }
                return false;
            }
            catch 
            {
                throw new ArgumentException("Please enter a valid value");
            }
            
        }
        public override double CalculateArea() //Формула Герона
        {
            double p = CalculatePerimeter()/2;
            return Math.Sqrt(p * (p - Leg1) * (p - Leg2) * (p - Leg3));
        }

        public override double CalculatePerimeter() 
        {

            return Leg1+Leg2+Leg3;
        }
    }
}
