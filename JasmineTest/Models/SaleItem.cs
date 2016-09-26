namespace JasmineTest.Models
{
    public class SaleItem
    {
        public int SaleItemId { get; set; }

        public string Title { get; set; }

        public int Quantity { get; set; }

        public double CostPerItem { get; set; }

        public int SaleHeaderId { get; set; }

        public virtual SaleHeader SaleHeader { get; set; }
    }
}