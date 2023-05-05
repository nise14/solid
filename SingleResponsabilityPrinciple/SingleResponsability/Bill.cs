namespace SingleResponsability
{
    public class Bill
    {
        public Bill(int number, Customer customer)
        {
            Number = number;
            Customer = customer;
            Items = new List<Item>();
        }

        public int Number { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
        public List<Item> Items { get; set; }

        public double Total()
        {
            double total = 0;

            foreach (var item in Items)
            {
                total += item.Subtotal();
            }

            return total;
        }
    }
}