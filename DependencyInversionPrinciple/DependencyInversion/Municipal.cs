namespace DependencyInversion;

public class Municipal : Impuesto
{
    public Municipal(double importe, string partida) : base(importe)
    {
        Partida = partida;
    }

    public string Partida { get; set; }

    public override void Imprimir()
    {
        Console.WriteLine($"Imprimiendo impuesto Municipal de partida numero {Partida} por un importe de {Importe}");
    }
}