﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_4
{
    class GeneradorTabla
    {
        Random rnd = new Random();

        //Generador de Random para el dia
        public double[] generadorRandomClima(int cantidad, int bandera) 
        {
            

            if (bandera == 1)
            {
                double[] valoresClima = { 0.72,0.33,0.39,0.86,0.85,0.37,0.3,0.48,0.31,0.97,0.4,0.91,0.73,0.33,0.53,0.55,0.59,0.01,0.57,0.8 };

                return valoresClima;
            }
            else 
            {
                double[] valoresClima = new double[cantidad];

                for (int i = 0; i < cantidad; i++)
                {
                    valoresClima[i] = rnd.NextDouble();
                }

                return valoresClima;
            }

        }

        public double[] generadorRandomDemanda(int cantidad, int bandera)
        {
            if (bandera == 1)
            {
                double[] valoresDemanda = {0.31, 0.87, 0.78, 0.97, 0.38, 0.63, 0.35, 0.83, 0.31, 0.14, 0.44, 0.68, 0.25, 0.06, 0.22, 0.77, 0.1, 0.29};
                return valoresDemanda;
            }
            else
            {
                double[] valoresDemanda = new double[cantidad];

                for (int i = 0; i < cantidad; i++)
                {
                    valoresDemanda[i] = rnd.NextDouble();
                }

                return valoresDemanda;
            }
        }


        //Coment 1
        //Coment 2
        //Coment 3
    }

    
}
