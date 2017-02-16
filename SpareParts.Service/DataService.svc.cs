using SpareParts.Contracts;
using SpareParts.Dto;
using SpareParts.Logic;
using System.Collections.Generic;

namespace SpareParts.Service
{
    public class DataService : IDataService
    {
        #region .: Users :.
        public bool Authenticate(string userName, string password)
        {
            return new UserLogic().Authenticate(userName, password);
        }

        public UserDto CreateUser(UserDto newUser)
        {
            return new UserLogic().Create(newUser);
        }

        public List<UserDto> GetAllUsers()
        {
            return new UserLogic().GetAll();
        }

        public List<UserUIDto> GetAllUsersForUI()
        {
            return new UserLogic().GetAllForUI();
        }

        public UserDto GetUserById(int userId)
        {
            return new UserLogic().GetById(userId);
        }

        public UserDto GetUserByUserName(string userName)
        {
            return new UserLogic().GetByUserName(userName);
        }

        public UserUIDto SaveUser(UserUIDto user)
        {
            return new UserLogic().Save(user);
        }

        public bool DisableUser(string userName)
        {
            return new UserLogic().Disable(userName);
        }
        #endregion

        #region .: Profiles :.
        public List<ProfileDto> GetAllProfiles()
        {
            return new ProfileLogic().GetAll();
        }

        public ProfileDto GetProfileById(int id)
        {
            return new ProfileLogic().GetById(id);
        }

        public ProfileDto GetProfileByName(string profileName)
        {
            return new ProfileLogic().GetByName(profileName);
        }

        public bool SaveProfile(ProfileDto dto)
        {
            return new ProfileLogic().Save(dto);
        }

        #endregion

        #region .: Brands :.
        public List<BrandDto> GetAllBrands()
        {
            return new BrandLogic().GetAll();
        }

        public List<BrandViewForUIDto> GetAllBrandsForUI()
        {
            return new BrandLogic().GetAllForUI();
        }

        public BrandDto GetBrandById(int id)
        {
            return new BrandLogic().GetById(id);
        }

        public BrandDto GetBrandByName(string name)
        {
            return new BrandLogic().GetByName(name);
        }

        public List<BrandViewForUIDto> GetBrandsByProductType(int id)
        {
            return new BrandLogic().GetByProductType(id);
        }

        public BrandDto CreateBrand(BrandDto dto)
        {
            return new BrandLogic().Create(dto);
        }

        public BrandDto SaveBrand(BrandDto dto)
        {
            return new BrandLogic().Save(dto);
        }

        public bool DeleteBrand(BrandDto dto)
        {
            return new BrandLogic().Delete(dto);
        }
        #endregion

        #region .: Attachment :.
        public List<AttachmentDto> GetAttachmentByProductId(int productId)
        {
            return new AttachmentLogic().GetByProductId(productId);
        }

        public AttachmentDto GetAttachmentById(int id)
        {
            return new AttachmentLogic().GetById(id);
        }

        public AttachmentDto CreateAttachment(AttachmentDto dto)
        {
            return new AttachmentLogic().Create(dto);
        }

        public AttachmentDto SaveAttachment(AttachmentDto dto)
        {
            return new AttachmentLogic().Save(dto);
        }

        #endregion

        #region .: Category :.
        public List<CategoryDto> GetAllCategories()
        {
            return new CategoryLogic().GetAll();
        }

        public List<CategoryViewDto> GetAllCategoriesForUIView()
        {
            return new CategoryLogic().GetAllForUIView();
        }

        public List<CategoryDto> GetCategories()
        {
            return new CategoryLogic().GetCategories();
        }


        public List<CategoryViewDto> GetSubCategories()
        {
            return new CategoryLogic().GetSubCategories();
        }

        public CategoryDto GetCategoryById(int id)
        {
            return new CategoryLogic().GetById(id);
        }

        public CategoryDto GetCategoryByName(string name)
        {
            return new CategoryLogic().GetByName(name);
        }

        public List<CategoryDto> GetCategoriesByProductType(int productTypeId)
        {
            return new CategoryLogic().GetByProductType(productTypeId);
        }

        public List<CategoryViewDto> GetSubCategory1(List<int> parentIds)
        {
            return new CategoryLogic().GetSubCategory1(parentIds);
        }

        public List<CategoryViewDto> GetSubCategory2(List<int> parentIds)
        {
            return new CategoryLogic().GetSubCategory2(parentIds);
        }

        public CategoryDto CreateCategory(CategoryDto dto)
        {
            return new CategoryLogic().Create(dto);
        }

