using SingleResponsability;

Customer customer = new Customer();
customer.LastName = "Cruz";
customer.Name = "Nicks";

Bill bill = new Bill(1235,customer);

Item item1 = new Item(new Product("Arroz",10),1);
Item item2 = new Item(new Product("Queso",90),21);

bill.Items.Add(item1);
bill.Items.Add(item2);

Console.WriteLine(bill.Total());

Console.ReadKey();