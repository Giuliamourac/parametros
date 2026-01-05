using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //params faz com que nao precise declarar um novo vetor ao colocar os numeros, menos verboso.
            int soma1 = Calculadora.Soma(2, 3);
            int soma2 = Calculadora.Soma(2, 3, 4);

            Console.WriteLine(soma1);
            Console.WriteLine(soma2);

            //ref faz com que a referencia no programa principal seja esta int N
            int triplo = 10;
            Calculadora.Triplo(ref triplo);
            Console.WriteLine(triplo);

            //out nao exige que a variael seja iniciada

            int metade = 30;
            int resultado;
            Calculadora.Metade(metade, out resultado);
            Console.WriteLine(resultado);
        }
    }
}