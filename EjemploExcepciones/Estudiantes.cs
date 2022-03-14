using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploExcepciones
{
    public class Estudiantes
    {
        public List<Estudiante> ListPersonas { set; get; }

        public Estudiantes()
        {
            ListPersonas = new List<Estudiante>();
        }

        public void AgregarPersona(Estudiante persona)
        {
            ListPersonas.Add(persona);
        }

        public List<Estudiante> ListarCadena(string cadena)
        {
            List<Estudiante> aux2 = new List<Estudiante>();

            foreach (Estudiante persona in ListPersonas)
            {
                if (persona.Nombres.Contains(cadena))
                {
                    aux2.Add(persona);
                }
            }
            return aux2;
        }

        public List<Estudiante> ListarDatos()
        {
            List<Estudiante> datos = new List<Estudiante>();
            foreach (Estudiante persona in ListPersonas)
            {
                datos.Add(persona);
            }
            return datos;
        }

        public List<Estudiante> ListarSuspenso()
        {
            List<Estudiante> susp = new List<Estudiante>();

            foreach (Estudiante persona in ListPersonas)
            {
                if (persona.Nota <= 14)
                {
                    susp.Add(persona);
                }
            }
            return susp;
        }
    }
}
