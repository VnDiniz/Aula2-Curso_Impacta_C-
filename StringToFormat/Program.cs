namespace StringToFormat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal valor = 1276.32m;

            Console.WriteLine(
                string.Format("{0:0.000}", valor) + "\n\n" +
                string.Format("{0:#.###}", valor) + "\n\n" +
                string.Format("{0:0,000.000}", valor) + "\n\n" +
                string.Format("{0:#,##0.00}", valor)
                );


            // 0 -> númerico (digito obrigatório)
            // 0:# é opcional o digito do valor 




        }
    }
}