        public CategoryDto SaveCategory(CategoryDto dto)
        {
            return new CategoryLogic().Save(dto);
        }

        public bool DeleteCategory(int categoryId)
        {
            return new CategoryLogic().Delete(categoryId);
        }


        #endregion

        #region .: Country - City :.
        public List<CountryDto> GetAllCountries()
        {
            return new CountryLogic().GetAllCountries();
        }

        public List<CountryUIDto> GetAllCountriesForUI()
        {
            return new CountryLogic().GetAllCountriesForUI();
        }

        public List<CountryDto> GetAllCountriesAndCities()
        {
            return new CountryLogic().GetAllCountriesAndCities();
        }

        public CountryDto GetCountryByName(string name)
        {
            return new CountryLogic().GetCountryByName(name);
        }

        public CountryDto CreateCountry(CountryDto dto)
        {
            return new CountryLogic().CreateCountry(dto);
        }

        public bool SaveCountry(CountryUIDto dto)
        {
            return new CountryLogic().SaveCountry(dto);
        }

        public bool DeleteCountry(int id)
        {
            return new CountryLogic().DeleteCountry(id);
        }

        public List<CityDto> GetCityByCountry(int countryId)
        {
            return new CountryLogic().GetCityByCountry(countryId);
        }

        public List<CityUIDto> GetAllCities()
        {
            return new CountryLogic().GetAllCities();
        }

        public List<LocationViewDto> GetAllLocations()
        {
            return new CountryLogic().GetAllLocations();
        }

        public CityDto GetCityByName(string name)
        {
            return new CountryLogic().GetCityByName(name);
        }

        public CityDto CreateCity(CityDto dto)
        {
            return new CountryLogic().CreateCity(dto);
        }

        public bool SaveCity(CityUIDto dto)
        {
            return new CountryLogic().SaveCity(dto);
        }

        public bool DeleteCity(int id)
        {
            return new CountryLogic().DeleteCity(id);
        }
        #endregion

        #region .: Model :.
        public List<ModelDto> GetAllModels()
        {
            return new ModelLogic().GetAll();
        }

        public List<ModelViewDto> GetAllModelsForUI()
        {
            return new ModelLogic().GetAllForUI();
        }

        public List<ModelDto> GetModelsByBrand(int brandId)
        {
            return new ModelLogic().GetByBrand(brandId);
        }

        public List<ModelDto> GetModelsByBrands(List<int> brandIds)
        {
            return new ModelLogic().GetByBrands(brandIds);
        }

        public ModelDto GetModelById(int id)
        {
            return new ModelLogic().GetById(id);
        }

        public List<ModelDto> GetModelBySubModelId(int subModelId)
        {
            return new ModelLogic().GetBySubModelId(subModelId);
        }

        public ModelDto CreateModel(ModelDto dto)
        {
            return new ModelLogic().Create(dto);
        }

        public ModelDto SaveModel(ModelDto dto)
        {
            return new ModelLogic().Save(dto);
        }

        public bool DeleteModel(int id)
        {
            return new ModelLogic().Delete(id);
        }
        #endregion

        #region .: ProductType :.
        public List<ProductTypeViewDto> GetAllProductTypes()
        {
            return new ProductTypeLogic().GetAll();
        }

        public ProductTypeDto GetProductTypeById(int id)
        {
            return new ProductTypeLogic().GetById(id);
        }

        public ProductTypeDto CreateProductType(ProductTypeDto dto)
        {
            return new ProductTypeLogic().Create(dto);
        }

        public ProductTypeDto SaveProductType(ProductTypeDto dto)
        {
            return new ProductTypeLogic().Save(dto);
        }

        public bool DeleteProductType(int productTypeId)
        {
            return new ProductTypeLogic().Delete(productTypeId);
        }
        #endregion

        #region .: Rating :.
        public List<RatingDto> GetAllRatings()
        {
            return new RatingLogic().GetAll();
        }

        public RatingDto GetRatingById(int id)
        {
            return new RatingLogic().GetById(id);
        }

        public RatingDto GeRatingtByName(string name)
        {
            return new RatingLogic().GetByName(name);
        }

        public RatingDto CreateRating(RatingDto dto)
        {
            return new RatingLogic().Create(dto);
        }

        public RatingDto SaveRating(RatingDto dto)
        {
            return new RatingLogic().Save(dto);
        }

        public bool DeleteRating(int id)
        {
            return new RatingLogic().Delete(id);
        }

        #endregion

        #region .: State :.
        public List<StateDto> GetAllStates()
        {
            return new StateLogic().GetAll();
        }

