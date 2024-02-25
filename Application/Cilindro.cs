namespace Application;

public class Cilindro
{
    public static double Volumen (double radio, double altura)
    {
        double volumen = 3.1415*radio*radio*altura;
        return volumen;
    }
}