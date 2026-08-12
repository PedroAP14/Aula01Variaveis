//Teste commit Aula03

using System;

namespace Aula01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nQual exemplo você quer vizualizar?");
            Console.WriteLine("\n1 - Concatenar palavras\n2 - Calcular Média\n3 - Calcular Tabuada\n4 - Verificar Aula Etec");
            int escolha = int.Parse(Console.ReadLine());
            if (escolha == 1)
                ConcatenarPalavras();
            else if (escolha == 2)
                CalcularMedia();
            else if (escolha == 3)
                CalcularTabuada();
            else if (escolha == 4)
                VerificarAulaEtec();
            else
                Console.WriteLine("Insira um exemplo válido");
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