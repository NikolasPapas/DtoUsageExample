using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDTOsApplication.Common.Types.DTOs;
using TestDTOsApplication.ExternalServices.DataTypes;

namespace TestDTOsApplication.ExternalServices.DataServices
{
    public static partial class Extensions
    {
        public static FinancialInformationDto ToFinancialInformationDto(this FinancialInformation financialInformation)
        {
            if (financialInformation==null) return null;
            return new FinancialInformationDto()
            {
                Year = financialInformation.Year,
                Income = financialInformation.Income,
                Assets = financialInformation.Assets,
            };
        }

    }
}
