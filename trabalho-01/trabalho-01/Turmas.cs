using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_01
{
    class Turmas
    {
        int[] numerosTurmas = new int[16];

        int atual = 0;


        public void CadastrarTurmas()
        {
            Console.Write("Digite a Turma: ");
            numerosTurmas[atual] = Convert.ToInt32(Console.ReadLine());
            atual++;
        }

        public void ListarTurmas()
        {
            Console.Clear();

            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(
                    String.Format(
                        "\nTurma: {0}",
                         numerosTurmas[atual]
                         
                         )
                         
                         );
            }
        }
            
         public void EditarTurmas()
        {
            Console.Clear();
            Console.WriteLine("Digite a Turma para Pesquisar: ");
            int turmaPesquisa = Convert.ToInt32(Console.ReadLine());
            int posicao = -1;
            for (int i = 0; i < atual; i++)
            {
                if (turmaPesquisa == numerosTurmas[i])
                {
                    posicao = 1;
                }
            }

            if (posicao != -1)
            {
                // encontrou o registro procurado
                Console.Write("Número da Turma: ");
                numerosTurmas[posicao] = Convert.ToInt32(Console.ReadLine());
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
                int buscarTurma = Convert.ToInt32(Console.ReadLine());
                bool achou = false;

                for (int i = 0; i < atual; i++)
			    {
			        if (buscarTurma == numerosTurmas[i])
                    {
                        Console.WriteLine(
                            String.Format(
                            "\nTurma: {0}", 
                            numerosTurmas
                            )
                            );
                            achou = true;
                            break;

                    }
			    }
                if (!achou)
	            {
                   Console.WriteLine("Turma não encontrao");
                }

            }
    }
}

