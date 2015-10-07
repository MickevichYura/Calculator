using System;

namespace PhysicsLibrary
{
    public class Length
    {
        private double _value;

        public double Value
        {
            get { return _value; }
        }

        private String measure = "m";

        public Length(double value)
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
