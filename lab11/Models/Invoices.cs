namespace lab11.Models
{
    public class Invoices
    {
        public int InvoicesID { get; set; }
        public Customers Customer { get; set; }
        public int CustomerID { get; set; }
        public DateTime Date { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal Total { get; set; }
    }
}
