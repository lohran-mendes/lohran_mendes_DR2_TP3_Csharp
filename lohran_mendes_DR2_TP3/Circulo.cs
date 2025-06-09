namespace lohran_mendes_DR2_TP3;

public class Circulo
{
    private double raio;

    public double CalcularArea()
    {
        return Math.PI * raio * raio;
    }
    public static void Exercicio_12()
    {
        Console.WriteLine("\nExercício 12 (circulo)");
        Circulo circulo = new();
        circulo.raio = 3.0;
        Console.WriteLine("Area calculada do circulo: ");
        Console.WriteLine(circulo.CalcularArea());
    }
}