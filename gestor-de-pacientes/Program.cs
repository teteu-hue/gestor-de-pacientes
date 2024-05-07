using gestor_de_pacientes.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace gestor_de_pacientes
{
    class Cadastro 
    {
        static void Main(string[] args)
        {
            Paciente[] pacientes = new Paciente[10];
            char opcao = 'a';

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
                Console.WriteLine("2 --- Excluir um paciente");
                Console.WriteLine("3 --- Listar a fila de prioridade");
                Console.WriteLine("4 --- Atender um paciente");

                opcao = char.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case '1':
                        Paciente paciente = new Paciente();

                        Console.WriteLine("Nome:");
                        nome = Console.ReadLine();

                        Console.WriteLine("Idade:");
                        idade = int.Parse(Console.ReadLine());

                        Console.WriteLine("Risco:");
                        risco = Console.ReadLine();

                        Console.WriteLine("Telefone:");
                        telefone = Console.ReadLine();

                        Console.WriteLine("email:");
                        email = Console.ReadLine();

                        Console.WriteLine("Esse paciente é preferencial?");
                        Console.WriteLine("Digite S ou N");
                        preferencial = char.Parse(Console.ReadLine().ToUpper());

                        paciente.Preferencial = preferencial;

                        //Paciente paciente = new Paciente(nome, idade, risco, telefone, email, preferencial);
                        pacientes[posicaoArray] = paciente;
                        break;

                    case '2':
                        pacientes[posicaoArray].mostrarDados();
                        break;

                    case '3':
                        for (int i = 0; i < pacientes.Length; i++)
                        {
                            Console.Write("ID do Paciente: " + pacientes[i].IdPaciente + " ");
                            pacientes[i].mostrarDados();
                            Console.WriteLine("--------------------------------------");
                            if (pacientes[i] == null)
                            {

                            }
                        }
                        break;
                }

                posicaoArray++;

            } while (opcao != 'q');

            pacientes[0].mostrarDados();

            Console.ReadKey();


        }
    }
}
