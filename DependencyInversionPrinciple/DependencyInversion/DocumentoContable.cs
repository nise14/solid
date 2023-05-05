namespace DependencyInversion;

public abstract class DocumentoContable: IImprimible
{
    protected string _sigla = string.Empty;

    public DateTime Fecha { get; set; }
    public double Importe { get; set; }
    public int Numero { get; set; }
    public abstract double Total();

    public abstract void Imprimir();

    public DocumentoContable(int numero, DateTime fecha, double importe)
    {
        Numero = numero;
        Fecha = fecha;
        Importe = importe;
    }
}