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
    }
}
