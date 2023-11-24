using Prueba16Nov.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba16Nov.Algoritmos
{
    public class AlgoritmoSimulacion
    {
        public AlgoritmoSimulacion() { }
        public List<int> GenerarValores(int n)
        {
            List<int> listaSalida = new List<int>(); // Lista de salida.
            for (int i = 0; i < n; i++)
            {
                listaSalida.Add(5 * (i + 1)); // Calculo para tener la lista.
            }

            return listaSalida;
        }

        public List<int> GenerarValoresPseudoaleatoriosCongruenciales(int x0, int a, int c, int m, int totalValores)
        {
            // Paso 1: Inicializamos valor generado.
            int valorGenerado = x0; // El primer valor es x0 en el congruencial.
            List<int> listaSalida = new List<int>();
            for (int i = 0; i < totalValores; i++)
            {
                // Paso 2: Calculamos el siguiente valor:
                int valorGeneradoAux = (a * valorGenerado + c) % m; // Fórmula del método.
                // Paso 2.5: Validar que el valor siguiente no se repita:
                if (listaSalida.Contains(valorGeneradoAux))
                {
                    break;
                }
                // Paso 3: Guardamos el valor nuevo.
                listaSalida.Add(valorGeneradoAux);
                // Paso 4: Seteamos el siguiente valor.
                valorGenerado = valorGeneradoAux;
            }

            return listaSalida;
        }

        public List<Experimento> SimulacionMontecarlo(int a, int b, int numVarInd, int numExp)
        {
            List<Experimento> listaExperimentos = new List<Experimento>();
            for (int i = 0; i < numExp; i++)
            {
                Experimento experimento = new Experimento();
                experimento.IdExperimento = i + 1; // Id del experimento.
                for (int j = 0; j < numVarInd; j++)
                {
                    Random random = new Random();
                    int aleatorio = random.Next(a, b); // Valor aleatorio entre a y b.
                    experimento.ListaValoresPaneles.Add(aleatorio); // Añadir valor aleatorio a la lista de paneles del experimento.
                }
                listaExperimentos.Add(experimento); // Añadir experimento a la lista de experimentos.
            }
            return listaExperimentos;
        }
    }
}
