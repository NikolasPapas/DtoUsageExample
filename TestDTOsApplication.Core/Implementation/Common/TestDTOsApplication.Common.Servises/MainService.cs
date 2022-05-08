using Microsoft.Extensions.Logging;
using TestDTOsApplication.Common.Interfaces;
using TestDTOsApplication.Common.Types;
using TestDTOsApplication.Common.Types.Requests;
using TestDTOsApplication.Common.Types.Responses;

namespace TestDTOsApplication.Common.Servises
{
    public class MainService : IMainService
    {
        private readonly IDataServiseId _dataServiseId;
        private readonly IDataServiseInformation _dataServiseInformation;
        private readonly ILogger<MainService> _logger;
        public MainService(
            IDataServiseId dataServiseId,
            IDataServiseInformation dataServiseInformation,
            ILogger<MainService> logger)
        {
            _dataServiseId = dataServiseId;
            _dataServiseInformation = dataServiseInformation;
            _logger = logger;
        }

        public async Task<GetDataResponse> GetData(GetDataRequest request)
        {
            List<DataObjectEnum> userDataObjects = await _dataServiseId.GetDataObjectEnumForId(request.Id);
            if (userDataObjects == null) return null;

            GetDataResponse results = new GetDataResponse() { DataList = new List<DataObject>() };

            foreach (var type in userDataObjects)
                results.DataList.Add(new DataObject() { Type = type, Data = await _dataServiseInformation.GetInformationForType(request.Id, type) });

            return results;
        }
    }
}