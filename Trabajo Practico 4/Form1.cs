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

            
            //Matriz
            GeneradorTabla generador = new GeneradorTabla();
            Solucion1 calc = new Solucion1();
            Herramientas h = new Herramientas();
            double[,] tabla = generador.tablaBase(Convert.ToInt32(txtCantidadDia.Text), 1);

            

            for (int i = 0; i < tabla.GetLength(0); i++)
            {
                dataTablaBase.Rows.Add();
                dataTablaBase.Rows[i].Cells[0].Value = tabla[i, 0].ToString();
                dataTablaBase.Rows[i].Cells[1].Value = tabla[i, 1].ToString();
                dataTablaBase.Rows[i].Cells[2].Value = tabla[i, 2].ToString();
                dataTablaBase.Rows[i].Cells[3].Value = tabla[i, 3].ToString();
            }


            double[] ganancias = calc.calcular(tabla, Convert.ToInt32(txtReserva.Text));
            txtPromedioGanancia.Text = Convert.ToString(calc.calcularPromedio(ganancias));
 

            h.arrayAGrid(ganancias, Ganancias, 4);


        }

        private void btnF_Click(object sender, EventArgs e)
        {
            //Prueba
            Solucion1 calc = new Solucion1();
            Herramientas h = new Herramientas();
            actividadF generar = new actividadF();

            double[] tabla = generar.puntoA(Convert.ToInt32(txtCantidadDia.Text), Convert.ToInt32(txtReserva.Text), cbDiaAnterior.Checked);

            txtPromedioGanancia.Text = Convert.ToString(calc.calcularPromedio(tabla));

            h.arrayAGrid(tabla, Ganancias, 4);

        }
    }
}
