using System;

namespace Trabajo_Practico_4
{
    class GeneradorTabla
    {
        Random rnd = new Random();
        public double demandaGlobal
        {
            get { return demandaGlobal; }
            set { demandaGlobal = value; }
        }

        //Generador de Random para el dia

        public double generadorRandomDemanda(int i, Boolean valoresFijos)
        {
            if (valoresFijos)
            {
                double[] valoresDemanda = { 0.31, 0.87, 0.78, 0.97, 0.38, 0.63, 0.35, 0.83, 0.31, 0.14, 0.44, 0.68, 0.24, 0.06, 0.22, 0.9, 0.27 ,0.77, 0.1, 0.29 };

                return valoresDemanda[i];
            }
            else
            {        
                return rnd.NextDouble();
            }
        }



        public double generadorRandomClima(int i, Boolean valoresFijos) 
        {
            

            if (valoresFijos)
            {
                double[] valoresClima = { 0.72,0.33,0.39,0.86,0.85,0.37,0.3,0.48,0.31,0.97,0.4,0.91,0.73,0.33,0.53,0.55,0.59,0.01,0.57,0.8 };

                return valoresClima[i];
            }
            else 
            {
                return rnd.NextDouble();
            }

        }

        //Funcion que retorna el dia 
        public int getClima(double random)
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


            public double[,] tablaBase(int reserva, double precioVenta, double precioVentaCementerio, double precioCompra, double precioCompraFaltante, Boolean diaAnterior, Boolean puedeCompra, int iteracion, Boolean aleatorio, double acumulada) 
        {
            double demanda = generadorRandomDemanda(iteracion, aleatorio);
            double clima = generadorRandomClima(iteracion, aleatorio);

            Solucion1 ganancia = new Solucion1();

            double[,] matrizBase = new double[1, 8];

            //Cuento las iteraciones
            matrizBase[0, 0] = iteracion + 1;

            //Random Clima
            matrizBase[0, 1] = clima;

            //Obtengo el clima
            int climaFinal = getClima(clima);
            matrizBase[0, 2] = Convert.ToDouble(climaFinal);

            //Random demanda
            matrizBase[0, 3] = demanda;

            //Obtengo la demanda
            int demandaFinal = getDemanda(demanda, climaFinal);
            matrizBase[0, 4] = Convert.ToDouble(demandaFinal);

            //Calculo el precio
            double precio = demandaFinal * precioVenta;
            matrizBase[0, 5] = precio;

            //Obtengo la ganancia
            matrizBase[0, 6] = ganancia.calcularPrueba(matrizBase,reserva,precioVenta,precioVentaCementerio,precioCompra,precioCompraFaltante,diaAnterior,puedeCompra);

            //Guardo la acumulada
            matrizBase[0, 7] = matrizBase[0, 6] + acumulada;

            return matrizBase;
        }

        public double[,] tablaBase1(int reserva, double precioVenta, double precioVentaCementerio, double precioCompra, double precioCompraFaltante, Boolean diaAnterior, Boolean puedeCompra, int iteracion, Boolean aleatorio, double acumulada)
        {
            double demanda = generadorRandomDemanda(iteracion, aleatorio);
            double clima = generadorRandomClima(iteracion, aleatorio);

            actividadF ganancia = new actividadF();

            double[,] matrizBase = new double[1, 8];

            //Cuento las iteraciones
            matrizBase[0, 0] = iteracion + 1;

            //Random Clima
            matrizBase[0, 1] = clima;

            //Obtengo el clima
            int climaFinal = getClima(clima);
            matrizBase[0, 2] = Convert.ToDouble(climaFinal);

            //Random demanda
            matrizBase[0, 3] = demanda;

            //Obtengo la demanda
            int demandaFinal = getDemanda(demanda, climaFinal);
            matrizBase[0, 4] = Convert.ToDouble(demandaFinal);

            //Calculo el precio
            double precio = demandaFinal * precioVenta;
            matrizBase[0, 5] = precio;

            //Obtengo la ganancia
            matrizBase[0, 6] = ganancia.calcular(matrizBase, reserva, precioVenta, precioVentaCementerio, precioCompra, precioCompraFaltante, diaAnterior, puedeCompra);

            //Guardo la acumulada
            matrizBase[0, 7] = matrizBase[0, 6] + acumulada;



            return matrizBase;
        }

        /*/public double[,] tablaBase()
        {
            return tablaBase(20, true, 12);
        }/*/

    }

    
}
