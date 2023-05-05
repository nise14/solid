namespace Liskov;

public class Remito
{
    public int CantBultos { get; set; }
    public int Numero { get; set; }
    public DateTime Fecha { get; set; }

    public Remito(int numero, DateTime fecha, int bultos)
    {
        CantBultos = bultos;
        Numero = numero;
        Fecha = fecha;
    }

    public string Descripcion()
    {
        return $"Remito nro {Numero} de fecha {Fecha.ToShortDateString()} con {CantBultos}";
    }

    public string Imprimir() => $"Imprimiendo {Descripcion()}";
}