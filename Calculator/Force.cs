using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Force
    {
        private double _value;

        public double Value
        {
            get { return _value; }
        }

        private String measure = "N (kg*m/s^2)";

        public Force(double value)
        {
            _value = value;
        }

        public static Force operator +(Force a, Force b)
        {
            return new Force(a._value + b._value);
        }

        public static Force operator -(Force a, Force b)
        {
            return new Force(a._value - b._value);
        }

        public static Work operator *(Force a, Length b)
        {
            return new Work(a.Value * b.Value);
        }

        public static Work operator *(Length a, Force b)
        {
            return b*a;
        }

        public static Puls operator *(Force a, Time b)
        {
            return new Puls(a.Value * b.Value);
        }

        public static Puls operator *(Time a, Force b)
        {
            return b * a;
        }

        public static Time operator /(Puls a, Force b)
        {
            return new Time(a.Value / b.Value);
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", _value, measure);
        }
    }
}
