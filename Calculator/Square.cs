using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Square
    {
        private int _value;

        public int Value
        {
            get { return _value; }
        }

        private String measure = "m^2";

        public Square(int value)
        {
            _value = value;
        }

        public static Square operator +(Square a, Square b)
        {
            return new Square(a._value + b._value);
        }

        public static Square operator -(Square a, Square b)
        {
            return new Square(a._value - b._value);
        }

        public static Volume operator *(Square a, Length b)
        {
            return new Volume(a._value * b.Value);
        }

        public static Volume operator *(Length a, Square b)
        {
            return b * a;
        }

        public static Length operator /(Square a, Length b)
        {
            return new Length(a._value / b.Value);
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", _value, measure);
        }
    }
}
