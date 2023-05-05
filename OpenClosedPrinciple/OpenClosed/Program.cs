using OpenClosed;

var unaFactura = new Factura(10);
Console.WriteLine(unaFactura.Descripcion());

var otraFactura = new NotaCredito(1230);
Console.WriteLine(otraFactura.Descripcion());

var otraFactura2 = new NotaDebito(1230);
Console.WriteLine(otraFactura2.Descripcion());