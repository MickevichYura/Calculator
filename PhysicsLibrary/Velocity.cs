using System;

namespace PhysicsLibrary
{
    public class Velocity
    {
        private double _value;

        public double Value
        {
            get { return _value; }
        }

        private String measure = "m/s";

        public Velocity(double value)
        {
            _value = value;
        }

        public static Velocity operator +(Velocity a, Velocity b)
        {
            return new Velocity(a._value + b._value);
        }

        public static Velocity operator -(Velocity a, Velocity b)
        {
            return new Velocity(a._value - b._value);
        }

        public static Acceleration operator /(Velocity a, Time b)
        {
            return new Acceleration(a.Value * b.Value);
        }

        public static Length operator *(Velocity a, Time b)
        {
            return new Length(a.Value * b.Value);
        }

        public static Length operator *(Time a, Velocity b)
        {
            return b * a;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", _value, measure);
        }
    }
}
