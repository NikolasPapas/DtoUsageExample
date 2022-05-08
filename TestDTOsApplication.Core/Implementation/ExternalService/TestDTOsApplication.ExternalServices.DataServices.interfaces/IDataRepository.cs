
using TestDTOsApplication.ExternalServices.DataTypes;

namespace TestDTOsApplication.ExternalServices.DataInterfaces
{
    public interface IDataRepository
    {
        Information GetInformationData(string Id);
        ExernalInformation GetExernalInformationData(string Id);
        List<Address> GetResidentialAddressData(string Id);
        List<Address> GetWorkAddressData(string Id);
        List<FinancialInformation> GetFinancialInformationData(string Id);
    }
}
