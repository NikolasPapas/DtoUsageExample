using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TestDTOsApplication.Common.Types.Responses
{
    /// <summary>
    /// return tha requested data from tha api
    /// </summary>
    [DataContract]
    public class GetDataResponse
    {
        /// <summary>
        /// tha list from data objects 
        /// </summary>
        [DataMember(Name = "dataList")]
        public List<DataObject> DataList { get; set; }
    }

    /// <summary>
    /// has 2 parameters type and data is a custom way to retern information of multiple data models under the same property
    /// </summary>
    public class DataObject
    {
        /// <summary>
        /// the type of data object
        /// </summary>
        [DataMember(Name = "type")]
        public DataObjectEnum Type { get; set; }

        /// <summary>
        /// the actual data
        /// </summary>
        [DataMember(Name = "data")]
        public object Data { get; set; }
    }
}