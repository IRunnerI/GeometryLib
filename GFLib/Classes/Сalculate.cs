

namespace GFLib
{
    public static class Сalculate
    {
        public static double AreaCircle(double radius) 
        {
            if (radius < 0) {
                throw new ArgumentException("Please enter a valid value");
            }
            return Math.PI * radius * radius;
        }
        public static double PerimeterCircle(double radius)
        {
            if (radius < 0) {
                throw new ArgumentException("Please enter a valid value");
            }
            return 2 * Math.PI * radius;
        }
        public static double AreaCircle(int radius) 
        {
            if (radius < 0) {
                throw new ArgumentException("Please enter a valid value");
            }
            return Math.PI * radius * radius;
        }
        public static double PerimeterCircle(int radius)
        {
            if (radius < 0) {
                throw new ArgumentException("Please enter a valid value");
            }
            return 2 * Math.PI * radius;
        }
        public static double AreaCircle(short radius) 
        {
            if (radius < 0) {
                throw new ArgumentException("Please enter a valid value");
            }
            return Math.PI * radius * radius;
        }
        public static double PerimeterCircle(short radius) 
        {
            if (radius < 0) {
                throw new ArgumentException("Please enter a valid value");
            }
            return 2 * Math.PI * radius;
        }
        public static double AreaCircle(float radius) 
        {
            if (radius < 0) {
                throw new ArgumentException("Please enter a valid value");
            }
            return Math.PI * radius * radius;
        }
        public static double PerimeterCircle(float radius) 
        {
            if (radius < 0) {
                throw new ArgumentException("Please enter a valid value");
            }
            return 2 * Math.PI * radius;
        }
        public static double AreaCircle(string radius) 
        {
            if (Convert.ToDouble(radius) < 0) {
                throw new ArgumentException("Please enter a valid value");
            }
            return Math.PI * Convert.ToDouble(radius) * Convert.ToDouble(radius);
        }
        public static double PerimeterCircle(string radius) 
        {
            if (Convert.ToDouble(radius) < 0) {
                throw new ArgumentException("Please enter a valid value");
            }
            return 2 * Math.PI * Convert.ToDouble(radius);
        }


        public static double AreaTriangle(double Leg1, double Leg2, double angle) 
        {

            double Leg3 = Math.Sqrt(Leg1 * Leg1 + Leg2 * Leg2 - 2 * Leg1 * Leg2 * Math.Cos(ToRadians(angle)));
            double p = PerimeterTriangle(Leg1, Leg2, angle) / 2;
            return Math.Sqrt(p * (p - Leg1) * (p - Leg2) * (p - Leg3));
        }
        public static double PerimeterTriangle(double Leg1, double Leg2, double angle) 
        {
            double Leg3 = Math.Sqrt(Leg1 * Leg1 + Leg2 * Leg2 - 2 * Leg1 * Leg2 * Math.Cos(ToRadians(angle)));
            return Leg1 + Leg2 + Leg3;
        }
        public static double AreaTriangle(string Leg1, string Leg2, string angle) {

            try 
            {
                double leg1 = Convert.ToDouble(Leg1);
                double leg2 = Convert.ToDouble(Leg2);
                double angle1 = Convert.ToDouble(angle);
                double Leg3 = Math.Sqrt(leg1 * leg1 + leg2 * leg2 - 2 * leg1 * leg2 * Math.Cos(ToRadians(angle1)));
                double p = PerimeterTriangle(Leg1, Leg2, angle) / 2;
                return Math.Sqrt(p * (p - leg1) * (p - leg2) * (p - Leg3));
            }
            catch 
            {
                throw new ArgumentException("Please enter a valid value");
            }

        }
        public static double PerimeterTriangle(string Leg1, string Leg2, string angle) 
        {
            double leg1 = Convert.ToDouble(Leg1);
            double leg2 = Convert.ToDouble(Leg2);
            double angle1 = Convert.ToDouble(angle);
            double Leg3 = Math.Sqrt(leg1 * leg1 + leg2 * leg2 - 2 * leg1 * leg2 * Math.Cos(ToRadians(angle1)));
            return leg1 + leg2 + Leg3;
        }
        public static double ToRadians(double angle) {
            return angle * Math.PI / 180.0;
        }
    }
}
