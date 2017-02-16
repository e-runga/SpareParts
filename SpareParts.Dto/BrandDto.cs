using System.Collections.Generic;

namespace SpareParts.Dto
{
    public class BrandDto : BasicDto
    {
        public List<ModelDto> Models { get; set; }

        public List<ProductTypeDto> ProductType { get; set; }
    }
}