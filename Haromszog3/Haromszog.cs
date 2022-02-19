using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszog3
{
    class Haromszog
    {
        private double a;
        private double b;
        private double c;
        public double GetA() { return a; }
        public double GetB() { return b; }
        public double GetC() { return c; }
        public Haromszog(double aa, double bb, double cc)
        {
            a = aa;
            b = bb;
            c = cc;
        }
        public bool Egyenloszaru()
        {
            if (a==b || b==c || a == c) { return true; }
            else { return false; }
        }
        public bool Szabalyos()
        {
            if (a==b && a==c) { return true; }
            else { return false; }
        }
        public double Kerulet()
        {
            return a + b + c;
        }
        public double Terulet()
        {
            //Herón képlete
            double s = (a + b + c) / 2;
            return Math.Sqrt(s*(s-a)*(s-b)*(s-c));
        }

    }
}
