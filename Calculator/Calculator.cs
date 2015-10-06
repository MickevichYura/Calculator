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

            Console.WriteLine(length + length);
            Console.WriteLine(length - length);
            Console.WriteLine(length * length);
            Console.WriteLine(length * length * length);
            Console.WriteLine(square * length);
            Console.WriteLine(length * square);
            Console.WriteLine(volume / square);

            Console.Read();
        }
    }
}
