using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_4
{
    class actividadF
    {
        public double[,] puntoA(int cantidad)
        
        {
            GeneradorTabla tabla = new GeneradorTabla();

            //Busco la matriz original.
            double[,] matriz = new double[cantidad,4];
            matriz = tabla.tablaBase(cantidad, 1);

            

            double perdida = 1.20;
            double gastado = 64;

            //Realizo una matriz con los datos de ganancia y los dias.
            double[,] minimatriz = new double[cantidad + 1, 2];

            for (int i = 0; i < cantidad; i++)
            {
                double demanda = matriz[i, 2];
                double precio = matriz[i, 3];

                if (demanda > 8)
                {
                    
                    minimatriz[i, 0] = ((precio - (demanda - 8) * 12 )-(demanda - 8)* perdida)- gastado;
                }

                else
                {
                    minimatriz[i, 0] = ((precio) - (demanda - 8) * perdida) - gastado;
                }
                
            }

            return minimatriz;

        }
    }
}
