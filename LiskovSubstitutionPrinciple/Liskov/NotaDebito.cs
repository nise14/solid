namespace Liskov;

public class NotaDebito : DocumentoContable
{
    public NotaDebito(int numero, DateTime fecha) : base(numero, fecha)
    {
        _sigla = "ND";
    }
}