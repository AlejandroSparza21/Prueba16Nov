using Prueba16Nov.Algoritmos;
using Prueba16Nov.Models;

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
            int limiteInferior = Convert.ToInt32(textBox1.Text); // Límite inferior.
            int limiteSuperior = Convert.ToInt32(textBox2.Text); // Límite superior.
            int numeroDeVariablesIndependientes = Convert.ToInt32(textBox3.Text);
            int numeroDeExperimentos = Convert.ToInt32(textBox4.Text);
            // Paso 1.2: Validación algoritmo:
            if (limiteInferior >= limiteSuperior)
            {
                MessageBox.Show("El límite inferior tiene que ser MENOR QUE el límite superior.");
                return;
            }
            if (numeroDeVariablesIndependientes <= 0)
            {
                MessageBox.Show("El número de variables independientes tiene que ser MAYOR QUE CERO.");
                return;
            }
            if (numeroDeExperimentos <= 0)
            {
                MessageBox.Show("El número de experimentos tiene que ser MAYOR QUE CERO.");
                return;
            }

            // Paso 2: Declarar clase algoritmo genético:
            AlgoritmoSimulacion algoritmo = new AlgoritmoSimulacion();
            // Paso 3: Llamar método principal:
            List<Experimento> listaExperimentos = algoritmo.SimulacionMontecarlo(limiteInferior, limiteSuperior, numeroDeVariablesIndependientes, numeroDeExperimentos);
            // Paso 4: Llenar las casillas:
            llenarGrid(listaExperimentos, numeroDeVariablesIndependientes, numeroDeExperimentos);

        }

        // Recibo lista de enteros.
        public void llenarGrid(List<Experimento> lista, int numVarInd, int NumExp)
        {
            // Paso 0: Indicar el número de columnas:
            List<String> numerosColumna = new List<String>();
            for (int i = 0; i <= numVarInd+1; i++)
            {
                numerosColumna.Add(i.ToString()); // Las de las variables independientes, la del número de experimento, y la de la selección aleatoria.
            }

            // Paso 1: Determinar la cantidad de columnas:
            dataGridView1.Columns.Clear(); // Borrar contenido.
            dataGridView1.Columns.Add(numerosColumna[0], "Número de experimento"); // Cabecera de columna 1.
            for (int i = 1; i <= numVarInd; i++)
            {
                dataGridView1.Columns.Add(numerosColumna[i], "Panel " + i.ToString());
            }
            dataGridView1.Columns.Add(numerosColumna[numVarInd+1], "Satélite X^(i)");

            // Paso 2: Recorrer el grid, para cada fila llenar los valores aleatorios:
            double suma = 0;
            double sumaCuadrada = 0.0;
            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add(); // Añadir filas.
                dataGridView1.Rows[i].Cells[Int32.Parse(numerosColumna[0])].Value = (i + 1).ToString();
                for (int j = 1; j <= numVarInd; j++)
                {
                    dataGridView1.Rows[i].Cells[Int32.Parse(numerosColumna[j])].Value = lista[i].ListaValoresPaneles[j - 1];
                }
                Random random = new Random();
                int aleatorio = random.Next(0, numVarInd-1); // Valor aleatorio entre 0 y el numero de variables independientes-1.
                dataGridView1.Rows[i].Cells[Int32.Parse(numerosColumna[numVarInd + 1])].Value = lista[i].ListaValoresPaneles[aleatorio];
                suma += lista[i].ListaValoresPaneles[aleatorio];
                sumaCuadrada += Math.Pow(lista[i].ListaValoresPaneles[aleatorio], 2);
            }

            // Paso 3: Calcular la media:
            double estimacionMedia = suma / NumExp;
            textBox5.Text = estimacionMedia.ToString();

            // Paso 4: Calcular la desviacion estandar:
            double var = sumaCuadrada / (NumExp*(NumExp-1)) - Math.Pow(estimacionMedia,2) / (NumExp-1);
            double desviacionEstandar = Math.Pow(var, 0.5);
            textBox6.Text = desviacionEstandar.ToString();
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
