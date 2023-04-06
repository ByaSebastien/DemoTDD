using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTDD.Services
{
    public interface IMathService
    {
        int Addition(int nb1, int nb2);
        int Soustraction(int nb1, int nb2);
        int Multiplication(int nb1, int nb2);
        int Division(int nb1, int nb2);
        int Puissance(int nb, int puissance);
        double Racine(int nb, int racine);
        bool isEven(int nb);
    }
}
