using System;
using TestDTOsApplication.Common.Types.DTOs;
using TestDTOsApplication.ExternalServices.DataTypes;

namespace TestDTOsApplication.ExternalServices.DataServices
{
    public static partial class Extensions
    {
        public static AddressDto ToAddressDto(this Address addres)
        {
            if (addres == null) return null;
            return new AddressDto()
            {
                Street = addres.Street,
                StreetNumber = addres.StreetNumber,
                PostalCode = addres.PostalCode,
                Country = addres.Country
            };
        }
    }
}
