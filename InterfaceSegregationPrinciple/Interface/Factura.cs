namespace Interface;

public class Factura : Documento
{
    public string? CAI { get; set; }

    public Factura(int numero, DateTime fecha) : base(numero, fecha) { }

    public override void Imprimir()
    {
        Console.WriteLine($"Imprimiendo por email la factura {Numero} del día {Fecha.ToShortDateString()}");
    }
}