public class Professor : Pessoa{
    public string Disciplina { get; set; }

    public void Ensinar() {
        Console.Write($"Professor de {Disciplina} está ensinado");
    }

    public string Getdisciplina(){
        return Disciplina;
    }

    public void Setdisciplina(string Disciplina){
        this.Disciplina = Disciplina;
    }

   

}