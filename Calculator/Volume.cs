using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Volume
    {
        private double _value;

        public double Value
        {
            get { return _value; }
        }

        private String measure = "m^3";

        public Volume(double value)
        {
            _value = value;
        }

        public static Volume operator +(Volume a, Volume b)
        {
            return new Volume(a._value + b._value);
        }

        public static Volume operator -(Volume a, Volume b)
        {
            return new Volume(a._value - b._value);
        }

        public static Length operator /(Volume a, Square b)
        {
            return new Length(a._value / b.Value);
        }

        public static Square operator /(Volume a, Length b)
        {
            return new Square(a._value / b.Value);
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", _value, measure);
        }
    }
}
