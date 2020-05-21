using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico_4
{
    class actividadF
    {
        /*/public double[,] segundaSolucion(int cantidadDias, int cantReservada, double precioVenta, Boolean diaAnterior, Boolean Aleatorio)
        {
            GeneradorTabla generador = new GeneradorTabla();
            actividadF calc = new actividadF();
            Herramientas h = new Herramientas();
            double[,] tabla;
            double[] ganancias;


            if (Aleatorio)
            {
                tabla = generador.tablaBase(cantidadDias, !Aleatorio, precioVenta);
            }
            else
            {
                tabla = generador.tablaBase(20, true, precioVenta);
            }
            
            ganancias = calc.calcular(tabla, cantReservada, diaAnterior);
            
            if (Aleatorio)
            {
                tabla = generador.tablaBase(cantidadDias, !Aleatorio, 12);
            }
            else
            {
                tabla = generador.tablaBase(20, true, 12);
            }
            ganancias = calc.calcular(tabla, cantReservada, diaAnterior);


            calc.calcularPromedioMod(ganancias);


            double[,] matriz = h.concatenarMatriz(tabla, ganancias);
            return matriz;
        } /*/


        public double calcular(double[,] matriz, int reserva, double precioVenta, double precioVentaCementerio, double precioCompra, double precioCompraFaltante, Boolean diaAnterior, Boolean puedeComprar)
        //double[,] matriz, int cantReservada, double precioVenta, double precioVentaCementerio, double precioCompra, double precioCompraFaltante, Boolean diaAnterior, Boolean puedeComprar

        {
            double columna = 0;
            double perdida = 1.20;

            if (puedeComprar)
            {

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    double gastado = reserva * 8;
                    double demanda = matriz[i, 2];
                    double precio = matriz[i, 3];

                    if (demanda > reserva)
                    {
                        columna = ((precio - (demanda - reserva) * 12) - (demanda - reserva) * perdida) - gastado;
                    }

                    else
                    {
                        columna = ((precio) - (reserva - demanda) * perdida) - gastado;
                    }

                }

            }
            else
            {
                double gastado = reserva * 8;
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    double demanda = matriz[i, 2];
                    double precio = matriz[i, 3];

                    if (demanda > reserva)
                    {
                        columna = ((precio - (demanda - reserva) * 12) - (demanda - reserva) * perdida) - gastado;
                    }

                    else
                    {
                        columna = ((precio) - (reserva - demanda) * perdida) - gastado;
                    }

                }
            }
            return columna;           
        }



        private void calcularPromedioMod(double[] col)
        {
            col[col.Length - 1] = col[col.Length - 1] / Convert.ToDouble(col.Length - 1);
        }

    }
}
