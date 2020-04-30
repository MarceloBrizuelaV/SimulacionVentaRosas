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

        //Funcion que retorna el dia 
        public int getClima( double random)
        {
            if(random <= 0.24)
            {
                //Dia Nublado
                return (2);
            }
            else
            {
                //Dia Soleado
                return (1);
            }
        }

        //Funcion que retorna la demanda segun dia y random
        public int getDemanda(double random, int dia) {
            switch (dia)
            {
                case 1:
                     if(random <= 0.09)
                    {
                        return (6);
                    }
                     else if( random <= 0.29)
                    {
                        return (7);
                    }
                     else if (random <= 0.74)
                    {
                        return (8);
                    }
                    else return (9);
           
                case 2:
                    if (random <= 0.05)
                    {
                        return (3);
                    }
                    else if (random <= 0.2)
                    {
                        return (4);
                    }
                    else if (random <= 0.6)
                    {
                        return (5);
                    }
                    else if (random <= 0.85)
                    {
                        return (6);
                    }
                    else return (7);
                default:
                    Console.WriteLine("Dia incorrecto");
                    return (0);
            }


        }


        //Simulador Principal
      

    }

    
}