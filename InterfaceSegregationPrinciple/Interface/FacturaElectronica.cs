namespace Interface;

public class FacturaElectronica : Documento, IEmaileable
{
    public FacturaElectronica(int numero, DateTime fecha):base(numero, fecha){}
    public string? CAE{get;set;}

    public void EnviarPorEmail()
    {
        Console.WriteLine($"Enviando por email la factura electrónica {Numero} del día {Fecha.ToShortDateString()}");
    }

    public override void Imprimir()
    {
        Console.WriteLine($"Imprimiendo la factura electrónica {Numero} del día {Fecha.ToShortDateString()}");
    }
}