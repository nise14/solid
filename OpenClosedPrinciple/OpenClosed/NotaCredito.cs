namespace OpenClosed;

public class NotaCredito : DocumentoContable
{
    public NotaCredito(int numero) : base(numero) { }

    public override string Descripcion()
    {
        return $"NC-{Numero}";
    }
}