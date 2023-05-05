namespace DependencyInversion;

public class FacturaLuz : Impuesto
{
    public FacturaLuz(double importe, string codigoPago) : base(importe)
    {
        CodigoPago = codigoPago;
    }

    public string CodigoPago { get; set; }

    public override void Imprimir()
    {
        Console.WriteLine($"Imprimiendo factura de luz con codigo de pago numero {CodigoPago} por un importe de {Importe}");
    }
}