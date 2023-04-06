using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTDD
{
    public class MathException : Exception
    {
        public MathException(string? message) : base(message)
        {
        }
    }
    public class OutOfRangeMathException : MathException
    {
        public OutOfRangeMathException() : base("Valeur trop grande pour un entier")
        {
        }
    }
}
