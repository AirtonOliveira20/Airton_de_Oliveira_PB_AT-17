using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airton_de_Oliveira_PB_AT_17
{
    internal class Turma
    {
        public int Codigo { get; set; }

        public Disciplina Disciplina { get; set; }

        public Professor Professor { get; set; }

        public List<Aluno> Alunos = new List<Aluno>();

        public Turma(int Codigo, Disciplina Disciplina, Professor professor)
        {
            this.Codigo = Codigo;
            this.Disciplina = Disciplina;
            Professor = professor;
            
        }

        public Turma(int Codigo)
        {
            this.Codigo = Codigo;
        }



        public string AddAluno(Aluno aluno)
        {
            if (Alunos.Count < 10)
            {
                Alunos.Add(aluno);
                aluno.AddTurma(this);

                return "Aluno adicionado";

            }
            else
            {
                return "Turma cheia";
            }

        }



        public Boolean AbrirTurma()
        {
            int numeroAlunos = Alunos.Count;
            if (numeroAlunos >= 2 && numeroAlunos <= 10)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public string GerarPauta()
        {
            if (AbrirTurma() == true)
            {
                string pauta = $"\nPauta da turma: {Codigo}\n";
                pauta += $"Disciplina: {Disciplina.Nome}\n";
                pauta += $"Professor: {Professor.Nome}\n";


                pauta += ("Lista de alunos:\n");
                foreach (var aluno in Alunos)
                {
                    pauta += $"{aluno.Nome}\n";
                }

                return pauta;

            }
            else
            {
                return "Nenhuma turma aberta";
            }


        }

        public void AddProfessor(Professor professor)
        {
            Professor = professor;
            professor.AddTurma(this);
        }

        public void AddDisciplina(Disciplina disciplina)
        {
            Disciplina = disciplina;
            disciplina.AddTurma(this);

        }

        public override string ToString()
        {
            return $"\nTurma: {Codigo}\nDisciplina: {Disciplina.Nome} Professor: {Professor.Nome}";
        }

        public Disciplina getDisciplina()
        {
            return this.Disciplina;
        }

    }


}

