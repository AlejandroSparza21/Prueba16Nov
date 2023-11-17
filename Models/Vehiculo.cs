using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba16Nov.Models
{
    public class Vehiculo
    {
        public double Capacidad { get; set; } 
        public long LatitudOrigenCondicionInicial { get; set; }
        public long LongitudOrigenCondicionInicial { get; set; }

        public List<Demanda> ListaAsignaciones { get; set; } = new List<Demanda>();
        public DateTime FechaDisponible { get; set; } = DateTime.Now; // A que hora me desocupo?
        
        public Vehiculo() { }
        public Vehiculo(double capacidad, long latitudOrigenCondicionInicial, long longitudOrigenCondicionInicial, List<Demanda> listaAsignaciones, DateTime fechaDisponible)
        {
            Capacidad = capacidad;
            LatitudOrigenCondicionInicial = latitudOrigenCondicionInicial;
            LongitudOrigenCondicionInicial = longitudOrigenCondicionInicial;
            ListaAsignaciones = listaAsignaciones;
            FechaDisponible = fechaDisponible;
        }
    }
}
