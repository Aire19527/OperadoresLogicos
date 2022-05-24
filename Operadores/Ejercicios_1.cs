using System;
using System.Collections.Generic;
using System.Text;

namespace Operadores
{
    public class Ejercicios_1
    {
        public void SaludoNombre()
        {
            Console.WriteLine("Escriba su nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine($"Hola, {nombre} ¿cómo estas? {2 + 2}");
            Console.WriteLine("Hola, " + nombre + " ¿cómo estas?");
        }

        public void ConversionLogintud()
        {
            //ctrol + k +d
            double pulgada = 2.54;
            Console.WriteLine("Ingrese longitud en CM:");
            int longitud = Convert.ToInt32(Console.ReadLine());

            double resultado = Math.Round(longitud / pulgada, 4);
            Console.WriteLine($"{longitud} cm = {resultado} in");
        }

        public void Circulo()
        {
            Console.WriteLine("Ingrese el Radio: ");
            int radio = Convert.ToInt32(Console.ReadLine());
            double pi = 3.1416;

            double perimetro = (2 * pi) * radio;
            //double perimetro_2 = 2 * pi * radio;
            //double perimetro_3 = (2 + pi) * radio;

            double area = pi * (radio * radio);
            Console.WriteLine($"Perímetro: {perimetro}");
            Console.WriteLine($"Área: {area}");
        }

        public void DeterminarParOImpar()
        {
            Console.WriteLine("Ingrese un número");
            int numero = Convert.ToInt32(Console.ReadLine());

            if ((numero % 2) == 0)
            {
                Console.WriteLine("Es un número par");
            }
            else
            {
                Console.WriteLine("Es un número impar");
            }
        }

        public void PalabraLarga()
        {
            Console.WriteLine("Escriba la palabra #1: ");
            string palabra_1 = Console.ReadLine();

            Console.WriteLine("Escriba la palabra #2: ");
            string palabra_2 = Console.ReadLine();

            int carateres_1 = palabra_1.Length;
            int carateres_2 = palabra_2.Length;

            if (carateres_1 > carateres_2)
            {
                Console.WriteLine($"La palabra: {palabra_1} tiene {carateres_1 - carateres_2} letras más que {palabra_2}");
            }
            else
            {
                Console.WriteLine($"La palabra: {palabra_2} tiene {carateres_2 - carateres_1} letras más que {palabra_1}");
            }
        }

        public void LetraONumero()
        {
            Console.WriteLine("Ingrese un carácter: ");
            string caracter = Console.ReadLine();

            try
            {
                int numero = Convert.ToInt32(caracter);
                Console.WriteLine("Es un número");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Es una letra");
            }
        }

    }
}
