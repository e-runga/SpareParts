using System.Collections.Generic;

namespace SpareParts.Dto
{
    public class ProductTypeDto : BasicDto
    {
        public List<BrandDto> Brands { get; set; }

        public List<CategoryDto> Categories { get; set; }
    }
}