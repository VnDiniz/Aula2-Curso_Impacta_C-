namespace OperadorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operador Ternário
            // teste lógico ? resposta se true : resposta se false
            //

            int num = 11;

            Console.WriteLine(num + " é " + (num % 2 == 0 ? "par" : "ímpar"));

        }
    }
}