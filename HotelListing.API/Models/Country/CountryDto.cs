using HotelListing.API.Models.Hotels;

namespace HotelListing.API.Models.Country
{
    public class CountryDto : BaseCountryDto
    {

        public string Id { get; set; }

        public List<HotelDto> Hotels { get; set; }

    }
}
