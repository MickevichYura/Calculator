using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Work
    {
        private double _value;

        public double Value
        {
            get { return _value; }
        }

        private String measure = "J (kg*m^2/s^2)";

        public Work(double value)
        {
            _value = value;
        }

        public static Work operator +(Work a, Work b)
        {
            return new Work(a._value + b._value);
        }

        public static Work operator -(Work a, Work b)
        {
            return new Work(a._value - b._value);
        }

        public static Length operator /(Work a, Force b)
        {
            return new Length(a.Value * b.Value);
        }

        public static Force operator /(Work a, Length b)
        {
            return new Force(a.Value * b.Value);
        }

        public static Velocity operator /(Work a, Puls b)
        {
            return new Velocity(a.Value * b.Value);
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", _value, measure);
        }
    }
}
