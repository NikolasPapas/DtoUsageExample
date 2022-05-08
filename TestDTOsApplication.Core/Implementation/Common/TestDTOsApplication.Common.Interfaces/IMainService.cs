using TestDTOsApplication.Common.Types.Requests;
using TestDTOsApplication.Common.Types.Responses;

namespace TestDTOsApplication.Common.Interfaces
{
    public interface IMainService
    {
     
        /// <summary>
        /// return to Controller the data for tha request id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetDataResponse> GetData(GetDataRequest request);

    }
}