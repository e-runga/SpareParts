using System.Collections.Generic;

namespace SpareParts.Dto
{
    public class CategoryDto : BasicDto
    {
        public List<ProductTypeDto> ProductType { get; set; }

        public int? ParentId { get; set; }

        public string Parent { get; set; }

        public bool IsActive { get; set; }
    }
}