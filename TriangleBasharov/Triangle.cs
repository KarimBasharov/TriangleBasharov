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
            double okr = 0;
            int s = 2;
            dat = Math.Pow(a, s) + Math.Pow(b, s);
            pif = Math.Sqrt(dat);
            okr = Math.Round(pif);
            return okr;
        }
        public double Pif2()
        {
            double dat2 = 0;
            double pif2 = 0;
            double okr = 0;
            int s = 2;
            dat2 = Math.Pow(c, s) - Math.Pow(b, s);
            pif2 = Math.Sqrt(dat2);
            okr = Math.Round(pif2);
            return okr;
        }
        public double Pif3()
        {
            double dat3 = 0;
            double pif3 = 0;
            double okr = 0;
            int s = 2;
            dat3 = Math.Pow(c, s) - Math.Pow(a, s);
            pif3 = Math.Sqrt(dat3);
            okr = Math.Round(pif3);
            return okr;
        }
        public double alpha()
        {
            double alp = 0;
            double gra = 0;
            double alpha = 0;
            int s = 2;
            alp = (Math.Pow(a, s) + Math.Pow(c, s) - Math.Pow(b, s)) / (2 * a * c);
            gra = Math.Acos(Math.Cos(alp)) * (180.0 / Math.PI);
            alpha = Math.Round(gra);
            return alpha;
        }
        public double beta()
        {
            double bete = 0;
            double gra = 0;
            double beta = 0;
            int s = 2;
            bete = (Math.Pow(a, s) + Math.Pow(b, s) - Math.Pow(c, s)) / (2 * a * b);
            gra = Math.Acos(Math.Cos(bete)) * (180.0 / Math.PI);
            beta = Math.Round(gra);
            return beta;
        }
        public double gamma()
        {
            double gam = 0;
            double gra = 0;
            double gamma = 0;
            int s = 2;
            gam = (Math.Pow(b, s) + Math.Pow(c, s) - Math.Pow(a, s)) / (2 * c * b);
            gra = Math.Acos(Math.Cos(gam)) * (180.0 / Math.PI);
            gamma = Math.Round(gra);
            return gamma;
        }
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