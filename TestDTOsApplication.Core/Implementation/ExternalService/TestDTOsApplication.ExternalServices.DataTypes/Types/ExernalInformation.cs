

namespace TestDTOsApplication.ExternalServices.DataTypes
{
    public class ExernalInformation
    {
        public List<Address> ResidentialAddress { get; set; }
        public List<Address> WorkAddress { get; set; }
        public List<FinancialInformation> FinancialInformation { get; set; }
    }
}
