namespace TiposDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Vinicius";
            int idade = 10;
            idade = 30;
                                                        // Precisão de casas decimais
            float salario = 1500.87844764f;             // 7 digitos
            double comissao = 456.4563784756453432;     // 15-16 digitos
            decimal juros = 0.987564839658476947346M;   // 28-29 digitos

            bool maiorDeIdade = false;
            char _teste = '1';

            // uso do var não é muito recomendável
            var x1 = 10;
            var x2 = "abc";
            // x1 = "abc";      após a declaração do primeiro valor (no caso do x1 int) ele não aceita mais outros tipos


            // Concatenar - Modo 1
            Console.WriteLine("Nome do aluno: " + nome);
            Console.WriteLine("Idade do aluno: " + idade);

            // Interpolação - Modo 2
            Console.WriteLine($"Nome: {nome}, salário: {salario}, é maior de idade: {maiorDeIdade}");

            // PlaceHolder - Modo 3
            Console.WriteLine("Nome: {0}, salário: {1}, é maior de idade: {2}", nome, salario, maiorDeIdade);
        }
    }
}