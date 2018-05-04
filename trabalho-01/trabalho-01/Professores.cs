using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_01
{
    class Professores
    {
        string[] nome = new string[20];
        string[] materiaAula = new string[20];
        string[] localAula = new string[20];
        int[] idade = new int[20];
        int atual = 0;

        public void CadastrarProfessor()
        {
            Console.Write("Nome do professor: ");
            nome[atual] = Console.ReadLine();

            Console.Write("Matéria aplicada: ");
            materiaAula[atual] = Console.ReadLine();

            Console.Write("Local de trabalho: ");
            localAula[atual] = Console.ReadLine();

            Console.Write("Idade: ");
            idade[atual] = Convert.ToInt32(Console.ReadLine());

        }

        public void EditarProfessor()
        {
            Console.Clear();

            Console.WriteLine("Digite um nome de professor para pesquisa: ");
            String professorPesquisado = Console.ReadLine();
            int posicao = -1;

            for(int i = 0; i < atual; i++)
            {
                if (professorPesquisado == nome[i] ) 
                {
                    posicao = i;
                }

            }

            if (posicao != -1) 
            {
                Console.Write("\nNome do professor: ");
                nome[posicao] = Console.ReadLine();

                

            }
        }

        }
            
    }
}
