using SpareParts.Dto;
using System.Collections.Generic;
using System.ServiceModel;

namespace SpareParts.Contracts
{
    [ServiceContract]
    public interface IDataService
    {
        #region .: Profiles :.
        [OperationContract]
        ProfileDto GetProfileById(int id);

        [OperationContract]
        ProfileDto GetProfileByName(string profileName);

        [OperationContract]
        List<ProfileDto> GetAllProfiles();

        [OperationContract]
        bool SaveProfile(ProfileDto dto);
        #endregion

        #region .: Users :.
        [OperationContract]
        List<UserDto> GetAllUsers();

        [OperationContract]
        List<UserUIDto> GetAllUsersForUI();

        [OperationContract]
        UserDto GetUserByUserName(string userName);

        [OperationContract]
        UserDto GetUserById(int userId);

        [OperationContract]
        UserDto CreateUser(UserDto newUser);

        [OperationContract]
        UserUIDto SaveUser(UserUIDto user);

        [OperationContract]
        bool Authenticate(string userName, string password);

        [OperationContract]
        bool DisableUser(string userName);
        #endregion

        #region .: Brands :.
        [OperationContract]
        List<BrandDto> GetAllBrands();

        [OperationContract]
        List<BrandViewForUIDto> GetAllBrandsForUI();

        [OperationContract]
        BrandDto GetBrandById(int id);

        [OperationContract]
        List<BrandViewForUIDto> GetBrandsByProductType(int id);

        [OperationContract]
        BrandDto GetBrandByName(string name);

        [OperationContract]
        BrandDto CreateBrand(BrandDto dto);

        [OperationContract]
        BrandDto SaveBrand(BrandDto dto);

        [OperationContract]
        bool DeleteBrand(BrandDto dto);

        #endregion

        #region .: Category :.
        [OperationContract]
        List<CategoryDto> GetAllCategories();

        [OperationContract]
        List<CategoryViewDto> GetAllCategoriesForUIView();

        [OperationContract]
        List<CategoryDto> GetCategories();

        [OperationContract]
        List<CategoryViewDto> GetSubCategories();

        [OperationContract]
        CategoryDto GetCategoryById(int id);

        [OperationContract]
        List<CategoryDto> GetCategoriesByProductType(int productTypeId);

        [OperationContract]
        CategoryDto GetCategoryByName(string name);

        [OperationContract]
        List<CategoryViewDto> GetSubCategory1(List<int> parentIds);

        [OperationContract]
        List<CategoryViewDto> GetSubCategory2(List<int> parentIds);

        [OperationContract]
        CategoryDto CreateCategory(CategoryDto dto);

        [OperationContract]
        CategoryDto SaveCategory(CategoryDto dto);

        [OperationContract]
        bool DeleteCategory(int categoryId);

        #endregion

        #region .: Country / City :.
        [OperationContract]
        List<CountryDto> GetAllCountries();

        [OperationContract]
        List<CountryUIDto> GetAllCountriesForUI();

        [OperationContract]
        List<CountryDto> GetAllCountriesAndCities();

        [OperationContract]
        CountryDto GetCountryByName(string name);

        [OperationContract]
        CountryDto CreateCountry(CountryDto dto);

        [OperationContract]
        bool SaveCountry(CountryUIDto dto);

        [OperationContract]
        bool DeleteCountry(int id);

        [OperationContract]
        List<CityDto> GetCityByCountry(int countryId);

        [OperationContract]
        List<CityUIDto> GetAllCities();

        [OperationContract]
        List<LocationViewDto> GetAllLocations();

        [OperationContract]
        CityDto GetCityByName(string name);

        [OperationContract]
        CityDto CreateCity(CityDto dto);

        [OperationContract]
        bool SaveCity(CityUIDto dto);

        [OperationContract]
        bool DeleteCity(int id);

        #endregion

        #region .: Model :.
        [OperationContract]
        List<ModelDto> GetAllModels();

        [OperationContract]
        List<ModelViewDto> GetAllModelsForUI();

