using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea05_POO.Domain
{
    public class Circunferencia
    {
        public double x;
        public double y;
        public double radio;

        public double calcularArea()
        {
            return Math.PI * radio * radio;
        }

        public double calcularPerimetro()
        {
            return (2 * Math.PI) * radio; 
        }

        public void moverCircunferencia(double nuevaX, double nuevaY)
        {
            x = nuevaX;
            y = nuevaY;
        }
    }
}
