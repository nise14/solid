namespace DependencyInversion;

public class Impresora
{
    public void Imprimir(IImprimible imprimible)
    {
        imprimible.Imprimir();
    }
}