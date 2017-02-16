using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SpareParts.Dto
{
    public class ProductDto : BaseDto
    {
        public string Name { get; set; }

        [Required(ErrorMessage = "Year is required")]
        public int[] YearIds { get; set; }

        [Required(ErrorMessage = "Product Type is required")]
        public ProductTypeDto ProductType { get; set; }

        [Required(ErrorMessage = "Item is required")]
        public ItemDto Item { get; set; }

        public PaperReferenceDto PaperReference { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public CityDto City { get; set; }

        [Required(ErrorMessage = "Stock Location is required")]
        public string StockLocation { get; set; }

        [Required(ErrorMessage = "Customer is required")]
        public CustomerDto Customer { get; set; }

        public OperatorDto Operator { get; set; }

        public List<CategoryDto> Categories { get; set; }

        public List<BrandDto> Brands { get; set; }

        public List<ModelDto> Models { get; set; }

        [Required(ErrorMessage = "State is required")]
        public StateDto State { get; set; }

        public int Status { get; set; }

        public RatingDto Rating { get; set; }

        public DateTime DepositBuyDate { get; set; }

        public decimal BuyingPrice { get; set; }

        public bool Sold { get; set; }

        [Required(ErrorMessage = "Selling is required")]
        public decimal SellingPrice { get; set; }

        public OperatorDto SellingOperator { get; set; }

        public CustomerDto Buyer { get; set; }

        public bool Mecanic { get; set; }

        public DateTime SellingDate { get; set; }

        public string CardIdentificationNumber { get; set; }

        public bool HasComplaint { get; set; }

        public OperatorDto ComplaintOperator { get; set; }

        public DateTime ComplaintDate { get; set; }

        public bool IsReturn { get; set; }

        public OperatorDto ReturnOperator { get; set; }

        public DateTime ReturnDate { get; set; }

        public bool IsReplace { get; set; }

        public OperatorDto ReplacementOperator { get; set; }

        public DateTime ReplaceDate { get; set; }

        public int ReplaceProductId { get; set; }

        public bool IsReimbursed { get; set; }

        public bool IsAvailable { get; set; }

        public string RequestNumber { get; set; }

        public OperatorDto RequestOperator { get; set; }

        public DateTime RequestDate { get; set; }

        public bool HasOrder { get; set; }

        public string OrderNumber { get; set; }

        public DateTime OrderDate { get; set; }

        public OperatorDto OrderOperator { get; set; }

        public CustomerDto OrderCustomer { get; set; }

        public decimal OrderSellingPrice { get; set; }

        public decimal AdvancePaymentAmount { get; set; }

        public DateTime EstimatedDeliveryDate { get; set; }

        public DateTime FinalDate { get; set; }

        public decimal BalanceAmount { get; set; }
    }
}