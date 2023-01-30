namespace OperadorCoalescenciaNula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string curso = null;
            string texto = curso ?? "Curso não informado";
            Console.WriteLine("Curso: " + texto);

            string curso2 = "C#";
            string texto2 = curso2 ?? "Curso não informado";
            Console.WriteLine("Curso: " + texto2);
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Texto longo e essa linha deve ir pra \nlinha de baixo");
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Código   \tProduto       \tPreço");
            Console.WriteLine("001      \tMouse         \tR$12,78");
            Console.WriteLine("001      \tTeclado       \tR$18,20");
            Console.WriteLine("001      \tMonitor       \tR$35,43");


        }
    }
}