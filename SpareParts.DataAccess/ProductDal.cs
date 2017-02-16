using SpareParts.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SpareParts.DataAccess
{
    public class ProductDal : BaseDal
    {
        #region .: Public Members :.
        /// <summary>
        /// Gets all products.
        /// </summary>
        /// <returns></returns>
        public List<Product> GetAll()
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Product.ToList();
                return retVal;
            }
        }

        /// <summary>
        /// Gets the by customer identifier.
        /// </summary>
        /// <param name="customerId">The customer identifier.</param>
        /// <returns></returns>
        public List<Product> GetByCustomerId(int customerId)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Product.Where(p => p.CustomerId.Equals(customerId)).ToList();
                return retVal;
            }
        }

        /// <summary>
        /// Gets the by operator identifier.
        /// </summary>
        /// <param name="operatorId">The operator identifier.</param>
        /// <returns></returns>
        public List<Product> GetByOperatorId(int operatorId)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Product.Where(p => p.OperatorId.Equals(operatorId)).ToList();
                return retVal;
            }
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Product GetById(int id)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Product
                    .Include(p => p.ProductType)
                    .Include(p => p.Rating)
                    .Include(p => p.Item)
                    .Include(p => p.State)
                    .Include(p => p.CreateOperator)
                    .Include(p => p.Customer)
                    .Include(p => p.PaperReference)
                    .Include(p => p.City)
                    .Include(p => p.City.Country)
                    .Include(p => p.Customer.CustomerType)
                    .Include(p => p.SellingOperator)
                    .Include(p => p.Categories)
                    .Include(p => p.Brands)
                    .Include(p => p.Models)
                    .FirstOrDefault(p => p.Id.Equals(id));

                return retVal;
            }
        }

        /// <summary>
        /// Creates the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="productTypeId">The category identifier.</param>
        /// <param name="itemId">The item identifier.</param>
        /// <param name="paperReferenceId">The paper reference identifier.</param>
        /// <param name="locationId">The location identifier.</param>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="operatorId">The operator identifier.</param>
        /// <param name="ratingId">The rating identifier.</param>
        /// <param name="yearIds">The year ids.</param>
        /// <param name="depositDate">The deposit date.</param>
        /// <param name="buyerId">The buyer identifier.</param>
        /// <param name="buyingPrice">The buying price.</param>
        /// <param name="sellingPrice">The selling price.</param>
        /// <param name="sellingOperatorId">The selling operator identifier.</param>
        /// <param name="sellingDate">The selling date.</param>
        /// <param name="cardIdentificationNumber">The card identification number.</param>
        /// <param name="mecanic">if set to <c>true</c> [mecanic].</param>
        /// <returns></returns>
        public Product Create(string name, int productTypeId, int itemId, int paperReferenceId, int locationId, int customerId, int operatorId, int ratingId,
            int[] yearIds, DateTime depositDate, int buyerId, decimal buyingPrice,
            decimal sellingPrice, int sellingOperatorId, DateTime sellingDate, string cardIdentificationNumber, bool mecanic)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var product = new Product
                {
                    Name = name,
                    ProductTypeId = productTypeId,
                    ItemId = itemId,
                    PaperReferenceId = paperReferenceId,
                    LocationId = locationId,
                    CustomerId = customerId,
                    OperatorId = operatorId,
                    RatingId = ratingId,
                    BuyerId = buyerId,
                    DepositBuyDate = depositDate,
                    BuyingPrice = buyingPrice,
                    OrderSellingPrice = sellingPrice,
                    SellingOperatorId = sellingOperatorId,
                    SellingDate = sellingDate,
                    CarIdentificationNumber = cardIdentificationNumber,
                    Mecanic = mecanic
                };

                model.Product.AddObject(product);
                model.SaveChanges();

                this.SetProductYears(product, yearIds, model);

                return this.GetById(product.Id);
            }
        }

        public void SetProductYears(Product product, int[] yearIds, DataModelEntities model)
        {
            foreach (var yearId in yearIds)
            {
                if (!product.ProductYear.Any(y => y.ProductId.Equals(product.Id) && y.Year.Id.Equals(yearId)))
                {
                    product.ProductYear.Add(new ProductYear { ProductId = product.Id, YearId = yearId });
                }
            }

            model.SaveChanges();
        }

        /// <summary>
        /// Saves the basic information.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="productTypeId">The category identifier.</param>
        /// <param name="itemId">The item identifier.</param>
        /// <param name="paperReferenceId">The paper reference identifier.</param>
        /// <param name="locationId">The location identifier.</param>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="operatorId">The operator identifier.</param>
        /// <param name="ratingId">The rating identifier.</param>
        /// <param name="yearIds">The year ids.</param>
        /// <param name="depositDate">The deposit date.</param>
        /// <returns></returns>
        public Product SaveBasicInfo(int productId, string name, int productTypeId, int itemId, int locationId, int customerId, int operatorId, int[] categoryIds, int[] brandIds, int[] modelIds,
            int[] yearIds, int stateId, decimal buyinPrice, DateTime depositDate)
        {
            using (DataModelEntities dataModel = new DataModelEntities())
            {
                var product = dataModel.Product.FirstOrDefault(p => p.Id.Equals(productId));

                if (product != null)
                {
                    product.Name = name;
                    product.ProductTypeId = productTypeId;
                    product.ItemId = itemId;
                    product.LocationId = locationId;
                    product.CustomerId = customerId;
                    product.OperatorId = operatorId;
                    product.DepositBuyDate = depositDate;
                    product.BuyingPrice = buyinPrice;
                    product.StateId = stateId;
                    product.ProductYear.Clear();
                    product.StatusId = (int)Enums.ProductStatus.New;

                    dataModel.SaveChanges();

                    foreach (var yearId in yearIds)
                    {
                        product.ProductYear.Add(new ProductYear { YearId = yearId });
                    }

                    dataModel.SaveChanges();
                }
                else
                {
                    product = new Product
                    {
                        Name = name,
                        ProductTypeId = productTypeId,
                        ItemId = itemId,
                        LocationId = locationId,
                        CustomerId = customerId,
                        OperatorId = operatorId,
                        DepositBuyDate = depositDate,
                        StateId = stateId,
                        BuyingPrice = buyinPrice,
                        StatusId = (int)Enums.ProductStatus.Sold
                    };

                    foreach (var yearId in yearIds)
                    {
                        product.ProductYear.Add(new ProductYear { YearId = yearId });
                    }

                    dataModel.Product.AddObject(product);
                }

                foreach (var categoryId in categoryIds)
                {
                    product.Categories.Add(dataModel.Category.FirstOrDefault(c => c.Id.Equals(categoryId)));
                }

                foreach (var brandId in brandIds)
                {
                    product.Brands.Add(dataModel.Brand.FirstOrDefault(b => b.Id.Equals(brandId)));
                }

                foreach (var modelId in modelIds)
                {
                    product.Models.Add(dataModel.Model.FirstOrDefault(m => m.Id.Equals(modelId)));
                }

                dataModel.SaveChanges();
                return this.GetById(product.Id);
            }
        }

        /// <summary>
        /// Saves the selling.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <param name="buyerId">The buyer identifier.</param>
        /// <param name="buyDate">The buy date.</param>
        /// <param name="buyingPrice">The buying price.</param>
        /// <param name="sellingPrice">The selling price.</param>
        /// <param name="sellingOperatorId">The selling operator identifier.</param>
        /// <param name="cardIdentificationNumber">The card identification number.</param>
        /// <param name="mecanic">if set to <c>true</c> [mecanic].</param>
        /// <returns></returns>
        public Product SaveSelling(int productId, int buyerId, DateTime buyDate, decimal sellingPrice, int sellingOperatorId, string cardIdentificationNumber, bool mecanic)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var product = model.Product.FirstOrDefault(p => p.Id.Equals(productId));
                int? buyer = null;

                if (buyerId == 0)
                {
                    buyer = null;
                }

                if (product != null)
                {
                    product.BuyerId = buyer;
                    product.DepositBuyDate = buyDate;
                    product.OrderSellingPrice = sellingPrice;
                    product.Sold = true;
                    product.SellingOperatorId = sellingOperatorId;
                    product.Mecanic = mecanic;
                    product.CarIdentificationNumber = cardIdentificationNumber;
                    product.StatusId = (int)Enums.ProductStatus.Sold;

                    model.SaveChanges();
                }

                return this.GetById(product.Id);
            }
        }

        /// <summary>
        /// Saves the complaint.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <param name="hasComplaint">if set to <c>true</c> [has complaint].</param>
        /// <param name="complaintOperatorId">The complaint operator identifier.</param>
        /// <param name="complaintDate">The complaint date.</param>
        /// <returns></returns>
        public Product SaveComplaint(int productId, bool hasComplaint, int complaintOperatorId, DateTime complaintDate)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var product = model.Product.FirstOrDefault(p => p.Id.Equals(productId));

                if (product != null)
                {
                    product.HasComplaint = hasComplaint;
                    product.ComplaintOperatorId = complaintOperatorId;
                    product.ComplaintDate = complaintDate;
                    product.StatusId = (int)Enums.ProductStatus.Complained;

                    model.SaveChanges();
                }

                return this.GetById(product.Id);
            }
        }

        /// <summary>
        /// Saves the return.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <param name="isReturn">if set to <c>true</c> [is return].</param>
        /// <param name="returnOperatorId">The return operator identifier.</param>
        /// <param name="returnDate">The return date.</param>
        /// <returns></returns>
        public Product SaveReturn(int productId, bool isReturn, int returnOperatorId, DateTime returnDate)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var product = model.Product.FirstOrDefault(p => p.Id.Equals(productId));

                if (product != null)
                {
                    product.IsReturn = isReturn;
                    product.ReturnOperatorId = returnOperatorId;
                    product.ReturnDate = returnDate;
                    product.StatusId = (int)Enums.ProductStatus.Returned;

                    model.SaveChanges();
                }

                return this.GetById(product.Id);
            }
        }

        /// <summary>
        /// Saves the replacement.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <param name="isReplace">if set to <c>true</c> [is replace].</param>
        /// <param name="replaceOperatorId">The replace operator identifier.</param>
        /// <param name="replaceDate">The replace date.</param>
        /// <param name="replacedProductId">The replaced product identifier.</param>
        /// <param name="isReimbursed">if set to <c>true</c> [is reimbursed].</param>
        /// <returns></returns>
        public Product SaveReplacement(int productId, bool isReplace, int replaceOperatorId, DateTime replaceDate, int replacedProductId, bool isReimbursed)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var product = model.Product.FirstOrDefault(p => p.Id.Equals(productId));
                var replacedProduct = model.Product.FirstOrDefault(p => p.Id.Equals(replacedProductId));

                if (product != null && replacedProduct != null)
                {
                    product.IsReplace = isReplace;
                    product.ReplaceOperatorId = replaceOperatorId;
                    product.ReplaceDate = replaceDate;
                    product.ReplacedProductId = replacedProductId;
                    product.IsReimbursed = isReimbursed;
                    product.StatusId = (int)Enums.ProductStatus.Replaced;

                    model.SaveChanges();
                }

                return this.GetById(product.Id);
            }
        }

        /// <summary>
        /// Saves the request.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <param name="requestNumber">The request number.</param>
        /// <param name="requestOperatorId">The request operator identifier.</param>
        /// <param name="requestDate">The request date.</param>
        /// <param name="isAvailable">if set to <c>true</c> [is available].</param>
        /// <returns></returns>
        public Product SaveRequest(int productId, string requestNumber, int requestOperatorId, DateTime requestDate, bool isAvailable)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var product = model.Product.FirstOrDefault(p => p.Id.Equals(productId));

                if (product != null)
                {
                    product.RequestNumber = requestNumber;
                    product.RequestOperatorId = requestOperatorId;
                    product.RequestDate = requestDate;
                    product.IsAvailable = isAvailable;
                    product.StatusId = (int)Enums.ProductStatus.Requested;

                    model.SaveChanges();
                }

                return this.GetById(product.Id);
            }
        }

        /// <summary>
        /// Saves the ordering.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <param name="hasOrder">if set to <c>true</c> [has order].</param>
        /// <param name="orderingOperatorId">The ordering operator identifier.</param>
        /// <param name="orderingCustomerId">The ordering customer identifier.</param>
        /// <param name="orderingDate">The ordering date.</param>
        /// <param name="orderingSellingPrice">The ordering selling price.</param>
        /// <param name="advancedAmount">The advanced amount.</param>
        /// <param name="balancedAmount">The balanced amount.</param>
        /// <param name="estimatedDeliveryDate">The estimated delivery date.</param>
        /// <param name="deliveryDate">The delivery date.</param>
        /// <returns></returns>
        public Product SaveOrdering(int productId, bool hasOrder, int orderingOperatorId, int orderingCustomerId, DateTime orderingDate, decimal orderingSellingPrice,
            decimal advancedAmount, decimal balancedAmount, DateTime estimatedDeliveryDate, DateTime deliveryDate)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var product = model.Product.FirstOrDefault(p => p.Id.Equals(productId));

                if (product != null)
                {
                    product.HasOrder = hasOrder;
                    product.OrderCustomerId = orderingCustomerId;
                    product.OrderOperatorId = orderingOperatorId;
                    product.OrderDate = orderingDate;
                    product.OrderSellingPrice = orderingSellingPrice;
                    product.AdvancePaymentAmount = advancedAmount;
                    product.BalanceAmount = balancedAmount;
                    product.EstimatedDeliveryDate = estimatedDeliveryDate;
                    product.FinalDate = deliveryDate;
                    product.StatusId = (int)Enums.ProductStatus.Ordered;

                    model.SaveChanges();
                }

                return this.GetById(product.Id);
            }
        }

        public List<ProductView> Search(string productType, string brand, string category, string model, string item, string state, string[] years, string vin)
        {
            using (DataModelEntities dataModel = new DataModelEntities())
            {
                IQueryable<ProductView> query = from product in dataModel.ProductView
                                                select product;

                if (!string.IsNullOrEmpty(productType)
                    && !string.IsNullOrEmpty(brand)
                    && !string.IsNullOrEmpty(category)
                    && !string.IsNullOrEmpty(model)
                    && !string.IsNullOrEmpty(item)
                    && !string.IsNullOrEmpty(state)
                    && !string.IsNullOrEmpty(vin)
                    && (years != null || years.Length > 0)
                    )
                {
                    query = !string.IsNullOrEmpty(productType) ? query.Where(p => p.ProductType.Contains(productType)) : query;
                    query = !string.IsNullOrEmpty(brand) ? query.Where(p => p.Brand.Contains(brand)) : query;
                    query = !string.IsNullOrEmpty(category) ? query.Where(p => p.Category.Contains(category)) : query;
                    query = !string.IsNullOrEmpty(model) ? query.Where(p => p.Model.Contains(model)) : query;
                    query = !string.IsNullOrEmpty(item) ? query.Where(p => p.Item.Contains(item)) : query;
                    query = !string.IsNullOrEmpty(state) ? query.Where(p => p.State.Contains(state)) : query;
                    //uery = (years != null || years.Length > 0) ? query.Where(p => p.Years.Contains(years.ToString()) : query;
                    query = !string.IsNullOrEmpty(vin) ? query.Where(p => p.VIN.Contains(vin)) : query;
                }

                return query.ToList();
            }
        }

        #endregion
    }
}