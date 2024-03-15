namespace CalculadoraEnzoPhilippi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Calculadora Tabajara 2024");

                Console.WriteLine("Digite 1 para Adicionar");
                Console.WriteLine("Digite 2 para Subtrair");
                Console.WriteLine("Digite 3 para Multiplicar");
                Console.WriteLine("Digite 4 para Dividir");

                Console.WriteLine("Digite S para sair");

                string operacao = Console.ReadLine();

                if (operacao == "S" || operacao == "s")
                    break;

                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "S")
                {

                    Console.WriteLine("Operação inválida, tente novamente...");
                    Console.ReadLine();

                    continue;
                }

                // escolher operação que será realizada

                Console.WriteLine("Digite o primeiro número");

                string primeiroNumeroString = "";

                primeiroNumeroString = Console.ReadLine();

                double primeiroNumero = Convert.ToDouble(primeiroNumeroString);

                Console.WriteLine("Digite o segundo numero");

                string segundoNumeroString = Console.ReadLine();

                double segundoNumero = Convert.ToDouble(segundoNumeroString);

                double resultado = 0;

                if (operacao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                }

                else if (operacao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                }

                else if (operacao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                }

                else if (operacao == "4")

                    while (segundoNumero == 0)
                    {
                        Console.WriteLine("Segundo número não pode ser Zero, tente novamente");

                        Console.ReadLine();

                        Console.WriteLine("Digite o segundo número novamente: ");

                        segundoNumero = Convert.ToInt32(Console.ReadLine());
                    }
                {
                    resultado = primeiroNumero / segundoNumero;
                }
                Console.WriteLine("O resultado é: " + resultado);

                Console.ReadLine();



            }
        }
    }
}
