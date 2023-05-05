using System;

namespace Liskov;

public abstract class DocumentoContable
{
    protected string? _sigla;

    public DocumentoContable(int numero, DateTime fecha)
    {
        Numero = numero;
        Fecha = fecha;
    }

    public DateTime Fecha { get; set; }
    public int Numero { get; set; }

    public string Imprimir() =>
        $"Imprimiendo {Descripcion()}";

    public virtual string Descripcion() =>
        $"{_sigla} nro {Numero} de fecha {Fecha.ToShortDateString()}";
}