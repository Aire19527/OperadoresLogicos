using System;
using System.Collections.Generic;
using System.Text;

namespace Operadores
{
    public class Suma
    {
        public void SumarNumero(int numero1, int numero2 )
        {
            int resultado=numero1+numero2;

            Console.WriteLine("Suma de números " + resultado);
            Console.WriteLine($"Suma de números {resultado}");
        }

        private void SumarNumero_Privado(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;

            Console.WriteLine("Suma de números" + resultado);
            Console.WriteLine($"Suma de números {resultado}");
        }
    }
}
