using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleRudnev
{
    class Triangle
    {
        public double a;
        public double b;
        public double c;
        public double h;
        public Triangle()
        {

        }
        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }
        public Triangle(double A, double H)
        {
            a = A;
            h = H;
        }

        public string outputA()
        {
            return Convert.ToString(a);
        }
        public string outputH()
        {
            return Convert.ToString(h);
        }
        public string outputB()
        {
            return Convert.ToString(b);
        }
        public string outputC()
        {
            return Convert.ToString(c);
        }
        public double Perimeter()
        {
            return a + b + c;
        }
        public double Height()
        {
            return Surface() * 2 / a;
        }
        public double Median()
        {
            return (Math.Sqrt(2 * b * b +
                            2 * c * c -
                            a * a) / 2);
        }
        public double SemiPerimter()
        {
            return Perimeter() / 2;
        }
        public double Surface()
        {
            double p = (a+b+c) /2;
            return Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
        }
        public double GetSetA
        {
            get{ return a; }
            set{ a = value; }
        }
        public double GetSetB
        {
            get { return b; }
            set { b = value; }
        }
        public double GetSetC
        {
            get { return c; }
            set { c = value; }
        }
        public double GetSetH
        {
            get { return h; }
            set { h = value; }
        }
        public bool ExistTriangle
        {
            get
            {
                if ((a < b + c) && (b < a + c) && (c < a + b)) return true;
                else return false;
            }
        }
    }

}
