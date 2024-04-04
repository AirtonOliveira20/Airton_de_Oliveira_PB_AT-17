namespace Airton_de_Oliveira_PB_AT_17
{
    internal class Program
    {

        static List<Turma> Turmas = new List<Turma>();
        static List<Aluno> Alunos = new List<Aluno>();
        static List<Professor> Professores = new List<Professor>();
        static List<Disciplina> Disciplinas = new List<Disciplina>();
        static void Main(string[] args)
        {

            CriarAluno();
            CriarDisciplina();
            CriarProfessor();
            CriarTurma();

            AdicionarAluno();
            AlocacaoDeTurmas();
            GerarPauta();
            AlocacaoDoAluno();
            AlocacaoDoProfessor();
            AlocacaoDaDisciplina();


        }

        public static void CriarAluno()
        {
            Alunos.Add(new Aluno(1, "Aluno 1"));
            Alunos.Add(new Aluno(2, "Aluno 2"));
            Alunos.Add(new Aluno(3, "Aluno 3"));
            Alunos.Add(new Aluno(4, "Aluno 4"));



        }

        public static void CriarTurma()
        {
            Turmas.Add(new Turma(1));
            Turmas[0].AddProfessor(Professores[0]);
            Turmas[0].AddDisciplina(Disciplinas[0]);


            Turmas.Add(new Turma(2));
            Turmas[1].AddProfessor(Professores[1]);
            Turmas[1].AddDisciplina(Disciplinas[1]);

            Turmas.Add(new Turma(3));
            Turmas[2].AddProfessor(Professores[1]);
            Turmas[2].AddDisciplina(Disciplinas[2]);


        }

        public static void CriarProfessor()
        {
            Professores.Add(new Professor(1, "João"));
            Professores.Add(new Professor(2, "José"));
        }

        public static void CriarDisciplina()
        {
            Disciplinas.Add(new Disciplina(1, "Java"));
            Disciplinas.Add(new Disciplina(2, ".Net"));
            Disciplinas.Add(new Disciplina(3, "PB"));

        }

        public static void AdicionarAluno()
        {
            Turmas[0].AddAluno(Alunos[0]);
            Turmas[0].AddAluno(Alunos[1]);
            Turmas[0].AddAluno(Alunos[2]);
            Turmas[0].AddAluno(Alunos[3]);
            Turmas[1].AddAluno(Alunos[0]);


            /*  Console.WriteLine(Turmas[0].AddAluno(Alunos[0]));
              Console.WriteLine(Turmas[0].AddAluno(Alunos[1]));
              Console.WriteLine(Turmas[0].AddAluno(Alunos[2]));
              Console.WriteLine(Turmas[0].AddAluno(Alunos[3]));*/

        }

        public static void AbrirTurma()
        {
            Console.WriteLine($"Turma 1: {Turmas[0].AbrirTurma()}");
            Console.WriteLine($"Turma 2: {Turmas[1].AbrirTurma()}");
            Console.WriteLine($"Turma 3: {Turmas[2].AbrirTurma()}");

        }

        public static void GerarPauta()
        {
            Console.WriteLine(Turmas[0].GerarPauta());

        }

        public static void AlocacaoDeTurmas()
        {
            foreach(var aux in Turmas)
            {
                Console.WriteLine("Alocação de Turmas");
                Console.WriteLine(aux.ToString());
            }
        }

        public static void AlocacaoDoAluno()
        {

            Alunos[0].MostrarDisciplinasAlocado();
        }

        public static void AlocacaoDoProfessor()
        {

            Professores[1].MostrarDisciplinasAlocado();
        }

        public static void AlocacaoDaDisciplina()
        {

            Disciplinas[1].MostrarDisciplinasAlocado();
        }




    }


}
