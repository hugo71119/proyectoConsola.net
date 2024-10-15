using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsola.Application
{
    public class VolumenElipse
    {
        public static double Volumen(double area, double altura)
        {
            double volumen = area * altura;
            return volumen;
        }
    }
}
