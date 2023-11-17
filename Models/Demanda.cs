using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba16Nov.Models
{
    public class Demanda
    {
        public string IdCliente { get; set; }
        public double OrigenLatitud { get; set; }
        public double OrigenLonitud { get; set; }
        public double DestinoLatitud { get; set; }
        public double DestinoLonitud { get; set; }
        public int CantidadKibros { get; set; }
        public DateTime FechaCobertura { get; set; }

        public Demanda() { }

        public Demanda(string idCliente, double origenLatitud, double origenLonitud, double destinoLatitud, double destinoLonitud, int cantidadKibros, DateTime fechaCobertura)
        {
            IdCliente = idCliente;
            OrigenLatitud = origenLatitud;
            OrigenLonitud = origenLonitud;
            DestinoLatitud = destinoLatitud;
            DestinoLonitud = destinoLonitud;
            CantidadKibros = cantidadKibros;
            FechaCobertura = fechaCobertura;
        }
    }
}
