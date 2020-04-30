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
            //Prueba
            actividadF generar = new actividadF();
            double[,] tabla = generar.puntoA(Convert.ToInt32(txtCantidadDia.Text));

            //Matriz
            //GeneradorTabla generador = new GeneradorTabla();
            //double [,] tabla = generador.tablaBase(Convert.ToInt32(txtCantidadDia.Text),1);

            for (int i = 0; i < tabla.GetLength(0); i++)
            {
                dataTablaBase.Rows.Add();
                dataTablaBase.Rows[i].Cells[0].Value = tabla[i, 0].ToString();
                dataTablaBase.Rows[i].Cells[1].Value = tabla[i, 1].ToString();
                //dataTablaBase.Rows[i].Cells[2].Value = tabla[i, 2].ToString();
                //dataTablaBase.Rows[i].Cells[3].Value = tabla[i, 3].ToString();
            }
        }


    }
}
