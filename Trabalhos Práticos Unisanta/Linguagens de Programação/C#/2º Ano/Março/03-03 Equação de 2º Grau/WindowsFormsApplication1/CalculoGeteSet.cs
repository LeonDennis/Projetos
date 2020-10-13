using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class CalculoGeteSet
    {
        private string a, b, c, delta, x1, x2;
        bool deltacalculado = false;
        public void setA(string a1) { a = a1; }
        public String getA() { return a; }
        public void setB(string b1) { b = b1; }
        public String getB() { return b; }
        public void setC(string c1) { c = c1; }
        public String getC() { return c; }

        public String CalcDelta()
        {
            do
            {
                delta = ((((float.Parse(b) * float.Parse(b)) - ((4 * float.Parse(a)) * float.Parse(c))).ToString()));
                deltacalculado = true;
            } 
            while (deltacalculado == false);

            return delta;
        }
        public String CalcX1()
        {
            x1 = (((-float.Parse(b)) + (Math.Sqrt(Convert.ToDouble(delta)))) / (2 * float.Parse(a))).ToString();
            return x1;
        }
        public String CalcX2()
        {
            x2 = (((-float.Parse(b)) - (Math.Sqrt(Convert.ToDouble(delta)))) / (2 * float.Parse(a))).ToString();
            return x2;
        }
    }
}
