namespace DependencyInversion;

public class NotaCredito : DocumentoContable
{
    public NotaCredito(int numero, DateTime fecha, double importe) : base(numero, fecha, importe)
    {
        _sigla = "NC";
    }

    public override void Imprimir()
    {
        Console.WriteLine($"Imprimiendo Nota Crédito {Numero} del {Fecha} por un importe de {Importe}");
    }

    public override double Total()
    {
        return Importe * 1.21 * -1;
    }
}