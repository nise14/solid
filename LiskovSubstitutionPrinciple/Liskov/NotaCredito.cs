namespace Liskov;

public class NotaCredito : DocumentoContable
{
    public NotaCredito(int numero, DateTime fecha) : base(numero, fecha)
    {
        _sigla = "NC";
    }
}