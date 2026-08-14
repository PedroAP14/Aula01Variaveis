//Teste commit Aula03

using System;

namespace Aula01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nQual exemplo você quer vizualizar?");
            Console.WriteLine("\n1 - Concatenar palavras\n2 - Calcular Média\n3 - Calcular Tabuada\n4 - Verificar Aula Etec\n5 - Detalhar Data\n6 - Desconto do INSS");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    ConcatenarPalavras();
                    break;

                case 2:
                    CalcularMedia();
                    break;

                case 3:
                    CalcularTabuada();
                    break;

                case 4:
                    VerificarAulaEtec();
                    break;

                case 5:
                    DetalharData();
                    break;

                case 6:
                    CalcularDescontoINSS();
                    break;

                default:
                    Console.WriteLine("Insira um exemplo válido");
                    break;
            }
        }

        public static void CalcularDescontoINSS()
        {
            Console.WriteLine("\nDigite seu salário:");
            float salario = float.Parse(Console.ReadLine());
            float desconto;
            float salariofinal;

            if (salario <= 1621)
            {
                desconto = salario * 0.075f;
            }

            else if (salario > 1621 && salario <= 2902.84f)
            {
                desconto = 1621 * 0.075f + (salario - 1621) * 0.09f;
            }

            else if (salario > 2902.84f && salario <= 4354.27f)
            {
                desconto = 1621 * 0.075f + (2902.84f - 1621) * 0.09f + (salario - 2902.84f) * 0.12f;
            }

            else if (salario > 4354.27f && salario <= 8475.55f)
            {
                desconto = 1621 * 0.075f + (2902.84f - 1621) * 0.09f + (4354.27f - 2902.84f) * 0.12f + (salario - 4354.27f) * 0.14f;
            }

            else
            {
                desconto = 1621 * 0.075f + (2902.84f - 1621) * 0.09f + (4354.27f - 2902.84f) * 0.12f + (8475.55f - 4354.27f) * 0.14f;
            }

            salariofinal = salario - desconto;
            Console.WriteLine($"\nO desconto é de {desconto:c2} portanto o seu salário vai ser {salariofinal:c2}");
        }

        public static void DetalharData()
        {
            Console.WriteLine("\nDigite uma data:");
            DateTime datahoje = DateTime.Parse(Console.ReadLine());

            if (datahoje.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("\nEsse dia é {0:dddd} do mês {0:MMMM} e são {1:HH:mm}", datahoje, DateTime.Now);
            }
            else
            {
                Console.WriteLine("\nEsse dia é {0:dddd} do mês {0:MMMM}", datahoje);
            }
        }

        public static void VerificarAulaEtec()
        {
            Console.WriteLine("\nDigite a data:");
            DateTime data = DateTime.Parse(Console.ReadLine());

            if (data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Final de semana! Hoje não tem aula! Revisarei exercícios.");
            }
            else
            {
                Console.WriteLine("Dia da semana! Bora pra Etec!");
            }
        }

        public static void CalcularTabuada()
        {
            Console.WriteLine("\nDigite a tabuada que você deseja calcular:");
            int tabuada = int.Parse(Console.ReadLine());
            int contador = 0;

            while (contador <= 10)
            {
                string mensagem = string.Format("{0} X {1} = {2}", tabuada, contador, tabuada * contador);
                Console.WriteLine(mensagem);
                contador++;
            }

        }

        public static void CalcularMedia()
        {
            Console.WriteLine("\nDigite a primeira nota:");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a segunda nota:");
            decimal nota2 = decimal.Parse(Console.ReadLine());

            decimal media = (nota1 + nota2) / 2;
            Console.WriteLine($"\nA média das notas é: {media}\n");

            if (media >= 7)
                Console.WriteLine("Você está APROVADO\n");
            else if (media < 7 && media >= 4)
                Console.WriteLine("Você está de RECUPERAÇÃO\n");
            else
                Console.WriteLine("Você está REPROVADO\n");

        }

        public static void ConcatenarPalavras()
        {
            Console.WriteLine("\nDigite seu nome: ");
            string nome = Console.ReadLine();
            string frase1 = $"\nOlá {nome}, Hoje é {DateTime.Now}";
            Console.WriteLine(frase1);
            Console.WriteLine("\n================================");

            Console.WriteLine("\nQuanto custa o dólar em reais?");
            decimal valorreais = decimal.Parse(Console.ReadLine());
            string frase2 = string.Format("\nHoje é dia {0:dd/MM/yyyy}, o dólar está custando {1:c2}", DateTime.Now, valorreais);
            Console.WriteLine(frase2);
            Console.WriteLine("\n================================");

            string cabecalho = string.Format("\n{0:dddd}, {0:dd} de {0:MMMM} de {0:yy} - {0:HH:mm:ss}\n", DateTime.Now);
            Console.WriteLine(cabecalho);
        }
    }
}