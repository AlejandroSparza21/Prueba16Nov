using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba16Nov.Models
{
    public class Experimento
    {
        public int IdExperimento { get; set; }
        public List<int> ListaValoresPaneles { get; set; } = new List<int>(); // Inicializar lista aqui, para que no esté null.
        public Experimento() { }
        public Experimento (int Experimento, List<int> listaValoresPaneles)
        {
            IdExperimento = Experimento;
            ListaValoresPaneles = listaValoresPaneles;
        }

    }
}
