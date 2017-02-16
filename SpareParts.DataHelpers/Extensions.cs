using SpareParts.Dto;
using System;
using System.Collections.Generic;
using SpareParts.Tools;
using System.Data.Objects.DataClasses;
using System.Linq;


namespace SpareParts.DataHelpers
{
    public static class Extensions
    {
        #region .: Profile :.
        public static ProfileDto ToDto(this DataAccess.Models.Profile item)
        {
            ProfileDto dto = null;

            if (item != null)
            {
                dto = new ProfileDto
                {
                    Id = item.Id,
                    Name = item.Name
                };
            }

            return dto;
        }

        public static List<ProfileDto> ToDto(this List<DataAccess.Models.Profile> collection)
        {
            var dtos = new List<ProfileDto>();

            if (collection != null)
            {
                collection.ForEach(c => dtos.Add(c.ToDto()));
            }

            return dtos;
        }
        #endregion

        //#region .: Group :.
        //public static GroupDto ToDto(this DataAccess.Models.Group item)
        //{
        //    GroupDto dto = null;

        //    if (item != null)
        //    {
        //        dto = new GroupDto()
        //        {
        //            Id = item.Id,
        //            Name = item.Name
        //        };
        //    }

        //    return dto;
        //}

        //public static List<GroupDto> ToDto(this List<DataAccess.Models.Group> collection)
        //{
        //    List<GroupDto> dtos = new List<GroupDto>();

        //    if (collection != null)
        //    {
        //        collection.ForEach(c => dtos.Add(c.ToDto()));
        //    }

        //    return dtos;
        //}
        //#endregion

        #region .: User :.
        public static UserDto ToDto(this DataAccess.Models.User item)
        {
            UserDto dto = null;

            if (item != null)
            {
                dto = new UserDto
                {
                    Id = item.Id,
                    UserName = item.UserName,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Email = item.Email,
                    Mobile = item.Mobile,
                    Profile = item.Profile.ToDto(),
                    Password = string.Empty
                };
            }

            return dto;
        }

        public static List<UserDto> ToDto(this List<DataAccess.Models.User> collection)
        {
            var dtos = new List<UserDto>();

            if (collection != null)
            {
                collection.ForEach(c => dtos.Add(c.ToDto()));
            }

            return dtos;
        }

        public static UserUIDto ToUIDto(this DataAccess.Models.User item)
        {
            UserUIDto dto = null;

            if (item != null)
            {
                dto = new UserUIDto
                {
                    Id = item.Id,
                    UserName = item.UserName,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Email = item.Email,
                    Mobile = item.Mobile,
                    Profile = item.Profile.Name,
                    Password = string.Empty,
                    Enabled = item.Enabled
                };
            }

            return dto;
        }

        public static List<UserUIDto> ToUIDto(this List<DataAccess.Models.User> collection)
        {
            var dtos = new List<UserUIDto>();

            if (collection != null)
            {
                collection.ForEach(c => dtos.Add(c.ToUIDto()));
            }

            return dtos;
        }
        #endregion

        #region .: BasicDto :.
        public static TDto ToBasic<TEntity, TDto>(this TEntity item)
            where TDto : class, IBasicDto
            where TEntity : System.Data.Objects.DataClasses.EntityObject
        {
            TDto dto = null;

            if (item != null)
            {
                dto = Activator.CreateInstance<TDto>();
                dto.Name = item.GetType().GetProperty("Name").GetValue(item).ToString();
                dto.Id = Convert.ToInt32(item.GetType().GetProperty("Id").GetValue(item));
            }

            return dto;
        }

        public static List<TDto> ToBasic<TEntity, TDto>(this List<TEntity> collection)
            where TDto : class, IBasicDto
            where TEntity : System.Data.Objects.DataClasses.EntityObject
        {
            var dtos = Activator.CreateInstance<List<TDto>>();

            if (collection != null)
            {
                collection.ForEach(c => dtos.Add(c.ToBasic<TEntity, TDto>()));
            }

            return dtos;
        }

        public static BasicDto ToBasicDto<T>(this T item)
            where T : System.Data.Objects.DataClasses.EntityObject
        {
            BasicDto dto = null;

            if (item != null)
            {
                dto = new BasicDto();

                foreach (var prop in typeof(T).GetProperties())
                {
                    if (prop.Name.Equals("Name"))
                    {
                        dto.Name = prop.GetValue(item).ToString();
                    }

                    if (prop.Name.Equals("Id"))
                    {
                        dto.Id = Convert.ToInt32(prop.GetValue(item));
                    }
                }
            }

            return dto;
        }

