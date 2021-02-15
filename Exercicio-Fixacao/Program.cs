using System;
using System.Globalization;

namespace Exercicio_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int continuar = 1;

            Console.WriteLine("Seja bem vindo à lista de exercícios de fixação de classes e atributos. A seguir será fornecido o tópico dos 3 exercícios " +
                "onde você poderá escolher um deles para testar.");

            while (continuar != 0)
            {
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                Console.WriteLine("Exercício 1 - Área, perímetro e diagonal de um retângulo.");
                Console.WriteLine("Exercício 2 - Salário de funcionário com aumento.");
                Console.WriteLine("Exercício 3 - Nota de um aluno.");
                Console.WriteLine("Exercício 4 - Conversor de moedas.");
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

                Console.Write("Escola a opção do exercício desejado (se desejar encerrar o programa digite qualquer outro número):");
                int opcao = int.Parse(Console.ReadLine());

                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");

                if (opcao == 1)
                {
                    Console.WriteLine("Fazer um programa para ler os calores da largura e altura de um retângulo. Em seguida, mostrar na tela o valor de sua área," +
                        "perímetro e diagonal. Usar uma classe mostrada em aula.");

                    Retangulo ret = new Retangulo();

                    Console.WriteLine("Entre a largura e altura do retângulo:");
                    Console.Write("Altura = ");
                    ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Largura = ");
                    ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine($"{ret}\n");
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto). Em seguida, mostrar os dados do " + 
                        "funcionário (nome e salário líquido). Em seguida, aumentar o salário do funcionário com base em uma porcentagem dada (somente o salário " +
                        "bruto é afetado pela porcentagem) e mostrar novamente os dados do funcionário. Use a classe mostrada em aula.\n");

                    Funcionario func = new Funcionario();

                    Console.Write("Nome: ");
                    func.Nome = Console.ReadLine();
                    Console.Write("Salário Bruto: ");
                    func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Imposto: ");
                    func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine($"Funcionário: {func}\n");

                    Console.Write("Digite a porcentagem para aumentar o salário: ");
                    func.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                    Console.WriteLine($"Dados atualizados: {func}\n");
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano (primeiro trimestre vale 30 " + 
                        "e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no ano. Dizer também se o aluno está APROVADO ou REPROVADO e, " +
                        "em caso negativo, quantos pontos faltam para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para " + 
                        "resolver este problema.\n");

                    Aluno aluno = new Aluno();

                    Console.Write("Nome do Aluno: ");
                    aluno.Nome = Console.ReadLine();

                    Console.WriteLine("Digite as três notas do aluno:");
                    aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine(aluno);
                }
                else if (opcao == 4)
                {
                    Console.WriteLine("Faça uma programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por uma pessoa em reais." + 
                        "Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda que a pessora terá que pagar 6% de IOF sobre o valor " + 
                        "em dólar. Criar uma classe ConversorDeMoeda para ser responsável pelos cálculos.\n");

                    Console.Write("Qual é a cotação do dólar? ");
                    double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Quantos dólares você vai comprar? ");
                    double valorDesejado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine();
                    double resultado = ConversorDeMoeda.ConverterMoeda(valorDesejado, dolar);
                    Console.WriteLine($"Valor a ser pago em reais = {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
                }
                else
                    break;

                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

                Console.Write("Digite 1 caso queira verificar outro exercício ou 0 para encerrar: ");
                continuar = int.Parse(Console.ReadLine());

                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");

                Console.Clear();
            }
        }
    }
}
