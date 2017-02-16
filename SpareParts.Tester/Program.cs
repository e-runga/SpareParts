using SpareParts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpareParts.Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateProfiles();
            //CreateUser();
            //Authenticate();
            //GetAllBrands();
            //CreateOperator();
            //CreateState();
            //CreateCategories();
            //CreateProductType();
            //CreateBrands();
            //FillYears();
            //GetAllProductTypes();
        }

        private static void CreateUser()
        {
            var client = new DataServiceClient.DataServiceClient();

            var profile = client.GetProfileByName("Administrator");
            var passw = SpareParts.Tools.Encryption.TripleDESHelper.Encrypt("Kig@li1");

            var user = new UserDto
            {
                Id = 0,
                UserName = "pha",
                FirstName = "Patrick",
                LastName = "Hatungimana",
                Email = "pha@erunga.net",
                Mobile = "+32477454769",
                Password = passw,
                Profile = profile
            };

            var newUser = client.CreateUser(user);
        }

        private static void CreateOperator()
        {
            var client = new DataServiceClient.DataServiceClient();

            var profile = client.GetProfileByName("Operator");
            var passw = SpareParts.Tools.Encryption.TripleDESHelper.Encrypt("Op3rat0r");

            var user = new UserDto
            {
                Id = 0,
                UserName = "Operator",
                FirstName = "OP",
                LastName = "1",
                Email = "op1@test.com",
                Mobile = "+32444556677",
                Password = passw,
                Profile = profile
            };

            var newUser = client.CreateUser(user);
        }


        private static void CreateProfiles()
        {
            var client = new DataServiceClient.DataServiceClient();

            var profile1 = new ProfileDto
            {
                Id = 0,
                Name = "Administrator"
            };

            var profile2 = new ProfileDto
            {
                Id = 0,
                Name = "Operator"
            };

            var profile3 = new ProfileDto
            {
                Id = 0,
                Name = "Customer"
            };

            client.SaveProfile(profile1);
            client.SaveProfile(profile2);
            client.SaveProfile(profile3);
        }

        private static void Authenticate()
        {
            var client = new DataServiceClient.DataServiceClient();
            string username = "pha";
            string passw = "Kig@li1";
            var encryptedPassw = Tools.Encryption.TripleDESHelper.Encrypt(passw);
            var authenticate = client.Authenticate(username, encryptedPassw);

            if (authenticate)
            {
                Console.WriteLine("Authenticated !");
            }
            else
            {
                Console.WriteLine("Authentication failed !!");
            }
        }

        private static void GetAllBrands()
        {
            var client = new DataServiceClient.DataServiceClient();
            var brands = client.GetAllBrands();
            foreach (var brand in brands)
            {
                Console.WriteLine("Brand: " + brand.Name);
            }
        }

        private static void CreateProductType()
        {
            var client = new DataServiceClient.DataServiceClient();
            var productTypes = new List<ProductTypeDto>();

            productTypes.Add(new ProductTypeDto { Name = "Lift" });
            productTypes.Add(new ProductTypeDto { Name = "Automobile" });
            productTypes.Add(new ProductTypeDto { Name = "Trucks" });
            productTypes.Add(new ProductTypeDto { Name = "Generator" });

            foreach (var item in productTypes)
            {
                var res = client.CreateProductType(item);
            }
        }

        private static void CreateCategories()
        {
            var client = new DataServiceClient.DataServiceClient();
            var categories = new List<CategoryDto>();
            categories.Add(new CategoryDto { Name = "Batteries" });
            categories.Add(new CategoryDto { Name = "Air Conditioning" });
            categories.Add(new CategoryDto { Name = "Brake disk" });
            categories.Add(new CategoryDto { Name = "Shock absorber" });
            categories.Add(new CategoryDto { Name = "Brake pad" });
            foreach (var item in categories)
            {
                var res = client.CreateCategory(item);
            }
        }

        private static void CreateBrands()
        {
            var client = new DataServiceClient.DataServiceClient();
            var brands = new List<BrandDto>();
            brands.Add(new BrandDto { Name = "Ford" });
            brands.Add(new BrandDto { Name = "Toyot" });
            brands.Add(new BrandDto { Name = "Mazda" });
            brands.Add(new BrandDto { Name = "Volkswagen" });
            brands.Add(new BrandDto { Name = "Mercedes" });

            foreach (var item in brands)
            {
                var res = client.CreateBrand(item);
            }
        }

        private static void CreateState()
        {
            var client = new DataServiceClient.DataServiceClient();
            var states = new List<StateDto>();
            states.Add(new StateDto { Name = "New" });
            states.Add(new StateDto { Name = "Used" });

            foreach (var item in states)
            {
                var res = client.CreateState(item);
            }
        }

        private static void FillYears()
        {
            var client = new DataServiceClient.DataServiceClient();

            for (short i = 1990; i < 2017; i++)
            {
                client.CreateYear(new YearDto { Year = i });
            }
        }

        private static void GetAllProductTypes()
        {
            var client = new DataServiceClient.DataServiceClient();

            var productTypes = client.GetAllProductTypes();
            foreach (var item in productTypes)
            {
                Console.WriteLine("Product Type: " + item.Name);
            }

            Console.ReadLine();
        }
    }
}
