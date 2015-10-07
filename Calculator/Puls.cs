using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Puls
    {
        private double _value;

        public double Value
        {
            get { return _value; }
        }

        private String measure = "kg*m/s";

        public Puls(double value)
        {
            _value = value;
        }

        public static Puls operator +(Puls a, Puls b)
        {
            return new Puls(a._value + b._value);
        }

        public static Puls operator -(Puls a, Puls b)
        {
            return new Puls(a._value - b._value);
        }

        public static Velocity operator /(Puls a, Mass b)
        {
            return new Velocity(a.Value * b.Value);
        }

        public static Force operator /(Puls a, Time b)
        {
            return new Force(a.Value * b.Value);
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", _value, measure);
        }
    }
}
