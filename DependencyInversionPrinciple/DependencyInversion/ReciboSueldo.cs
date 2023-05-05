namespace DependencyInversion;

public class ReciboSueldo : IImprimible
{
    public ReciboSueldo(int legajo, double total)
    {
        Legajo = legajo;
        Total = total;
    }

    public int Legajo { get; set; }
    public double Total { get; set; }

    public void Imprimir()
    {
        Console.WriteLine($"Imprimiendo recibo sueldo del legajo {Legajo} por un total de {Total}");
    }
}