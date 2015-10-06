using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Length
    {
        private int _value;

        public int Value
        {
            get { return _value; }
        }

        private String measure = "m";

        public Length(int value)
        {
            _value = value;
        }

        public static Length operator +(Length a, Length b)
        {
            return new Length(a._value + b._value);
        }

        public static Length operator -(Length a, Length b)
        {
            return new Length(a._value - b._value);
        }

        public static Square operator *(Length a, Length b)
        {
            return new Square(a._value * b._value);
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", _value, measure);
        }
    }
}
