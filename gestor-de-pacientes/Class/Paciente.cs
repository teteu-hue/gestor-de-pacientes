using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace gestor_de_pacientes.Class
{
    class Paciente
    {
        static int nextID;
        private int idPaciente;
        private string nome;
        private int idade;
        private string risco;
        private string telefone;
        private string email;
        private char preferencial;

        public Paciente() 
        { 
            this.idPaciente = Interlocked.Increment(ref nextID);
        }

        public Paciente(string nome)
        {
            this.nome = nome;
            this.idPaciente = Interlocked.Increment(ref nextID);
        }

        public Paciente(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
            this.idPaciente = Interlocked.Increment(ref nextID);
        }

        public Paciente(string nome, int idade, string risco)
        {
            this.nome = nome;
            this.idade = idade;
            this.risco = risco;
            this.idPaciente = Interlocked.Increment(ref nextID);
        }

        public Paciente(string nome, int idade, string risco, string telefone)
        {
            this.nome = nome;
            this.idade = idade;
            this.risco = risco;
            this.telefone = telefone;
            this.idPaciente = Interlocked.Increment(ref nextID);
        }

        public Paciente(string nome, int idade, string risco, string telefone, string email)
        {
            this.nome = nome;
            this.idade = idade;
            this.risco = risco;
            this.telefone = telefone;
            this.email = email;
            this.idPaciente = Interlocked.Increment(ref nextID);
        }

        public Paciente(string nome, int idade, string risco, string telefone, string email, char preferencial)
        {
            this.nome = nome;
            this.idade = idade;
            this.risco = risco;
            this.telefone = telefone;
            this.email = email;
            this.preferencial = preferencial;
            this.idPaciente = Interlocked.Increment(ref nextID);
        }

        public int IdPaciente
        {
            get
            {
                return this.idPaciente;
            }

            set
            {
                this.idPaciente = value;
            }
        }
        public string Nome
        { 
            get 
            { 
                return this.nome; 
            } 
            set 
            {  
                this.nome = value; 
            }
        }

        public int Idade
        {
            get 
            {
                return this.idade;
            }

            set 
            {
                this.idade = value;
            }
        }

        public string Risco
        {
            get
            {
                return this.risco;
            }

            set
            {
                risco = value;
            }
        }

        public string Telefone
        {
            get
            {
                return this.telefone;
            }

            set
            {
                if(value.Length > 10)
                {

                }
                this.telefone = value;
            }
        }

        public string Email
        {
            get 
            {
                return this.email;
            }

            set
            {
                this.email = value;
            }
        }

        public char Preferencial
        {
            get
            {
                return this.preferencial;
            }

            set
            {
                
                while (this.preferencial != 'S' && this.preferencial != 'N')
                {
                    Console.WriteLine("Digite novamente S ou N");
                    this.preferencial = char.Parse(Console.ReadLine().ToUpper());
                }
            }
        }

        public void mostrarDados()
        {
            Console.WriteLine("\n");
            Console.WriteLine($"ID Paciente: {this.idPaciente}");
            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"Idade: {this.idade}");
            Console.WriteLine($"Risco: {this.risco}");
            Console.WriteLine($"Telefone: {this.telefone}");
            Console.WriteLine($"Email: {this.email}");
            Console.WriteLine("\n");
        }

    }
}
