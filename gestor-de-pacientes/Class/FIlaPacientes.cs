using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public void listarPacientes()
        {

            for(int i = 0; i < this.pacientes.Length; i++)
            {
                if (this.pacientes[i] == null)
                {
                    Console.WriteLine("Acabou a fila de pacientes!");
                    return;
                }
                this.pacientes[i].mostrarDados();
            }
        }

        public void adicionarPaciente(Paciente paciente)
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
                    

                /* verifica se a proxima posição na fila é nula, se for insere o paciente nela
                if (this.pacientes[i] == null)
                {
                    this.pacientes[i] = paciente;
                    return;
                }
                */
            }
        }

    }
}
