using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataTablaBase.Rows.Clear();
            
            Solucion1 calc = new Solucion1();
            GeneradorTabla generador = new GeneradorTabla();
            Herramientas h = new Herramientas();

            double [,] matriz;

            h.valoresInexistentes(this, gbVariables);


            //Variables auxiliares
            int cantidadDias = Convert.ToInt32(txtCantidadDia.Text)/* Convert.ToInt32(txtSimulaciones.Text)*/;
            int cantidadSimulaciones = Convert.ToInt32(txtSimulaciones.Text);

            double acumulada = 0;
            double acumuladaProm = 0;
            double reserva = Convert.ToInt32(txtReserva.Text);
            GeneradorTabla guardacion = new GeneradorTabla();

            //TODOS LAS FUNCIONES MATRIZ = GENERAR.TABLABASE tienen el valor booleano invertido
            for (int j = 0; j < cantidadSimulaciones; j++)
            {
                //If para ver si esta activada la casilla de modificar valores
                if (cbVariables.Checked)
                {
                    //If para ver si se trabaja con numeros aleatorios o los fijos
                    if (cbNumerosAleatorios.Checked)
                    {
                        if (cbDiaAnterior.Checked)
                        {
                            for (int i = 0; i < cantidadDias; i++)
                            {
                                matriz = generador.tablaBase(Convert.ToInt32(reserva),
                                Convert.ToDouble(txtPrecioVenta.Text), Convert.ToDouble(txtPrecioVentaCementerio.Text), Convert.ToDouble(txtPrecioCompra.Text), Convert.ToDouble(txtPrecioCompraFaltantes.Text),
                                cbDiaAnterior.Checked, cbPuedeComprar.Checked, i, false, guardacion, acumulada);

                                reserva = matriz[0, 4];
                                acumulada = matriz[0, 7];
                                if ((i >= Convert.ToInt32(txtDesde.Text) && i < Convert.ToInt32(txtHasta.Text)) || i == (Convert.ToInt32(txtCantidadDia.Text)) - 1)
                                {
                                    dataTablaBase.Rows.Add();
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[0].Value = matriz[0, 0];
                                    //Rnd Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[1].Value = matriz[0, 1];
                                    //Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[2].Value = matriz[0, 2];
                                    //Rnd Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[3].Value = matriz[0, 3];
                                    //Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[4].Value = matriz[0, 4];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[5].Value = matriz[0, 5];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[6].Value = matriz[0, 6];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = matriz[0, 7];
                                }

                            }
                            h.setearTipoDia(dataTablaBase, 1);
                            dataTablaBase.Rows.Add();
                            h.formatearDataGridTexto(dataTablaBase);
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[7].Value) / Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[0].Value);
                            dataTablaBase.Rows.Add();
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Black;
                            acumuladaProm += Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[7].Value);

                            acumulada = 0;
                        }
                        else
                        {
                            for (int i = 0; i < cantidadDias; i++)
                            {
                                matriz = generador.tablaBase(Convert.ToInt32(reserva),
                                Convert.ToDouble(txtPrecioVenta.Text), Convert.ToDouble(txtPrecioVentaCementerio.Text), Convert.ToDouble(txtPrecioCompra.Text), Convert.ToDouble(txtPrecioCompraFaltantes.Text),
                                cbDiaAnterior.Checked, cbPuedeComprar.Checked, i, false, guardacion, acumulada);

                                acumulada = matriz[0, 7];

                                if ((i >= Convert.ToInt32(txtDesde.Text) && i < Convert.ToInt32(txtHasta.Text)) || i == (Convert.ToInt32(txtCantidadDia.Text)) - 1)
                                {
                                    dataTablaBase.Rows.Add();
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[0].Value = matriz[0, 0];
                                    //Rnd Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[1].Value = matriz[0, 1];
                                    //Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[2].Value = matriz[0, 2];
                                    //Rnd Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[3].Value = matriz[0, 3];
                                    //Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[4].Value = matriz[0, 4];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[5].Value = matriz[0, 5];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[6].Value = matriz[0, 6];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = matriz[0, 7];
                                }

                            }
                            h.setearTipoDia(dataTablaBase, 1);
                            dataTablaBase.Rows.Add();
                            h.formatearDataGridTexto(dataTablaBase);
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[7].Value) / Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[0].Value);
                            dataTablaBase.Rows.Add();
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Black;
                            acumuladaProm += Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[7].Value);


                            acumulada = 0;
                        }

                    }
                    else
                    {
                        if (cbDiaAnterior.Checked)
                        {
                            for (int i = 0; i < 20; i++)
                            {
                                matriz = generador.tablaBase(Convert.ToInt32(reserva),
                                Convert.ToDouble(txtPrecioVenta.Text), Convert.ToDouble(txtPrecioVentaCementerio.Text), Convert.ToDouble(txtPrecioCompra.Text), Convert.ToDouble(txtPrecioCompraFaltantes.Text),
                                cbDiaAnterior.Checked, cbPuedeComprar.Checked, i, false, guardacion, acumulada);

                                reserva = matriz[0, 4];
                                acumulada = matriz[0, 7];
                                if ((i >= Convert.ToInt32(txtDesde.Text) && i < Convert.ToInt32(txtHasta.Text)) || i == 20 - 1)
                                {
                                    dataTablaBase.Rows.Add();
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[0].Value = matriz[0, 0];
                                    //Rnd Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[1].Value = matriz[0, 1];
                                    //Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[2].Value = matriz[0, 2];
                                    //Rnd Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[3].Value = matriz[0, 3];
                                    //Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[4].Value = matriz[0, 4];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[5].Value = matriz[0, 5];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[6].Value = matriz[0, 6];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = matriz[0, 7];
                                }
                            }
                            h.setearTipoDia(dataTablaBase, 1);
                            dataTablaBase.Rows.Add();
                            h.formatearDataGridTexto(dataTablaBase);
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[7].Value) / Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[0].Value);
                            dataTablaBase.Rows.Add();
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Black;
                            acumuladaProm += Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[7].Value);


                            acumulada = 0;
                        }
                        else //COMPROBAR ESTE ELSE
                        {
                            for (int i = 0; i < 20; i++)
                            {
                                matriz = generador.tablaBase(Convert.ToInt32(reserva),
                                Convert.ToDouble(txtPrecioVenta.Text), Convert.ToDouble(txtPrecioVentaCementerio.Text), Convert.ToDouble(txtPrecioCompra.Text), Convert.ToDouble(txtPrecioCompraFaltantes.Text),
                                cbDiaAnterior.Checked, cbPuedeComprar.Checked, i, false, guardacion, acumulada);

                                //reserva = matriz[0, 2];
                                acumulada = matriz[0, 7];
                                if ((i >= Convert.ToInt32(txtDesde.Text) && i < Convert.ToInt32(txtHasta.Text)) || i == 20 - 1)
                                {
                                    dataTablaBase.Rows.Add();
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[0].Value = matriz[0, 0];
                                    //Rnd Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[1].Value = matriz[0, 1];
                                    //Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[2].Value = matriz[0, 2];
                                    //Rnd Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[3].Value = matriz[0, 3];
                                    //Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[4].Value = matriz[0, 4];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[5].Value = matriz[0, 5];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[6].Value = matriz[0, 6];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = matriz[0, 7];
                                }
                            }
                            h.setearTipoDia(dataTablaBase, 1);
                            dataTablaBase.Rows.Add();
                            h.formatearDataGridTexto(dataTablaBase);
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[7].Value) / Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[0].Value);
                            dataTablaBase.Rows.Add();
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Black;
                            acumuladaProm += Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[7].Value);

                            acumulada = 0;
                        }
                    }
                }
                else
                {
                    if (cbNumerosAleatorios.Checked)
                    {
                        if (cbDiaAnterior.Checked)
                        {
                            for (int i = 0; i < cantidadDias; i++)
                            {
                                matriz = generador.tablaBase(Convert.ToInt32(reserva), 12, 1.2, 8, 11, cbDiaAnterior.Checked, cbPuedeComprar.Checked, i, false, guardacion, acumulada);

                                reserva = matriz[0, 4];
                                acumulada = matriz[0, 7];
                                if ((i >= Convert.ToInt32(txtDesde.Text) && i < Convert.ToInt32(txtHasta.Text)) || i == (Convert.ToInt32(txtCantidadDia.Text)) - 1)
                                {
                                    dataTablaBase.Rows.Add();
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[0].Value = matriz[0, 0];
                                    //Rnd Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[1].Value = matriz[0, 1];
                                    //Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[2].Value = matriz[0, 2];
                                    //Rnd Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[3].Value = matriz[0, 3];
                                    //Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[4].Value = matriz[0, 4];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[5].Value = matriz[0, 5];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[6].Value = matriz[0, 6];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = matriz[0, 7];
                                }
                            }
                            h.setearTipoDia(dataTablaBase, 1);
                            dataTablaBase.Rows.Add();
                            h.formatearDataGridTexto(dataTablaBase);
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[7].Value) / Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[0].Value);
                            dataTablaBase.Rows.Add();
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Black;
                            acumuladaProm += Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[7].Value);

                            acumulada = 0;
                        }
                        else
                        {
                            for (int i = 0; i < cantidadDias; i++)
                            {

                                matriz = generador.tablaBase(Convert.ToInt32(reserva), 12, 1.2, 8, 11, cbDiaAnterior.Checked, cbPuedeComprar.Checked, i, false, guardacion, acumulada);

                                acumulada = matriz[0, 7];

                                if ((i >= Convert.ToInt32(txtDesde.Text) && i < Convert.ToInt32(txtHasta.Text)) || i == (Convert.ToInt32(txtCantidadDia.Text)) - 1)
                                {
                                    dataTablaBase.Rows.Add();
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[0].Value = matriz[0, 0];
                                    //Rnd Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[1].Value = matriz[0, 1];
                                    //Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[2].Value = matriz[0, 2];
                                    //Rnd Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[3].Value = matriz[0, 3];
                                    //Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[4].Value = matriz[0, 4];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[5].Value = matriz[0, 5];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[6].Value = matriz[0, 6];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = matriz[0, 7];
                                }

                            }
                            h.setearTipoDia(dataTablaBase, 1);
                            dataTablaBase.Rows.Add();
                            h.formatearDataGridTexto(dataTablaBase);
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[7].Value) / Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[0].Value);
                            dataTablaBase.Rows.Add();
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Black;
                            acumuladaProm += Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[7].Value);

                            acumulada = 0;
                        }

                    }
                    else
                    {
                        if (cbDiaAnterior.Checked)
                        {
                            for (int i = 0; i < 20; i++)
                            {
                                matriz = generador.tablaBase(Convert.ToInt32(reserva), 12, 1.2, 8, 11, cbDiaAnterior.Checked, cbPuedeComprar.Checked, i, true, guardacion, acumulada);

                                reserva = matriz[0, 4];
                                acumulada = matriz[0, 7];
                                if ((i >= Convert.ToInt32(txtDesde.Text) && i < Convert.ToInt32(txtHasta.Text)) || i == 20 - 1)//CAMBIO 2
                                {
                                    dataTablaBase.Rows.Add();
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[0].Value = matriz[0, 0];
                                    //Rnd Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[1].Value = matriz[0, 1];
                                    //Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[2].Value = matriz[0, 2];
                                    //Rnd Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[3].Value = matriz[0, 3];
                                    //Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[4].Value = matriz[0, 4];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[5].Value = matriz[0, 5];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[6].Value = matriz[0, 6];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = matriz[0, 7];
                                }

                            }
                            h.setearTipoDia(dataTablaBase, 1);
                            dataTablaBase.Rows.Add();
                            h.formatearDataGridTexto(dataTablaBase);
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[7].Value) / Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[0].Value);
                            dataTablaBase.Rows.Add();
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Black;
                            acumuladaProm += Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[7].Value);

                            acumulada = 0;
                        }
                        else
                        {
                            for (int i = 0; i < 20; i++)
                            {
                                matriz = generador.tablaBase(Convert.ToInt32(reserva), 12, 1.2, 8, 11, cbDiaAnterior.Checked, cbPuedeComprar.Checked, i, true, guardacion, acumulada);

                                acumulada = matriz[0, 7];
                                if ((i >= Convert.ToInt32(txtDesde.Text) && i < Convert.ToInt32(txtHasta.Text)) || i == 20 - 1)
                                {
                                    dataTablaBase.Rows.Add();
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[0].Value = matriz[0, 0];
                                    //Rnd Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[1].Value = matriz[0, 1];
                                    //Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[2].Value = matriz[0, 2];
                                    //Rnd Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[3].Value = matriz[0, 3];
                                    //Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[4].Value = matriz[0, 4];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[5].Value = matriz[0, 5];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[6].Value = matriz[0, 6];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = matriz[0, 7];
                                }
                            }
                            h.setearTipoDia(dataTablaBase, 1);
                            dataTablaBase.Rows.Add();
                            h.formatearDataGridTexto(dataTablaBase);
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[7].Value) / Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[0].Value);
                            dataTablaBase.Rows.Add();
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Black;
                            acumuladaProm += Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[7].Value);

                            acumulada = 0;
                        }

                    }

                }
                                Console.WriteLine("Simulacion Finalizada");
            }

            txtPromedioGanancia.Text = (acumuladaProm / Convert.ToDouble(txtSimulaciones.Text)).ToString();
        }


        private void btnF_Click(object sender, EventArgs e)
        {
            dataTablaBase.Rows.Clear();

            Solucion1 calc = new Solucion1();
            GeneradorTabla generador = new GeneradorTabla();
            Herramientas h = new Herramientas();

            double[,] matriz;

            h.valoresInexistentes(this, gbVariables);


            //Variables auxiliares
            int cantidadDias = Convert.ToInt32(txtCantidadDia.Text);
            int cantidadSimulaciones = Convert.ToInt32(txtSimulaciones.Text);

            double acumulada = 0;
            double acumuladaProm = 0;

            double reserva = Convert.ToInt32(txtReserva.Text);
            GeneradorTabla guardacion = new GeneradorTabla();

            //TODOS LAS FUNCIONES MATRIZ = GENERAR.TABLABASE tienen el valor booleano invertido
            for (int j = 0; j < cantidadSimulaciones; j++)
            {
                if (cbVariables.Checked)
                {
                    //If para ver si se trabaja con numeros aleatorios o los fijos
                    if (cbNumerosAleatorios.Checked)
                    {
                        if (cbDiaAnterior.Checked)
                        {
                            for (int i = 0; i < cantidadDias; i++)
                            {
                                matriz = generador.tablaBase1(Convert.ToInt32(reserva),
                                Convert.ToDouble(txtPrecioVenta.Text), Convert.ToDouble(txtPrecioVentaCementerio.Text), Convert.ToDouble(txtPrecioCompra.Text), Convert.ToDouble(txtPrecioCompraFaltantes.Text),
                                cbDiaAnterior.Checked, cbPuedeComprar.Checked, i, false, guardacion, acumulada);

                            reserva = matriz[0, 4];
                            acumulada = matriz[0, 7];
                                if ((i >= Convert.ToInt32(txtDesde.Text) && i < Convert.ToInt32(txtHasta.Text)) || i == (Convert.ToInt32(txtCantidadDia.Text)) - 1)
                                {
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[0].Value = matriz[0, 0];
                                    //Rnd Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[1].Value = matriz[0, 1];
                                    //Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[2].Value = matriz[0, 2];
                                    //Rnd Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[3].Value = matriz[0, 3];
                                    //Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[4].Value = matriz[0, 4];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[5].Value = matriz[0, 5];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[6].Value = matriz[0, 6];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = matriz[0, 7];
                                }
                            }
                            h.setearTipoDia(dataTablaBase, 1);
                            dataTablaBase.Rows.Add();
                            h.formatearDataGridTexto(dataTablaBase);
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[7].Value) / Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[0].Value);
                            dataTablaBase.Rows.Add();
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Black;
                            acumuladaProm += Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[7].Value);

                            acumulada = 0;
                        }
                        else
                        {
                            for (int i = 0; i < cantidadDias; i++)
                            {
                                matriz = generador.tablaBase1(Convert.ToInt32(reserva),
                                Convert.ToDouble(txtPrecioVenta.Text), Convert.ToDouble(txtPrecioVentaCementerio.Text), Convert.ToDouble(txtPrecioCompra.Text), Convert.ToDouble(txtPrecioCompraFaltantes.Text),
                                cbDiaAnterior.Checked, cbPuedeComprar.Checked, i, false, guardacion, acumulada);

                                acumulada = matriz[0, 7];
                                if ((i >= Convert.ToInt32(txtDesde.Text) && i < Convert.ToInt32(txtHasta.Text)) || i == (Convert.ToInt32(txtCantidadDia.Text)) - 1)
                                {
                                    dataTablaBase.Rows.Add();
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[0].Value = matriz[0, 0];
                                    //Rnd Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[1].Value = matriz[0, 1];
                                    //Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[2].Value = matriz[0, 2];
                                    //Rnd Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[3].Value = matriz[0, 3];
                                    //Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[4].Value = matriz[0, 4];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[5].Value = matriz[0, 5];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[6].Value = matriz[0, 6];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = matriz[0, 7];
                                }
                            }
                            h.setearTipoDia(dataTablaBase, 1);
                            dataTablaBase.Rows.Add();
                            h.formatearDataGridTexto(dataTablaBase);
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[5].Value = Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[5].Value) / Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[0].Value);
                            dataTablaBase.Rows.Add();
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Black;
                            acumuladaProm += Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[5].Value);


                }
                else
                {
                    if (cbDiaAnterior.Checked)
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            matriz = generador.tablaBase1(Convert.ToInt32(reserva),
                            Convert.ToDouble(txtPrecioVenta.Text), Convert.ToDouble(txtPrecioVentaCementerio.Text), Convert.ToDouble(txtPrecioCompra.Text), Convert.ToDouble(txtPrecioCompraFaltantes.Text),
                            cbDiaAnterior.Checked, cbPuedeComprar.Checked, i, false, guardacion, acumulada);

                            reserva = matriz[0, 4];
                            acumulada = matriz[0, 7];
                            dataTablaBase.Rows.Add();
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[0].Value = matriz[0, 0];
                            //Rnd Clima
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[1].Value = matriz[0, 1];
                            //Clima
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[2].Value = matriz[0, 2];
                            //Rnd Demanda
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[3].Value = matriz[0, 3];
                            //Demanda
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[4].Value = matriz[0, 4];
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[5].Value = matriz[0, 5];
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[6].Value = matriz[0, 6];
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = matriz[0, 7];
                            acumulada = 0;
                        }

                    }
                    else
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            matriz = generador.tablaBase1(Convert.ToInt32(reserva),
                            Convert.ToDouble(txtPrecioVenta.Text), Convert.ToDouble(txtPrecioVentaCementerio.Text), Convert.ToDouble(txtPrecioCompra.Text), Convert.ToDouble(txtPrecioCompraFaltantes.Text),
                            cbDiaAnterior.Checked, cbPuedeComprar.Checked, i, false, guardacion, acumulada);

                            //reserva = matriz[0, 2];
                            acumulada = matriz[0, 7];
                            dataTablaBase.Rows.Add();
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[0].Value = matriz[0, 0];
                            //Rnd Clima
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[1].Value = matriz[0, 1];
                            //Clima
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[2].Value = matriz[0, 2];
                            //Rnd Demanda
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[3].Value = matriz[0, 3];
                            //Demanda
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[4].Value = matriz[0, 4];
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[5].Value = matriz[0, 5];
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[6].Value = matriz[0, 6];
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = matriz[0, 7];
                        }
                    }

                }
            }
            else
            {
                if (cbNumerosAleatorios.Checked)
                {
                    if (cbDiaAnterior.Checked)
                    {
                        for (int i = 0; i < cantidadDias; i++)
                        if (cbDiaAnterior.Checked)
                        {
                            for (int i = 0; i < 20; i++)
                            {
                                matriz = generador.tablaBase1(Convert.ToInt32(reserva),
                                Convert.ToDouble(txtPrecioVenta.Text), Convert.ToDouble(txtPrecioVentaCementerio.Text), Convert.ToDouble(txtPrecioCompra.Text), Convert.ToDouble(txtPrecioCompraFaltantes.Text),
                                cbDiaAnterior.Checked, cbPuedeComprar.Checked, i, false, guardacion, acumulada);

                                reserva = matriz[0, 4];
                                acumulada = matriz[0, 7];
                                if ((i >= Convert.ToInt32(txtDesde.Text) && i < Convert.ToInt32(txtHasta.Text)) || i == (Convert.ToInt32(txtCantidadDia.Text)) - 1)
                                {
                                    dataTablaBase.Rows.Add();
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[0].Value = matriz[0, 0];
                                    //Rnd Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[1].Value = matriz[0, 1];
                                    //Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[2].Value = matriz[0, 2];
                                    //Rnd Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[3].Value = matriz[0, 3];
                                    //Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[4].Value = matriz[0, 4];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[5].Value = matriz[0, 5];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[6].Value = matriz[0, 6];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = matriz[0, 7];
                                }
                            }
                            h.setearTipoDia(dataTablaBase, 1);
                            dataTablaBase.Rows.Add();
                            h.formatearDataGridTexto(dataTablaBase);
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[7].Value) / Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[0].Value);
                            dataTablaBase.Rows.Add();
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Black;
                            acumuladaProm += Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[7].Value);


                            acumulada = 0;
                        }
                        else
                        {
                            for (int i = 0; i < 20; i++)
                            {
                                matriz = generador.tablaBase1(Convert.ToInt32(reserva),
                                Convert.ToDouble(txtPrecioVenta.Text), Convert.ToDouble(txtPrecioVentaCementerio.Text), Convert.ToDouble(txtPrecioCompra.Text), Convert.ToDouble(txtPrecioCompraFaltantes.Text),
                                cbDiaAnterior.Checked, cbPuedeComprar.Checked, i, false, guardacion, acumulada);

                                //reserva = matriz[0, 2];
                                acumulada = matriz[0, 7];
                                if ((i >= Convert.ToInt32(txtDesde.Text) && i < Convert.ToInt32(txtHasta.Text)) || i == 20 - 1) //MODIFIQUE ESTE
                                {
                                    dataTablaBase.Rows.Add();
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[0].Value = matriz[0, 0];
                                    //Rnd Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[1].Value = matriz[0, 1];
                                    //Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[2].Value = matriz[0, 2];
                                    //Rnd Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[3].Value = matriz[0, 3];
                                    //Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[4].Value = matriz[0, 4];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[5].Value = matriz[0, 5];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[6].Value = matriz[0, 6];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = matriz[0, 7];
                                }
                            }
                            h.setearTipoDia(dataTablaBase, 1);
                            dataTablaBase.Rows.Add();
                            h.formatearDataGridTexto(dataTablaBase);
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[7].Value) / Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[0].Value);
                            dataTablaBase.Rows.Add();
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Black;
                            acumuladaProm += Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[7].Value);

                            acumulada = 0;
                        }
                    }
                }
                else
                {
                    if (cbNumerosAleatorios.Checked)
                    {
                        if (cbDiaAnterior.Checked)
                        {
                            for (int i = 0; i < cantidadDias; i++)
                            {
                                matriz = generador.tablaBase1(Convert.ToInt32(reserva), 12, 1.2, 8, 11, cbDiaAnterior.Checked, cbPuedeComprar.Checked, i, false, guardacion, acumulada);

                                reserva = matriz[0, 4];
                                acumulada = matriz[0, 7];
                                if ((i >= Convert.ToInt32(txtDesde.Text) && i < Convert.ToInt32(txtHasta.Text)) || i == (Convert.ToInt32(txtCantidadDia.Text)) - 1)
                                {
                                    dataTablaBase.Rows.Add();
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[0].Value = matriz[0, 0];
                                    //Rnd Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[1].Value = matriz[0, 1];
                                    //Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[2].Value = matriz[0, 2];
                                    //Rnd Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[3].Value = matriz[0, 3];
                                    //Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[4].Value = matriz[0, 4];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[5].Value = matriz[0, 5];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[6].Value = matriz[0, 6];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = matriz[0, 7];
                                }
                            }
                            h.setearTipoDia(dataTablaBase, 1);
                            dataTablaBase.Rows.Add();
                            h.formatearDataGridTexto(dataTablaBase);
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[7].Value) / Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[0].Value);
                            dataTablaBase.Rows.Add();
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Black;
                            acumuladaProm += Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[7].Value);

                            acumulada = 0;
                        }
                        else
                        {
                            //ACA
                            for (int i = 0; i < cantidadDias; i++)
                            {
                                matriz = generador.tablaBase1(Convert.ToInt32(reserva), 12, 1.2, 8, 11, cbDiaAnterior.Checked, cbPuedeComprar.Checked, i, false, guardacion, acumulada);

                                //reserva = matriz[0, 2];
                                acumulada = matriz[0, 5];
                                if ((i >= Convert.ToInt32(txtDesde.Text) && i < Convert.ToInt32(txtHasta.Text)) || i == (Convert.ToInt32(txtCantidadDia.Text)) - 1)
                                {
                                    dataTablaBase.Rows.Add();
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[0].Value = matriz[0, 0];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[1].Value = matriz[0, 1];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[2].Value = matriz[0, 2];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[3].Value = matriz[0, 3];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[4].Value = matriz[0, 4];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[5].Value = matriz[0, 5];
                                }
                            }
                            h.setearTipoDia(dataTablaBase, 1);
                            dataTablaBase.Rows.Add();
                            h.formatearDataGridTexto(dataTablaBase);
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[5].Value = Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[5].Value) / Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[0].Value);
                            dataTablaBase.Rows.Add();
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Black;
                            acumuladaProm += Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[5].Value);


                            acumulada = 0;
                        }

                    }
                    else
                    {
                        if (cbDiaAnterior.Checked)
                        {
                            for (int i = 0; i < 20; i++)
                            {
                                matriz = generador.tablaBase1(Convert.ToInt32(reserva), 12, 1.2, 8, 11, cbDiaAnterior.Checked, cbPuedeComprar.Checked, i, true, guardacion, acumulada);

                                reserva = matriz[0, 2];
                                acumulada = matriz[0, 5];
                                if ((i >= Convert.ToInt32(txtDesde.Text) && i < Convert.ToInt32(txtHasta.Text)) || i == 20 - 1)//CAMBIO 2
                                {
                                    dataTablaBase.Rows.Add();
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[0].Value = matriz[0, 0];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[1].Value = matriz[0, 1];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[2].Value = matriz[0, 2];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[3].Value = matriz[0, 3];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[4].Value = matriz[0, 4];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[5].Value = matriz[0, 5];
                                }
                            }
                            h.setearTipoDia(dataTablaBase, 1);
                            dataTablaBase.Rows.Add();
                            h.formatearDataGridTexto(dataTablaBase);
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[5].Value = Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[5].Value) / Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[0].Value);
                            dataTablaBase.Rows.Add();
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Black;
                            acumuladaProm += Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[5].Value);

                            acumulada = 0;
                        }
                        else
                        {
                            for (int i = 0; i < 20; i++)
                            {
                                matriz = generador.tablaBase1(Convert.ToInt32(reserva), 12, 1.2, 8, 11, cbDiaAnterior.Checked, cbPuedeComprar.Checked, i, true, guardacion, acumulada);

                                //reserva = matriz[0, 2];
                                acumulada = matriz[0, 7];
                                if ((i >= Convert.ToInt32(txtDesde.Text) && i < Convert.ToInt32(txtHasta.Text)) || i == 20 - 1)
                                {
                                    dataTablaBase.Rows.Add();
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[0].Value = matriz[0, 0];
                                    //Rnd Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[1].Value = matriz[0, 1];
                                    //Clima
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[2].Value = matriz[0, 2];
                                    //Rnd Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[3].Value = matriz[0, 3];
                                    //Demanda
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[4].Value = matriz[0, 4];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[5].Value = matriz[0, 5];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[6].Value = matriz[0, 6];
                                    dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = matriz[0, 7];
                                }
                            }
                            h.setearTipoDia(dataTablaBase, 1);
                            dataTablaBase.Rows.Add();
                            h.formatearDataGridTexto(dataTablaBase);
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].Cells[7].Value = Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[7].Value) / Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[0].Value);
                            dataTablaBase.Rows.Add();
                            dataTablaBase.Rows[dataTablaBase.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Black;
                            acumuladaProm += Convert.ToDouble(dataTablaBase.Rows[dataTablaBase.Rows.Count - 2].Cells[7].Value);

                            acumulada = 0;
                        }
                    }
                }
                Console.WriteLine("Simulacion F finalizada");
            }

            txtPromedioGanancia.Text = (acumuladaProm / Convert.ToDouble(txtSimulaciones.Text)).ToString();
        }


        private void cbVariables_CheckedChanged(object sender, EventArgs e)
        {
            gbVariables.Enabled = cbVariables.Checked;
            Herramientas.Limpiar(gbVariables);
            if (cbVariables.Checked)
            {
                this.Height = 718;
            }
            else
            {
                this.Height = 524;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gbVariables.Enabled = false;
            cbDiaAnterior.Checked = false;
            cbNumerosAleatorios.Checked = false;
            cbPuedeComprar.Checked = false;
            cbVariables.Checked = false;

            txtCantidadDia.Enabled = false;

            this.Height = 524;
        }

        private void cbNumerosAleatorios_CheckedChanged(object sender, EventArgs e)
        {
            txtCantidadDia.Enabled = cbNumerosAleatorios.Checked;
            txtCantidadDia.Text = "0";
        }
    }
}
