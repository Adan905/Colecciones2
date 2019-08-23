using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Grupo> grupos = new List<Grupo>();

            Grupo matematicas =
                new Grupo("Matematicas", "Mat5773");

            Grupo historia =
                new Grupo("Historia", "HST2761");

            grupos.Add(matematicas);
            grupos.Add(historia);

            Alumno pepe = new Alumno("Pepe", "23129");
            Alumno compa = new Alumno("Compa", "59847");
            Alumno compi = new Alumno("Compi", "89427");
            Alumno orion = new Alumno("Orion", "23545");
            Alumno zeus = new Alumno("Zeus", "59846");
            Alumno prometeus = new Alumno("Prometeus", "25446");

            historia.Alumnos.Add(pepe);
            historia.Alumnos.Add(compa);
            historia.Alumnos.Add(compi);
            historia.Alumnos.Add(orion);
            historia.Alumnos.Add(zeus);
            historia.Alumnos.Add(prometeus);

            matematicas.Alumnos.Add(pepe);
            matematicas.Alumnos.Add(orion);
            matematicas.Alumnos.Add(zeus);
            matematicas.Alumnos.Add(prometeus);

            foreach(Grupo grupo in grupos)
            {
                Console.WriteLine("Grupo: " +
                    grupo.Codigo);
                Console.WriteLine("Materia: " +
                    grupo.Materia);
                Console.WriteLine("Lista de alumnos:");
                foreach(Alumno alumno in grupo.Alumnos)
                {
                    Console.WriteLine("*" +
                        alumno.Nombre);
                }
            }

            Console.Read();

        }

    }
}
