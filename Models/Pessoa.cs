public class Pessoa
{
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public void ExibirInfo()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
    }
}