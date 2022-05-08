using TestDTOsApplication.ExternalServices.DataInterfaces;
using TestDTOsApplication.ExternalServices.DataTypes;

namespace TestDTOsApplication.ExternalServices.DataServices
{
    public class DataRepository : IDataRepository
    {
        private readonly List<Information> _informationData;
        public DataRepository()
        {
            _informationData = InitInformationData();
        }

        private List<Information> InitInformationData()
        {
            return new List<Information>()
            {
                new Information()
                {
                    id ="1",
                    CreateUser="123456",
                    CreateOn =DateTime.Now.AddDays(-5),
                    UpdateUser = "123456",
                    UpdateOn =DateTime.Now.AddDays(-2),

                    Name ="cccccc",
                    LasName ="vvvvvvv",
                    ExernalInformation = new ExernalInformation()
                    {
                        ResidentialAddress =new List<Address>()
                        {
                            new Address()
                            {
                                id ="467982",
                                CreateUser="123456",
                                CreateOn =DateTime.Now.AddDays(-5),
                                UpdateUser = "123456",
                                UpdateOn =DateTime.Now.AddDays(-2),

                                Active =true,
                                Street="rrrrrrr",
                                StreetNumber =15,
                                PostalCode ="41244",
                                Country ="UK",

                            },
                            new Address()
                            {
                                id ="56789",
                                CreateUser="123456",
                                CreateOn =DateTime.Now.AddDays(-5),
                                UpdateUser = "123456",
                                UpdateOn =DateTime.Now.AddDays(-2),

                                Active =false,
                                Street="yyyyyyyy",
                                StreetNumber =34,
                                PostalCode ="67766",
                                Country ="DE"
                            }
                        },
                        WorkAddress = new List<Address>()
                        {
                            new Address()
                            {
                                id ="12345",
                                CreateUser="123456",
                                CreateOn =DateTime.Now.AddDays(-5),
                                UpdateUser = "123456",
                                UpdateOn =DateTime.Now.AddDays(-2),

                                Active =true,
                                Street="ttttttt",
                                StreetNumber =30,
                                PostalCode ="50966",
                                Country ="UK"
                            }
                        },
                        FinancialInformation = new List<FinancialInformation>()
                        {
                            new FinancialInformation()
                            {
                                id ="5859847",
                                CreateUser="123456",
                                CreateOn =DateTime.Now.AddDays(-5),
                                UpdateUser = "123456",
                                UpdateOn =DateTime.Now.AddDays(-2),

                                Active= true,
                                Year ="2022",
                                Income =(float) 123.55,
                                Assets =(float) 325.55,
                            },
                            new FinancialInformation()
                            {
                                id ="4356434",
                                CreateUser="123456",
                                CreateOn =DateTime.Now.AddDays(-5),
                                UpdateUser = null,
                                UpdateOn =null,

                                Active= false,
                                Year ="2010",
                                Income =(float) 0.44,
                                Assets =(float) 125.77,
                            }
                        }
                    }

                },
                new Information()
                {
                    id ="2",
                    CreateUser="123456",
                    CreateOn =DateTime.Now.AddDays(-5),
                    UpdateUser = "123456",
                    UpdateOn =DateTime.Now.AddDays(-2),

                    Name ="cccccc",
                    LasName ="vvvvvvv",
                    ExernalInformation = new ExernalInformation()
                    {
                        ResidentialAddress =new List<Address>()
                        {
                            new Address()
                            {
                                id ="467982",
                                CreateUser="123456",
                                CreateOn =DateTime.Now.AddDays(-5),
                                UpdateUser = "123456",
                                UpdateOn =DateTime.Now.AddDays(-2),

                                Active =true,
                                Street="rrrrrrr",
                                StreetNumber =15,
                                PostalCode ="41244",
                                Country ="UK",

                            }
                        },
                        WorkAddress = null,
                        FinancialInformation = new List<FinancialInformation>()
                        {
                            new FinancialInformation()
                            {
                                id ="4356434",
                                CreateUser="123456",
                                CreateOn =DateTime.Now.AddDays(-5),
                                UpdateUser = null,
                                UpdateOn =null,

                                Active= false,
                                Year ="2010",
                                Income =(float) 0.44,
                                Assets =(float) 125.77,
                            }
                        }
                    }
                }
            };
        }

        public Information GetInformationData(string Id)
        {
            return _informationData.FirstOrDefault(x => x.id == Id);
        }

        public ExernalInformation GetExernalInformationData(string Id)
        {
            return _informationData.FirstOrDefault(x => x.id == Id)?.ExernalInformation;
        }

        public List<Address> GetResidentialAddressData(string Id)
        {
            return _informationData.FirstOrDefault(x => x.id == Id)?.ExernalInformation?.ResidentialAddress;
        }

        public List<Address> GetWorkAddressData(string Id)
        {
            return _informationData.FirstOrDefault(x => x.id == Id)?.ExernalInformation?.WorkAddress;
        }

        public List<FinancialInformation> GetFinancialInformationData(string Id)
        {
            return _informationData.FirstOrDefault(x => x.id == Id)?.ExernalInformation?.FinancialInformation;
        }
    }
}
