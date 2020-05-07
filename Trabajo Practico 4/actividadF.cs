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
        public double[,] segundaSolucion(int cantidadDias, int cantReservada, double precioVenta, Boolean diaAnterior, Boolean Aleatorio)
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
        }


        private double[] calcular(double[,] matriz, int reserva, Boolean diaAnterior)
        //double[,] matriz, int cantReservada, double precioVenta, double precioVentaCementerio, double precioCompra, double precioCompraFaltante, Boolean diaAnterior, Boolean puedeComprar

        {
            GeneradorTabla tabla = new GeneradorTabla();
            double gananciaAcumulada = 0;

            //Busco la matriz original.
            //double[,] matriz = new double[cantidad,4];
            double[] columna = new double[matriz.GetLength(0) + 1];
            
            //matriz = tabla.tablaBase(cantidad, true, 12);
            double perdida = 1.20;
            

            //Realizo una matriz con los datos de ganancia y los dias.
            //double[] columna = new double[cantidad + 1];

            if (diaAnterior)
            {

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    double gastado = reserva * 8;
                    double demanda = matriz[i, 2];
                    double precio = matriz[i, 3];

                    if (demanda > reserva)
                    {
                        columna[i] = ((precio - (demanda - reserva) * 12) - (demanda - reserva) * perdida) - gastado;
                    }

                    else
                    {
                        columna[i] = ((precio) - (reserva - demanda) * perdida) - gastado;
                    }

                    //columna[columna.GetLength(0) - 1] += columna[i];
                    gananciaAcumulada += columna[i];
                    reserva = Convert.ToInt32(demanda);
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
                        columna[i] = ((precio - (demanda - reserva) * 12) - (demanda - reserva) * perdida) - gastado;
                    }

                    else
                    {
                        columna[i] = ((precio) - (reserva - demanda) * perdida) - gastado;
                    }

                    gananciaAcumulada += columna[i];
                    //columna[columna.GetLength(0) - 1] += columna[i];
                }
            }
            columna[columna.Length - 1] = gananciaAcumulada;
            return columna;           
        }



        private void calcularPromedioMod(double[] col)
        {
            col[col.Length - 1] = col[col.Length - 1] / Convert.ToDouble(col.Length - 1);
        }

    }
}
