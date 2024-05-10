using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace gestor_de_pacientes.Class
{
    class Menu
    {

        public Menu()
        {
            FilaPacientes filaPacientes = new FilaPacientes();
            Paciente[] pacientes = filaPacientes.Pacientes;

            char opcao;

            Console.WriteLine("Gestor de fila de pacientes");
            do
            {
                Console.WriteLine("Digite uma opção!");
                Console.WriteLine("1 --- Cadastrar um paciente");
                Console.WriteLine("2 --- Listar a fila de prioridade");
                Console.WriteLine("3 --- Atender um paciente");
                Console.WriteLine("q --- Sair do atendimento de pacientes");

                opcao = char.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case '1':
                        Paciente paciente = Paciente.cadastraPaciente();
                        filaPacientes.addPaciente(paciente);
                        break;

                    case '2':
                        filaPacientes.showAllPacientes();
                        
                        break;

                    case '3':
                        break;

                    default:
                        Console.WriteLine("Opção incorreta, digite uma opção válida!");
                        break;
                }

                

            } while (opcao != 'q');



        }

    }
}
