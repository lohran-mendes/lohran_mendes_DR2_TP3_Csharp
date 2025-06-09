namespace lohran_mendes_DR2_TP3;

public class Carro
{
    public string Nome;
    public string Marca;

  public Carro(string nome, string marca)
    {
        Nome = nome;
        Marca = marca;
    }

    private string Buzinar() {
        return "O " + Nome + " da marca " + Marca + " está buzinando!";
    }

    // Exemplo da criação de objeto a partir da classe declarada
    public static void Exercicio_1(){
        Console.WriteLine("\nExercício 1:");
        var carro1 = new Carro("HB20", "Hyundai");
        var carro2 = new Carro("Virtus", "Volkswagen");
        Console.WriteLine(carro1.Buzinar());
        Console.WriteLine(carro2.Buzinar());
    }
}