using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airton_de_Oliveira_PB_AT_17
{
    internal class Professor
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }

        public List<Turma> Turmas = new List<Turma>();
        public Professor(int matricula, string nome)
        {
            this.Matricula = matricula;
            this.Nome = nome;

        }

        public void AddTurma(Turma turma)
        {
            Turmas.Add(turma);

        }

        public string ExibirTurmas()
        {
            StringBuilder resposta = new StringBuilder();

            foreach (Turma aux in Turmas)
            {
                resposta.Append(aux.ToString());

            }
            return $"{resposta.ToString()}";
        }

        public void MostrarDisciplinasAlocado()
        {
            Console.WriteLine($"Alocação do Professor: {Nome}:");
            foreach (Turma turma in Turmas)
            {
                Console.WriteLine($"{turma.Disciplina.Nome}");
            }
        }


    }
}
