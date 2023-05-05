namespace OpenClosed;

public class NotaDebito : DocumentoContable
{
    public NotaDebito(int numero) : base(numero) { }

    public override string Descripcion()
    {
        return $"ND-{Numero}";
    }
}