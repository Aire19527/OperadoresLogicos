using Operadores.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Operadores
{
    public class Listas
    {
        List<PersonaDto> listaPersonas;
        List<OficiosDto> listaOficios;

        public Listas()
        {
            LlenadoOficios();
            LlenadoLista();
        }

        private void LlenadoLista()
        {
            listaPersonas = new List<PersonaDto>();


            for (int i = 0; i < 200; i++)
            {
                Random random = new Random();

                //OficiosDto ofi =listaOficios.Where(x => x.Id == random.Next(1, 5)).First();
                //string oficio=listaOficios.First(x => x.Id == random.Next(1, 5)).Oficio;

                int idOficio = random.Next(1, 5);
                OficiosDto ofi = listaOficios.First(x => x.Id == idOficio);
                //                string oficio= ofi.Oficio;

                listaPersonas.Add(new PersonaDto()
                {
                    Id = i,
                    Nombre = $"Fulanito {i.ToString()}",
                    Edad = random.Next(20, 60),
                    //Profesion = listaOficios.First(x => x.Id == random.Next(1, 5)).Oficio
                    Profesion = ofi.Oficio
                });
            }
            //foreach (var item in listaPersonas)
            //{
            //    Console.WriteLine($"{item.Nombre} - {item.Edad}");
            //}

        }

        private void LlenadoOficios()
        {
            listaOficios = new List<OficiosDto>();

            listaOficios.AddRange(new List<OficiosDto>()
            {
                new OficiosDto()
                {
                    Id=1,
                    Oficio="Ingeniero"
                },
                new OficiosDto()
                {
                    Id=2,
                    Oficio="Medico"
                },
                new OficiosDto()
                {
                    Id=3,
                    Oficio="Veterinario"
                },
                new OficiosDto()
                {
                    Id=4,
                    Oficio="Agricultor"
                },
                new OficiosDto()
                {
                    Id=5,
                    Oficio="Policia"
                }

            });
        }


        //Consultar personas mayores a 40 años
        public void Consulta_1()
        {
            List<PersonaDto> resultado = listaPersonas.Where(x => x.Edad >= 40).ToList();

            foreach (var persona in resultado)
            {
                Console.WriteLine($"Nombre: {persona.Nombre} - Edad: {persona.Edad}");
            }

            //Y = &&
            //O = ||
            List<PersonaDto> result_2 = listaPersonas.Where(x => x.Edad >= 30 && x.Profesion == "Ingeniero").ToList();

            List<PersonaDto> result_3 = listaPersonas.Where(x => x.Edad >= 30
                                                              && (x.Profesion == "Ingeniero" || x.Profesion == "Medico")).ToList();


            Console.WriteLine($"Total Registros: {result_3.Count()}");
            Console.WriteLine($"Total Ingenieros: {result_3.Count(x => x.Profesion == "Ingeniero")}");
            Console.WriteLine($"Total Medicos: {result_3.Count(x => x.Profesion == "Medico")}");
        }


        // prop = propiedad
        //ctor =constructor
        // ctrl + k + d =identar
        // ctrl + k + c =comentar
        // ctrl + k + u =descomentar
        // ctrl + s =guardar cambios en la hoja

    }
}
