using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsola.Application
{
    public class Cuadrado
    {
        public static double Perimetro(double pi, double semiejeMenor, double semiejeMayor)
        {
            double perimetro = Math.Round(pi * (semiejeMenor + semiejeMayor), 2);
            return perimetro;
        }
        public static double Area(double pi, double semiejeMenor, double semiejeMayor)
        {
            double area = Math.Round((pi * semiejeMenor * semiejeMayor), 2);
            return area;
        }
    }
}
