using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_4
{
    class actividadF
    {
        public double[] puntoA(int cantidad, int reserva, Boolean check)
        
        {
            GeneradorTabla tabla = new GeneradorTabla();

            //Busco la matriz original.
            double[,] matriz = new double[cantidad,4];
            matriz = tabla.tablaBase(cantidad, 1);

            double perdida = 1.20;
            

            //Realizo una matriz con los datos de ganancia y los dias.
            double[] minimatriz = new double[cantidad + 1];

            if (check)
            {

                for (int i = 0; i < cantidad; i++)
                {
                    double gastado = reserva * 8;
                    double demanda = matriz[i, 2];
                    double precio = matriz[i, 3];

                    if (demanda > reserva)
                    {
                        minimatriz[i] = ((precio - (demanda - reserva) * 12) - (demanda - reserva) * perdida) - gastado;
                    }

                    else
                    {
                        minimatriz[i] = ((precio) - (reserva - demanda) * perdida) - gastado;
                    }

                    minimatriz[minimatriz.GetLength(0) - 1] += minimatriz[i];
                    reserva = Convert.ToInt32(demanda);
                }
            }
            else
            {
                double gastado = reserva * 8;
                for (int i = 0; i < cantidad; i++)
                {
                    double demanda = matriz[i, 2];
                    double precio = matriz[i, 3];

                    if (demanda > reserva)
                    {
                        minimatriz[i] = ((precio - (demanda - reserva) * 12) - (demanda - reserva) * perdida) - gastado;
                    }

                    else
                    {
                        minimatriz[i] = ((precio) - (reserva - demanda) * perdida) - gastado;
                    }

                    minimatriz[minimatriz.GetLength(0) - 1] += minimatriz[i];
                }
            }
            


            return minimatriz;

        }
    }
}
