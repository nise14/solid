using Interface;

Factura factura = new Factura(12345, DateTime.Now);
factura.CAI = "23456";

FacturaElectronica facturaElectronica = new FacturaElectronica(12344, DateTime.Now);
facturaElectronica.CAE = "4324234";

facturaElectronica.Imprimir();
facturaElectronica.EnviarPorEmail();

factura.Imprimir();

Console.ReadKey();