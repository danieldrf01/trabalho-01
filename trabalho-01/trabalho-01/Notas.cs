using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_01
{
    class Notas
    {
        string[] materia = new string[13];
        double[] nota = new double[13];

        int atual = 0;


        public void CadastrarNotas()
        {
            Console.Write("Digite a Matéria: ");
            materia[atual] = Console.ReadLine();

            Console.Write("\nDigite a Nota: ");
            nota[atual] = Convert.ToDouble(Console.ReadLine());


        }

        public void ListarNotas()
        {
            Console.Clear();

            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(
                   String.Format(
                   "\nMatéria: {0} \nNota: {1} ",
                   materia[i], nota[i]

                   )

                   );
            }
        }
        public void EditarNota()
        {
            Console.Clear();

            Console.Write("\nDigite uma matéria para pesquisa: ");
            String materiaPesquisada = Console.ReadLine();
            int posicao = -1;

            for (int i = 0; i < atual; i++)
            {
                if (materia[i] == materiaPesquisada)
                {
                    posicao = i;

                }
            }

            if (posicao != -1)
            {
                Console.Write("Digite a Matéria: ");
                materia[posicao] = Console.ReadLine();
                Console.Write("\nDigite a Nota: ");
                nota[posicao] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dados alterados com sucesso ");
            }

            else
            {
                Console.WriteLine("Registro não encontrado");
            }

        }

        public void BuscarNota()
        {
            Console.Clear();

            Console.Write("Digite a matéria para busca: ");
            string materiaPesquisada = Console.ReadLine();

            for (int i = 0; i < atual; i++)
            {
                if (materiaPesquisada == materia[i])
                {
                    Console.WriteLine(
                        String.Format(
                        "\nMatéria: {0} \nNota: {1}",
                        materia[i], nota[i]
                        )
                        );
                    break;
                    }
                      
                        
                   
            }
        }
    }
}
