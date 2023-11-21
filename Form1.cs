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
            if (textBox1.Text.Equals(**) ||
                textBox2.Text.Equals(**))
            {
                MessageBox.Show("Los n�meros tienen que ser MAYOR que cero, NO VAC�OS.")
                return;
            }
            // Paso 1: Inicializaci�n de par�metros:
            int totalValores = Convert.ToInt32(textBox1.Text);
            int valorMuestra = Convert.ToInt32(textBox2.Text);
            // Paso 2: Declarar clase algoritmo gen�tico:
            AlgoritmoSimulacion algoritmo = new AlgoritmoSimulacion();
            // Paso 3: Llamar m�todo principal:
            List<int> listaEnteros = algoritmo.GenerarValores(totalValores);
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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

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
    }
}
