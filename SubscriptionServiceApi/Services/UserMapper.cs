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
                    GivenName = userDto.GivenName,
                    FamilyName = userDto.FamilyName,
                    Email = userDto.Email,
                    PhoneNumber = userDto.PhoneNumber,
                    Address = new Address()
                    {
                        AddressCountry = userDto.Address.AddressCountry,
                        AddressLocality = userDto.Address.AddressLocality,
                        AddressRegion = userDto.Address.AddressRegion,
                        PostOfficeBoxNumber = userDto.Address.PostOfficeBoxNumber,
                        PostalCode = userDto.Address.PostalCode,
                        PostalAddress = userDto.Address.PostalAddress
                    },
                    Invoice = new InvoiceData()
                    {
                        
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