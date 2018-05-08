using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_01
{
    class SistemaProfessor
    {
        Professores professores = new Professores();
        public void SistemaProfessores()
        {
            GerirMenu();
        }
        public void Sistema()
        {
            Console.Clear();
            Console.WriteLine("1 - Cadastrar Professor:\n2 - Listar Professor\n3 - Editar Professor\n4 - Buscar Professor\n5 - Sair");
        }
        public void GerirMenu()
        {
            GerirMenu();
            int menuEscolha = Convert.ToInt32(Console.ReadLine());

            while (menuEscolha != 5)
            {
                switch (menuEscolha)
                {
                    case 1:
                        professores.CadastrarProfessor();
                        break;

                    case 2:
                        professores.ListarProfessor();
                        break;

                    case 3:
                        professores.EditarProfessor();
                        break;

                    case 4:
                        professores.BuscarProfessor();
                        break;

                }
            }

            GerirMenu();
            menuEscolha = Convert.ToInt32(Console.ReadLine());
            
        }
    }
}
