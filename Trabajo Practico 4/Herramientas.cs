using System;
using System.Collections.Generic;
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
        public void setearTipoDia(DataGridView dataGridView, int numColumna)
        {
            numColumna -= 1;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                switch (dataGridView.Rows[i].Cells[numColumna].Value)
                {
                    case "1":
                        dataGridView.Rows[i].Cells[numColumna].Value = "Soleado";
                        break;
                    case "2":
                        dataGridView.Rows[i].Cells[numColumna].Value = "Nublado";
                        break;
                    default:
                        break;
                }
            }
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
                dataGridView.Rows.Add();
                for (int i = 0; i < matriz.GetLength(1); i++)
                {
                    dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[i].Value = TruncadoMarcelo(matriz[0, i], ordenTruncado).ToString();
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


    }
}
