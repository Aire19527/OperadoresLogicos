using System;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AveriguarEdad();

            //Ejercicios_1 objEjercicio = new Ejercicios_1();
            //objEjercicio.LetraONumero();

            Ciclos objCiclos = new Ciclos();
            objCiclos.EjemploCicloFor();
        }

        //CamelCase
        static void Variables()
        {

            Console.WriteLine("Hola mundo.");

            //Variables
            // Tipo Enteros
            // System.Int32
            int entero = 32; //32 bytes
            int numero = 100;

            int resultadoSuma = entero + numero;
            Console.WriteLine("Suma");
            Console.WriteLine(resultadoSuma);

            int resultadoMultiplicacion = entero * numero;
            Console.WriteLine("Multiplicacion");
            Console.WriteLine(resultadoMultiplicacion);

            decimal resultadoDivision = Convert.ToDecimal(entero) / Convert.ToDecimal(numero);
            Console.WriteLine("Division");
            Console.WriteLine(resultadoDivision);


            int resultadoResta = entero - numero;
            Console.WriteLine("Resta");
            Console.WriteLine(resultadoResta);


            //// System.Int64
            //long largoEntero = 64; // 64 bytes

            //// System.Int16
            //short s = 16; //16 bytes

            //// tipo texto
            //string texto = "Hola mundo del gallinero";

            //// Tipos Logicos
            //bool resultado = true;
            //bool resultadoDos = false;
        }


        static void AveriguarEdad()
        {
            // averiguar la edad de una persona, y si es mayor a 20 años, entonces decirle que 
            //aplica a un bono de descuento, si no es mayor, decirle que debe esperar hasta
            // que cumpla 20 años.

            Console.WriteLine("*** PRIMER ALGORITMO QUE AVERIGUA LA EDAD ***");
            Console.WriteLine("Por favor digita tu fecha de nacimiento: ");
            int fechaNacimiento = Convert.ToInt32(Console.ReadLine());
            //int fechaNacimiento = Console.ReadLine();

            var q = Console.ReadLine();

            //int anio = 2022;
            int anio = DateTime.Now.Year;

            int edad = anio - fechaNacimiento;

            if (edad >= 20)
            {
                Console.WriteLine("Señor usuario, usted aplica para un bono de descuento");
            }
            else
            {
                Console.WriteLine("Señor usuario, usted debe esperar a tener 20 años");
            }
        }
    }
}
