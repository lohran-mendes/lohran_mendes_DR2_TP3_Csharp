namespace lohran_mendes_DR2_TP3;

public class Esfera
{
    private double raio;

    public double CalcularVolume()
    {
        return ((4.0 / 3.0) * Math.PI * (raio * raio * raio));
    }

    public static void Exercicio_12()
    {
        Console.WriteLine("\nExercício 12 (esfera)");
        Esfera esfera = new();
        esfera.raio = 5.0;
        Console.WriteLine("Volume calculado da esfera: ");
        Console.WriteLine(esfera.CalcularVolume());
    }
}