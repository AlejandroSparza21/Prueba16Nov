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

        public List<List<int>> CuadradoMedio(int x0, int n, int totalValores)
        {
            // Paso 1: Inicializamos valor generado.
            int valorGenerado = x0; // El primer valor es x0 en el congruencial.
            List<List<int>> matrizSalida = new List<List<int>>();

            for (int i = 0; i < totalValores; i++)
            {
                List<int> listaSalida = new List<int>(); // Lista de fila.
                listaSalida.Add(i); // Añadir índice.
                listaSalida.Add(valorGenerado); // Añadir valor semilla.
                // Paso 2: Calculamos el siguiente valor:
                int r_2 = (int)Math.Pow(valorGenerado, 2); // El valor al cuadrado.
                listaSalida.Add(r_2); // Añadir valor semilla al cuadrado.
                string sx0_2 = r_2.ToString(); // Se convierte a string.
                // Paso 2.1: Obtener los dígitos de enmedio:
                string msx0_2 = "0"; // Originalmente es 0.
                if (sx0_2.Length > 2) // Si tiene más de dos dígitos:
                {
                    msx0_2 = sx0_2.Substring(1, sx0_2.Length - 2); // Quito los dígitos extremos.

                }
                listaSalida.Add(int.Parse(msx0_2)); // Añadir el valor de enmedio.
                // Paso 2.2: Se valida que los dígitos de enmedio tengan al menos la longitud de 2n:
                int lmsx0_2 = msx0_2.Length;
                if (lmsx0_2 < 2 * n)
                {
                    for (int j = 0; j < 2*n - lmsx0_2; j++)
                    {
                        msx0_2 += "0"; // Colocar 0's a la derecha del valor de enmedio.
                    }
                }

                // Paso 2.3: Obtener los n primeros dígitos del valor de enmedio:
                string cpy = msx0_2;
                string valor1s = msx0_2.Substring(0, n);
                // Paso 2.4: Obtener los n últimos dígitos del valor de enmedio:
                string valor2s = cpy.Substring(cpy.Length-n);

                // Paso 2.5: Devolver los valores a enteros:
                int valor1 = int.Parse(valor1s);
                int valor2 = int.Parse(valor2s);
                listaSalida.Add(valor1); // Añadir valor1 a la lista.
                listaSalida.Add(valor2); // Añadir valor2 a la lista.
                matrizSalida.Add(listaSalida); // Añadir la fila a la matriz de salida.

                // Si valor1 es 0, se acaba el algoritmo:
                if (valor1 == 0)
                {
                    break;
                }

                // Paso 2.6: actualizar el valor inicial al valor 1:
                valorGenerado = valor1;

            }
            return matrizSalida;
        }

        public List<List<int>> ProductoMedio(int x0, int y0, int n, int totalValores)
        {
            // Paso 1: Inicializamos valor generado.
            int valorGenerado1 = x0; // El primer valor es x0 en el congruencial.
            int valorGenerado2 = y0; // El segundo valor es y0 en el congruencial.
            List<List<int>> matrizSalida = new List<List<int>>(); // Matriz de valores.

            for (int i = 0; i < totalValores; i++)
            {
                List<int> listaSalida = new List<int>(); // Lista de fila.
                listaSalida.Add(i); // Añadir índice.
                listaSalida.Add(valorGenerado1); // Añadir valor semilla 1.
                listaSalida.Add(valorGenerado2); // Añadir valor semilla 2.
                // Paso 2: Calculamos el siguiente valor:
                int r_2 = valorGenerado1 * valorGenerado2; // El valor al cuadrado.
                listaSalida.Add(r_2); // Añadir producto de los valores semilla.
                string sr_2 = r_2.ToString(); // Se convierte a string.
                string msr_2 = sr_2.Substring(1, sr_2.Length - 2); // Quito los dígitos extremos.
                listaSalida.Add(int.Parse(msr_2)); // Añadir el valor de enmedio.
                // Paso 2.2: Se valida que los dígitos de enmedio tengan al menos la longitud de 2n:
                int lmsr_2 = msr_2.Length;
                if (lmsr_2 < 2 * n)
                {
                    for (int j = 0; j < 2 * n - lmsr_2; j++)
                    {
                        msr_2 += "0"; // Colocar 0's a la derecha del valor de enmedio.
                    }
                }

                // Paso 2.3: Obtener los n primeros dígitos del valor de enmedio:
                string cpy = msr_2;
                string valor1s = msr_2.Substring(0, n);
                // Paso 2.4: Obtener los n últimos dígitos del valor de enmedio:
                string valor2s = cpy.Substring(cpy.Length - n);

                // Paso 2.5: Devolver los valores a enteros:
                int valor1 = int.Parse(valor1s);
                int valor2 = int.Parse(valor2s);
                listaSalida.Add(valor1); // Añadir valor1 a la lista.
                listaSalida.Add(valor2); // Añadir valor2 a la lista.
                matrizSalida.Add(listaSalida); // Añadir la fila a la matriz de salida.

                // Si valor1 es 0, se acaba el algoritmo:
                if (valor1 == 0)
                {
                    break;
                }

                // Paso 2.6: actualizar los valores iniciales:
                valorGenerado1 = valorGenerado2;
                valorGenerado2 = valor1;

            }
            return matrizSalida;
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
    }
}
