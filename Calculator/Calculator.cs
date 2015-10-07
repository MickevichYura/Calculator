using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    static class Calculator
    {
        static void Main(string[] args)
        {
            Length length = new Length(2);
            Square square = new Square(4);
            Volume volume = new Volume(8);
            Time time = new Time(10);
            Mass mass = new Mass(30);
            Velocity velocity = length / time;
            Force force = new Force(100);
            Puls puls = new Puls(10);

            Console.WriteLine(mass * velocity / time * length);
            Console.WriteLine(puls / force);

            Console.Read();
        }
    }
}
