using SubscriptionServiceApi.Dtos;
using SubscriptionServiceApi.Infrastructure.Models;

namespace SubscriptionServiceApi.Services
{
    internal static class UserMapper
    {
        public static User ToUserMapper(UserDto userDto)
        {
            return new User()
            {
                Id = userDto.Id,
                UserName = userDto.Username,
                Person = new Person()
                {
                    Id = userDto.PersonId,
                    GivenName = userDto.GivenName,
                    FamilyName = userDto.FamilyName,
                    Email = userDto.Email,
                    PhoneNumber = userDto.PhoneNumber,
                    Address = new Address()
                    {
                        Id = userDto.Address.Id,
                        AddressCountry = userDto.Address.AddressCountry,
                        AddressLocality = userDto.Address.AddressLocality,
                        AddressRegion = userDto.Address.AddressRegion,
                        PostOfficeBoxNumber = userDto.Address.PostOfficeBoxNumber,
                        PostalCode = userDto.Address.PostalCode,
                        PostalAddress = userDto.Address.PostalAddress
                    },
                    Invoice = new InvoiceData()
                    {
                        Id = userDto.Invoice.Id,
                        CustomerName = userDto.Invoice.CustomerName,
                        Organization = userDto.Invoice.Organization,
                        TaxNumber = userDto.Invoice.TaxNumber,
                        PaymentMethod = userDto.Invoice.PaymentMethod,
                        Address = new Address()
                        {
                            Id = userDto.Invoice.Address.Id,
                            AddressCountry = userDto.Invoice.Address.AddressCountry,
                            AddressLocality = userDto.Invoice.Address.AddressLocality,
                            AddressRegion = userDto.Invoice.Address.AddressRegion,
                            PostOfficeBoxNumber = userDto.Invoice.Address.PostOfficeBoxNumber,
                            PostalCode = userDto.Invoice.Address.PostalCode,
                            PostalAddress = userDto.Invoice.Address.PostalAddress
                        },

                    }
                }
                
            };
        }
        public static UserDto ToUserDtoMapper(User user)
        {
            return new UserDto()
            {
                Id = user.Id

            };
        }
        
    }
}