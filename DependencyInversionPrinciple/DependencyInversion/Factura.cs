namespace DependencyInversion;

public class Factura : DocumentoContable
{
    public Factura(int numero, DateTime fecha, double importe) : base(numero, fecha, importe)
    {
        _sigla = "FC";
    }

    public override void Imprimir()
    {
        Console.WriteLine($"Imprimiendo factura {Numero} del {Fecha} por un importe de {Importe}");
    }

    public override double Total()
    {
        return Importe * 1.21;
    }
}