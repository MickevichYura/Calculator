using System;

namespace PhysicsLibrary
{
    public class Time
    {
        private double _value;

        public double Value
        {
            get { return _value; }
        }

        private String measure = "s";

        public Time(double value)
        {
            _value = value;
        }

        public static Time operator +(Time a, Time b)
        {
            return new Time(a._value + b._value);
        }

        public static Time operator -(Time a, Time b)
        {
            return new Time(a._value - b._value);
        }

        public static Velocity operator /(Length a, Time b)
        {
            return new Velocity(a.Value * b.Value);
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", _value, measure);
        }
    }
}
