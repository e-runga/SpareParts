using SpareParts.DataAccess;
using SpareParts.DataHelpers;
using SpareParts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpareParts.Logic
{
    /// <summary>
    /// The Product business logic
    /// </summary>
    /// <seealso cref="SpareParts.Logic.BaseLogic" />
    public class ProductLogic : BaseLogic
    {
        #region .: Private Members :.
        /// <summary>
        /// The dal
        /// </summary>
        private readonly ProductDal dal;
        #endregion

        #region .: Constructors :.
        public ProductLogic()
        {
            this.dal = new ProductDal();
        }
        #endregion

        #region .: Public Methods :.
        /// <summary>
        /// Gets all products.
        /// </summary>
        /// <returns></returns>
        public List<ProductDto> GetAll()
        {
            try
            {
                var retVal = this.dal.GetAll().ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Gets all summary.
        /// </summary>
        /// <returns></returns>
        public List<ProductSummaryDto> GetAllSummaries()
        {
            try
            {
                var retVal = this.Search(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, new string[] { }, string.Empty).ToSummary();
                return retVal;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the by customer identifier.
        /// </summary>
        /// <param name="customerId">The customer identifier.</param>
        /// <returns></returns>
        public List<ProductDto> GetByCustomerId(int customerId)
        {
            try
            {
                var retVal = this.dal.GetByCustomerId(customerId).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Gets the by operator identifier.
        /// </summary>
        /// <param name="operatorId">The operator identifier.</param>
        /// <returns></returns>
        public List<ProductDto> GetByOperatorId(int operatorId)
        {
            try
            {
                var retVal = this.dal.GetByOperatorId(operatorId).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public ProductDto GetById(int id)
        {
            try
            {
                var retVal = this.dal.GetById(id).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Creates the specified dto.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        public ProductDto Create(ProductDto dto)
        {
            try
            {
                var retVal = this.dal.Create(dto.Name,
                    dto.ProductType.Id,
                    dto.Item.Id,
                    dto.PaperReference.Id,
                    dto.City.Id,
                    dto.Customer.Id,
                    dto.Operator.Id,
                    dto.Rating.Id,
                    dto.YearIds,
                    dto.DepositBuyDate,
                    dto.Buyer.Id,
                    dto.BuyingPrice,
                    dto.SellingPrice,
                    dto.SellingOperator.Id,
                    dto.SellingDate,
                    dto.CardIdentificationNumber,
                    dto.Mecanic).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Saves the basic information.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        public ProductDto SaveBasicInfo(ProductDto dto)
        {
            try
            {
                var retVal = this.dal.SaveBasicInfo(dto.Id,
                    dto.Name,
                    dto.ProductType.Id,
                    dto.Item.Id,
                    dto.City.Id,
                    dto.Customer.Id,
                    dto.Operator.Id,
                    dto.Categories.Select(c => c.Id).ToArray(),
                    dto.Brands.Select(b => b.Id).ToArray(),
                    dto.Models.Select(m => m.Id).ToArray(),
                    dto.YearIds,
                    dto.State.Id,
                    dto.BuyingPrice,
                    dto.DepositBuyDate).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Saves the selling.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        public ProductDto SaveSelling(ProductDto dto)
        {
            try
            {
                var retVal = this.dal.SaveSelling(dto.Id,
                    dto.Buyer != null ? dto.Buyer.Id : 0,
                    dto.SellingDate,
                    dto.SellingPrice,
                    dto.SellingOperator.Id,
                    dto.CardIdentificationNumber,
                    dto.Mecanic)
                    .ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Saves the complaint.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        public ProductDto SaveComplaint(ProductDto dto)
        {
            try
            {
                var retVal = this.dal.SaveComplaint(dto.Id,
                    dto.HasComplaint,
                    dto.ComplaintOperator.Id,
                    dto.ComplaintDate)
                    .ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Saves the return.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        public ProductDto SaveReturn(ProductDto dto)
        {
            try
            {
                var retVal = this.dal.SaveReturn(dto.Id,
                    dto.IsReturn,
                    dto.ReturnOperator.Id,
                    dto.ReturnDate)
                    .ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Saves the replacement.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        public ProductDto SaveReplacement(ProductDto dto)
        {
            try
            {
                var retVal = this.dal.SaveReplacement(dto.Id,
                    dto.IsReplace,
                    dto.ReplacementOperator.Id,
                    dto.ReplaceDate,
                    dto.ReplaceProductId,
                    dto.IsReimbursed)
                    .ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Saves the request.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        public ProductDto SaveRequest(ProductDto dto)
        {
            try
            {
                var retVal = this.dal.SaveRequest(dto.Id,
                    dto.RequestNumber,
                    dto.RequestOperator.Id,
                    dto.RequestDate,
                    dto.IsAvailable)
                    .ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Saves the ordering.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        public ProductDto SaveOrdering(ProductDto dto)
        {
            try
            {
                var retVal = this.dal.SaveOrdering(dto.Id,
                    dto.HasOrder,
                    dto.OrderOperator.Id,
                    dto.OrderCustomer.Id,
                    dto.OrderDate,
                    dto.OrderSellingPrice,
                    dto.AdvancePaymentAmount,
                    dto.BalanceAmount,
                    dto.EstimatedDeliveryDate,
                    dto.FinalDate)
                    .ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Searches the specified product type.
        /// </summary>
        /// <param name="productType">Type of the product.</param>
        /// <param name="brand">The brand.</param>
        /// <param name="category">The category.</param>
        /// <param name="subCategory1">The sub category1.</param>
        /// <param name="subCategory2">The sub category2.</param>
        /// <param name="model">The model.</param>
        /// <param name="subModel">The sub model.</param>
        /// <param name="item">The item.</param>
        /// <param name="state">The state.</param>
        /// <param name="years">The years.</param>
        /// <param name="vin">The vin.</param>
        /// <returns></returns>
        public List<ProductViewDto> Search(string productType, string brand, string category, string model, string item, string state, string[] years, string vin)
        {
            try
            {
                var retVal = this.dal.Search(productType, brand, category, model, item, state, years, vin).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProductViewDto> SearchSealable(string productType, string brand, string category, string model, string item, string state, string[] years, string vin)
        {
            try
            {
                var retVal = this.dal.Search(productType, brand, category, model, item, state, years, vin)
                    .Where(p => p.Sold.Equals(false))
                    .ToList()
                    .ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}