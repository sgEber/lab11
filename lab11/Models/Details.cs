namespace lab11.Models
{
    public class Details
    {
        public int DetailID { get; set; }
        public decimal Amount { get; set; }
        public decimal subtotal { get; set; }
        public Products Product { get; set; }
        public int ProductID { get; set; }
        public Invoices Invoice { get; set; }
        public int InvoiceID { get; set; }
    }
}
