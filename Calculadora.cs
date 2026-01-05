using System.Security.Principal;

namespace Curso
{
    class Calculadora
    {
        public static int Soma(params int[] numeros) //params faz com que nao precise declarar um novo vetor ao colocar os numeros, menos verboso.
        {
            int soma = 0;

            for(int i =0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }

            return soma;
        }

        public static void Triplo(ref int n) // ref faz com que a referencia no programa principal seja esta int N
        {
            n = n * 3;
        }

        public static void Metade(int origem, out int resultado) //out nao exige que a variael seja iniciada, variavel de saida
        {
            resultado = origem/2;
        }

    }
}