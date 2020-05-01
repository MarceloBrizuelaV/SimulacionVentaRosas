using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_4
{
    class Solucion1
    {


        public double[] calcular(double[,] matriz, int cantReservada, Boolean anterior)
        {
            double[] columna = new double[matriz.GetLength(0) + 1];
            
            double gananciaAcumulada = 0;
            if (anterior)
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    double costo = cantReservada * 8;
                    double demanda = matriz[i, matriz.GetLength(1) - 2];
                    double venta = matriz[i, matriz.GetLength(1) - 1];
                    if (demanda < cantReservada)
                    {
                        columna[i] = (venta + (cantReservada - demanda) * 1.2) - costo;
                    }
                    else
                    {
                        columna[i] = (venta - (demanda - cantReservada) * 12) - costo;
                    }

                    cantReservada = Convert.ToInt32(demanda);
                    gananciaAcumulada += columna[i];
                    
                }
            }
            else
            {
                double costo = cantReservada * 8;
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    double demanda = matriz[i, matriz.GetLength(1) - 2];
                    double venta = matriz[i, matriz.GetLength(1) - 1];
                    if (demanda < cantReservada)
                    {
                        columna[i] = (venta + (cantReservada - demanda) * 1.2) - costo;
                    }
                    else
                    {
                        columna[i] = (venta - (demanda - cantReservada) * 12) - costo;
                    }

                    gananciaAcumulada += columna[i];
                }
            }
            columna[columna.Length - 1] = gananciaAcumulada;
            return columna;
        }

        






        public double calcularPromedio(double[] col)
        {
            return col[col.Length - 1] / Convert.ToDouble(col.Length - 1);
        }
        //HOLA









    }
}
