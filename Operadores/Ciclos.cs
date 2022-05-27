using System;
using System.Collections.Generic;
using System.Text;

namespace Operadores
{
    public class Ciclos
    {
        public void LlenadoListas()
        {
            List<int> listInt = new List<int>()
            {
                10,
                260,
                341,
                478,
            };

            listInt.Add(5);

            List<int> listInt2 = new List<int>()
            {
                6,
                7,
                8,
            };

            listInt.AddRange(listInt2);

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //foreach (var item in listInt)
            //{
            //    Console.WriteLine(item);
            //}

            int opt = 1;
            int count = 0;
            while (opt == 1)
            {
                //count++;
                count = count + 1;


                Console.WriteLine($"Grupo Sofia {count}");

                if (count == 20)
                {
                    opt = 2;
                }
            }

            Console.WriteLine("Salió del bucle");

        }

        public void EjemploWhile()
        {
            Ejercicios_1 objEjercicios = new Ejercicios_1();
            int opt = 1;
            while (opt == 1)
            {
                Console.Clear(); //limpiar pantalla
                Console.WriteLine("***********************");
                Console.WriteLine("***Ejercicios Sofia ***");
                Console.WriteLine("***********************");
                Console.WriteLine("");
                Console.WriteLine("1. Saludo por el nombre");
                Console.WriteLine("2. Conversión de longitud");
                Console.WriteLine("3. Circulo");
                Console.WriteLine("4. Determinar Par o Impar");
                Console.WriteLine("5. Palabra más larga");
                Console.WriteLine("6. Letra o número");
                Console.WriteLine("7. ** SALIR **");
                Console.WriteLine("");
                int ejercio = Convert.ToInt32(Console.ReadLine());

                if (ejercio == 1)
                {
                    objEjercicios.SaludoNombre();
                }
                else if (ejercio == 2)
                {
                    objEjercicios.ConversionLogintud();
                }
                else if (ejercio == 3)
                {
                    objEjercicios.Circulo();
                }
                else if(ejercio==4)
                {
                    objEjercicios.DeterminarParOImpar();
                }
                else if (ejercio == 5)
                {
                    objEjercicios.PalabraLarga();
                }
                else if (ejercio == 6)
                {
                    objEjercicios.LetraONumero();
                }
                else if (ejercio == 7)
                {
                    opt = 2;
                }
                Console.ReadKey(); //espera a que de enter
            }
        }

        public void EjemploCicloFor()
        {
            //Digitar la cantidad de veces que se va a repetir un nombre
            int opt = 1;
            while (opt==1)
            {
                Console.Clear();
                Console.WriteLine("***********************");
                Console.WriteLine("***Ejercicios Ciclo For ***");
                Console.WriteLine("***********************");
                Console.WriteLine("");
                Console.WriteLine("1. Repetir For");
                Console.WriteLine("2. ** SALIR **");
                int ejercio =Convert.ToInt32(Console.ReadLine());

                if (ejercio == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Digita un nombre");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("¿cuantas veces quiere que se repita ese nombre?");
                    int cantidad = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= cantidad; i++)
                    {
                        Console.WriteLine($"{nombre} {i}");
                    }

                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($"Hasta la próxima");
                    opt = 2;
                }
                

            }
        }

    }
}
