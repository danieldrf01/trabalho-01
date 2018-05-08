using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace trabalho_01
{
    class SistemaNota
    {
        Notas notas = new Notas();
        public void SistemaNota()
        {
            GerirMenu();
        }
        public void Sistema()
        {
            Console.Clear();
            Console.WriteLine("1 - Cadastar Nota:\n2 - Listar Nota\n3 - Editar Nota\n4 - Buscar Nota\n5 - Sair");
        }
        public void GerirMenu()
        {
            GerirMenu();
            int menuEscolha = Convert.ToInt32(Console.ReadLine());
            
            while(menuEscolha != 5)
            {
                switch (menuEscolha)
                {
                    case 1:
                        notas.CadastrarNotas();
                        break;

                    case 2:
                        notas.ListarNotas();
                        break;

                    case 3:
                        notas.EditarNota();
                        break;

                    case 4:
                        notas.BuscarNota();
                        break;

                }
            }

            GerirMenu();
            menuEscolha = Convert.ToInt32(Console.ReadLine());

        }

    }
}
