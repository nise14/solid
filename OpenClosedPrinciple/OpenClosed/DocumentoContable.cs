using System;

namespace OpenClosed;

public abstract class DocumentoContable
{
    public DocumentoContable(int numero)
    {
        Numero = numero;
    }

    public DateTime Fecha { get; set; }
    public double Importe { get; set; }
    public int Numero { get; set; }

    public abstract string Descripcion();
}