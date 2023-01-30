namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Operadores Aritméticos
             * + Somar
             * - Subtrair
             * * Multiplicar
             * / Dividir
             * % Módulo (resto da divisão)
             * 
             */

            int a = 5;
            int b = 2;
            int soma = a + b;
            int subtracao = a - b;
            int multiplicacao = a * b;
            int divisao = a / b;
            int resto = a % b;

            Console.WriteLine("Resultado da soma: " + soma);
            Console.WriteLine("Resultado da subtração: " + subtracao);
            Console.WriteLine("Resultado da multiplicação: " + multiplicacao);
            Console.WriteLine("Resultado da divisão: " + divisao);
            Console.WriteLine("Resultado do resto da divisão: " + resto);
            Console.WriteLine("----------------------------------------");


            // Operadores Incrementais e Decrementais:
            // ++   Incremento
            // --   Decremento

            int num = 5;
            Console.WriteLine("Valor de num: " + num);
            Console.WriteLine("Valor de num antes do incremento: " + num++);
            Console.WriteLine("Valor de num pós-incremento: " + num);
            Console.WriteLine("2 + ++num: " + (2 + ++num));

        }
    }
}