        [OperationContract]
        List<ModelDto> GetModelsByBrand(int brandId);

        [OperationContract]
        List<ModelDto> GetModelsByBrands(List<int> brandIds);

        [OperationContract]
        ModelDto GetModelById(int id);

        [OperationContract]
        List<ModelDto> GetModelBySubModelId(int subModelId);

        [OperationContract]
        ModelDto CreateModel(ModelDto dto);

        [OperationContract]
        ModelDto SaveModel(ModelDto dto);

        [OperationContract]
        bool DeleteModel(int id);
        #endregion

        #region .: ProductType :.
        [OperationContract]
        List<ProductTypeViewDto> GetAllProductTypes();

        [OperationContract]
        ProductTypeDto GetProductTypeById(int id);

        [OperationContract]
        ProductTypeDto CreateProductType(ProductTypeDto dto);

        [OperationContract]
        ProductTypeDto SaveProductType(ProductTypeDto dto);

        [OperationContract]
        bool DeleteProductType(int productTypeId);
        #endregion

        #region .: Rating :.

        [OperationContract]
        List<RatingDto> GetAllRatings();

        [OperationContract]
        RatingDto GetRatingById(int id);

        [OperationContract]
        RatingDto GeRatingtByName(string name);

        [OperationContract]
        RatingDto CreateRating(RatingDto dto);

        [OperationContract]
        RatingDto SaveRating(RatingDto dto);

        [OperationContract]
        bool DeleteRating(int id);

        #endregion

        #region .: State :.
        [OperationContract]
        List<StateDto> GetAllStates();

        [OperationContract]
        StateDto GetByStateId(int id);

        [OperationContract]
        StateDto GetStateByName(string name);

        [OperationContract]
        StateDto CreateState(StateDto dto);

        [OperationContract]
        StateDto SaveState(StateDto dto);

        [OperationContract]
        bool DeleteState(int id);

        #endregion

        //#region .: SubCategory1 :.
        //[OperationContract]
        //List<SubCategory1Dto> GetAllSubCategories1();

        //[OperationContract]
        //List<SubCategory1Dto> GetSubCategory1ByCategoryId(int categoryId);

        //[OperationContract]
        //SubCategory1Dto CreateSubCategory1(SubCategory1Dto dto);

        //[OperationContract]
        //SubCategory1Dto SaveSubCategory1(SubCategory1Dto dto);

        //[OperationContract]
        //bool DeleteSubCategory1(int id);

        //#endregion

        //#region .: SubCategory2 :.
        //[OperationContract]
        //List<SubCategory2Dto> GetAllSubCategories2();

        //[OperationContract]
        //List<SubCategory2Dto> GetSubCategory2BySubCategory1Id(int subCategoryId);

        //[OperationContract]
        //SubCategory2Dto CreateSubCategory2(SubCategory2Dto dto);

        //[OperationContract]
        //SubCategory2Dto SaveSubCategory2(SubCategory2Dto dto);

        //[OperationContract]
        //bool DeleteSubCategory2(int id);

        //#endregion

        #region .: SubModel :.
        [OperationContract]
        List<SubModelDto> GetAllSubModels();

        [OperationContract]
        SubModelDto GetSubModelById(int id);

        [OperationContract]
        List<SubModelDto> GetSubModelByModelId(int modelId);

        [OperationContract]
        List<SubModelDto> GetSubModelByModels(List<int> modelIds);

        [OperationContract]
        SubModelDto CreateSubModel(SubModelDto dto);

        [OperationContract]
        SubModelDto SaveSubModel(SubModelDto dto);

        [OperationContract]
        bool DeleteSubModel(int id);

        #endregion

        #region .: CustomerType :.
        [OperationContract]
        List<CustomerTypeDto> GetAllCustomerTypes();

        [OperationContract]
        CustomerTypeDto GetCustomerTypeById(int id);

        [OperationContract]
        CustomerTypeDto GetCustomerTypeByName(string name);

