namespace OpenClosed;

public class Factura : DocumentoContable
{
    public Factura(int numero) : base(numero) { }

    public override string Descripcion()
    {
        return $"FC-{Numero}";
    }
}