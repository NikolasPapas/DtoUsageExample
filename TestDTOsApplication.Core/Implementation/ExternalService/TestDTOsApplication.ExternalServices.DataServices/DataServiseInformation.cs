using TestDTOsApplication.Common.Interfaces;
using TestDTOsApplication.Common.Types;
using TestDTOsApplication.ExternalServices.DataInterfaces;

namespace TestDTOsApplication.ExternalServices.DataServices
{
    public class DataServiseInformation : IDataServiseInformation
    {
        private readonly IDataRepository _dataRepository;
        private Dictionary<DataObjectEnum, Func<string, object>> _TypeToData;
        private Dictionary<DataObjectEnum, Func<string, object>> TypeToData
        {
            get => _TypeToData != null ? _TypeToData : _TypeToData = new Dictionary<DataObjectEnum, Func<string, object>>()
                    {
                        { DataObjectEnum.StringData, GetStringData},
                        { DataObjectEnum.ResidentialAddress, GetResidentialAddress},
                        { DataObjectEnum.WorkAddress, GetWorkAddress},
                        { DataObjectEnum.FinancialInformation, GetFinancialInformation},
                    };
        }

        public DataServiseInformation(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public async Task<object> GetInformationForType(string id, DataObjectEnum dataObjectEnum)=> TypeToData[dataObjectEnum](id);

        private object GetStringData(string id)
        {
           return _dataRepository.GetInformationData(id).LasName;
        }

        private object GetResidentialAddress(string id)
        {
            return _dataRepository.GetResidentialAddressData(id).FirstOrDefault(x=>x.Active).ToAddressDto();
        }

        private object GetWorkAddress(string id)
        {
            return _dataRepository.GetWorkAddressData(id).FirstOrDefault(x => x.Active).ToAddressDto();
        }

        private object GetFinancialInformation(string id)
        {
            return _dataRepository.GetFinancialInformationData(id).FirstOrDefault(x => x.Active).ToFinancialInformationDto();
        }

 
    }
}
