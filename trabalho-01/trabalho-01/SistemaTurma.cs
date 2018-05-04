using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace trabalho_01
{
    class SistemaTurma
    {
        Turmas turmas = new Turmas();
        public SistemaTurma()
        {
            GerirMenu();
        }
        // Apresentar o menu para o usuario
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Cadastrar Turma\n2 - Editar Turma\n3 - Listar Turma\n4 - Buscar Turma\n5 - Sair");
        }
       public void GerirMenu()
        {
            /*
            *  Chama método para apresentar o menu para o usuario
            */
            Menu();
            int menuEscolha = Convert.ToInt32(Console.ReadLine());
            while (menuEscolha != 20)
            {
                switch (menuEscolha)
                {
                    case 1:
                        turmas.CadastrarTurmas();
                        break;

                    case 2:
                        turmas.ListarTurmas();
                        break;

                    case 3:
                        turmas.EditarTurmas();
                        break;
                    case 4:
                        turmas.BuscarTurmas();
                        break;
                }

                Menu();

                menuEscolha = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
