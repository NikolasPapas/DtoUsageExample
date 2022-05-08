using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TestDTOsApplication.Common.Types
{
    /// <summary>
    /// The type of returned data 
    /// </summary>
    public enum DataObjectEnum
    {
        [DataMember(Name = "stringData")]
        StringData,

        [DataMember(Name = "ResidentialAddress")]
        ResidentialAddress,

        [DataMember(Name = "WorkAddress")]
        WorkAddress,

        [DataMember(Name = "FinancialInformation")]
        FinancialInformation

    }
}
