using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_4
{
    class Solucion1
    {


        public double[] calcular(double[,] matriz, int cantReservada, double precioVenta, double precioCompra, double precioCompraFaltante, Boolean diaAnterior, Boolean puedeComprar)
        {
            double[] columna = new double[matriz.GetLength(0) + 1];
            double gananciaAcumulada = 0;

            //Resolucion del inciso D, aplicando a los incisos A, B y C
            //En este caso puede comprar a otro precio en caso de faltarle
            if (puedeComprar)
            {
                //En caso de utilizar la demanda del dia anterior para comprar
                if (diaAnterior)
                {
                    for (int i = 0; i < matriz.GetLength(0); i++)
                    {
                        double costo = cantReservada * precioCompra;
                        double demanda = matriz[i, matriz.GetLength(1) - 2];
                        double venta = matriz[i, matriz.GetLength(1) - 1];
                        if (demanda <= cantReservada)
                        {
                            columna[i] = (venta + (cantReservada - demanda) * 1.2) - costo;
                        }
                        else
                        {
                            columna[i] = (venta - costo - (demanda - cantReservada) * precioCompraFaltante);
                        }
                        cantReservada = Convert.ToInt32(demanda);
                        gananciaAcumulada += columna[i];
                    }
                    columna[columna.Length - 1] = gananciaAcumulada;
                    return columna;
                }

                //En caso de no utilizar la demanda del dia anterior (compra fija)
                else
                {
                    double costo = cantReservada * precioCompra;
                    for (int i = 0; i < matriz.GetLength(0); i++)
                    {
                        double demanda = matriz[i, matriz.GetLength(1) - 2];
                        double venta = matriz[i, matriz.GetLength(1) - 1];
                        if (demanda <= cantReservada)
                        {
                            columna[i] = (venta + (cantReservada - demanda) * 1.2) - costo;
                        }
                        else
                        {
                            columna[i] = (venta - (demanda - cantReservada) * precioCompraFaltante) - costo;
                        }
                        gananciaAcumulada += columna[i];
                    }
                    columna[columna.Length - 1] = gananciaAcumulada;
                    return columna;
                }
            }
            

            //Resolucion de los incisos A, B y C
            //En este caso no puede comprar cuando le faltan
            if (diaAnterior)
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    double costo = cantReservada * precioCompra;
                    double demanda = matriz[i, matriz.GetLength(1) - 2];
                    double venta = matriz[i, matriz.GetLength(1) - 1];
                    if (demanda < cantReservada)
                    {
                        columna[i] = (venta + (cantReservada - demanda) * 1.2) - costo;
                    }
                    else
                    {
                        columna[i] = (venta - (demanda - cantReservada) * precioVenta) - costo;
                    }
                    cantReservada = Convert.ToInt32(demanda);
                    gananciaAcumulada += columna[i];
                    }
                columna[columna.Length - 1] = gananciaAcumulada;
                return columna;
            }
            else
            {
                double costo = cantReservada * precioCompra;
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
                        columna[i] = (venta - (demanda - cantReservada) * precioVenta) - costo;
                    }

                    gananciaAcumulada += columna[i];
                }
                columna[columna.Length - 1] = gananciaAcumulada;
                return columna;
            }
        }

        






        public double calcularPromedio(double[] col)
        {
            return col[col.Length - 1] / Convert.ToDouble(col.Length - 1);
        }
        //HOLA









    }
}