        public static IEnumerable<BasicDto> ToBasicDto<T>(this EntityCollection<T> collection)
            where T : System.Data.Objects.DataClasses.EntityObject
        {
            var dtos = new List<BasicDto>();

            if (collection != null)
            {
                foreach (var item in collection)
                {
                    dtos.Add(item.ToBasicDto());
                }
            }

            return dtos;
        }

        #endregion

        #region .: Attachment :.
        public static AttachmentDto ToDto(this DataAccess.Models.Attachment item)
        {
            AttachmentDto dto = null;

            if (item != null)
            {
                dto = new AttachmentDto
                {
                    Id = item.Id,
                    FileName = item.FileName,
                    Extension = item.Extension,
                    MimeType = item.MimeType,
                    Content = item.Content,
                    Product = item.Product.ToDto()
                };
            }

            return dto;
        }

        public static List<AttachmentDto> ToDto(this List<DataAccess.Models.Attachment> collection)
        {
            var dtos = new List<AttachmentDto>();

            if (collection != null)
            {
                collection.ForEach(c => dtos.Add(c.ToDto()));
            }

            return dtos;
        }
        #endregion

        #region .: Customer :.
        public static CustomerDto ToDto(this DataAccess.Models.Customer item)
        {
            CustomerDto dto = null;

            if (item != null)
            {
                dto = new CustomerDto
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Mobile = item.Mobile,
                    Phone = item.Phone,
                    Email = item.Email,
                    CustomerType = item.CustomerType.ToBasic<DataAccess.Models.CustomerType, CustomerTypeDto>()
                };
            }

            return dto;
        }

        public static List<CustomerDto> ToDto(this List<DataAccess.Models.Customer> collection)
        {
            var dtos = new List<CustomerDto>();

            if (collection != null)
            {
                collection.ForEach(c => dtos.Add(c.ToDto()));
            }

            return dtos;
        }

        public static CustomerUIDto ToUIDto(this DataAccess.Models.Customer item)
        {
            CustomerUIDto dto = null;

            if (item != null)
            {
                item = new DataAccess.Models.Customer
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName
                };
            }

