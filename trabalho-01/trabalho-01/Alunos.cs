using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_01
{
    class Alunos
    {
        int[] numerosAlunos = new int[480];

        int atual = 0;


        public void CadastrarAluno()
        {
            Console.Write("Digite a Turma: ");
            numerosAlunos[atual] = Convert.ToInt32(Console.ReadLine());
            atual++;
        }

        public void ListarTurmas()
        {
            Console.Clear();

            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(
                    String.Format(
                        "\nAlunos: {0}",
                         numerosAlunos[atual]

                         )

                         );
            }
        }

        public void EditarTurmas()
        {
            Console.Clear();
            Console.WriteLine("Digite a Turma para Pesquisar: ");
            int AlunoPesquisa = Convert.ToInt32(Console.ReadLine());
            int posicao = -1;
            for (int i = 0; i < atual; i++)
            {
                if (AlunoPesquisa == numerosAlunos[i])
                {
                    posicao = 1;
                }
            }

            if (posicao != -1)
            {
                // encontrou o registro procurado
                Console.Write("Número da Turma: ");
                numerosAlunos[posicao] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Dados alterados com sucesso");
            }
            else
            {
                Console.WriteLine("Registro não encontrado");
            }
        }

        public void BuscarTurmas()
        {
            Console.WriteLine("Digite a Turma para Busca: ");
            int buscarAluno = Convert.ToInt32(Console.ReadLine());
            bool achou = false;

            for (int i = 0; i < atual; i++)
            {
                if (buscarAluno == numerosAlunos[i])
                {
                    Console.WriteLine(
                        String.Format(
                        "\nTurma: {0}",
                        numerosAlunos
                        )
                        );
                    achou = true;
                    break;

                }
            }
            if (!achou)
            {
                Console.WriteLine("Aluno não encontrao");
            }

        }
    }
}
