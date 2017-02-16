using System.Collections.Generic;

namespace SpareParts.Dto
{
    public class CountryDto : BasicDto
    {
        public List<CityDto> Cities { get; set; }
    }
}