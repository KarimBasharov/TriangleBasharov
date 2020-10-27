using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleBasharov
{
    class Triangle
    {
        public double a; // первая сторона
        public double b; // вторая сторона
        public double c; // третья сторона
        public double r; // радиус описанной окружности

        public Triangle() // конструктор. Создаем с заданным радиусом.
        {
            
        }
        public Triangle(double A, double B, double C, double R)
        {
            r = R;
            a = A;
            b = B;
            c = C;
        }
        public string outputA()
        {
            return Convert.ToString(a);
        }
        public string outputB()
        {
            return Convert.ToString(b);
        }
        public string outputC()
        {
            return Convert.ToString(c);
        }
        public string outputR() // выводим r - радиус.
        {
            return Convert.ToString(r);
        }

        public double Height() //нахождение высоты треугольника через радиус.
        {
            double h = 0;
            h = b * c / 2 * r;
            return h;
        }
        public double Perimeter()
        {
            double p = 0;
            p = a + b + c;
            return p;
        }
        public double Surface()
        {
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;
        }
        public double Pif1()
        {
            double dat = 0;
            double pif = 0;
            int s = 2;
            dat = Math.Pow(a, s) + Math.Pow(b, s);
            pif = Math.Sqrt(dat);
            return pif;
        }
        public double Pif2()
        {
            double dat2 = 0;
            double pif2 = 0;
            int s = 2;
            dat2 = Math.Pow(c, s) - Math.Pow(b, s);
            pif2 = Math.Sqrt(dat2);
            return pif2;
        }
        public double Pif3()
        {
            double dat3 = 0;
            double pif3 = 0;
            int s = 2;
            dat3 = Math.Pow(c, s) - Math.Pow(a, s);
            pif3 = Math.Sqrt(dat3);
            return pif3;
        }

        /*public double Sinus()
        {
            double sinus = 0;
            double alpha = 0;
        }*/
        public double GetSetA
        {
            get
            { return a; }
            set
            { a = value; }
        }
        public double GetSetB
        {
            get
            { return b; }
            set
            { b = value; }
        }
        public double GetSetC
        {
            get
            { return c; }
            set
            { c = value; }
        }

        public double GetSetR // это свойство позволяет установить или же изменить значение радиуса r.
        {
            get
            { return r; }
            set
            { r = value; }
        }
        public bool ExistTriangle
        {
            get
            {
                if ((a < b + c) && (b < a + c) && (c < a + b))
                    return true;
                else return false;            
            }

        }
    }
}
