using TestDTOsApplication.Common.Interfaces;
using TestDTOsApplication.Common.Types;
using TestDTOsApplication.ExternalServices.DataInterfaces;

namespace TestDTOsApplication.ExternalServices.DataServices
{
    public class DataServiseId : IDataServiseId
    {
        private readonly IDataRepository _dataRepository;
        public DataServiseId(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public async Task<List<DataObjectEnum>> GetDataObjectEnumForId(string id)
        {
            var data = _dataRepository.GetInformationData(id);
            if (data == null) return null;

            List<DataObjectEnum> results = new List<DataObjectEnum>();

            if (data.ExernalInformation.ResidentialAddress != null && data.ExernalInformation.ResidentialAddress.Count > 0)
                results.Add(DataObjectEnum.ResidentialAddress);

            if (data.ExernalInformation.WorkAddress != null && data.ExernalInformation.WorkAddress.Count > 0)
                results.Add(DataObjectEnum.WorkAddress);

            if (data.ExernalInformation.FinancialInformation != null && data.ExernalInformation.FinancialInformation.Count > 0)
                results.Add(DataObjectEnum.FinancialInformation);

            return results;
        }
    }
}
