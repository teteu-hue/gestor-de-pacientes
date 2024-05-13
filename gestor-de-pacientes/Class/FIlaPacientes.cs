using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace gestor_de_pacientes.Class
{
     class FilaPacientes
    {
        private Paciente[] pacientes = new Paciente[10];

        public Paciente[] Pacientes
        {
            get
            {
                return this.pacientes;
            }
        }

        public void showAllPacientes()
        {

            for(int i = 0; i < this.pacientes.Length; i++)
            {
                if (this.pacientes[i] == null)
                {
                    Console.WriteLine("Acabou a fila de pacientes!\n");
                    return;
                }
                this.pacientes[i].mostrarDados();
            }
        }

        public void addPaciente(Paciente paciente)
        {
            for(int i = 0; i < this.pacientes.Length; i++)
            {
                // Caso eu tenha um paciente que seja preferêncial qual a lógica?
                // 1 - Verificar se o paciente na fila é preferencial
                // 1.1 CASO SIM - VERIFICAR se o paciente que está entrando é preferencial
                // 1.1.2 - CASO SIM - Inserir o paciente numa posição antes de um paciente comum
             
                if (this.pacientes[i] == null)
                {
                    this.pacientes[i] = paciente;
                    return;
                }    
                
                if (this.pacientes[i].Preferencial == 'N' && this.pacientes[i] != null)
                {
                     if(paciente.Preferencial == 'S')
                     {
                        Paciente temp = this.pacientes[i];
                        this.pacientes[i] = paciente;
                        this.pacientes[i + 1] = temp;
                        return;
                    }
                } 
                    
            }
        }

        public void deletePaciente(int id_paciente)
        {
            Paciente paciente = this.getPaciente(id_paciente);

            Console.WriteLine("O próximo paciente a ser atendido é: ");
            paciente.mostrarDados();
            Console.WriteLine("Confirma o atendimento? S ou N?");
            char option = char.Parse(Console.ReadLine().ToUpper());

            while (option != 'S' && option != 'N')
            {
                Console.WriteLine("Digite um caractere válido!");
                option = char.Parse(Console.ReadLine().ToUpper());
            }

            if (paciente.IdPaciente == id_paciente)
            {
                this.pacientes[0] = null;
                Console.WriteLine("Excluído com sucesso!");
            }
            
        }

        public Paciente getPaciente(int id_paciente)
        {
            for (int i = 0; i < pacientes.Length; i++)
            {
                if (this.pacientes[i].IdPaciente == id_paciente)
                {
                    return this.pacientes[i];
                }
            }
            return null;
        }

    }
}