            return dto;
        }

        public static List<CustomerUIDto> ToUIDto(this List<DataAccess.Models.Customer> collection)
        {
            var dtos = new List<CustomerUIDto>();

            if (collection != null)
            {
                collection.ForEach(c => dtos.Add(c.ToUIDto()));
            }

            return dtos;
        }
        #endregion

        #region .: Operator :.
        public static OperatorDto ToDto(this DataAccess.Models.Operator item)
        {
            OperatorDto dto = null;

            if (item != null)
            {
                dto = new OperatorDto
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Mobile = item.Mobile,
                    Email = item.Email
                };
            }

            return dto;
        }

        public static List<OperatorDto> ToDto(this List<DataAccess.Models.Operator> collection)
        {
            var dtos = new List<OperatorDto>();

            if (collection != null)
            {
                collection.ForEach(c => dtos.Add(c.ToDto()));
            }

            return dtos;
        }
        #endregion

        #region .: Location :.
        //public static LocationDto ToDto(this DataAccess.Models.Location item)
        //{
        //    LocationDto dto = null;

        //    if (item != null)
        //    {
        //        dto = new LocationDto
        //        {
        //            Id = item.Id,
        //            Name = item.Name,
        //            City = item.City.ToBasicDto() as CityDto
        //        };
        //    }

        //    return dto;
        //}

        //public static List<LocationDto> ToDto(this List<DataAccess.Models.Location> collection)
        //{
        //    var dtos = new List<LocationDto>();

        //    if (collection != null)
        //    {
        //        collection.ForEach(c => dtos.Add(c.ToDto()));
        //    }

        //    return dtos;
        //}

        public static LocationViewDto ToDto(this DataAccess.Models.LocationView item)
        {
            LocationViewDto dto = null;

            if (item != null)
            {
                dto = new LocationViewDto
                {
                    Id = item.Id,
                    Location = item.Location
                };
            }

            return dto;
        }

        public static List<LocationViewDto> ToDto(this List<DataAccess.Models.LocationView> collection)
        {
            var dtos = new List<LocationViewDto>();

            if (collection != null)
            {
                collection.ForEach(l => dtos.Add(l.ToDto()));
            }

            return dtos;
        }
        #endregion

        #region .: Rating :.
        public static RatingDto ToDto(this DataAccess.Models.Rating item)
        {
            RatingDto dto = null;

            if (item != null)
            {
                dto = new RatingDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Amount = item.Amount
                };
            }

            return dto;
        }

        public static List<RatingDto> ToDto(this List<DataAccess.Models.Rating> collection)
        {
            var dtos = new List<RatingDto>();

            if (collection != null)
            {
                collection.ForEach(c => dtos.Add(c.ToDto()));
            }

            return dtos;
        }
        #endregion

        #region .: SubModel :.
        public static SubModelDto ToDto(this DataAccess.Models.SubModel item)
        {
            SubModelDto dto = null;

            if (item != null)
            {
                dto = new SubModelDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Models = new List<ModelDto>()
                };
            }

            if (item.Model != null)
            {
                foreach (var model in item.Model)
                {
                    dto.Models.Add(new ModelDto { Id = model.Id, Name = model.Name });
                }
            }

            return dto;
        }

        public static List<SubModelDto> ToDto(this List<DataAccess.Models.SubModel> collection)
        {
            var dtos = new List<SubModelDto>();

            if (collection != null)
            {
                collection.ForEach(c => dtos.Add(c.ToDto()));
            }

            return dtos;
        }
        #endregion

        #region .: State :.
        public static StateDto ToDto(this DataAccess.Models.State item)
        {
            StateDto dto = null;

            if (item != null)
            {
                dto = new StateDto
                {
                    Id = item.Id,
                    Name = item.Name
                };
            }

            return dto;
        }

        public static List<StateDto> ToDto(this List<DataAccess.Models.State> collection)
        {
            var dtos = new List<StateDto>();

            if (collection != null)
            {
                collection.ForEach(c => dtos.Add(c.ToDto()));
            }

            return dtos;
        }
        #endregion

        #region .: Brand :.
        public static BrandDto ToDto(this DataAccess.Models.Brand item)
        {
            BrandDto dto = null;

            if (item != null)
            {
                dto = new BrandDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Models = new List<ModelDto>(),
                    ProductType = new List<ProductTypeDto>()
                };

                //foreach (var model in item.Model)
                //{
                //    dto.Models.Add(new ModelDto { Id = model.Id, Name = model.Name });
                //}
            }

            return dto;
        }

        public static List<BrandDto> ToDto(this List<DataAccess.Models.Brand> collection)
        {
            var dtos = new List<BrandDto>();

            if (collection != null)
            {
                collection.ForEach(b => dtos.Add(b.ToDto()));
            }

            return dtos;
        }

        #endregion

        #region .: BrandView / BrandViewForUI :.
        public static BrandViewForUIDto ToDto(this DataAccess.Models.BrandViewForUI item)
        {
            BrandViewForUIDto dto = null;

            if (item != null)
            {
                dto = new BrandViewForUIDto
                {
                    BrandId = item.BrandId,
                    Brand = item.Brand,
                    ProductTypeId = item.ProductTypeId,
                    ProductType = item.ProductType,
                    Models = item.Models
                };
            }

            return dto;
        }

        public static List<BrandViewForUIDto> ToDto(this List<DataAccess.Models.BrandViewForUI> collection)
        {
            var dtos = new List<BrandViewForUIDto>();

            if (collection != null)
            {
                collection.ForEach(b => dtos.Add(b.ToDto()));
            }

            return dtos;
        }
        #endregion

        #region .: Product Type :.
        public static ProductTypeDto ToDto(this DataAccess.Models.ProductType item)
        {
            ProductTypeDto dto = null;

            if (item != null)
            {
                dto = new ProductTypeDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Brands = item.Brand == null ? null : item.Brand.ToBasicDto() as List<BrandDto>,
                    Categories = item.Category != null ? item.Category.ToBasicDto() as List<CategoryDto> : null
                };
            }

            return dto;
        }

        public static List<ProductTypeDto> ToDto(this List<DataAccess.Models.ProductType> collection)
        {
            var dtos = new List<ProductTypeDto>();

            if (collection != null)
            {
                collection.ForEach(p => dtos.Add(p.ToDto()));
            }

            return dtos;
        }

        public static ProductTypeViewDto ToDto(this DataAccess.Models.ProductTypeView item)
        {
            ProductTypeViewDto dto = null;

            if (item != null)
            {
                dto = new ProductTypeViewDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Categories = item.Categories,
                    Brands = item.Brands
                };
            }

            return dto;
        }

        public static List<ProductTypeViewDto> ToDto(this List<DataAccess.Models.ProductTypeView> collection)
        {
            var dtos = new List<ProductTypeViewDto>();

            if (collection != null)
            {
                collection.ForEach(c => dtos.Add(c.ToDto()));
            }

            return dtos;
        }
        #endregion

        #region .: Model / SubModel :.
        public static ModelDto ToDto(this DataAccess.Models.Model item)
        {
            ModelDto dto = null;

            if (item != null)
            {
                dto = new ModelDto { Id = item.Id, Name = item.Name };
                dto.Brands = new List<BrandDto>();
                //dto.Brands = item.Brand != null ? item.Brand.ToList().ToDto() : new List<BrandDto>();
                //item.Brand.ToList().ForEach(b => dto.Brands.Add(new BrandDto { Id = b.Id, Name = b.Name }));
                //dto.SubModels = new List<SubModelDto>();

                //foreach (var subModel in item.SubModel)
                //{
                //    dto.SubModels.Add(new SubModelDto { Id = subModel.Id, Name = subModel.Name });
                //}
            }

            return dto;
        }

        public static List<ModelDto> ToDto(this List<DataAccess.Models.Model> collection)
        {
            var dtos = new List<ModelDto>();

            if (collection != null)
            {
                collection.ForEach(m => dtos.Add(m.ToDto()));
            }

            return dtos;
        }

        public static ModelViewDto ToDto(this DataAccess.Models.ModelView item)
        {
            var dto = new ModelViewDto();

            if (item != null)
            {
                dto = new ModelViewDto
                {
                    Id = item.Id,
                    Model = item.Model,
                    SubModel = item.SubModel,
                    SubModelId = item.SubModelId
                };
            }

            return dto;
        }

        public static List<ModelViewDto> ToDto(this List<DataAccess.Models.ModelView> collection)
        {
            var dtos = new List<ModelViewDto>();

            if (collection != null)
            {
                collection.ForEach(m => dtos.Add(m.ToDto()));
            }

            return dtos;
        }
        #endregion

        #region .: Category :.
        public static CategoryDto ToDto(this DataAccess.Models.Category item)
        {
            CategoryDto dto = null;

            if (item != null)
            {
                dto = new CategoryDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    ProductType = new List<ProductTypeDto>(),
                    IsActive = item.IsActive
                };
            }

            return dto;
        }

        public static ProductTypeDto ToAdminDto(this DataAccess.Models.ProductType item)
        {
            ProductTypeDto dto = null;

            if (item != null)
            {
                dto = new ProductTypeDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Brands = new List<BrandDto>(),
                    Categories = new List<CategoryDto>()
                };

                item.Brand.ToList().ForEach(b => dto.Brands.Add(new BrandDto { Id = b.Id, Name = b.Name }));
                item.Category.ToList().ForEach(c => dto.Categories.Add(new CategoryDto { Id = c.Id, Name = c.Name }));
            }

            return dto;
        }

        public static List<ProductTypeDto> ToAdminDto(this List<DataAccess.Models.ProductType> collection)
        {
            var dtos = new List<ProductTypeDto>();

            if (collection != null)
            {
                collection.ForEach(c => dtos.Add(c.ToAdminDto()));
            }

            return dtos;
        }

        public static List<CategoryDto> ToDto(this List<DataAccess.Models.Category> collection)
        {
            var dtos = new List<CategoryDto>();

            if (collection != null)
            {
                collection.ForEach(c => dtos.Add(c.ToDto()));
            }

            return dtos;
        }

        public static CategoryViewDto ToDto(this DataAccess.Models.CategoryView item)
        {
            CategoryViewDto dto = null;

            if (item != null)
            {
                dto = new CategoryViewDto
                {
                    Id = item.Id,
                    Category = item.Category,
                    SubCategory1 = item.SubCategory1,
                    SubCategory2 = item.SubCategory2,
                    SubCategory1Id = item.SubCategory1Id,
                    SubCategory2Id = item.SubCategory2Id,
                    ParentId = item.ParentId,
                    SubCategory1ParentId = item.SubCategory1ParentId,
                    SubCategory2ParentId = item.SubCategory2ParentId
                };
            }

            return dto;
        }

        public static List<CategoryViewDto> ToDto(this List<DataAccess.Models.CategoryView> collection)
        {
            var dtos = new List<CategoryViewDto>();

            if (collection != null)
            {
                collection.ForEach(c => dtos.Add(c.ToDto()));
            }

            return dtos;
        }

        #endregion

        #region .: Country :.
        public static CountryDto ToDto(this DataAccess.Models.Country item)
        {
            CountryDto dto = null;

            if (item != null)
            {
                dto = item.ToBasicDto() as CountryDto;
                dto.Cities = item.City.ToBasicDto() as List<CityDto>;
            }

            return dto;
        }

        public static List<CountryDto> ToDto(this List<DataAccess.Models.Country> collection)
        {
            var dtos = new List<CountryDto>();

            if (collection != null)
            {
                collection.ForEach(c => dtos.Add(c.ToDto()));
            }

            return dtos;
        }

        public static CountryUIDto ToUIDto(this DataAccess.Models.Country item)
        {
            CountryUIDto dto = null;

            if (item != null)
            {
                dto = new CountryUIDto { Id = item.Id, Name = item.Name };
            }

            return dto;
        }

        public static List<CountryUIDto> ToUIDto(this List<DataAccess.Models.Country> collection)
        {
            var dtos = new List<CountryUIDto>();

            if (collection != null)
            {
                collection.ForEach(c => dtos.Add(c.ToUIDto()));
            }

            return dtos.OrderBy(c => c.Name).ToList();
        }
        #endregion

        #region .: City :.
        public static CityDto ToDto(this DataAccess.Models.City item)
        {
            CityDto dto = null;

            if (item != null)
            {
                dto = item.ToBasicDto() as CityDto;
            }

            return dto;
        }

        public static List<CityDto> ToDto(this List<DataAccess.Models.City> collection)
        {
            var dtos = new List<CityDto>();

            if (collection != null)
            {
                collection.ForEach(c => dtos.Add(c.ToDto()));
            }

            return dtos;
        }

        public static CityUIDto ToUIDto(this DataAccess.Models.City item)
        {
            CityUIDto dto = null;

            if (item != null)
            {
                dto = new CityUIDto { Id = item.Id, CityName = item.Name, CountryId = item.CountryId, CountryName = item.Country.Name };
            }

            return dto;
        }

        public static List<CityUIDto> ToUIDto(this List<DataAccess.Models.City> collection)
        {
            var dtos = new List<CityUIDto>();

            if (collection != null)
            {
                collection.ForEach(c => dtos.Add(c.ToUIDto()));
            }

            return dtos.OrderBy(c => c.CountryName).ThenBy(c => c.CityName).ToList();
        }
        #endregion

        //#region .: SubCategory1 :.
        //public static SubCategory1Dto ToDto(this DataAccess.Models.SubCategory1 item)
        //{
        //    SubCategory1Dto dto = null;

        //    if (item != null)
        //    {
        //        dto = new SubCategory1Dto
        //        {
        //            Id = item.Id,
        //            Name = item.Name,
        //            Category = new CategoryDto(),
        //            SubCategories2 = new List<SubCategory2Dto>()
        //        };
        //    }

        //    if (item.Category != null)
        //    {
        //        dto.Category.Id = item.Category.Id;
        //        dto.Category.Name = item.Category.Name;
        //    }

        //    return dto;
        //}

        //public static List<SubCategory1Dto> ToDto(this List<DataAccess.Models.SubCategory1> collection)
        //{
        //    var dtos = new List<SubCategory1Dto>();

        //    if (collection != null)
        //    {
        //        collection.ForEach(s => dtos.Add(s.ToDto()));
        //    }

        //    return dtos;
        //}

        //public static SubCategory1FlatDto ToFlatDto(this DataAccess.Models.SubCategory1 item)
        //{
        //    SubCategory1FlatDto dto = null;

        //    if (item != null)
        //    {
        //        dto = new SubCategory1FlatDto
        //        {
        //            Id = item.Id,
        //            Name = item.Name
        //        };

        //        if (item.Category != null)
        //        {
        //            dto.CategoryId = item.Category.Id;
        //            dto.CategoryName = item.Category.Name;
        //        }
        //    }

        //    return dto;
        //}

        //public static List<SubCategory1FlatDto> ToFlatDto(this List<DataAccess.Models.SubCategory1> collection)
        //{
        //    var dtos = new List<SubCategory1FlatDto>();

        //    if (collection != null)
        //    {
        //        collection.ForEach(c => dtos.Add(c.ToFlatDto()));
        //    }

        //    return dtos;
        //}
        //#endregion

        //#region .: SubCategory2 :.
        //public static SubCategory2Dto ToDto(this DataAccess.Models.SubCategory2 item)
        //{
        //    SubCategory2Dto dto = null;

        //    if (item != null)
        //    {
        //        dto = new SubCategory2Dto
        //        {
        //            Id = item.Id,
        //            Name = item.Name,
        //            SubCategory1 = new SubCategory1Dto { Id = item.SubCategory1Id, Name = item.SubCategory1.Name }
        //        };
        //    }

        //    if (item.SubCategory1 != null)
        //    {
        //        item.SubCategory1.Id = item.SubCategory1.Id;
        //        item.SubCategory1.Name = item.SubCategory1.Name;
        //    }

        //    return dto;
        //}

        //public static List<SubCategory2Dto> ToDto(this List<DataAccess.Models.SubCategory2> collection)
        //{
        //    var dtos = new List<SubCategory2Dto>();

        //    if (collection != null)
        //    {
        //        collection.ForEach(s => dtos.Add(s.ToDto()));
        //    }

        //    return dtos;
        //}
        //#endregion

        #region .: Year :.
        public static YearDto ToDto(this DataAccess.Models.Year item)
        {
            YearDto dto = null;

            if (item != null)
            {
                dto = new YearDto
                {
                    Id = item.Id,
                    Year = item.Year1.HasValue ? item.Year1.Value : Convert.ToInt16(0)
                };
            }

            return dto;
        }

        public static List<YearDto> ToDto(this List<DataAccess.Models.Year> collection)
        {
            var dtos = new List<YearDto>();

            if (collection != null)
            {
                collection.ForEach(c => dtos.Add(c.ToDto()));
            }

            return dtos;
        }
        #endregion

        #region .: Product :.
        public static ProductDto ToDto(this DataAccess.Models.Product item)
        {
            ProductDto dto = null;

            if (item != null)
            {
                dto = new ProductDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    DepositBuyDate = item.DepositBuyDate,
                    BuyingPrice = item.BuyingPrice.HasValue ? item.BuyingPrice.Value : 0.0m,
                    Item = item.Item.ToBasicDto() as ItemDto,
                    ProductType = item.ProductType.ToBasicDto() as ProductTypeDto,
                    PaperReference = item.PaperReference.ToBasicDto() as PaperReferenceDto,
                    City = item.City.ToDto(),
                    StockLocation = item.StockLocation,
                    Rating = item.Rating.ToDto(),
                    Customer = item.Customer.ToDto(),
                    Operator = item.CreateOperator.ToDto(),
                    Brands = item.Brands.ToList().ToDto(),
                    Categories = item.Categories.ToList().ToDto(),
                    Models = item.Models.ToList().ToDto(),
                    Sold = item.Sold,
                    SellingPrice = item.SellPrice.HasValue ? item.SellPrice.Value : 0.0m,
                    SellingOperator = item.SellingOperator.ToDto(),
                    State = item.State.ToDto(),
                    Buyer = item.ProductBuyer.ToDto(),
                    Mecanic = item.Mecanic.HasValue && item.Mecanic.Value,
                    SellingDate = item.SellingDate.HasValue ? item.SellingDate.Value : Constants.DEFAULT_DATE,
                    CardIdentificationNumber = item.CarIdentificationNumber,
                    HasComplaint = item.HasComplaint.HasValue && item.HasComplaint.Value,
                    ComplaintOperator = item.ComplaintOperator.ToDto(),
                    ComplaintDate = item.ComplaintDate.HasValue ? item.ComplaintDate.Value : Constants.DEFAULT_DATE,
                    IsReturn = item.IsReturn.HasValue && item.IsReturn.Value,
                    ReturnDate = item.ReturnDate.HasValue ? item.ReturnDate.Value : Constants.DEFAULT_DATE,
                    ReturnOperator = item.ReturnOperator.ToDto(),
                    IsReplace = item.IsReplace.HasValue && item.IsReplace.Value,
                    ReplacementOperator = item.ReplaceOperator.ToDto(),
                    ReplaceDate = item.ReplaceDate.HasValue ? item.ReplaceDate.Value : Constants.DEFAULT_DATE,
                    ReplaceProductId = item.ReplacedProductId.HasValue ? item.ReplacedProductId.Value : 0,
                    IsReimbursed = item.IsReimbursed.HasValue && item.IsReimbursed.Value,
                    IsAvailable = item.IsAvailable.HasValue && item.IsAvailable.Value,
                    RequestNumber = item.RequestNumber,
                    RequestDate = item.RequestDate.HasValue ? item.RequestDate.Value : Constants.DEFAULT_DATE,
                    RequestOperator = item.RequestOperator.ToDto(),
                    HasOrder = item.HasOrder.HasValue && item.HasOrder.Value,
                    OrderNumber = item.OrderNumber,
                    OrderDate = item.OrderDate.HasValue ? item.OrderDate.Value : Constants.DEFAULT_DATE,
                    OrderOperator = item.OrderOperator.ToDto(),
                    OrderCustomer = item.OrderCustomer.ToDto(),
                    OrderSellingPrice = item.OrderSellingPrice.HasValue ? item.OrderSellingPrice.Value : 0.0m,
                    AdvancePaymentAmount = item.AdvancePaymentAmount.HasValue ? item.AdvancePaymentAmount.Value : 0.0m,
                    EstimatedDeliveryDate = item.EstimatedDeliveryDate.HasValue ? item.EstimatedDeliveryDate.Value : Constants.DEFAULT_DATE,
                    FinalDate = item.FinalDate.HasValue ? item.FinalDate.Value : Constants.DEFAULT_DATE,
                    BalanceAmount = item.BalanceAmount.HasValue ? item.BalanceAmount.Value : 0.0m
                };
            }

            return dto;
        }

        public static List<ProductDto> ToDto(this List<DataAccess.Models.Product> collection)
        {
            var dtos = new List<ProductDto>();

            if (collection != null)
            {
                collection.ForEach(c => dtos.Add(c.ToDto()));
            }

            return dtos;

        }
        #endregion

        #region .: ProductView :.
        public static ProductViewDto ToDto(this DataAccess.Models.ProductView item)
        {
            ProductViewDto dto = null;

            if (item != null)
            {
                dto = new Dto.ProductViewDto
                {
                    ProductId = item.ProductId,
                    ProductName = item.ProductName,
                    SellPrice = item.SellPrice,
                    BuyingPrice = item.BuyingPrice,
                    Brand = item.Brand,
                    Country = item.Country,
                    City = item.City,
                    Model = item.Model,
                    Category = item.Category,
                    Item = item.Item,
                    ProductType = item.ProductType,
                    VIN = item.VIN,
                    Years = item.Years,
                    Sold = item.Sold,
                    IsReimbursed = item.IsReimbursed,
                    IsReplace = item.IsReplace,
                    IsReturn = item.IsReturn,
                    HasOrder = item.HasOrder,
                    Status = item.Status,
                    StatusName = item.StatusName
                };
            }

            return dto;
        }

        public static List<ProductViewDto> ToDto(this List<DataAccess.Models.ProductView> collection)
        {
            var dtos = new List<ProductViewDto>();

            if (collection != null)
            {
                collection.ForEach(c => dtos.Add(c.ToDto()));
            }

            return dtos;
        }

        public static ProductSummaryDto ToSummary(this ProductViewDto item)
        {
            ProductSummaryDto dto = null;

            if (item != null)
            {
                dto = new ProductSummaryDto
                {
                    ProductId = item.ProductId,
                    Product = string.Format("{0} - {1} - {2} - {3}", item.ProductType, item.Brand, item.Model, item.Category)
                };
            }

            return dto;
        }

        public static List<ProductSummaryDto> ToSummary(this List<ProductViewDto> collection)
        {
            var dtos = new List<ProductSummaryDto>();

            if (collection != null)
            {
                collection.ForEach(c => dtos.Add(c.ToSummary()));
            }

            return dtos;
        }
       #endregion
    }
}