        public StateDto GetByStateId(int id)
        {
            return new StateLogic().GetById(id);
        }

        public StateDto GetStateByName(string name)
        {
            return new StateLogic().GetByName(name);
        }

        public StateDto CreateState(StateDto dto)
        {
            return new StateLogic().Create(dto);
        }

        public StateDto SaveState(StateDto dto)
        {
            return new StateLogic().Save(dto);
        }

        public bool DeleteState(int id)
        {
            return new StateLogic().Delete(id);
        }
        #endregion

        //#region .: SubCategory1 :.
        //public List<SubCategory1Dto> GetAllSubCategories1()
        //{
        //    return new SubCategory1Logic().GetAll();
        //}

        //public List<SubCategory1Dto> GetSubCategory1ByCategoryId(int categoryId)
        //{
        //    return new SubCategory1Logic().GetByCategoryId(categoryId);
        //}

        //public SubCategory1Dto CreateSubCategory1(SubCategory1Dto dto)
        //{
        //    return new SubCategory1Logic().Create(dto);
        //}

        //public SubCategory1Dto SaveSubCategory1(SubCategory1Dto dto)
        //{
        //    return new SubCategory1Logic().Save(dto);
        //}

        //public bool DeleteSubCategory1(int id)
        //{
        //    return new SubCategory1Logic().Delete(id);
        //}
        //#endregion

        //#region .: SubCategory2 :.
        //public List<SubCategory2Dto> GetAllSubCategories2()
        //{
        //    return new SubCategory2Logic().GetAll();
        //}

        //public List<SubCategory2Dto> GetSubCategory2BySubCategory1Id(int subCategoryId)
        //{
        //    return new SubCategory2Logic().GetBySubCategory1Id(subCategoryId);
        //}

        //public SubCategory2Dto CreateSubCategory2(SubCategory2Dto dto)
        //{
        //    return new SubCategory2Logic().Create(dto);
        //}

        //public SubCategory2Dto SaveSubCategory2(SubCategory2Dto dto)
        //{
        //    return new SubCategory2Logic().Save(dto);
        //}

        //public bool DeleteSubCategory2(int id)
        //{
        //    return new SubCategory2Logic().Delete(id);
        //}
        //#endregion

        #region .: SubModel :.
        public List<SubModelDto> GetAllSubModels()
        {
            return new SubModelLogic().GetAll();
        }

        public SubModelDto GetSubModelById(int id)
        {
            return new SubModelLogic().GetById(id);
        }

        public List<SubModelDto> GetSubModelByModelId(int modelId)
        {
            return new SubModelLogic().GetByModelId(modelId);
        }

        public List<SubModelDto> GetSubModelByModels(List<int> modelIds)
        {
            return new SubModelLogic().GetByModels(modelIds);
        }

        public SubModelDto CreateSubModel(SubModelDto dto)
        {
            return new SubModelLogic().Create(dto);
        }

        public SubModelDto SaveSubModel(SubModelDto dto)
        {
            return new SubModelLogic().Save(dto);
        }

        public bool DeleteSubModel(int id)
        {
            return new SubModelLogic().Delete(id);
        }
        #endregion

        #region .: Year :.
        public List<YearDto> GetAllYears()
        {
            return new YearLogic().GetAll();
        }

        public YearDto GetYearById(int id)
        {
            return new YearLogic().GetById(id);
        }

        public YearDto CreateYear(YearDto dto)
        {
            return new YearLogic().Create(dto);
        }

        public YearDto SaveYear(YearDto dto)
        {
            return new YearLogic().Save(dto);
        }


        #endregion

        #region .: CustomerType :.
        public List<CustomerTypeDto> GetAllCustomerTypes()
        {
            return new CustomerTypeLogic().GetAll();
        }

        public CustomerTypeDto GetCustomerTypeById(int id)
        {
            return new CustomerTypeLogic().GetById(id);
        }

        public CustomerTypeDto GetCustomerTypeByName(string name)
        {
            return new CustomerTypeLogic().GetByName(name);
        }

        public CustomerTypeDto CreateCustomerType(string name)
        {
            return new CustomerTypeLogic().Create(name);
        }

        public CustomerTypeDto SaveCustomerType(CustomerTypeDto dto)
        {
            return new CustomerTypeLogic().Save(dto);
        }

        public bool DeleteCustomerType(CustomerTypeDto dto)
        {
            return new CustomerTypeLogic().Delete(dto);
        }
        #endregion

        #region .: Item :.
        public List<ItemDto> GetAllItems()
        {
            return new ItemLogic().GetAll();
        }

