using AutoMapper;
using SubscriptionServiceApi.Infrastructure.Models;

namespace SubscriptionServiceApi.ViewModels.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Address, AddressViewModel>();
            CreateMap<AddressViewModel, Address>();
            
            CreateMap<Discount, DiscountViewModel>();
            CreateMap<DiscountViewModel, Discount>();
            
            CreateMap<InvoiceData, InvoiceDataViewModel>();
            CreateMap<InvoiceDataViewModel, InvoiceData>();
            
            CreateMap<Person, PersonViewModel>();
            CreateMap<PersonViewModel, Person>();
            
            CreateMap<Product, ProductVersion>();
            CreateMap<ProductVersion, Product>();
            
            CreateMap<ProductVersion, ProductVersionViewModel>();
            CreateMap<ProductVersionViewModel, ProductVersion>();
            
            CreateMap<Subscription, SubscriptionViewModel>();
            CreateMap<SubscriptionViewModel, Subscription>();
            
            CreateMap<User, UserViewModel>();
            CreateMap<UserViewModel, User>();
        }
    }
}