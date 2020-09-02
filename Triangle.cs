using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleRudnev
{
    class Triangle
    {
        public double a;
        public double b;
        public double c;
        public double h;
        public Triangle() { }
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
        public double hA()
        {
            return Surface() / 2 / a;
        }
        public double hB()
        {
            return Surface() / 2 / b;
        }
        public double hC()
        {
            return Surface() / 2 / c;
        }
        public double SemiPerimter()
        {
            return Perimeter() / 2;
        }
        public double Surface()
        {
          double p = a + b + c;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public string TriangleType()
        {
            string type = "";
            if (a == b && b == c)
            {
                type = "Равносторонний";
            }
            else if ((a == b) && (a != c) || (b == c) && (b != a) || (a == c) && (a != b))
            {
                type = "Равнобедренный";
            }
            else if(a!= b || b!=c)
            {
                type = "Разносторонний";
            }
            else if (c *2 == (a*2+b*2))
            {
                type = "Правильный";
            }
            else if (c*2 > (a*2+b*2))
            {
                type = "Тупоугольный";
            }
            else if (c*2 < (a*2+b*2))
            {
                type = "Остроугольный";
            }
            return type;
        }
        public string ImageSource()
        {
            string source = Application.StartupPath+ "\\" +  "img" + "\\";
            switch (TriangleType())
            {
                case "Равносторонний":
                    source += "equilateral";
                    break;
                case "Равнобедренный":
                    source += "isosceles";
                    break;
                case "Разносторонний":
                    source += "scalene";
                    break;
                case "Правильный":
                    source += "right";
                    break;
                case "Тупоугольный":
                    source += "obtuse";
                    break;
                case "Остроугольный":
                    source += "acute";
                    break;
            }
            return source+=".PNG".Replace(@"\", "/");
        }
        public double Side1Surface()
        {
            return  a /2 *h;
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
