using DependencyInversion;

Impresora impresora = new Impresora();

IImprimible factura = new Factura(1234, DateTime.Now, 303);
IImprimible notaCredito = new NotaCredito(344, DateTime.Now, 400);
IImprimible remito = new Remito(551, DateTime.Now, 5);
IImprimible facturaLuz = new FacturaLuz(441, "432423");
Municipal municipal = new Municipal(4324, "65743");

impresora.Imprimir(factura);
impresora.Imprimir(notaCredito);
impresora.Imprimir(remito);
impresora.Imprimir(facturaLuz);
impresora.Imprimir(municipal);

Console.ReadKey();