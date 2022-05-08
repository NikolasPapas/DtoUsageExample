using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestDTOsApplication.Common.Interfaces;
using TestDTOsApplication.Common.Types.Requests;
using TestDTOsApplication.Common.Types.Responses;

namespace TestDTOsApplication.Common.Controllers
{
    [Route("tesDto")]
    [ApiController]
    public class TesDtoContoller : ControllerBase
    {
        private readonly IMainService _mainService;
        private readonly ILogger<TesDtoContoller> _logger;

        public TesDtoContoller(IMainService mainService,ILogger<TesDtoContoller> logger)
        {
            _mainService = mainService;
            _logger = logger;
        }

        /// <summary>
        /// Get Data for id 1 || 2 || 3
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("getData")]
        public async Task<GetDataResponse> GetData(GetDataRequest request)
        {
            return await _mainService.GetData(request);
        }

    }
}