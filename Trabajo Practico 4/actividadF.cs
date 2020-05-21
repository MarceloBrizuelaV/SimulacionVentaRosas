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
        public double calcular(double[,] matriz, int reserva, double precioVenta, double precioVentaCementerio, double precioCompra, double precioCompraFaltante, Boolean diaAnterior, Boolean puedeComprar)

        {
            double columna = 0;
            double perdida = 1.20;

            if (puedeComprar)
            {

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    double gastado = reserva * 8;
                    double demanda = matriz[i, 4];
                    double precio = matriz[i, 5];

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
                    double demanda = matriz[i, 4];
                    double precio = matriz[i, 5];

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