        [OperationContract]
        CustomerTypeDto CreateCustomerType(string name);

        [OperationContract]
        CustomerTypeDto SaveCustomerType(CustomerTypeDto dto);

        [OperationContract]
        bool DeleteCustomerType(CustomerTypeDto dto);

        #endregion

        #region .: Item :.
        [OperationContract]
        List<ItemDto> GetAllItems();

        [OperationContract]
        ItemDto GetItemById(int id);

        [OperationContract]
        ItemDto GetItemByName(string name);

        [OperationContract]
        ItemDto CreateItem(ItemDto dto);

        [OperationContract]
        ItemDto SaveItem(ItemDto dto);

        [OperationContract]
        bool DeleteItem(ItemDto dto);

        #endregion

        #region .: PaperReference :.
        [OperationContract]
        List<PaperReferenceDto> GetAllPaperReferences();

        [OperationContract]
        PaperReferenceDto GetPaperReferenceById(int id);

        [OperationContract]
        PaperReferenceDto GetPaperReferenceByName(string name);

        [OperationContract]
        PaperReferenceDto CreatePaperReference(PaperReferenceDto dto);

        [OperationContract]
        PaperReferenceDto SavePaperReference(PaperReferenceDto dto);

        [OperationContract]
        bool DeletePaperReference(PaperReferenceDto dto);

        #endregion

        #region .: Attachment :.
        [OperationContract]
        List<AttachmentDto> GetAttachmentByProductId(int productId);

        [OperationContract]
        AttachmentDto GetAttachmentById(int id);

        [OperationContract]
        AttachmentDto CreateAttachment(AttachmentDto dto);

        [OperationContract]
        AttachmentDto SaveAttachment(AttachmentDto dto);
        #endregion

        #region .: Customer :.
        [OperationContract]
        CustomerDto GetCustomerById(int id);

        [OperationContract]
        List<CustomerDto> GetAllCustomers();

        [OperationContract]
        List<CustomerUIDto> GetAllCustomersForUI();

        [OperationContract]
        List<CustomerDto> SearchCustomer(string fName, string lName, string email, string mobile, string phone);

        [OperationContract]
        CustomerDto CreateCustomer(CustomerDto dto);

        [OperationContract]
        CustomerDto SaveCustomer(CustomerDto dto);

        #endregion

        #region .: Year :.
        [OperationContract]
        List<YearDto> GetAllYears();

        [OperationContract]
        YearDto GetYearById(int id);

        [OperationContract]
        YearDto CreateYear(YearDto dto);

        [OperationContract]
        YearDto SaveYear(YearDto dto);
        #endregion

        #region .: Product :.
        [OperationContract]
        List<ProductDto> GetAllProducts();

        [OperationContract]
        List<ProductSummaryDto> GetAllProductSummaries();

        [OperationContract]
        List<ProductDto> GetProductByCustomerId(int customerId);

        [OperationContract]
        List<ProductDto> GetProductByOperatorId(int operatorId);

        [OperationContract]
        ProductDto GetProductById(int id);

        [OperationContract]
        ProductDto CreateProduct(ProductDto dto);

        [OperationContract]
        ProductDto SaveProductBasicInfo(ProductDto dto);

        [OperationContract]
        ProductDto SaveProductSelling(ProductDto dto);

        [OperationContract]
        ProductDto SaveProductComplaint(ProductDto dto);

        [OperationContract]
        ProductDto SaveProductReturn(ProductDto dto);

        [OperationContract]
        ProductDto SaveProductReplacement(ProductDto dto);

        [OperationContract]
        ProductDto SaveProductRequest(ProductDto dto);

        [OperationContract]
        ProductDto SaveProductOrdering(ProductDto dto);

        [OperationContract]
        List<ProductViewDto> SearchProduct(string productType, string brand, string category, string model, string item, string state, string[] years, string vin);

        [OperationContract]
        List<ProductViewDto> SearchSellableProducts(string productType, string brand, string category, string model, string item, string state, string[] years, string vin);

        #endregion
    }
}