using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTDD.Services
{
    public class MathService : IMathService
    {
        public int Addition(int nb1, int nb2)
        {
            if((long)nb1 + (long)nb2 > int.MaxValue)
                throw new OutOfRangeMathException();

            return nb1 + nb2 ;
        }
        public int Soustraction(int nb1, int nb2)
        {
            if ((long)nb1 - (long)nb2 < int.MinValue)
                throw new OutOfRangeMathException();

            return nb1 - nb2;
        }

        public int Division(int nb1, int nb2)
        {
            return nb1/ nb2;
        }

        public int Multiplication(int nb1, int nb2)
        {
            if((long)nb1 * (long)nb2 > int.MaxValue || (long)nb1 * (long)nb2 < int.MinValue)
                throw new OutOfRangeMathException();

            return nb1 * nb2;
        }

        public int Puissance(int nb, int puissance)
        {
            bool isNegative = puissance < 0;

            if(isNegative)
                puissance *= -1;

            int result = 1;

            for(int i = 0; i < puissance; i++)
            {
                if ((long)result * (long)nb > int.MaxValue)
                    throw new OutOfRangeMathException();
                result *= nb;
            }

            if (isNegative) return 1 / result;

            return result;
        }

        public double Racine(int nb, int racine)
        {
            return Math.Sqrt(nb);
        }

        public bool isEven(int nb)
        {
            return nb % 2 == 0;
        }
    }
}
