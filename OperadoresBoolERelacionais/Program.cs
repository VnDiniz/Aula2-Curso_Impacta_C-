namespace OperadoresBoolERelacionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operadores Aritméticos

            // a = b -> 'a' está recebendo o valor de 'b'   (atribuição)
            // a == b -> 'a' é igual a 'b'?    (comparação)
            // a != b -> 'a' é não igual a 'b'?    (não igual ou diferente)
            // true ou false

            int a = 10;
            int b = 20;

            Console.WriteLine("Valor de a: " + a);
            Console.WriteLine("Valor de a: " + b);
            Console.WriteLine("a == b: " + (a == b));   
            Console.WriteLine("a != b: " + (a != b));   
            Console.WriteLine("a > b: " + (a > b));     
            Console.WriteLine("a < b: " + (a < b));     
            Console.WriteLine("a <= b: " + (a <= b));   
            Console.WriteLine("a >= b: " + (a >= b));

            Console.WriteLine(new String('-',50));


            // Operadores Lógicos
            // 
            // &&   AND  (e)
            // ||   OR   (ou)
            // !    NOT  (não)
            //

            int w = 30, x = 40, y = 50, z = 60;
            Console.WriteLine("w < x || y == 50:" + (w < x || y == 50));

        }
    }
}