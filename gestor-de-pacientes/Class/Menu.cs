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

            string nome;
            int idade;
            string risco;
            string telefone;
            string email;
            char preferencial;


            int posicaoArray = 0;

            Console.WriteLine("Gestor de fila de pacientes");
            do
            {
                Console.WriteLine("Digite uma opção!");
                Console.WriteLine("1 --- Cadastrar um paciente");
                Console.WriteLine("2 --- Listar a fila de prioridade");
                Console.WriteLine("3 --- Atender um paciente");

                opcao = char.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case '1':
                        Paciente paciente = new Paciente();

                        Console.WriteLine("Nome:");
                        paciente.Nome = Console.ReadLine();

                        Console.WriteLine("Idade:");
                        paciente.Idade = int.Parse(Console.ReadLine());

                        Console.WriteLine("Risco:");
                        paciente.Risco = Console.ReadLine();

                        Console.WriteLine("Telefone:");
                        paciente.Telefone = Console.ReadLine();

                        Console.WriteLine("email:");
                        paciente.Email = Console.ReadLine();

                        Console.WriteLine("Esse paciente é preferencial?");
                        Console.WriteLine("Digite S ou N");
                        preferencial = char.Parse(Console.ReadLine().ToUpper());
                        paciente.Preferencial = preferencial;

                        filaPacientes.adicionarPaciente(paciente);
                        posicaoArray++;
                        break;

                    case '2':
                        filaPacientes.listarPacientes();
                        
                        break;

                    case '3':
                        break;
                }

                

            } while (opcao != 'q');



        }

    }
}
