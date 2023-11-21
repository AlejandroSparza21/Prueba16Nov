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
                // Paso 3: Guardamos el valor nuevo.
                listaSalida.Add(valorGeneradoAux);
                // Paso 4: Seteamos el siguiente valor.
                valorGenerado = valorGeneradoAux;
            }

            return listaSalida;
        }
    }
}
