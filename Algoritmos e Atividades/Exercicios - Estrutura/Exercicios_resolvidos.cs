using System;
using System.Globalization;

namespace EstruturasSequenciais
{
    public class EstruturaSequencial
    {
        public static void Exercicio1()
        // Faça um programa para ler dois valores inteiros e, em seguida, mostrar a soma desses números com uma mensagem explicativa.
        {
            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());
            int soma = valor1 + valor2;
            Console.WriteLine("SOMA = " + soma);
        }

        public static void Exercicio3()
        // Faça um programa para ler quatro valores inteiros A, B, C e D. Em seguida, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int diferenca = (a * b) - (c * d);

            Console.WriteLine("DIFERENCA = " + diferenca);
        }

        public static void Exercicio4()
        // Faça um programa que leia o número de um funcionário, suas horas trabalhadas, o valor que recebe por hora e calcule o salário desse funcionário. Em seguida, mostre o número e o salário do funcionário, com duas casas decimais.
        {
            int numFuncionario = int.Parse(Console.ReadLine());
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = (double)horasTrabalhadas * valorPorHora;

            Console.WriteLine("NUMERO = " + numFuncionario);
            Console.WriteLine("SALARIO = R$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void Exercicio5()
        // Faça um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
        {
            string[] pecas1 = Console.ReadLine().Split(' ');
            int codPeca1 = int.Parse(pecas1[0]);
            int numPecas1 = int.Parse(pecas1[1]);
            double valorUnitario1 = double.Parse(pecas1[2], CultureInfo.InvariantCulture);

            string[] pecas2 = Console.ReadLine().Split(' ');
            int codPeca2 = int.Parse(pecas2[0]);
            int numPecas2 = int.Parse(pecas2[1]);
            double valorUnitario2 = double.Parse(pecas2[2], CultureInfo.InvariantCulture);

            double valorTotal = (double)(numPecas1 * valorUnitario1) + (numPecas2 * valorUnitario2);

            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void Exercicio6()
        // Faça um programa que leia três valores em ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
        // a) a área do triângulo retângulo que tem A por base e C por altura.
        // b) a área do círculo de raio C. (pi = 3.14159)
        // c) a área do trapézio que tem A e B por bases e C por altura.
        // d) a área do quadrado que tem lado B.
        // e) a área do retângulo que tem lados A e B.
        {
            string[] valores = Console.ReadLine().Split(' ');
            double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double triangulo = A * C / 2.0;
            double circulo = 3.14159 * C * C;
            double trapezio = (A + B) / 2.0 * C;
            double quadrado = B * B;
            double retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}

namespace EstruturasCondicionais
{
    public class EstruturaCondicional
    {
        public static void Exercicio1()
        // Faça um programa para ler um número inteiro e dizer se este número é negativo ou não.
        {
            int numero = int.Parse(Console.ReadLine());
            if (numero >= 0)
                Console.WriteLine("NAO NEGATIVO");
            else
                Console.WriteLine("NEGATIVO");
        }

        public static void Exercicio2()
        // Faça um programa para ler um número inteiro e dizer se este número é par ou ímpar.
        {
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("PAR");
            else
                Console.WriteLine("IMPAR");
        }

        public static void Exercicio3()
        // Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            if (A % B == 0 || B % A == 0)
                Console.WriteLine("Sao Multiplos");
            else
                Console.WriteLine("Nao Sao Multiplos");
        }

        public static void Exercicio4()
        // Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
        {
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;

            if (horaInicial < horaFinal)
                duracao = horaFinal - horaInicial;
            else
                duracao = 24 - horaInicial + horaFinal;

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
        }

        public static void Exercicio5()
        // Escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.
        {
            string[] pedido = Console.ReadLine().Split(' ');
            double codigo = double.Parse(pedido[0]);
            double quantidade = double.Parse(pedido[1]);

            double preco = 0.0;

            if (codigo == 1)
                preco = 4.00 * quantidade;
            else if (codigo == 2)
                preco = 4.50 * quantidade;
            else if (codigo == 3)
                preco = 5.00 * quantidade;
            else if (codigo == 4)
                preco = 2.00 * quantidade;
            else
                preco = 1.50 * quantidade;

            Console.WriteLine("Total: R$ " + preco.ToString("F2"));
        }

    }
}

namespace EstruturasWhile
{
    public class EstruturaWhile
    {
        public static void Exercicio1()
        // Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha incorreta informada, escreva a mensagem "Senha Inválida". Quando a senha for informada corretamente, deve ser impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
        {
            int senha = int.Parse(Console.ReadLine());
            while (senha != 2002)
            {
                Console.WriteLine("Senha Inválida");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }

        public static void Exercicio2()
        // Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema cartesiano. Para cada ponto, escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo menos uma das duas coordenadas for igual a zero (nesta situação, nenhuma mensagem deve ser impressa).
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int x = int.Parse(entrada[0]);
            int y = int.Parse(entrada[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                    Console.WriteLine("Primeiro");
                else if (x > 0 && y < 0)
                    Console.WriteLine("Quarto");
                else if (x < 0 && y < 0)
                    Console.WriteLine("Terceiro");
                else
                    Console.WriteLine("Segundo");
                entrada = Console.ReadLine().Split(' ');
                x = int.Parse(entrada[0]);
                y = int.Parse(entrada[1]);
            }
        }

        public static void Exercicio3()
        // Um posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1. Álcool, 2. Gasolina, 3. Diesel, 4. Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4), deve ser solicitado um novo código (até que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser impressa a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo.
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int produto = int.Parse(Console.ReadLine());

            while (produto != 4)
            {
                if (produto == 1)
                    alcool += 1;
                else if (produto == 2)
                    gasolina += 1;
                else if (produto == 3)
                    diesel += 1;
                else
                    Console.WriteLine("Código inválido. Digite um código válido.");

                produto = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine($"Alcool: {alcool}\nGasolina: {gasolina}\nDiesel: {diesel}");
        }
    }
}
