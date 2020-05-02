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
        public String primeraSolucion(DataGridView dataGridView, int cantidadSimulaciones, int cantidadDias, int cantReservada, double precioVenta, double precioVentaCementerio, double precioCompra, double precioCompraFaltante, Boolean diaAnterior, Boolean puedeComprar, Boolean Aleatorio, Boolean cambiarVariables)
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
                    tabla = generador.tablaBase(cantidadDias, !Aleatorio, precioVenta);
                }
                else
                {
                    tabla = generador.tablaBase(20, true, precioVenta);
                }
                ganancias = calc.calcular(tabla, cantReservada, precioVenta, precioVentaCementerio, precioCompra, precioCompraFaltante, diaAnterior, puedeComprar);
            }
            else
            {
                if (Aleatorio)
                {
                    tabla = generador.tablaBase(cantidadDias, !Aleatorio, 12);
                }
                else
                {
                    tabla = generador.tablaBase(20, true, 12);
                }
                ganancias = calc.calcular(tabla, cantReservada, 12, 1.2, 8, 11, diaAnterior, puedeComprar);
            }
            String ganancia = Convert.ToString(calc.calcularPromedio(ganancias));

            if (cantidadSimulaciones != 1)
            {
                dataGridView.Rows.Add(2);
                h.volverMatrizOrigen(dataGridView);
                h.matrizAGrid(tabla, dataGridView, 2);
                h.setearTipoDia(dataGridView, 2);
                h.agregarColumnaGrid(ganancias, dataGridView, "Ganancias");

            }


            h.volverMatrizOrigen(dataGridView);
            h.matrizAGrid(tabla, dataGridView, 2);
            h.setearTipoDia(dataGridView, 2);
            h.agregarColumnaGrid(ganancias, dataGridView, "Ganancias");

            return ganancia;
        }

        //Funcion del calculo de la ganancia por dia
        public double[] calcular(double[,] matriz, int cantReservada, double precioVenta, double precioVentaCementerio, double precioCompra, double precioCompraFaltante, Boolean diaAnterior, Boolean puedeComprar)
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
                            columna[i] = (venta + (cantReservada - demanda) * precioVentaCementerio) - costo;
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
                            columna[i] = (venta + (cantReservada - demanda) * precioVentaCementerio) - costo;
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
                        columna[i] = (venta + (cantReservada - demanda) * precioVentaCementerio) - costo;
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
                        columna[i] = (venta + (cantReservada - demanda) * precioVentaCementerio) - costo;
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

        
        //Calculo del promedio a partir de un array (el ultimo dato del mismo tiene que tener la sumatoria)
        public double calcularPromedio(double[] col)
        {
            return col[col.Length - 1] / Convert.ToDouble(col.Length - 1);
        }









    }
}
