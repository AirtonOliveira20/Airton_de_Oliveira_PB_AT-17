using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airton_de_Oliveira_PB_AT_17
{
    internal class Disciplina
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Turma Turma { get; set; }

        public Disciplina(int codigo, string nome)
        {
            this.Codigo = codigo;
            this.Nome = nome;

        }

        public void AddTurma(Turma turma)
        {
            Turma = turma;

        }

        public string ExibirTurmas()
        {
            return Turma.ToString();
        }

        public void MostrarDisciplinasAlocado()
        {
            Console.WriteLine($"Alocação da disciplina: {Nome}:");
                      
            Console.WriteLine($"{Turma.Professor.Nome}");
            
        }

        public override string ToString()
        {
            return $"Código da disciplina: {Codigo}\nNome da disciplina: {Nome}\n";
        }
    }
}