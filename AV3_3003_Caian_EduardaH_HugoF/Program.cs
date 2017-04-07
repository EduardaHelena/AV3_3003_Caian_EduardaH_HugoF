using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV3_3003_Caian_EduardaH_HugoF
{
    class Player
    {
        string nome;
        int ponto;
        public Player(string nome, int ponto)
        {
            this.nome = nome;
            this.ponto = ponto;
        }
    }
    class Program
    {
      
        static void Main(string[] args)
        {
            
            int[] pontuacao = new int[] { 10, 5, 3, 100, 120, 55, 45, 30, 200, 150 };

            string[] jogador = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };


            //Console.WriteLine(pontuacao[0] + "" + player [0]);

            int indice = 0;

            string indiceNome;


            for (int i = 0; i < pontuacao.Length; i++)
            {


                for (int j = i + 1; j < pontuacao.Length; j++)
                {

                    if (pontuacao[i] < pontuacao[j])
                    {
                        indice = pontuacao[i];
                        indiceNome = jogador[i];

                        pontuacao[i] = pontuacao[j];
                        jogador[i] = jogador[j];

                        pontuacao[j] = indice;
                        jogador[j] = indiceNome;
                    }


                }

                //Imprimi a lista com Nome e Jogador
                Console.WriteLine("Nome: " + jogador[i] + "  ||   " + "Pontos: " + pontuacao[i]);
                Console.WriteLine("----------------------------------------------------------------");

            }

            Console.WriteLine("");
            Console.WriteLine("Deseja salvar sua pontuacao?");
            string SalvarDados = Console.ReadLine();

            if (SalvarDados == "Sim" || SalvarDados == "sim")
            { 
                Console.WriteLine("");
                Console.WriteLine("Seu nome: ");
                string NomeUsuario = Console.ReadLine().ToString();

                Console.WriteLine("");
                Console.WriteLine("Sua pontuacao: ");
                int PontosUsuario = int.Parse(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("Deseja ver Ranking: ");
                string VerTabela = Console.ReadLine().ToString();

                if (VerTabela  == "Sim" || VerTabela == "sim")
                {

                    if (PontosUsuario > pontuacao[pontuacao.Length - 1])
                    {
                        pontuacao[pontuacao.Length - 1] = PontosUsuario;
                        jogador[jogador.Length - 1] = NomeUsuario;
                    }

                    for (int i = 0; i < pontuacao.Length; i++)
                    {

                        for (int j = i + 1; j < pontuacao.Length; j++)
                        {


                            if (pontuacao[i] < pontuacao[j])
                            {
                                indice = pontuacao[i];

                                indiceNome = jogador[i];

                                pontuacao[i] = pontuacao[j];
                                jogador[i] = jogador[j];
                                
                                pontuacao[j] = indice;
                                jogador[j] = indiceNome;
                            }

                        }

                        //Imprimi a lista com Nome e Jogador
                        Console.WriteLine("Nome: " + jogador[i] + "  ||   " + "Pontos: " + pontuacao[i]);
                        Console.WriteLine("----------------------------------------------------------------");

                       
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Deseja salvar sua pontuacao?");
                    SalvarDados = Console.ReadLine();

                }
                Console.ReadLine();

            }


        }

    }
}
