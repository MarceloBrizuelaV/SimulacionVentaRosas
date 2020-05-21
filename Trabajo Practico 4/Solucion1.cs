using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico_4
{
    class Solucion1
    {
        public double calcularPrueba(double[,] matriz, int cantReservada, double precioVenta, double precioVentaCementerio, double precioCompra, double precioCompraFaltante, Boolean diaAnterior, Boolean puedeComprar, GeneradorTabla objeto) 
        {
            double columna = 0;

            if (puedeComprar)
            {
                double costo = cantReservada * precioCompra;
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    double demanda = matriz[i, matriz.GetLength(1) - 4];
                    double venta = matriz[i, matriz.GetLength(1) - 3];
                    if (demanda <= cantReservada)
                    {
                        columna = (venta + (cantReservada - demanda) * precioVentaCementerio) - costo;
                    }
                    else
                    {
                        columna = (venta - (demanda - cantReservada) * precioCompraFaltante) - costo;
                    }
                }
                return columna;
            }
            else
            {
                double costo = cantReservada * precioCompra;
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    double demanda = matriz[i, matriz.GetLength(1) - 4];
                    double venta = matriz[i, matriz.GetLength(1) - 3];
                    if (demanda < cantReservada)
                    {
                        columna = (venta + (cantReservada - demanda) * precioVentaCementerio) - costo;
                    }
                    else
                    {
                        columna = (venta - (demanda - cantReservada) * precioVenta) - costo;
                    }
                }
                return columna;
            }

        }

        //Calculo del promedio a partir de un array (el ultimo dato del mismo tiene que tener la sumatoria)
        public double calcularPromedio(double[] col)
        {
            return col[col.Length - 1] / Convert.ToDouble(col.Length - 1);
        }


        //Calcular promedio a partir de un array y lo remplaza en la ultima fila
        public void calcularPromedioMod(double [] col)
        {
            col[col.Length - 1] = col[col.Length - 1] / Convert.ToDouble(col.Length - 1);
        }
    }
}
