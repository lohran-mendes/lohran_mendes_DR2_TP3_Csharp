namespace lohran_mendes_DR2_TP3;

public class Ingresso
{
    string NomeDoShow { get; set; } = "";
    double Preco { get; set; }
    int QuantidadeDisponivel { get; set; }

    public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
    {
        NomeDoShow = nomeDoShow;
        Preco = preco;
        QuantidadeDisponivel = quantidadeDisponivel;
    }

    public Ingresso()
    {
    }

    public void AlterarPreco(double novoPreco)
    {
        Preco = novoPreco;
    }

    public void AlterarQuantidade(int novaQuantidade)
    {
        QuantidadeDisponivel = novaQuantidade;
    }

    public string ExibirInformacoes()
    {
        return
            $"O ingresso para {NomeDoShow} está custando R${Preco} e ainda temos {QuantidadeDisponivel} disponíveis.";
    }

    public static void Exercicio_4()
    {
        Console.WriteLine("\nExercicio 4:");
        Ingresso ingresso = new();
        ingresso.NomeDoShow = "Thiaguinho";
        ingresso.Preco = 80.50;
        ingresso.QuantidadeDisponivel = 100;
        Console.WriteLine("Informações do ingresso antes de altera-lo:");
        Console.WriteLine(ingresso.ExibirInformacoes());
        ingresso.AlterarPreco(150);
        ingresso.AlterarQuantidade(70);
        Console.WriteLine("Informações do ingresso depois da alteração:");
        Console.WriteLine(ingresso.ExibirInformacoes());
    }

    public static void Exercicio_5()
    {
        Console.WriteLine("\nExercício 5:");
        Ingresso ingresso = new();
        ingresso.NomeDoShow = "Lady Gaga";
        ingresso.Preco = 200;
        ingresso.QuantidadeDisponivel = 400;
        Console.WriteLine($"Nome do show através do getter: {ingresso.NomeDoShow}");
        Console.WriteLine($"Preço do show através do getter: {ingresso.Preco}");
        Console.WriteLine(
            $"Quantidade disponível de ingressos do show através do getter: {ingresso.QuantidadeDisponivel}");
    }

    public static void Exercicio_6()
    {
        Console.WriteLine("\nExercicio 6:");
        Ingresso ingresso = new("Péricles", 120, 300);
        Console.WriteLine(ingresso.ExibirInformacoes());
    }
}