using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDTOsApplication.Common.Types;

namespace TestDTOsApplication.Common.Interfaces
{
    public interface IDataServiseInformation
    {
        Task<object> GetInformationForType(string id, DataObjectEnum dataObjectEnum);
    }
}
