using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airton_de_Oliveira_PB_AT_17
{
    internal class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }

        public List<Turma> Turmas = new List<Turma>();

        public Aluno(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
        }

        public String AddTurma(Turma turma)
        {
            Turmas.Add(turma);

            return "Turma adicionada no aluno";

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
            Console.WriteLine($"Alocação do aluno: {Nome}:");
            foreach (Turma turma in Turmas)
            {
                Console.WriteLine($"{turma.Disciplina.Nome}");
            }
        }

        public override string ToString()
        {
            return $"Matricula: {Matricula}\nNome: {Nome}\n";
        }
    }
}
