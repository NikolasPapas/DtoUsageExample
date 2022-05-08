using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDTOsApplication.Common.Types;

namespace TestDTOsApplication.Common.Interfaces
{
    public interface IDataServiseId
    {
        Task<List<DataObjectEnum>> GetDataObjectEnumForId(string id);

    }
}
