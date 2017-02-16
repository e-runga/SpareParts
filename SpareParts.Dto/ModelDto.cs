using System.Collections.Generic;

namespace SpareParts.Dto
{
    public class ModelDto : BasicDto
    {
        public List<BrandDto> Brands { get; set; }

        public List<SubModelDto> SubModels { get; set; }
    }
}