

namespace TestDTOsApplication.ExternalServices.DataTypes
{
    public class FinancialInformation : Base
    {
        public bool Active { get; set; }
        public string Year { get; set; }
        public float Income { get; set; }
        public float Assets { get; set; }
    }
}
