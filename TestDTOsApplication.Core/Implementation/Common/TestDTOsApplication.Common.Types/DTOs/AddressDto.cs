using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TestDTOsApplication.Common.Types.DTOs
{
    [DataContract]
    public class AddressDto 
    {
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

    }
}
