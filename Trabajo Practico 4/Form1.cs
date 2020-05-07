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

            double [,] matriz;

            h.valoresInexistentes(this, gbVariables);
                        
            for (int i = 0; i < Convert.ToInt32(txtSimulaciones.Text); i++)
            {
                matriz = calc.primeraSolucion(dataTablaBase, Convert.ToInt32(txtSimulaciones.Text), Convert.ToInt32(txtCantidadDia.Text), Convert.ToInt32(txtReserva.Text),
                Convert.ToDouble(txtPrecioVenta.Text), Convert.ToDouble(txtPrecioVentaCementerio.Text), Convert.ToDouble(txtPrecioCompra.Text), Convert.ToDouble(txtPrecioCompraFaltantes.Text),
                cbDiaAnterior.Checked, cbPuedeComprar.Checked, cbNumerosAleatorios.Checked, cbVariables.Checked);

                h.matrizAGrid(matriz, dataTablaBase, 2);
                h.setearTipoDia(dataTablaBase, 2);
                dataTablaBase.Rows.Add();
            }
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
