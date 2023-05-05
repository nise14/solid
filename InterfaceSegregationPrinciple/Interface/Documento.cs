namespace Interface;

public abstract class Documento : IImprimible
{
    public DateTime Fecha { get; set; }
    public int Numero { get; set; }

    public Documento(int numero, DateTime fecha)
    {
        Numero = numero;
        Fecha = fecha;
    }

    public abstract void Imprimir();
}