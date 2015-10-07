using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Acceleration
    {
        private double _value;

        public double Value
        {
            get { return _value; }
        }

        private String measure = "m/s^2";

        public Acceleration(double value)
        {
            _value = value;
        }

        public static Acceleration operator +(Acceleration a, Acceleration b)
        {
            return new Acceleration(a._value + b._value);
        }

        public static Acceleration operator -(Acceleration a, Acceleration b)
        {
            return new Acceleration(a._value - b._value);
        }

        public static Velocity operator *(Acceleration a, Time b)
        {
            return new Velocity(a.Value * b.Value);
        }

        public static Velocity operator *(Time a, Acceleration b)
        {
            return b * a;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", _value, measure);
        }
    }
}
