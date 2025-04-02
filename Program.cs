class Program
{
    static void Main()
    {
        Organiza drop = new Organiza();

        Escola escola = new Escola();
        escola.Nome = "UNASP";
        escola.Endereco = "Rua A, 32232";

        // adciona dados do diretor
        Professor diretor = new Professor();
        diretor.Nome = "Marcello";
        diretor.Idade = 50;
        diretor.Disciplina = "Direção";

        escola.Diretoria = new Diretoria { Diretor = diretor };

        Turma turma1 = new Turma();
        turma1.Nome = "Turma1";
        Turma turma2 = new Turma();
        turma2.Nome = "Turma2";


        Aluno aluno1 = new Aluno(); // aluno 1
        aluno1.Matricula = 1; 
        aluno1.Nome = "Rafael";
        aluno1.Idade = 10;

        Aluno aluno2 = new Aluno(); // aluno 2
        aluno2.Matricula = 2;
        aluno2.Nome = "Duda";
        aluno2.Idade = 69;  // ta véinho né

        Aluno aluno3 = new Aluno(); // aluno 3
        aluno3.Matricula = 3; 
        aluno3.Nome = "Lucas";
        aluno3.Idade = 14;

        Aluno aluno4 = new Aluno();// aluno 4
        aluno2.Matricula = 4;
        aluno2.Nome = "João";
        aluno2.Idade = 12;  
        
        // adiciona aluno a turma1...
        turma1.AdicionarAluno(aluno1);
        turma1.AdicionarAluno(aluno2);
        turma1.AdicionarAluno(aluno3);


        // adiona aluno a turma2...
        turma2.AdicionarAluno(aluno3);
        turma2.AdicionarAluno(aluno4);

        Professor professor1 = new Professor();
        professor1.Nome = "Duda";
        professor1.Idade = 69;
        professor1.Disciplina = "POO";

        Professor professor2 = new Professor();
        professor2.Nome = "Marcos";
        professor2.Idade = 23;
        professor2.Disciplina = "História";
        
        // adiciona professora turma1
        turma1.AdicionarProfessor(professor1);
        turma1.AdicionarProfessor(professor2);

        // adiciona professora turma2
        turma2.AdicionarProfessor(professor2);
        

        // faz a exibição
        escola.AdicionarTurma(turma1);

        escola.ExibirInfo();
        drop.pular();

        escola.ListarTurmas();
        turma1.ListarAlunos();
        drop.pular();
        turma1.ListarProfessores();
        escola.AdicionarTurma(turma2);

        drop.pular();
        drop.pular();
        turma2.ListarAlunos();
        
        drop.pular();
        turma2.ListarProfessores();

        drop.pular();
        escola.Diretoria.ExibirDiretor();
    }
}
