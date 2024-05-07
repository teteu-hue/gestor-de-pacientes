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
                if (this.pacientes[i] == null)
                {
                    this.pacientes[i] = paciente;
                }
            }
        }

    }
}
