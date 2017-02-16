using System.Collections.Generic;

namespace SpareParts.Dto
{
    public class SubCategory1Dto : BasicDto
    {
        public List<SubCategory2Dto> SubCategories2 { get; set; }

        public CategoryDto Category { get; set; }
    }
}