namespace DependencyInversion;

public abstract class Impuesto: IImprimible
{

    public Impuesto(double importe)
    {
        Importe = importe;
    }

    public double Importe { get; set; }

    public abstract void Imprimir();
}