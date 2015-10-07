using System;

namespace PhysicsLibrary
{
    public class Mass
    {
        private double _value;

        public double Value
        {
            get { return _value; }
        }

        private String measure = "kg";

        public Mass(double value)
        {
            _value = value;
        }

        public static Mass operator +(Mass a, Mass b)
        {
            return new Mass(a._value + b._value);
        }

        public static Mass operator -(Mass a, Mass b)
        {
            return new Mass(a._value - b._value);
        }

        public static Puls operator *(Mass a, Velocity b)
        {
            return new Puls(a.Value * b.Value);
        }

        public static Puls operator *(Velocity a, Mass b)
        {
            return b * a;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", _value, measure);
        }
    }
}
