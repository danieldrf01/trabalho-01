using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace trabalho_01
{
    class SistemaAluno
    {
        Alunos alunos = new Alunos();
        public void SistemaAluno()
        {
            GerirMenu();
        }
        // Apresentar o menu para o usuario
        public void Sistema()
        {
            Console.Clear();
            Console.WriteLine("1 - Cadastrar Turma\n2 - Editar Turma\n3 - Listar Turma\n4 - Buscar Turma\n5 - Sair");
        }
        public void GerirMenu()
        {
            GerirMenu();
            int menuEscolha = Convert.ToInt32(Console.ReadLine());
            while (menuEscolha != 20)
            {
                switch (menuEscolha)
                {
                    case 1:
                        alunos.CadastrarAluno();
                        break;

                    case 2:
                        alunos.ListarAlunos();
                        break;

                    case 3:
                        alunos.EditarAlunos();
                        break;
                    case 4:
                        alunos.BuscarAlunos();
                        break;
                }
            }

            GerirMenu();

            menuEscolha = Convert.ToInt32(Console.ReadLine());
        }
    }
}