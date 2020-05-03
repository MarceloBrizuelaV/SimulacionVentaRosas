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
            Solucion1 calc = new Solucion1();
            Herramientas h = new Herramientas();

            String g="";

            h.valoresInexistentes(this, gbVariables);
            
            /*
            g = calc.primeraSolucion(dataTablaBase, Convert.ToInt32(txtSimulaciones.Text), Convert.ToInt32(txtCantidadDia.Text), Convert.ToInt32(txtReserva.Text),
                Convert.ToDouble(txtPrecioVenta.Text), Convert.ToDouble(txtPrecioVentaCementerio.Text), Convert.ToDouble(txtPrecioCompra.Text), Convert.ToDouble(txtPrecioCompraFaltantes.Text),
                cbDiaAnterior.Checked, cbPuedeComprar.Checked, cbNumerosAleatorios.Checked, cbVariables.Checked);

            */

            
            for (int i = 0; i <= Convert.ToInt32(txtSimulaciones.Text); i++)
            {
                g = calc.primeraSolucion(dataTablaBase, Convert.ToInt32(txtSimulaciones.Text), Convert.ToInt32(txtCantidadDia.Text), Convert.ToInt32(txtReserva.Text),
                Convert.ToDouble(txtPrecioVenta.Text), Convert.ToDouble(txtPrecioVentaCementerio.Text), Convert.ToDouble(txtPrecioCompra.Text), Convert.ToDouble(txtPrecioCompraFaltantes.Text),
                cbDiaAnterior.Checked, cbPuedeComprar.Checked, cbNumerosAleatorios.Checked, cbVariables.Checked);

                
            }
            


            txtPromedioGanancia.Text = g;
            /*
            GeneradorTabla generador = new GeneradorTabla();
            Solucion1 calc = new Solucion1();
            Herramientas h = new Herramientas();
            double[,] tabla;
            double[] ganancias;


            if (cbVariables.Checked)
            {
                if (cbNumerosAleatorios.Checked)
                {
                    tabla = generador.tablaBase(Convert.ToInt32(txtCantidadDia.Text), !cbNumerosAleatorios.Checked, Convert.ToDouble(txtPrecioVenta.Text));
                }
                else
                {
                    tabla = generador.tablaBase(20, true, Convert.ToDouble(txtPrecioVenta.Text));
                }
                ganancias = calc.calcular(tabla, Convert.ToInt32(txtReserva.Text), Convert.ToDouble(txtPrecioVenta.Text), Convert.ToDouble(txtPrecioVentaCementerio.Text), 
                                            Convert.ToDouble(txtPrecioCompra.Text), Convert.ToDouble(txtPrecioCompraFaltantes.Text), cbDiaAnterior.Checked, cbPuedeComprar.Checked);
            }
            else
            {
                if (cbNumerosAleatorios.Checked)
                {
                    tabla = generador.tablaBase(Convert.ToInt32(txtCantidadDia.Text), !cbNumerosAleatorios.Checked, 12);
                }
                else
                {
                    tabla = generador.tablaBase(20, true, 12);
                }
                ganancias = calc.calcular(tabla, Convert.ToInt32(txtReserva.Text), 12, 1.2, 8, 11, cbDiaAnterior.Checked, cbPuedeComprar.Checked);
            }
            txtPromedioGanancia.Text = Convert.ToString(calc.calcularPromedio(ganancias));

            h.volverMatrizOrigen(dataTablaBase);
            h.matrizAGrid(tabla, dataTablaBase, 2);
            h.setearTipoDia(dataTablaBase, 2);
            h.agregarColumnaGrid(ganancias, dataTablaBase, "Ganancias");*/
        }
        
        private void btnF_Click(object sender, EventArgs e)
        {
            //Prueba
            Solucion1 calc = new Solucion1();
            Herramientas h = new Herramientas();
            actividadF generar = new actividadF();


            double[] tabla = generar.puntoA(Convert.ToInt32(txtCantidadDia.Text), Convert.ToInt32(txtReserva.Text), 12, 8, 11, 1.2, cbDiaAnterior.Checked, cbPuedeComprar.Checked);

            txtPromedioGanancia.Text = Convert.ToString(calc.calcularPromedio(tabla));

            h.agregarColumnaGrid(tabla, dataTablaBase, "Ganancias");

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
