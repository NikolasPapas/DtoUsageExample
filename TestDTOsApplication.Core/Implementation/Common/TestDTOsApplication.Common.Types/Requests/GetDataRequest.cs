using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TestDTOsApplication.Common.Types.Requests
{
    /// <summary>
    /// Request to give id and get information for that customer
    /// </summary>
    [DataContract]
    public class GetDataRequest
    {

        /// <summary>
        /// give the id of the customer You Wont 
        /// </summary>
        [DataMember(Name = "id")]
        public string Id { get; set; }
    }
}
