public class Turma
{
    public string Nome { get; set; }
    private List<Aluno> Alunos = new List<Aluno>();
    private List<Professor> Professores = new List<Professor>();

    public void AdicionarAluno(Aluno aluno)
    {
        Alunos.Add(aluno);
    }

    public void AdicionarProfessor(Professor professor)
    {
        Professores.Add(professor);
    }

    public void ListarAlunos()
    {
        Console.WriteLine($"Alunos da Turma {Nome}:");
        foreach (var aluno in Alunos)
            aluno.ExibirInfo();
    }

    public void ListarProfessores()
    {
        Console.WriteLine($"Professores da Turma {Nome}:");
        foreach (var professor in Professores)
            professor.ExibirInfo();
    }
}
