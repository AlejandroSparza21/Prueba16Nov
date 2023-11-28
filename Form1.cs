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
            // Paso 0: Condición de vacío:
            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals("") ||
                textBox3.Text.Equals("") ||
                textBox4.Text.Equals(""))
            {
                MessageBox.Show("Los números tienen que ser NO VACÍOS.");
                return;
            }
            // Paso 1: Inicialización de parámetros:
            int x0 = Convert.ToInt32(textBox1.Text); // Semilla 1.
            int y0 = Convert.ToInt32(textBox2.Text); // Semilla 2.
            int n = Convert.ToInt32(textBox3.Text); // Número de digitos.
            int total = Convert.ToInt32(textBox4.Text); // Números a generar.
            // Paso 1.2: Validación algoritmo:
            if (x0 <= 0 || y0 <= 0 || n <= 0 || total <= 0)
            {
                MessageBox.Show("Los números tienen que ser MAYORES QUE CERO.");
                return;
            }

            // Paso 2: Declarar clase algoritmo genético:
            AlgoritmoSimulacion algoritmo = new AlgoritmoSimulacion();
            // Paso 3: Llamar método principal:
            List<List<int>> matrizEnteros = algoritmo.ProductoMedio(x0, y0, n, total);
            // Paso 4: Llenar el grid:
            llenarGrid(matrizEnteros);
        }

        // Recibo lista de enteros.
        public void llenarGrid(List<List<int>> lista)
        {
            // Paso 0: Indicar el número de columnas:
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";
            string numeroColumna3 = "3";
            string numeroColumna4 = "4";
            string numeroColumna5 = "5";
            string numeroColumna6 = "6";
            string numeroColumna7 = "7";

            // Paso 1: Determinar la cantidad de columnas:
            dataGridView1.Columns.Clear(); // Borrar contenido.
            dataGridView1.Columns.Add(numeroColumna1, "n"); // Cabecera de columna 1.
            dataGridView1.Columns.Add(numeroColumna2, "R(n)"); // Cabecera de columna 2.
            dataGridView1.Columns.Add(numeroColumna3, "R(n+1)"); // Cabecera de columna 3.
            dataGridView1.Columns.Add(numeroColumna4, "R(n)^2"); // Cabecera de columna 4.
            dataGridView1.Columns.Add(numeroColumna5, "M.R(n)^2"); // Cabecera de columna 5.
            dataGridView1.Columns.Add(numeroColumna6, "Val 1"); // Cabecera de columna 6.
            dataGridView1.Columns.Add(numeroColumna7, "Val 2"); // Cabecera de columna 7.

            // Paso 2: Recorrer el grid, para cada fila llenar los valores aleatorios:
            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add(); // Añadir filas.
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = lista[i][Int32.Parse(numeroColumna1) - 1].ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = lista[i][Int32.Parse(numeroColumna2) - 1].ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna3) - 1].Value = lista[i][Int32.Parse(numeroColumna3) - 1].ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna4) - 1].Value = lista[i][Int32.Parse(numeroColumna4) - 1].ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna5) - 1].Value = lista[i][Int32.Parse(numeroColumna5) - 1].ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna6) - 1].Value = lista[i][Int32.Parse(numeroColumna6) - 1].ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna7) - 1].Value = lista[i][Int32.Parse(numeroColumna7) - 1].ToString();
            }
        }

        public void DescargaExcel(DataGridView data)
        {
            // Paso 0: Instalar complemento de Excel:
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Application.Workbooks.Add(true); // Añadir libro de trabajo.
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

        public bool esPrimo(int numero)
        {
            if (numero < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
