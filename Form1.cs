using Prueba16Nov.Algoritmos;

namespace Prueba16Nov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Paso 0: Condici�n de vac�o:
            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals("") ||
                textBox3.Text.Equals("") ||
                textBox4.Text.Equals(""))
            {
                MessageBox.Show("Los n�meros tienen que ser NO VAC�OS.");
                return;
            }
            // Paso 1: Inicializaci�n de par�metros:
            int x0 = Convert.ToInt32(textBox1.Text);
            int a = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int m = Convert.ToInt32(textBox4.Text);
            int total = Convert.ToInt32(textBox5.Text);
            // Paso 1.2: Validaci�n algoritmo:
            if (x0 < 0 || a <= 0 || c <= 0 || m <= 0)
            {
                MessageBox.Show("Los n�meros tienen que ser MAYORES QUE CERO.");
                return;
            }
            // A�adir que m sea mayor a x0, a y c.
            //if (m < x0 || m < a || m < c)
            //{
                //MessageBox.Show("m tiene que ser MAYOR QUE los dem�s n�meros.");
                //return;
            //}

            // Paso 2: Declarar clase algoritmo gen�tico:
            AlgoritmoSimulacion algoritmo = new AlgoritmoSimulacion();
            // Paso 3: Llamar m�todo principal:
            List<int> listaEnteros = algoritmo.GenerarValoresPseudoaleatoriosCongruenciales(x0, a, c, m, total);
            // Paso 4: Llenar el grid:
            llenarGrid(listaEnteros);
        }

        // Recibo lista de enteros.
        public void llenarGrid(List<int> lista)
        {
            // Paso 0: Indicar el n�mero de columnas:
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";

            // Paso 1: Determinar la cantidad de columnas:
            dataGridView1.Columns.Clear(); // Borrar contenido.
            dataGridView1.Columns.Add(numeroColumna1, "Id"); // Cabecera de columna 1.
            dataGridView1.Columns.Add(numeroColumna2, "Valor");

            // Paso 2: Recorrer el grid, para cada fila llenar los valores aleatorios:
            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add(); // A�adir filas.
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = (i + 1).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = lista[i].ToString();
            }
        }

        public void DescargaExcel(DataGridView data)
        {
            // Paso 0: Instalar complemento de Excel:
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Application.Workbooks.Add(true); // A�adir libro de trabajo.
            int indiceColumna = 0;
            // Paso 1: Construyes columnas y los nombres de las "cabeceras":
            foreach (DataGridViewColumn columna in data.Columns)
            {
                indiceColumna++;
                exportarExcel.Cells[1, indiceColumna] = columna.HeaderText; // Obtener encabezados de columna.
            }
            // Paso 2: Construir filas y llenas valores:
            int indiceFilas = 0;

            foreach (DataGridViewRow fila in data.Rows)
            {
                indiceFilas++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in data.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[indiceFilas + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
            // Paso 3: Visibilidad:
            exportarExcel.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DescargaExcel(dataGridView1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
