using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea05_POO.Domain
{
    internal class Elipse
    {
        private double semiEjeMayor;
        private double semiEjeMenor;

        public Elipse(double semiEjeMayor1, double semiEjeMenor1)
        {
            semiEjeMayor = semiEjeMayor1;
            semiEjeMenor = semiEjeMenor1;
        }
        public double calcularArea()
        {
            return Math.PI * semiEjeMayor * semiEjeMenor;
        }
        public double calcularPerimetro()
        {
            return Math.PI * (3(semiEjeMayor+ semiEjeMenor)-Math.Sqrt((3*semiEjeMayor + semiEjeMenor)*(semiEjeMayor+3*semiEjeMenor)))
        }
        public void moverElipse(double desplazamientoX, double desplazamientoY)
        {
            x = desplazamientoX;
            y = desplazamientoY;
        }
    }
}
