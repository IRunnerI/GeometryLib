using GFLib.Interfaces;

namespace GFLib.Classes
{
    public class Triangle : MyFigure, IFigure
    {
        private double leg1, leg2, leg3, angle1, angle2, angle3;


        private double Leg1
        {
            get
            {
                return leg1;
            }
            set
            {
                if (0 > value)
                {
                    throw new ArgumentException("Please enter a valid value");
                }
                else
                {
                    leg1 = value;
                }
            }
        }
        private double Leg2
        {
            get
            {
                return leg2;
            }
            set
            {
                if (0 > value)
                {
                    throw new ArgumentException("Please enter a valid value");
                }
                else
                {
                    leg2 = value;
                }
            }
        }
        private double Leg3
        {
            get
            {
                return leg3;
            }
            set
            {
                if (0 > value)
                {
                    throw new ArgumentException("Please enter a valid value");
                }
                else
                {
                    leg3 = value;
                }
            }
        }
        private double Angle1
        {
            get
            {
                return angle1;
            }
            set
            {
                if (value == 0 || value >= 180)
                {
                    throw new ArgumentException("Please enter a valid value");
                }
                else
                {
                    angle1 = value;
                }
            }
        }
        private double Angle2
        {
            get
            {
                return angle2;
            }
            set
            {
                if (value == 0 || value >= 180)
                {
                    throw new ArgumentException("Please enter a valid value");
                }
                else
                {
                    angle2 = value;
                }
            }
        }
        private double Angle3
        {
            get
            {
                return angle3;
            }
            set
            {
                angle3 = 180 - angle1 - angle2;
                if (angle3 < 0)
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
            Angle1 = angle;
            Leg3 = Math.Sqrt(Leg1 * Leg1 + Leg2 * Leg2 - 2 * Leg1 * Leg2 * Math.Cos(ToRadians(angle)));
        }
        public Triangle(float Leg1, float Leg2, float angle)
        {
            this.Leg1 = Leg1;
            this.Leg2 = Leg2;
            Angle1 = angle;
            Leg3 = Math.Sqrt(Leg1 * Leg1 + Leg2 * Leg2 - 2 * Leg1 * Leg2 * Math.Cos(ToRadians(angle)));
        }
        public Triangle(double Leg1, double Leg2, double angle)
        {
            this.Leg1 = Leg1;
            this.Leg2 = Leg2;
            Angle1 = angle;
            Leg3 = Math.Sqrt(Leg1 * Leg1 + Leg2 * Leg2 - 2 * Leg1 * Leg2 * Math.Cos(ToRadians(angle)));
        }
        public Triangle(short Leg1, short Leg2, short angle)
        {
            this.Leg1 = Leg1;
            this.Leg2 = Leg2;
            Angle1 = angle;
            Leg3 = Math.Sqrt(Leg1 * Leg1 + Leg2 * Leg2 - 2 * Leg1 * Leg2 * Math.Cos(ToRadians(angle)));
        }
        public Triangle(string Leg1, string Leg2, string angle)
        {
            try
            {
                this.Leg1 = Convert.ToDouble(Leg1);
                this.Leg2 = Convert.ToDouble(Leg2);
                Angle1 = Convert.ToDouble(angle);
                Leg3 = Math.Sqrt(this.Leg1 * this.Leg1 + this.Leg2 * this.Leg2 - 2 * this.Leg1 * this.Leg2 * Math.Cos(ToRadians(Angle1)));
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
            triangle.Angle1 = angle;
            triangle.Angle2 = angle2;
            triangle.Leg2 = Leg1 * Math.Sin(angle) / Math.Sin(triangle.angle3);
            triangle.Leg3 = Leg1 * Math.Sin(angle2) / Math.Sin(triangle.angle3);
            return triangle;
        }
        public static Triangle Two_Angles(int Leg1, int angle, int angle2)
        {
            Triangle triangle = new Triangle();
            triangle.Leg1 = Leg1;
            triangle.Angle1 = angle;
            triangle.Angle2 = angle2;
            triangle.Leg2 = Leg1 * Math.Sin(angle) / Math.Sin(triangle.angle3);
            triangle.Leg3 = Leg1 * Math.Sin(angle2) / Math.Sin(triangle.angle3);
            return triangle;
        }
        public bool isRight() //проверка на прямоугольность
        {
            try
            {
                if (Leg1 * Leg1 + Leg2 * Leg2 == Leg3 * Leg3 || Leg1 * Leg1 + Leg3 * Leg3 == Leg2 * Leg2 || Leg3 * Leg3 + Leg2 * Leg2 == Leg1 * Leg1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                throw new ArgumentException("Please enter a valid value");
            }

        }

        public override double CalculateArea() //Формула Герона
        {
            double p = CalculatePerimeter() / 2;
            return Math.Sqrt(p * (p - Leg1) * (p - Leg2) * (p - Leg3));
        }

        public override double CalculatePerimeter()
        {

            return Leg1 + Leg2 + Leg3;
        }
        private static double ToRadians(double angle)
        {
            return angle * Math.PI / 180.0;
        }
    }
}
