using System;

namespace AreaTriangulo
{
    public class Triangulo
    {
        public double A;
        public double B;
        public double C;
        public double Area;

        public void CalcularArea()
        {
            double p;
            p = (A + B + C) / 2;

            Area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }

}
