

namespace TestDTOsApplication.ExternalServices.DataTypes
{
    public class Address : Base
    {
        public bool Active { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}
