using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea04_POO.Domain
{
    public class Cliente
    {
        public string nombre;
        public double saldo;

        public void comprar(double total)
        {
            if (saldo >= total)
            {
                saldo -= total;
            }
        }
    }
}
