public class Escola
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    private List<Turma> Turmas = new List<Turma>();
    public Diretoria Diretoria { get; set; }

    public void AdicionarTurma(Turma turma)
    {
        Turmas.Add(turma);
    }

    public void ExibirInfo()
    {
        Console.WriteLine($"Escola: {Nome}, Endereço: {Endereco}");
    }

    public void ListarTurmas()
    {
        Console.WriteLine("Turmas:");
        foreach (var turma in Turmas)
            Console.WriteLine($"{turma.Nome}:");

    }
}
