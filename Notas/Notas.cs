using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas
{
    internal class Notas
    {
        public double[] Notes = new double[4];
        public double promedio;

       /* public Notas(double promedio)
        {
            this.promedio = promedio;
        }*/
        public double Promediar()
        {
            double suma = 0.0; 
            for (int i = 0; i < 4; i++)
            {
                suma += Notes[i]; 
            }
            return suma / 4;
        }

        public double hallarNotaBaja()
        {
            double notita = Notes[0];
            for (int i = 1; i < 4; i++)
            {
                if (Notes[i] < notita)
                {
                    notita = Notes[i];
                }
            }
            return notita;
        }
    }
}
