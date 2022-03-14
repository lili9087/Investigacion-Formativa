using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploExcepciones
{
    public class Estudiante
    {
        public string Codigo { set; get; }
        public string Asignatura { set; get; }
        public string Nombres { set; get; }
        public string Apellidos { set; get; }
        public string Semestre { set; get; }
        public string Paralelo { set; get; }
        public string Email { set; get; }
        public int Nota { set; get; }

        public Estudiante()
        {
        }

        public Estudiante(string codigo, string asignatura, string nombres, string apellidos, string semestre, string paralelo, string email, int nota)
        {
            Codigo = codigo;
            Asignatura = asignatura;
            Nombres = nombres;
            Apellidos = apellidos;
            Semestre = semestre;
            Paralelo = paralelo;
            Email = email;
            Nota = nota;
           
        }
    }
}
