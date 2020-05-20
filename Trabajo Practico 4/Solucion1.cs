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
        /*/public double[,] primeraSolucion(DataGridView dataGridView, int cantidadSimulaciones, int cantidadDias, int cantReservada, double precioVenta, double precioVentaCementerio, double precioCompra, double precioCompraFaltante, Boolean diaAnterior, Boolean puedeComprar, Boolean Aleatorio, Boolean cambiarVariables)
        {
            GeneradorTabla generador = new GeneradorTabla();
            Solucion1 calc = new Solucion1();
            Herramientas h = new Herramientas();
            double[,] tabla;
            double[] ganancias;


            if (cambiarVariables)
            {
                if (Aleatorio)
                {
                    //tabla = generador.tablaBase(cantidadDias, !Aleatorio, precioVenta);
                }
                else
                {
                    //tabla = generador.tablaBase(20, true, precioVenta);
                }
                //ganancias = calc.calcular(tabla, cantReservada, precioVenta, precioVentaCementerio, precioCompra, precioCompraFaltante, diaAnterior, puedeComprar);
            }
            else
            {
                if (Aleatorio)
                {
                    //tabla = generador.tablaBase(cantidadDias, !Aleatorio, 12);
                }
                else
                {
                    //tabla = generador.tablaBase(20, true, 12);
                }
                //ganancias = calc.calcular(tabla, cantReservada, 12, 1.2, 8, 11, diaAnterior, puedeComprar);
            }


            calc.calcularPromedioMod(ganancias);


            double [,] matriz = h.concatenarMatriz(tabla, ganancias);
            return matriz;

            
        }/*/

        //Funcion del calculo de la ganancia por dia
      /*/  public double calcular(double[,] matriz, int cantReservada, double precioVenta, double precioVentaCementerio, double precioCompra, double precioCompraFaltante, Boolean diaAnterior, Boolean puedeComprar, GeneradorTabla objeto)
        {
            double columna = 0;

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
                            columna = (venta + (cantReservada - demanda) * precioVentaCementerio) - costo;
                        }
                        else
                        {
                            columna = (venta - costo - (demanda - cantReservada) * precioCompraFaltante);
                        }
                        objeto.demandaGlobal = Convert.ToInt32(demanda);

                    }
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
                            columna = (venta + (cantReservada - demanda) * precioVentaCementerio) - costo;
                        }
                        else
                        {
                            columna = (venta - (demanda - cantReservada) * precioCompraFaltante) - costo;
                        }
                    }
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
                    objeto.demandaGlobal = Convert.ToInt32(demanda);
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
        } /*/

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
