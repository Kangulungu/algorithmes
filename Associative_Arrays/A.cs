using System;
using System.Collections.Generic;
using System.Text;

namespace Associative_Arrays
{
    public class A
    {
        private double d, e, f;

        public A(double v)
        {
            d = e = f = v;
        }

        public double this[string str]
        {
            get
            {
                switch (str)
                {
                    case "d": { return d; }
                    case "e": { return e; }
                    case "f": { return f; }
                    default: throw new Exception("Error");
                }
            }
            set
            {
                switch (str)
                {
                    case "d": { d = value; break; }
                    case "e": { e = value; break; }
                    case "f": { f = value; break; }
                    default: throw new Exception("Error");
                }
            }
        }

        public override string ToString()
        {
            return "A: " + d + ", " + e + ", " + f;
        }

    }
}
