using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("!, 2, 3, 4, 5, 6, 7, 8, 9,10\n11,12,13,14,15,16,17,18,19,20\n21,22,23,24,25,26,27,28,29,30\n31,32,33,34,35,36,37,38,39,40");
            Console.Write("\n");
            Console.Write("\n1, 2, 3, 4, 5, 6, 7, 8, 9,10");
            Console.Write("\n11,12,13,14,15,16,17,18,19,20");
            Console.Write("\n21,22,23,24,25,26,27,28,29,30");
            Console.Write("\n31,32,33,34,35,36,37,38,39,40");
            Console.ReadKey();
            Console.Clear();
            // Exercicio 2
            var x = 2;
            var y = 3;
            Console.WriteLine("x =" + x);
            Console.WriteLine("O valor de x + x é: " + (x + x));
            Console.WriteLine("x =");
            Console.WriteLine((x + y) + "=" + (y + x));
            Console.ReadKey();
            Console.Clear();
            //exercicio 3
            Console.WriteLine("*\n**\n***\n****\n*****");
            Console.ReadKey();
            Console.Clear();
            //Exercicio 4
            Console.Write("*");
            Console.Write("***");
            Console.WriteLine("*****");
            Console.Write("****");
            Console.WriteLine("**");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Coloque seu Ra");
            var ra = Console.ReadLine();
            Console.WriteLine("Coloque seu nome");
            var nome = Console.ReadLine();
            Console.WriteLine("Coloque seu sobrenome");
            var sobrenome = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"{ra}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{nome}");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{sobrenome}");
            Console.ReadKey();
            Console.Clear();
            //exercicio 6
            Console.WriteLine("6. Escreva um programa que solicite do usuário dois números, e imprima o resultado da soma, subtração, multiplicação e divisão.");
            Console.Write("\nNúmero 1: ");
            int numero1 = Int32.Parse(Console.ReadLine());

            Console.Write("Número 2: ");
            int numero2 = Int32.Parse(Console.ReadLine());

            int soma = numero1 + numero2;
            Console.WriteLine("{0} + {1} = {2}", numero1, numero2, soma);

            int subtracao = numero1 - numero2;
            Console.WriteLine("{0} - {1} = {2}", numero1, numero2, subtracao);

            int multiplicacao = numero1 * numero2;
            Console.WriteLine("{0} × {1} = {2}", numero1, numero2, multiplicacao);

            int divisao = numero1 / numero2;
            Console.WriteLine("{0} ÷ {1} = {2}", numero1, numero2, divisao);


            Console.WriteLine("\n\n");
            Console.ReadKey();
            Console.Clear();
            //exercicio 7
            Console.WriteLine("Escreva um programa que receba como entrada o raio de um círculo e imprima o diâmetro, a circunferência e a área. " +
                "Para isso, utilize as fórmulas: diâmetro = 2r; circunferência = 2πr, área = πr² ");

            Console.Write("\nRaio: ");
            double raio = Double.Parse(Console.ReadLine());

            double diametro = 2 * raio;
            double circunferencia = 2 * Math.PI * raio;
            double area = Math.PI * Math.Pow(raio, 2);

            Console.WriteLine("Diâmetro = " + diametro);
            Console.WriteLine("Circunferência = " + circunferencia);
            Console.WriteLine("Área = " + area);

            Console.WriteLine("\n\n");
            Console.ReadKey();
            Console.Clear();
            //exercicio 8
            Console.WriteLine("Escreva um programa que leia dois números inteiros e determine e verifique se o primeiro é um múltiplo do segundo. " +
                "Por exemplo: se o usuário digitar 15 e 3, o primeiro número será múltiplo do segundo; se o usuário digitar 2 e 4, o primeiro número " +
                "não será múltiplo do segundo. Dica: use o operador módulo para obter o resto da divisão.");
            Console.WriteLine("Digite um número positivo inteiro, diferente de zero");

            Console.Write("\nNúmero 1: ");
            int numeroInteiro1 = Int32.Parse(Console.ReadLine());

            Console.Write("Número 2: ");
            int numeroInteiro2 = Int32.Parse(Console.ReadLine());
            int resto = numeroInteiro1 % numeroInteiro2;


            if (resto > 0)
                Console.WriteLine("{0} NÃO é múltiplo de {1}", numeroInteiro1, numeroInteiro2);
            else
                Console.WriteLine("{0} é múltiplo de {1}", numeroInteiro1, numeroInteiro2);


            Console.WriteLine("\n\n");
            Console.ReadKey();
            Console.Clear();
            //exercicio 9
            Console.WriteLine("9. Escreva um programa que receba como entrada um número de 5 dígitos, separe o número em dígitos individuais e os imprima " +
                "separados por 3 espaços cada um. Por exemplo, se o usuário digitar 42339, o programa deverá imprimir: 4    2    3    3    9. Dica: utilize " +
                "as operações de divisão e módulo para extrair cada dígito do número.");

            int unidade = 0;
            int dezena = 0;
            int centena = 0;
            int unidadeDeMilhar = 0;
            int dezenaDeMilhar = 0;
            int restoDivisao = 0;
            int quociente = 0;

            const int DECIMAL = 10;
            // a constante é usada quando o valor sera unico durante toda a execução

            // Lê dado do usuário
            Console.WriteLine("Digite um número inteiro com 5 dígitos");
            Console.Write("\nNúmero: ");
            int numeroCincoDigitos = Int32.Parse(Console.ReadLine());

            // Obtém digito das unidades
            restoDivisao = numeroCincoDigitos % DECIMAL;
            quociente = numeroCincoDigitos / DECIMAL;
            unidade = restoDivisao;

            // Obtém dígito das dezenas
            restoDivisao = quociente % DECIMAL;
            quociente = quociente / DECIMAL;
            dezena = restoDivisao;

            // Obtém dígito das centenas
            restoDivisao = quociente % DECIMAL;
            quociente = quociente / DECIMAL;
            centena = restoDivisao;

            // Obtém dígito das unidades de milhar
            restoDivisao = quociente % DECIMAL;
            quociente = quociente / DECIMAL;
            unidadeDeMilhar = restoDivisao;

            // Obtém dígito das dezenas de milhar
            dezenaDeMilhar = quociente;

            Console.WriteLine("Número Espaçado: {0}   {1}   {2}   {3}   {4}", dezenaDeMilhar, unidadeDeMilhar, centena, dezena, unidade);


            Console.WriteLine("\n\n");
            Console.ReadKey();
            Console.Clear();
            //exercicio 10
            Console.WriteLine("10. Escreva um programa que calcule o quadrado e o cubo dos números de 0 a 10, e imprima os valores em forma de tabela.");

            int numero = 0;
            double quadrado = 0.0;
            double cubo = 0.0;

            Console.WriteLine("\nNúmero\t\tQuadrado\tCubo");

            quadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

            numero = numero + 1;
            quadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

            numero = numero + 1;
            quadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

            numero = numero + 1;
            quadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

            numero = numero + 1;
            quadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

            numero = numero + 1;
            quadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

            numero = numero + 1;
            quadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

            numero = numero + 1;
            quadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

            numero = numero + 1;
            quadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

            numero = numero + 1;
            quadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

            numero = numero + 1;
            quadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

            Console.ReadKey(true);

        }
    }
}