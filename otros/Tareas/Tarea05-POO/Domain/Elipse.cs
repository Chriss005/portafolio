using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea05_POO.Domain
{
    internal class Elipse
    {
        public double semiEjeMayor;
        public double semiEjeMenor;

        public double calcularArea()
        {
            return Math.PI * semiEjeMayor * semiEjeMenor;
        }
        public double calcularPerimetro()
        {
            return Math.PI * (3(semiEjeMayor+ semiEjeMenor)-Math.Sqrt((3*semiEjeMayor + semiEjeMenor)*(semiEjeMayor+3*semiEjeMenor)))
        }
        public void moverElipse(double nuevaX, double nuevaY)
        {
            x = nuevaX;
            y = nuevaY;
        }
    }
}
