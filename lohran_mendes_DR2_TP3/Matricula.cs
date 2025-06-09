namespace lohran_mendes_DR2_TP3;

public class Matricula
{
    string NomeDoAluno;
    string Curso;
    int NumeroMatricula;
    string Situacao;
    string DataInicial;

    public void Trancar()
    {
        Situacao = "Trancada";
    }

    public void Reativar()
    {
        Situacao = "Ativa";
    }

    public string ExibirInformacoes()
    {
        return $"O aluno {NomeDoAluno} do curso {Curso} iniciou a formação em {DataInicial} e está com a matricula {Situacao}.";
    }

    public static void Exercicio_9()
    {
        Console.WriteLine("\nExercício 9:");
        Matricula matricula = new Matricula();
        matricula.NomeDoAluno = "Lohran Mendes";
        matricula.Curso = "Engenharia de Software";
        matricula.DataInicial = "01/09/2024";
        matricula.Trancar();
        matricula.NumeroMatricula = 12345678;
        Console.WriteLine("Informações do aluno antes das alterações:");
        Console.WriteLine(matricula.ExibirInformacoes());
        matricula.Reativar();
        Console.WriteLine("Informações do aluno depoiss das alterações:");
        Console.WriteLine(matricula.ExibirInformacoes());
        
    }
}