        public ItemDto GetItemById(int id)
        {
            return new ItemLogic().GetById(id);
        }

        public ItemDto GetItemByName(string name)
        {
            return new ItemLogic().GetByName(name);
        }

        public ItemDto CreateItem(ItemDto dto)
        {
            return new ItemLogic().Create(dto);
        }

        public ItemDto SaveItem(ItemDto dto)
        {
            return new ItemLogic().Save(dto);
        }

        public bool DeleteItem(ItemDto dto)
        {
            return new ItemLogic().Delete(dto);
        }
        #endregion

        #region .: PaperReference :.
        public List<PaperReferenceDto> GetAllPaperReferences()
        {
            return new PaperReferenceLogic().GetAll();
        }

        public PaperReferenceDto GetPaperReferenceById(int id)
        {
            return new PaperReferenceLogic().GetById(id);
        }

        public PaperReferenceDto GetPaperReferenceByName(string name)
        {
            return new PaperReferenceLogic().GetByName(name);
        }

        public PaperReferenceDto CreatePaperReference(PaperReferenceDto dto)
        {
            return new PaperReferenceLogic().Create(dto);
        }

        public PaperReferenceDto SavePaperReference(PaperReferenceDto dto)
        {
            return new PaperReferenceLogic().Save(dto);
        }

        public bool DeletePaperReference(PaperReferenceDto dto)
        {
            return new PaperReferenceLogic().Delete(dto);
        }
        #endregion

        #region .: Customer :.
        public CustomerDto GetCustomerById(int id)
        {
            return new CustomerLogic().GetById(id);
        }

        public List<CustomerDto> GetAllCustomers()
        {
            return new CustomerLogic().GetAll();
        }

        public List<CustomerUIDto> GetAllCustomersForUI()
        {
            return new CustomerLogic().GetAllForUI();
        }

        public List<CustomerDto> SearchCustomer(string fName, string lName, string email, string mobile, string phone)
        {
            return new CustomerLogic().Search(fName, lName, email, mobile, phone);
        }

        public CustomerDto CreateCustomer(CustomerDto dto)
        {
            return new CustomerLogic().Create(dto);
        }

        public CustomerDto SaveCustomer(CustomerDto dto)
        {
            return new CustomerLogic().Save(dto);
        }

        #endregion

        #region .: Product :.
        public List<ProductDto> GetAllProducts()
        {
            return new ProductLogic().GetAll();
        }

        public List<ProductSummaryDto> GetAllProductSummaries()
        {
            return new ProductLogic().GetAllSummaries();
        }

        public List<ProductDto> GetProductByCustomerId(int customerId)
        {
            return new ProductLogic().GetByCustomerId(customerId);
        }

        public List<ProductDto> GetProductByOperatorId(int operatorId)
        {
            return new ProductLogic().GetByOperatorId(operatorId);
        }

        public ProductDto GetProductById(int id)
        {
            return new ProductLogic().GetById(id);
        }

        public ProductDto CreateProduct(ProductDto dto)
        {
            return new ProductLogic().Create(dto);
        }

        public ProductDto SaveProductBasicInfo(ProductDto dto)
        {
            return new ProductLogic().SaveBasicInfo(dto);
        }

        public ProductDto SaveProductSelling(ProductDto dto)
        {
            return new ProductLogic().SaveSelling(dto);
        }

        public ProductDto SaveProductComplaint(ProductDto dto)
        {
            return new ProductLogic().SaveComplaint(dto);
        }

        public ProductDto SaveProductReturn(ProductDto dto)
        {
            return new ProductLogic().SaveReturn(dto);
        }

        public ProductDto SaveProductReplacement(ProductDto dto)
        {
            return new ProductLogic().SaveReplacement(dto);
        }

        public ProductDto SaveProductRequest(ProductDto dto)
        {
            return new ProductLogic().SaveRequest(dto);
        }

        public ProductDto SaveProductOrdering(ProductDto dto)
        {
            return new ProductLogic().SaveOrdering(dto);
        }

        /// <summary>
        /// Searches the product.
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
        public List<ProductViewDto> SearchProduct(string productType, string brand, string category, string model, string item, string state, string[] years, string vin)
        {
            return new ProductLogic().Search(productType, brand, category, model, item, state, years, vin);
        }

        /// <summary>
        /// Searches the sealable products.
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
        public List<ProductViewDto> SearchSellableProducts(string productType, string brand, string category, string model, string item, string state, string[] years, string vin)
        {
            return new ProductLogic().SearchSealable(productType, brand, category, model, item, state, years, vin);
        }
        #endregion
    }
}