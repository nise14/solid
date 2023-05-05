namespace Liskov;

public class Impresora{
    public void ImprimirRemito(Remito unRemito){
        Console.WriteLine(unRemito.Imprimir());
    }

    public void Imprimir(DocumentoContable unDocumento){
        Console.WriteLine(unDocumento.Imprimir());
    }
}