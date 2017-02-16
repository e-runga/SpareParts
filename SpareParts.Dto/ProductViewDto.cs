namespace SpareParts.Dto
{
    public class ProductViewDto
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal SellPrice { get; set; }

        public decimal BuyingPrice { get; set; }

        public string Brand { get; set; }

        public int Status { get; set; }

        public string StatusName { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Model { get; set; }

        public string Category { get; set; }

        public string ProductType { get; set; }

        public string Item { get; set; }

        public string VIN { get; set; }

        public string Years { get; set; }

        public bool Sold { get; set; }

        public bool HasOrder { get; set; }

        public bool IsReimbursed { get; set; }

        public bool IsReplace { get; set; }

        public bool IsReturn { get; set; }

        public string DisplayName { get; set; }
    }
}