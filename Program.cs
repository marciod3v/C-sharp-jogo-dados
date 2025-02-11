using System;


namespace textEditor
{
    class Program
    {
        private static object p1;
        private static object p2;

        private static object dadoP1;
        private static object dadoP2;

        private static object numeroAleatorio;

        private static object pontuacaoP1;
        private static object pontuacaoP2;


        static void Main(string[] args)
        {
            string repetirLoop = "sim";
            while (repetirLoop == "sim")
            {
                Jogadores();
                Console.WriteLine("Deseja jogar novamente ? (sim/nao)");
                repetirLoop = Console.ReadLine();
                Console.Clear();
            }

        }
        static void Jogadores()
        {
            Console.Clear();
            Console.WriteLine("Digite o nome do jogador 1:");
            p1 = Console.ReadLine().ToLower();
            Console.WriteLine("Digite o nome do jogador 2:");
            p2 = Console.ReadLine().ToLower();

            if (p1 == p2)
            {
                Console.WriteLine("Os jogadores não podem ter o mesmo nome.Insira os dados novamente:");
                Thread.Sleep(1000);
                Console.Clear();
                Jogadores();
            }
            else
            {
                rodadas();
            }
        }

        static void rodadas()
        {
            Random numeroAleatorio = new Random();

            int dadoP1 = 0;
            int dadoP2 = 0;

            int pontuacaoP1 = 0;
            int pontuacaoP2 = 0;
            Console.WriteLine("Digite o número de rodadas (1 a 5):");
            int numeroRodadas = int.Parse(Console.ReadLine());

            if (numeroRodadas > 5 || numeroRodadas < 1)
            {
                Console.WriteLine("Número de rodadas inválido.");
                rodadas();
            }

            for (int i = 1; i <= numeroRodadas; i++)
            {
                Thread.Sleep(500);
                Console.Clear();

                dadoP1 = numeroAleatorio.Next(1, 7);
                dadoP2 = numeroAleatorio.Next(1, 7);
                Console.WriteLine($"Jogando dados do {p1}.");
                Thread.Sleep(1500);
                Console.WriteLine($"Resultado:{dadoP1}");
                Thread.Sleep(1500);
                Console.WriteLine($"Jogando dados do {p2}.");
                Thread.Sleep(1500);
                Console.WriteLine($"Resultado:{dadoP2}");

                if (dadoP1 > dadoP2)
                {
                    Console.WriteLine($"{p1} venceu a {i} rodada.");
                    Thread.Sleep(1500);
                    pontuacaoP1++;
                }
                else if (dadoP1 < dadoP2)
                {
                    Console.WriteLine($"{p2} venceu a {i} rodada.");
                    Thread.Sleep(1500);
                    pontuacaoP2++;
                }

                Thread.Sleep(2000);
            }

            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("Fim de jogo");
            Thread.Sleep(1000);
            if (pontuacaoP1 > pontuacaoP2)
            {
                Console.WriteLine($"{p1} venceu");
            }
            else if (pontuacaoP1 == pontuacaoP2)
            {
                Console.WriteLine("Empate");
                Thread.Sleep(1000);
                Console.WriteLine("Rodada bônus iniciando...");
                Thread.Sleep(1000);
                rodadaBonus();
            }
            else
            {
                Console.WriteLine($"{p2} venceu");
            }
        }

        static void rodadaBonus()
        {
            Random numeroAleatorio = new Random();
            int pontuacaoP1 = 0;
            int pontuacaoP2 = 0;

            Console.Clear();
            int dadoP1 = numeroAleatorio.Next(1, 7);
            int dadoP2 = numeroAleatorio.Next(1, 7);
            Console.WriteLine($"Jogando dados do {p1}.");
            Thread.Sleep(1500);
            Console.WriteLine($"Resultado:{dadoP1}");
            Thread.Sleep(1500);
            Console.WriteLine($"Jogando dados do {p2}.");
            Thread.Sleep(1500);
            Console.WriteLine($"Resultado:{dadoP2}");

            if (dadoP1 > dadoP2)
            {
                Console.WriteLine($"{p1} venceu a rodada bônus.");
                Thread.Sleep(1500);
                pontuacaoP1++;
            }
            else if (dadoP1 < dadoP2)
            {
                Console.WriteLine($"{p2} venceu a rodada bônus.");
                Thread.Sleep(1500);
                pontuacaoP2++;
            }

            if (pontuacaoP1 > pontuacaoP2)
            {
                Console.WriteLine($"{p1} Ganhou");
            }
            else if (pontuacaoP1 == pontuacaoP2)
            {
                Console.WriteLine("Empate novamente, iniciando outra rodada bônus...");
                Thread.Sleep(1000);
                Console.Clear();
                rodadaBonus();
            }
            else if (pontuacaoP1 < pontuacaoP2)
            {
                Console.WriteLine($"{p2} Ganhou");
            }
        }

        static int somarPontuacao(int pontuacaoP1, int pontuacaoP2)
        {
            Console.WriteLine($"A pontuação final do {p1} é:{pontuacaoP1}");
            Console.WriteLine($"A pontuação final de {p2} é:{pontuacaoP2}");
        }
    }
}