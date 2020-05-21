using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico_4
{
    class Herramientas
    {
        public Herramientas()
        {

        }

        //Esta funcion trunca los numeros
        public double TruncadoMarcelo(double valor, int cantATruncar)
        {
            int factor = Convert.ToInt32(Math.Pow(10, cantATruncar));
            return (Math.Truncate(valor * factor)) / factor;
        }

        //Funcion estetica para mostrar el tipo de dia por String en vez de un int
        public String setearTipoDia(double val)
        {
            String err= "";
                switch (Convert.ToInt32(val))
                {
                    case 1:
                        return "Soleado";
                        break;
                    case 2:
                        return "Nublado";
                        break;
                    default:
                        break;
                }
            return err;
        
        }

        //Esta funcion agrega los datos al datagrid
        public void matrizAGrid(double[,] matriz, System.Windows.Forms.DataGridView dataGridView, int ordenTruncado)
        {
            if (dataGridView.Rows.Count == 0)
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    dataGridView.Rows.Add();
                    for (int c = 0; c < matriz.GetLength(1); c++)
                    {
                        dataGridView.Rows[i].Cells[c].Value = TruncadoMarcelo(matriz[i, c], ordenTruncado).ToString();
                    }
                }
            }
            else
            {
                
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    dataGridView.Rows.Add();

                    for (int i = 0; i < matriz.GetLength(1); i++)
                    {
                        dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[i].Value = TruncadoMarcelo(matriz[j, i], ordenTruncado).ToString();
                    }
                }

            }

        }

        //Esta funcion agrega datos al DataGrid desde un array
        public void arrayAGrid(double[] array, System.Windows.Forms.DataGridView dataGrid, int ordenTruncado)
        {
            for (int i = 0; i < array.Length; i++)
            {
                dataGrid.Rows.Add();
                dataGrid.Rows[i].Cells[0].Value = i + 1;
                dataGrid.Rows[i].Cells[1].Value = TruncadoMarcelo(Convert.ToDouble(array[i]), ordenTruncado);
            }
        }

        //Funcion que permite agregar un array en la ultima columna de un datagrid cuando tiene informacion
        public void agregarColumnaGrid(double[] lista, DataGridView dataGridView, String nombreColumna)
        {
            dataGridView.Columns.Add(nombreColumna, nombreColumna);
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                dataGridView.Rows[i].Cells[nombreColumna].Value = TruncadoMarcelo(lista[i], 4);
            }
        }


        //Función que une una matriz con un array, teniendo en cuenta la ultima fila del Array
        public double [,] concatenarMatriz(double[,] matriz, double[] array)
        {

            double[,] nuevaMatriz= new double[array.Length, matriz.GetLength(1) + 1];
            
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    nuevaMatriz[i, j] = matriz[i, j];
                }
                nuevaMatriz[i, matriz.GetLength(1)] = array[i];
            }

            nuevaMatriz[array.Length - 1, matriz.GetLength(1)] = array[array.Length - 1];
            return nuevaMatriz;
        
        }


        //Necesito una funcion que me agregue la columna al grid teniendo en cuenta que el datagrid tiene mas filas que las de la columna
        public void concatenarDataGrid(DataGridView dataGridView, double[,] matriz, double[] ganancias)
        {
            dataGridView.Rows.Add(2);
            int puntoInicio = dataGridView.Rows.Count + 1;

            double[,] nuevaMatriz = new double[matriz.GetLength(0), matriz.GetLength(1) + 1];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    nuevaMatriz[i,j] = matriz[i,j];
                }
                nuevaMatriz[i, matriz.GetLength(1)] = ganancias[i];

            }
            matrizAGrid(nuevaMatriz, dataGridView, 4);
        }



        //Esta funcion limpia los textbox
        public static void Limpiar(GroupBox gb)
        {
            // Checar todos los textbox del formulario
            foreach (Control oControls in gb.Controls)
            {
                if (oControls is TextBox)
                {
                    oControls.Text = "0";
                }

            }
        }

        public static void Limpiar(Form ofrm)
        {
            // Checar todos los textbox del formulario
            foreach (Control oControls in ofrm.Controls)
            {
                if (oControls is TextBox)
                {
                    oControls.Text = ""; // Eliminar el texto del TextBox
                }

            }
        }

        public void valoresInexistentes(Form form, GroupBox gb)
        {
            foreach (Control oControls in form.Controls)
            {
                if (oControls is TextBox && oControls.Text == "")
                {
                    oControls.Text = "0";
                }

            }
            foreach (Control oControls in gb.Controls)
            {
                if (oControls.Text == "")
                {
                    oControls.Text = "0";
                }

            }
        }

        public void volverMatrizOrigen(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count != 0)
            {
                dataGridView.Rows.Clear();
                dataGridView.Columns.RemoveAt(dataGridView.Columns.Count - 1);
            }
        }

        public void formatearDataGridTexto(DataGridView dataGridView)
        {
            for (int i = 0; i < 3; i++)
            {
                //dataGridView.Rows.Add();
                dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[i].Value = "";
                //dataGridView.Rows[dataGridView.Rows.Count - 2].DefaultCellStyle.BackColor = Color.Beige;
            }
            dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[6].Value = "Ganancia Promedio Simulacion";
        }

        public void calcularValoresAcumulados(DataGridView grilla)
        {
            double primerValor = Convert.ToDouble(grilla.Rows[0].Cells[4].Value);
            grilla.Rows[0].Cells[5].Value = primerValor;
            for (int i = 1; i < grilla.Rows.Count; i++)
            {
                double anterior = Convert.ToDouble(grilla.Rows[i].Cells[4].Value);
                double alLado = Convert.ToDouble(grilla.Rows[i - 1].Cells[5].Value);
                grilla.Rows[i].Cells[5].Value = anterior + alLado;
            }
        }
    }


}
