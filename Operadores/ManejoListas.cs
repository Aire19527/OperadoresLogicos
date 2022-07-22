using Operadores.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Operadores
{
    public class ManejoListas
    {
        //Se quiere realizar un programa que lea por teclado las 5 notas obtenidas por un alumno(comprendidas entre 0 y 10).
        //A continuación debe mostrar todas las notas, la nota media, la nota más alta que ha sacado y la menor.

        #region Variables
        List<int> notas;
        List<AlumnosDto> alumnos;
        #endregion

        #region Constructor
        public ManejoListas()
        {
            //EjecicioNotas();
            NombreAlumnos();
        }
        #endregion

        #region Metodos

        public void EjecicioNotas()
        {
            notas = new List<int>();
            int count = 1;
            while (count <= 5)
            {
                Console.Write($"por favor ingresar la nota #{count} del alumno: ");
                int nota = Convert.ToInt32(Console.ReadLine());
                if (nota < 0 || nota >= 11)
                {
                    Console.WriteLine("Las notas deben ser entre 0 y 10");
                    Console.WriteLine("");
                }
                else
                {
                    count++;
                    notas.Add(nota);
                }
            }

            count = 1;
            Console.WriteLine("");
            Console.WriteLine("** LISTADO DE NOTAS **");
            foreach (var item in notas)
            {
                Console.WriteLine($"Nota #{count}:  {item}");
                count++;
            }

            double notaMedia = notas.Average();
            Console.WriteLine("");
            Console.WriteLine("** NOTA PROMEDIO **");
            Console.WriteLine($"{notaMedia}");

            int notaAlta = notas.Max();
            Console.WriteLine("");
            Console.WriteLine("** NOTA MÁS ALTA **");
            Console.WriteLine($"{notaAlta}");

            int notaBaja = notas.Min();
            Console.WriteLine("");
            Console.WriteLine("** NOTA MÁS BAJA **");
            Console.WriteLine($"{notaBaja}");
        }

        //Queremos guardar los nombres y la edades de los alumnos de un curso.
        //Realiza un programa que introduzca el nombre y la edad de cada alumno.
        //El proceso de lectura de datos terminará cuando se introduzca como nombre un asterisco(*)
        //Al finalizar se mostrará los siguientes datos:
        //  1. Fijar desde que edad se considera mayor de edad.
        //  2. Todos lo alumnos mayores de edad.
        //  3. Los alumnos mayores (el mayor de todos))

        public void NombreAlumnos()
        {
            alumnos = new List<AlumnosDto>();

            Console.WriteLine("*******************************************");
            Console.WriteLine("¿Desde que edad se considera mayor de edad?");
            Console.WriteLine("*******************************************");
            int mayorEdad = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            bool finalizar = false;
            Console.WriteLine("***************************");
            Console.WriteLine("*** REGISTRO DE ALUMNOS ***");
            Console.WriteLine("***************************");
            while (!finalizar)
            {
                AlumnosDto alumno = new AlumnosDto();

                Console.WriteLine("");
                Console.Write("Por favpr introduzca el nombre: ");
                alumno.Nombre = Console.ReadLine();
                if (alumno.Nombre == "*")
                    finalizar = true;
                else
                {
                    Console.Write("Por favpr introduzca la edad: ");
                    alumno.Edad = Convert.ToInt32(Console.ReadLine());
                    alumnos.Add(alumno);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("******************************");
            Console.WriteLine("*** ALUMNOS MAYORES DE EDAD***");
            Console.WriteLine("******************************");

            List<AlumnosDto> alumnosMayores = alumnos.Where(a => a.Edad >= mayorEdad).ToList();
            foreach (var mayores in alumnosMayores)
            {
                Console.WriteLine($"Alumno: {mayores.Nombre} - Edad: {mayores.Edad}");
            }

            Console.WriteLine("");
            Console.WriteLine("***********************");
            Console.WriteLine("*** ALUMNOS MAYORES ***");
            Console.WriteLine("***********************");

            int edadMayor = alumnosMayores.Max(x => x.Edad);
            List<AlumnosDto> alumnosMayorMayor = alumnosMayores.Where(x => x.Edad == edadMayor).ToList();
            foreach (var mayores in alumnosMayorMayor)
            {
                Console.WriteLine($"Alumno: {mayores.Nombre} - Edad: {mayores.Edad}");
            }

        }




    }

    #endregion


}
