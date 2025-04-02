public class Diretoria
{
    public Professor Diretor { get; set; }

    public void ExibirDiretor()
    {
        Console.WriteLine($"Nome do Diretor: {Diretor.Nome}");
    }
}